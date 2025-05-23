﻿/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Util.Internal;
using System.Diagnostics.CodeAnalysis;
using ThirdParty.RuntimeBackports;


#if NETSTANDARD
using Amazon.Runtime.Internal.Util;
#endif

namespace Amazon.DynamoDBv2
{

    /// <summary>
    /// Specifies the conversion schema used to map the types to DynamoDB types.
    /// This schema influences how items are serialized and deserialized when interacting with DynamoDB.
    /// </summary>
    public enum ConversionSchema
    {
        /// <summary>
        /// Indicates that no schema has been explicitly set.
        /// </summary>
        Unset = -1,

        /// <summary>
        /// Legacy conversion schema (and current default for context-level configurations).
        ///
        /// This schema pre-dates support for native DynamoDB types such as L (list), M (map), BOOL, and NULL.
        /// Common .NET type mappings:
        /// <ul>
        /// <li><para>Number types (byte, int, float, decimal, etc.) → DynamoDB N (number)</para></li>
        /// <li><para>string, char → S (string)</para></li>
        /// <li><para>bool → N ("0" for false, "1" for true)</para></li>
        /// <li><para>DateTime, Guid → S (string)</para></li>
        /// <li><para>MemoryStream, byte[] → B (binary)</para></li>
        /// <li><para>List, HashSet, array of numeric types → NS (number set)</para></li>
        /// <li><para>List, HashSet, array of string types → SS (string set)</para></li>
        /// <li><para>List, HashSet, array of binary types → BS (binary set)</para></li>
        /// <li><para>Dictionary{string, object} → M (map)</para></li>
        /// </ul>
        /// </summary>
        V1 = 0,

        /// <summary>
        /// Enhanced conversion schema that supports native DynamoDB types including L (list), M (map), BOOL, and NULL.
        /// 
        /// Common .NET type mappings:
        /// <ul>
        /// <li><para>Number types (byte, int, float, decimal, etc.) → DynamoDB N (number)</para></li>
        /// <li><para>string, char → S (string)</para></li>
        /// <li><para>bool → BOOL</para></li>
        /// <li><para>DateTime, Guid → S (string)</para></li>
        /// <li><para>MemoryStream, byte[] → B (binary)</para></li>
        /// <li><para>HashSet of numeric types → NS (number set)</para></li>
        /// <li><para>HashSet of string types → SS (string set)</para></li>
        /// <li><para>HashSet of binary types → BS (binary set)</para></li>
        /// <li><para>List, array (numeric, string, binary types) → L (list)</para></li>
        /// <li><para>Dictionary{string, object} → M (map)</para></li>
        /// </ul>
        /// Recommended for applications that need full fidelity with native DynamoDB types.
        /// </summary>
        V2 = 1,
    }

    /// <summary>
    /// A collection of converters capable of converting between
    /// .NET and DynamoDB objects.
    /// </summary>
    public class DynamoDBEntryConversion
    {
        #region Static members

        /// <summary>
        /// Default conversion before 2014 L, M, BOOL, NULL support.
        /// 
        /// The following .NET types are converted into the following DynamoDB types:
        /// Number types (byte, int, float, decimal, etc.) are converted to N
        /// String and char are converted to S
        /// Bool is converted to N (0=false, 1=true)
        /// DateTime and Guid are converto to S
        /// MemoryStream and byte[] are converted to B
        /// List, HashSet, and array of numerics types are converted to NS
        /// List, HashSet, and array of string-based types are converted to SS
        /// List, HashSet, and array of binary-based types are converted to BS
        /// Dictionary{string,object} are converted to M
        /// </summary>
        public static DynamoDBEntryConversion V1 { get; private set; }


