/*
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

/*
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A reference to a table within Snowflake.
    /// </summary>
    public partial class SnowflakeTableReference
    {
        private string _accountIdentifier;
        private string _databaseName;
        private string _schemaName;
        private string _secretArn;
        private string _tableName;
        private SnowflakeTableSchema _tableSchema;

        /// <summary>
        /// Gets and sets the property AccountIdentifier. 
        /// <para>
        ///  The account identifier for the Snowflake table reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=256)]
        public string AccountIdentifier
        {
            get { return this._accountIdentifier; }
            set { this._accountIdentifier = value; }
        }

        // Check to see if AccountIdentifier property is set
        internal bool IsSetAccountIdentifier()
        {
            return this._accountIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The name of the database the Snowflake table belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        ///  The schema name of the Snowflake table reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SchemaName
        {
            get { return this._schemaName; }
            set { this._schemaName = value; }
        }

        // Check to see if SchemaName property is set
        internal bool IsSetSchemaName()
        {
            return this._schemaName != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        ///  The secret ARN of the Snowflake table reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        ///  The name of the Snowflake table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TableSchema. 
        /// <para>
        ///  The schema of the Snowflake table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnowflakeTableSchema TableSchema
        {
            get { return this._tableSchema; }
            set { this._tableSchema = value; }
        }

        // Check to see if TableSchema property is set
        internal bool IsSetTableSchema()
        {
            return this._tableSchema != null;
        }

    }
}