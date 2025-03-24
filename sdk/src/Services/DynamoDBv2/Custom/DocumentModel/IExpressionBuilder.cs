using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Interface for a builder that constructs a <see cref="Expression"/>
    /// </summary>
    public interface IExpressionBuilder
    {
        /// <summary>
        /// The expression string
        /// </summary>
        ExpressionBuilder AddExpression(string expression);

        /// <summary>
        /// The optional 'expression values' string dictionary
        /// </summary>
        ExpressionBuilder AddExpressionValues(Dictionary<string, DynamoDBEntry> expressionValues);

        /// <summary>
        /// Merge the given ExpressionValues into the builder's existing ExpressionValues
        /// </summary>
        ExpressionBuilder MergeExpressionValues(Dictionary<string, DynamoDBEntry> expressionValues);

        /// <summary>
        /// Adds a single element to the optional 'expression values' string dictionary
        /// </summary>
        ExpressionBuilder PutExpressionValue(string key, DynamoDBEntry value);

        /// <summary>
        /// The optional 'expression names' string dictionary
        /// </summary>
        ExpressionBuilder AddExpressionNames(Dictionary<string, string> expressionNames);

        /// <summary>
        /// Merge the given ExpressionNames into the builder's existing ExpressionNames
        /// </summary>
        ExpressionBuilder MergeExpressionNames(Dictionary<string, string> expressionNames);

        /// <summary>
        /// Adds a single element to the optional 'expression names' string dictionary
        /// </summary>
        ExpressionBuilder PutExpressionName(string key, string value);

        /// <summary>
        /// Call at the end to build the new <see cref="Expression"/>
        /// </summary>
        Expression Build();
    }
}