        /// <summary>
        /// Schema fully supporting 2014 L, M, BOOL, NULL additions.
        /// 
        /// The following .NET types are converted into the following DynamoDB types:
        /// Number types (byte, int, float, decimal, etc.) are converted to N
        /// String and char are converted to S
        /// Bool is converted to BOOL
        /// DateTime and Guid are converto to S
        /// MemoryStream and byte[] are converted to B
        /// HashSet of numerics types are converted to NS
        /// HashSet of string-based types are converted to SS
        /// HashSet of binary-based types are converted to BS
        /// List and array of numerics, string-based types, and binary-based types
        /// are converted to L type.
        /// Dictionary{string,object} are converted to M
        /// </summary>
        public static DynamoDBEntryConversion V2 { get; private set; }


        /// <summary>
        /// Returns a DynamoDBEntryConversion corresponding to the ConversionSchema.
        /// The returned conversion is immutable. The conversion must be cloned
        /// before it can be modified.
        /// </summary>
        /// <param name="schema">Conversion to return.</param>
        /// <returns>DynamoDBEntryConversion corresponding to the ConversionSchema.</returns>
        internal static DynamoDBEntryConversion GetConversion(ConversionSchema schema)
        {
            switch (schema)
            {
                case ConversionSchema.V1:
                    return DynamoDBEntryConversion.V1;
                case ConversionSchema.V2:
                    return DynamoDBEntryConversion.V2;
                default:
                    throw new ArgumentOutOfRangeException("schema");
            }
        }

        /// <summary>
        /// Conversion corresponding to AWSConfigs.DynamoDBConfig.ConversionSchema
        /// </summary>
        internal static DynamoDBEntryConversion CurrentConversion
        {
            get
            {
                return GetConversion(AWSConfigsDynamoDB.ConversionSchema);
            }
        }

        #endregion

        #region Constructors

        static DynamoDBEntryConversion()
        {
            V1 = new DynamoDBEntryConversion(ConversionSchema.V1, isImmutable: true);
            V2 = new DynamoDBEntryConversion(ConversionSchema.V2, isImmutable: true);
        }
        private DynamoDBEntryConversion(ConversionSchema schema, bool isImmutable)
        {
            OriginalConversion = schema;
            switch (schema)
            {
                case ConversionSchema.V1:
                    SetV1Converters();
                    break;
                case ConversionSchema.V2:
                    SetV2Converters();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("schema");
            }
            IsImmutable = isImmutable;
        }

        /// <summary>
        /// Creates an empty, mutable conversion.
        /// </summary>
        internal DynamoDBEntryConversion()
        {
            OriginalConversion = ConversionSchema.V1;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Convert value to DynamoDBEntry
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public DynamoDBEntry ConvertToEntry<TInput>(TInput value)
        {
            DynamoDBEntry entry;
            if (TryConvertToEntry<TInput>(value, out entry))
                return entry;

            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                "Unable to convert [{0}] of type {1} to DynamoDBEntry", value, value.GetType().FullName));
        }

        /// <summary>
        /// Convert value to DynamoDBEntry
        /// </summary>
        /// <param name="inputType"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public DynamoDBEntry ConvertToEntry(Type inputType, object value)
        {
            if (inputType == null) throw new ArgumentNullException("inputType");
            if (value == null) throw new ArgumentNullException("value");

            var converter = ConverterCache.GetConverter(inputType);
            DynamoDBEntry output = converter.ToEntry(value);

            return output;
        }

        /// <summary>
        /// Try to convert value to DynamoDBEntry. If it fails the method returns false.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="value"></param>
        /// <param name="entry"></param>
        /// <returns>True if successfully converted, otherwise false.</returns>
        public bool TryConvertToEntry<TInput>(TInput value, out DynamoDBEntry entry)
        {
            var inputType = typeof(TInput);
            return TryConvertToEntry(inputType, value, out entry);
        }

        /// <summary>
        /// Try to convert value to DynamoDBEntry. If it fails the method returns false.
        /// </summary>
        /// <param name="inputType"></param>
        /// <param name="value"></param>
        /// <param name="entry"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool TryConvertToEntry(Type inputType, object value, out DynamoDBEntry entry)
        {
            if (inputType == null) throw new ArgumentNullException("inputType");
            if (value == null) throw new ArgumentNullException("value");

            var converter = ConverterCache.GetConverter(inputType);
            return converter.TryToEntry(value, out entry);
        }

