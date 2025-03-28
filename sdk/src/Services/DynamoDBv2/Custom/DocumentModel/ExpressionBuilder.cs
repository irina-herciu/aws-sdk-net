using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.DocumentModel.likeJava;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Builder that constructs a <see cref="Expression"/>
    /// </summary>
    public class ExpressionBuilder : IExpressionBuilder
    {
        private string _expression;
        private Dictionary<string, DynamoDBEntry> _expressionValues;
        private Dictionary<string, string> _expressionNames;

        /// <summary>
        /// Constructs a new ExpressionBuilder
        /// </summary>
        public ExpressionBuilder() { }


        /// <inheritdoc/>
        public ExpressionBuilder AddExpression(string expression)
        {
            _expression = expression;
            return this;
        }


        /// <inheritdoc/>
        public ExpressionBuilder AddExpressionValues(Dictionary<string, DynamoDBEntry> expressionValues)
        {
            _expressionValues = expressionValues == null ? null : new Dictionary<string, DynamoDBEntry>(expressionValues);
            return this;
        }


        /// <inheritdoc/>
        public ExpressionBuilder MergeExpressionValues(Dictionary<string, DynamoDBEntry> expressionValues)
        {
            if (_expressionValues == null)
                return AddExpressionValues(expressionValues);

            if (expressionValues == null)
                return this;

            foreach (var kvp in expressionValues)
            {
                if (_expressionValues.TryGetValue(kvp.Key, out var oldValue))
                {
                    if (!EqualityComparer<DynamoDBEntry>.Default.Equals(oldValue, kvp.Value))
                    {
                        throw new ArgumentException($"Attempt to coalesce expressions with conflicting expression values. Expression value key = '{kvp.Key}'");
                    }
                }

                _expressionValues[kvp.Key] = kvp.Value;
            }

            return this;
        }


        /// <inheritdoc/>
        public ExpressionBuilder PutExpressionValue(string key, DynamoDBEntry value)
        {
            _expressionValues ??= new Dictionary<string, DynamoDBEntry>();
            _expressionValues[key] = value;
            return this;
        }

        /// <inheritdoc/>
        public ExpressionBuilder AddExpressionNames(Dictionary<string, string> expressionNames)
        {
            _expressionNames = expressionNames == null ? null : new Dictionary<string, string>(expressionNames);
            return this;
        }


        /// <inheritdoc/>
        public ExpressionBuilder MergeExpressionNames(Dictionary<string, string> expressionNames)
        {
            if (_expressionNames == null)
                return AddExpressionNames(expressionNames);

            if (expressionNames == null)
                return this;

            foreach (var kvp in expressionNames)
            {
                if (_expressionNames.TryGetValue(kvp.Key, out var oldValue))
                {
                    if (!string.Equals(oldValue, kvp.Value))
                    {
                        throw new ArgumentException($"Attempt to coalesce expressions with conflicting expression names. Expression name key = '{kvp.Key}'");
                    }
                }

                _expressionNames[kvp.Key] = kvp.Value;
            }

            return this;
        }


        /// <inheritdoc/>
        public ExpressionBuilder PutExpressionName(string key, string value)
        {
            _expressionNames ??= new Dictionary<string, string>();
            _expressionNames[key] = value;
            return this;
        }


        /// <inheritdoc/>
        public Expression Build()
        {
            return new Expression()
            {
                ExpressionStatement = _expression,
                ExpressionAttributeNames = _expressionNames,
                ExpressionAttributeValues = _expressionValues
            };
        }

    }
}