        /// <summary>
        /// Convert the DynamoDBEntry to the specified type.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="entry"></param>
        /// <returns></returns>
        public TOutput ConvertFromEntry<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] TOutput>(DynamoDBEntry entry)
        {
            TOutput output;
            if (TryConvertFromEntry<TOutput>(entry, out output))
                return output;

            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                "Unable to convert [{0}] of type {1} to {2}", entry, entry.GetType().FullName, typeof(TOutput).FullName));
        }

        /// <summary>
        /// Convert the DynamoDBEntry to the specified type.
        /// </summary>
        /// <param name="outputType"></param>
        /// <param name="entry"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public object ConvertFromEntry([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type outputType, DynamoDBEntry entry)
        {
            if (outputType == null) throw new ArgumentNullException("outputType");
            if (entry == null) throw new ArgumentNullException("entry");

            var converter = ConverterCache.GetConverter(outputType);
            object output = converter.FromEntry(entry, outputType);

            return output;
        }

        /// <summary>
        /// Try to convert the DynamoDBEntry to the specified type. If it fails the method returns false.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="entry"></param>
        /// <param name="output"></param>
        /// <returns>True if successfully converted, otherwise false.</returns>
        public bool TryConvertFromEntry<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] TOutput>(DynamoDBEntry entry, out TOutput output)
        {
            output = default(TOutput);

            var outputType = typeof(TOutput);
            object converted;

            if (TryConvertFromEntry(outputType, entry, out converted))
            {
                if (converted != null)
                    output = (TOutput)converted;

                return true;
            }

            return false;
        }

        /// <summary>
        /// Try to convert the DynamoDBEntry to the specified type. If it fails the method returns false.
        /// </summary>
        /// <param name="outputType"></param>
        /// <param name="entry"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool TryConvertFromEntry([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type outputType, DynamoDBEntry entry, out object value)
        {
            if (outputType == null) throw new ArgumentNullException("outputType");
            if (entry == null) throw new ArgumentNullException("entry");

            var converter = ConverterCache.GetConverter(outputType);
            return converter.TryFromEntry(entry, outputType, out value);
        }

        #endregion

        #region Internal members

        internal bool IsImmutable { get; private set; }
        internal DynamoDBEntryConversion Clone()
        {
            return new DynamoDBEntryConversion(this.OriginalConversion, isImmutable: false);
        }

        internal bool HasConverter(Type type)
        {
            return ConverterCache.HasConverter(type);
        }

        internal bool TryGetConverter(Type type, out Converter converter)
        {
            return ConverterCache.TryGetConverter(type, out converter);
        }

        internal IEnumerable<DynamoDBEntry> ConvertToEntries(Type elementType, IEnumerable values)
        {
            if (values == null) throw new ArgumentNullException("values");

            foreach (var value in values)
                yield return ConvertToEntry(elementType, value);
        }
        internal IEnumerable<DynamoDBEntry> ConvertToEntries<T>(IEnumerable<T> values)
        {
            if (values == null) throw new ArgumentNullException("values");

            var elementType = typeof(T);
            foreach (var value in values)
                yield return ConvertToEntry(elementType, value);

            //foreach (var value in values)
            //    yield return ConvertToEntry(value);
        }

        internal IEnumerable<object> ConvertFromEntries([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type elementType, IEnumerable<DynamoDBEntry> entries)
        {
            if (entries == null) throw new ArgumentNullException("entries");

            foreach (var entry in entries)
                yield return ConvertFromEntry(elementType, entry);
        }

        internal PrimitiveList ItemsToPrimitiveList(IEnumerable items)
        {
            var inputType = items.GetType();
            var elementType = Utils.GetPrimitiveElementType(inputType);
            var primitives = ToPrimitives(items, elementType);
            var pl = new PrimitiveList(primitives);
            return pl;
        }

        #endregion

        #region Private members

        private ConverterCache ConverterCache = new ConverterCache();
        private ConversionSchema OriginalConversion;

        internal void AddConverter(Converter converter)
        {
            ConverterCache.AddConverter(converter, this);
        }

        private void SetV1Converters()
        {
            AddConverter(new ByteConverterV1());
            AddConverter(new SByteConverterV1());
            AddConverter(new UInt16ConverterV1());
            AddConverter(new Int16ConverterV1());
            AddConverter(new UInt32ConverterV1());
            AddConverter(new Int32ConverterV1());
            AddConverter(new UInt64ConverterV1());
            AddConverter(new Int64ConverterV1());
            AddConverter(new SingleConverterV1());
            AddConverter(new DoubleConverterV1());
            AddConverter(new DecimalConverterV1());
            AddConverter(new CharConverterV1());
            AddConverter(new StringConverterV1());
            AddConverter(new DateTimeConverterV1());
            AddConverter(new GuidConverterV1());
            AddConverter(new BytesConverterV1());
            AddConverter(new MemoryStreamConverterV1());
            AddConverter(new EnumConverterV1());
            AddConverter(new BoolConverterV1());
            AddConverter(new PrimitiveCollectionConverterV1());
            AddConverter(new DictionaryConverterV1());
#if NET8_0_OR_GREATER
            AddConverter(new DateOnlyConverterV1());
            AddConverter(new TimeOnlyConverterV1());
#endif
        }

        private void SetV2Converters()
        {
            AddConverter(new ByteConverterV2());
            AddConverter(new SByteConverterV2());
            AddConverter(new UInt16ConverterV2());
            AddConverter(new Int16ConverterV2());
            AddConverter(new UInt32ConverterV2());
            AddConverter(new Int32ConverterV2());
            AddConverter(new UInt64ConverterV2());
            AddConverter(new Int64ConverterV2());
            AddConverter(new SingleConverterV2());
            AddConverter(new DoubleConverterV2());
            AddConverter(new DecimalConverterV2());
            AddConverter(new CharConverterV2());
            AddConverter(new StringConverterV2());
            AddConverter(new DateTimeConverterV2());
            AddConverter(new GuidConverterV2());
            AddConverter(new BytesConverterV2());
            AddConverter(new MemoryStreamConverterV2());
            AddConverter(new DictionaryConverterV2());
            AddConverter(new EnumConverterV2());
            AddConverter(new BoolConverterV2());
            AddConverter(new CollectionConverterV2());
#if NET8_0_OR_GREATER
            AddConverter(new DateOnlyConverterV2());
            AddConverter(new TimeOnlyConverterV2());
#endif
        }

        // Converts items to Primitives.
        // elementType must be a type that is a primitive (Utils.IsPrimitive(elementType) must return true)
        private IEnumerable<Primitive> ToPrimitives(IEnumerable items, Type elementType)
        {
            Utils.ValidatePrimitiveType(elementType);

            foreach (var item in items)
            {
                // Convert to DynamoDBEntry

                // Item may be DynamoDBEntry already, in which case don't convert
                var entry = item as DynamoDBEntry;
                if (entry == null)
                    entry = ConvertToEntry(elementType, item);

                // If entry is not Primitive, throw an exception
                var p = entry.AsPrimitive();
                if (p == null)
                    throw new InvalidCastException(string.Format(CultureInfo.InvariantCulture,
                        "Unable to convert [{0}] of type {1} to Primitive",
                        item,
                        elementType.FullName));
                yield return p;
            }
        }

        #endregion
    }

    internal abstract class Converter
    {
        /// <summary>
        /// Returns all types for which it can be used.
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<Type> GetTargetTypes();

        /// <summary>
        /// Conversion that this converter is part of.
        /// This field is set by DynamoDBEntryConversion when the Converter
        /// is added to that DynamoDBEntryConversion.
        /// 
        /// This conversion should be used if the Converter needs to
        /// make sub-conversions (for instance, a collection converter).
        /// </summary>
        public DynamoDBEntryConversion Conversion { get; set; }

        public DynamoDBEntry ToEntry(object value)
        {
            if (value == null) throw new ArgumentNullException("value");

            DynamoDBEntry entry;
            if (TryToEntry(value, out entry))
                return entry;

            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                "Unable to convert [{0}] of type {1} to DynamoDBEntry using the converter {2}", value, value.GetType().FullName, this.GetType().FullName));
        }
        public bool TryToEntry(object value, out DynamoDBEntry entry)
        {
            if (value == null) throw new ArgumentNullException("value");

            Primitive p;
            if (TryTo(value, out p))
            {
                entry = p;
                return true;
            }

            PrimitiveList pl;
            if (TryTo(value, out pl))
            {
                entry = pl;
                return true;
            }

            DynamoDBBool b;
            if (TryTo(value, out b))
            {
                entry = b;
                return true;
            }

            DynamoDBList l;
            if (TryTo(value, out l))
            {
                entry = l;
                return true;
            }

            Document d;
            if (TryTo(value, out d))
            {
                entry = d;
                return true;
            }

            entry = null;
            return false;
        }

        public object FromEntry(DynamoDBEntry entry, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType)
        {
            if (entry == null) throw new ArgumentNullException("entry");
            if (targetType == null) throw new ArgumentNullException("targetType");

            object value;
            if (TryFromEntry(entry, targetType, out value))
                return value;

            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                "Unable to convert [{0}] of type {1} to {2}", entry, entry.GetType().FullName, targetType.FullName));
        }

        public bool TryFromEntry(DynamoDBEntry entry, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out object value)
        {
            var p = entry as Primitive;

            if (p != null)
            {
                // Special case for handling null values (directive to DELETE) in Document
                if (p.Value == null && p.Type == DynamoDBEntryType.String)
                {
                    value = null;
                    return true;
                }

                if (TryFrom(p, targetType, out value))
                    return true;
            }

            var pl = entry as PrimitiveList;
            if (pl != null && TryFrom(pl, targetType, out value))
                return true;

            var b = entry as DynamoDBBool;
            if (b != null && TryFrom(b, targetType, out value))
                return true;

            var l = entry as DynamoDBList;
            if (l != null && TryFrom(l, targetType, out value))
                return true;

            var d = entry as Document;
            if (d != null && TryFrom(d, targetType, out value))
                return true;

            var n = entry as DynamoDBNull;
            if (n != null)
            {
                value = null;
                return true;
            }

            // Could not convert entry to a known type, setting value to null as it's an out parameter
            value = null;
            return false;
        }

        public virtual bool TryTo(object value, out DynamoDBBool b)
        {
            b = null;
            return false;
        }
        public virtual bool TryTo(object value, out Primitive p)
        {
            p = null;
            return false;
        }
        public virtual bool TryTo(object value, out PrimitiveList pl)
        {
            pl = null;
            return false;
        }
        public virtual bool TryTo(object value, out DynamoDBList l)
        {
            l = null;
            return false;
        }
        public virtual bool TryTo(object value, out Document d)
        {
            d = null;
            return false;
        }

        public virtual bool TryFrom(DynamoDBBool b, Type targetType, out object result)
        {
            result = null;
            return false;
        }

        public virtual bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out object result)
        {
            result = null;
            return false;
        }

        public virtual bool TryFrom(PrimitiveList pl, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out object result)
        {
            result = null;
            return false;
        }

        public virtual bool TryFrom(DynamoDBList l, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out object result)
        {
            result = null;
            return false;
        }
        public virtual bool TryFrom(Document d, Type targetType, out object result)
        {
            result = null;
            return false;
        }
    }

    internal abstract class Converter<T> : Converter
    {
        public override bool TryTo(object value, out DynamoDBBool b)
        {
            return TryTo((T)value, out b);
        }
        public override bool TryTo(object value, out Primitive p)
        {
            return TryTo((T)value, out p);
        }
        public override bool TryTo(object value, out PrimitiveList pl)
        {
            return TryTo((T)value, out pl);
        }
        public override bool TryTo(object value, out DynamoDBList l)
        {
            return TryTo((T)value, out l);
        }
        public override bool TryTo(object value, out Document d)
        {
            return TryTo((T)value, out d);
        }

        protected virtual bool TryTo(T value, out DynamoDBBool b)
        {
            b = null;
            return false;
        }
        protected virtual bool TryTo(T value, out Primitive p)
        {
            p = null;
            return false;
        }
        protected virtual bool TryTo(T value, out PrimitiveList pl)
        {
            pl = null;
            return false;
        }
        protected virtual bool TryTo(T value, out DynamoDBList l)
        {
            l = null;
            return false;
        }
        protected virtual bool TryTo(T value, out Document d)
        {
            d = null;
            return false;
        }

        public override bool TryFrom(DynamoDBBool b, Type targetType, out object result)
        {
            T t;
            var output = TryFrom(b, targetType, out t);
            result = t;
            return output;
        }

        public override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out object result)
        {
            T t;
            var output = TryFrom(p, targetType, out t);
            result = t;
            return output;
        }

        public override bool TryFrom(PrimitiveList pl, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out object result)
        {
            T t;
            var output = TryFrom(pl, targetType, out t);
            result = t;
            return output;
        }

        public override bool TryFrom(DynamoDBList l, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out object result)
        {
            T t;
            var output = TryFrom(l, targetType, out t);
            result = t;
            return output;
        }
        public override bool TryFrom(Document d, Type targetType, out object result)
        {
            T t;
            var output = TryFrom(d, targetType, out t);
            result = t;
            return output;
        }

        protected virtual bool TryFrom(DynamoDBBool b, Type targetType, out T result)
        {
            result = default(T);
            return false;
        }

        protected virtual bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out T result)
        {
            result = default(T);
            return false;
        }
        protected virtual bool TryFrom(PrimitiveList pl, Type targetType, out T result)
        {
            result = default(T);
            return false;
        }
        protected virtual bool TryFrom(DynamoDBList l, Type targetType, out T result)
        {
            result = default(T);
            return false;
        }
        protected virtual bool TryFrom(Document d, Type targetType, out T result)
        {
            result = default(T);
            return false;
        }
    }

    internal class ConverterCache
    {
        private static Type EnumType = typeof(Enum);
        private Dictionary<Type, Converter> Cache = new Dictionary<Type, Converter>();

        public bool HasConverter(Type type)
        {
            Converter converter;
            return TryGetConverter(type, out converter);
        }
        public void AddConverter(Converter converter, DynamoDBEntryConversion conversion)
        {
            if (converter == null)
                throw new ArgumentNullException("converter");
            if (conversion == null)
                throw new ArgumentNullException("conversion");

            if (conversion.IsImmutable)
                throw new InvalidOperationException("Adding converters to immutable conversion is not supported. The conversion must be cloned first.");

            converter.Conversion = conversion;
            var types = converter.GetTargetTypes();
            foreach (var type in types)
            {
                Cache[type] = converter;
            }
        }

        public Converter GetConverter(Type type)
        {
            Converter converter;
            if (!TryGetConverter(type, out converter))
                throw new InvalidOperationException("No converter configured for type " + type.FullName);

            return converter;
        }
        public bool TryGetConverter(Type type, out Converter converter)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            // all enums use the same converter, one for Enum
            if (type.IsEnum)
                return Cache.TryGetValue(EnumType, out converter);

            return Cache.TryGetValue(type, out converter);
        }
    }
}
