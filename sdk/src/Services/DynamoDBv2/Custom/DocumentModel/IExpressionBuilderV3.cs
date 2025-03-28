using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2.DocumentModel
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member


    public class OperandItem
    {
        public static OperandItem New()
        {
            return new OperandItem();
        }

        protected string AttributeNames { get; set; }

        protected DynamoDBEntry AttributeValue { get; set; }

        //todo handle nested attributes
        public OperandItem WithName(string path)
        {
            AttributeNames = path;
            return this;
        }


        public OperandItem WithValue(DynamoDBEntry value)
        {
            AttributeValue = value;
            return this;
        }

        public string RenderNameKey => $"#{AttributeNames.ToLower()}";
        public string RenderValueKey => $":{AttributeNames.ToLower()}";
    }

    public abstract class ExpressionBuilderV4
    {
        protected List<OperandItem> OperandItems { get; set; }
        protected List<ConditionItem> ConditionItems { get; set; }
        protected string Operator { get; set; }

        //TODO: change to mode/type condition or operand
        protected bool IsCondition => ConditionItems.Count != 0;

        public abstract Expression Build();

    }

    public class ConditionItem : ExpressionBuilderV4
    {

        public ConditionItem()
        {
            OperandItems = new List<OperandItem>();
            ConditionItems = new List<ConditionItem>();
        }

        public override Expression Build()
        {
            return new Expression()
            {
                //TODO: Implement this
            };
        }

        //protected internal virtual Expression VisitChildren(ConditionItem visitor)
        //{
        //    if (!CanReduce) throw Error.MustBeReducible();
        //    return visitor.Visit(ReduceAndCheck());
        //}

        /// <summary>
        /// Creates a <see cref="string"/> representation of the Expression.
        /// </summary>
        /// <returns>A <see cref="string"/> representation of the Expression.</returns>
        public override string ToString()
        {
            return ""; //ExpressionStringBuilder.ExpressionToString(this);
        }

        public static ConditionItem New()
        {
            return new ConditionItem();
        }

        public ConditionItem WithCondition(ConditionItem equalTo)
        {
            ConditionItems.Add(equalTo);
            return this;
        }

        public ConditionItem And(ConditionItem equalTo)
        {
            ConditionItems.Add(equalTo);
            Operator = "AND";
            return this;
        }

        public ConditionItem Or(ConditionItem equalTo)
        {
            ConditionItems.Add(equalTo);
            Operator = "OR";
            return this;
        }

        public ConditionItem Not(ConditionItem equalTo)
        {
            ConditionItems.Add(equalTo);
            Operator = "NOT";
            return this;
        }

        public ConditionItem Parenthesis(ConditionItem equalTo)
        {
            ConditionItems.Add(equalTo);
            Operator = "()";
            return this;
        }

        //TODO: Implement condition vs operand check

        public ConditionItem With(OperandItem operandItem)
        {
            OperandItems.Add(operandItem);
            return this;
        }

        public ConditionItem EqualTo(OperandItem operandItem)
        {
            OperandItems.Add(operandItem);
            Operator = "=";
            return this;
        }

        public ConditionItem NotEqualTo(OperandItem operandItem)
        {
            OperandItems.Add(operandItem);
            Operator = "<>";
            return this;
        }

        public ConditionItem GreaterThan(OperandItem operandItem)
        {
            OperandItems.Add(operandItem);
            Operator = ">";
            return this;
        }

        public ConditionItem LessThan(OperandItem operandItem)
        {
            OperandItems.Add(operandItem);
            Operator = "<";
            return this;
        }

        public ConditionItem GreaterThanOrEqualTo(OperandItem operandItem)
        {
            OperandItems.Add(operandItem);
            Operator = ">=";
            return this;
        }

        public ConditionItem LessThanOrEqualTo(OperandItem operandItem)
        {
            OperandItems.Add(operandItem);
            Operator = "<=";
            return this;
        }

        

    }

    public abstract class ExpressionBuilderV3
    {
        protected string AttributeNames { get; set; }
        protected string Operator { get; set; }

        public ExpressionBuilderV3 WithName(string path)
        {
            AttributeNames = path;
            return this;
        }

        protected string RenderNameKey => $"#{AttributeNames.ToLower()}";
        protected string RenderValueKey => $":{AttributeNames.ToLower()}";

        public abstract Expression Build();
    }

    public class FunctionExpression : ExpressionBuilderV3
    {
        public static FunctionExpression New()
        {
            return new FunctionExpression();
        }

        public FunctionExpression AttributeExists(string path)
        {
            AttributeNames = path;
            Operator = "attribute_exists";
            return this;
        }

        public FunctionExpression AttributeNotExists(string path)
        {
            AttributeNames = path;
            Operator = "attribute_not_exists";
            return this;
        }

        public FunctionExpression Size(string path)
        {
            AttributeNames = path;
            Operator = "size";
            return this;
        }

        public override Expression Build()
        {
            return new Expression()
            {
                ExpressionStatement = $"{Operator}({RenderNameKey})",
                ExpressionAttributeNames = { [RenderNameKey] = AttributeNames }
            };
        }

        public new FunctionExpression WithName(string path)
        {
            AttributeNames = path;
            return this;
        }

    }

    public class UpdateExpression : ConditionalExpression
    {
        public new static UpdateExpression New()
        {
            return new UpdateExpression();
        }
        public new UpdateExpression WithName(string path)
        {
            AttributeNames = path;
            return this;
        }
        protected override string ExpressionStatement()
        {
            return $"SET {base.ExpressionStatement()}";
        }
    }

    public class ConditionalExpression : ExpressionBuilderV3
    {
        private DynamoDBEntry AttributeValue;

        public static ConditionalExpression New()
        {
            return new ConditionalExpression();
        }

        public new ConditionalExpression WithName(string path)
        {
            AttributeNames = path;
            return this;
        }

        public ConditionalExpression EqualTo(DynamoDBEntry value)
        {
            AttributeValue = value;
            Operator = "=";
            return this;
        }


        public ConditionalExpression Value(DynamoDBEntry value)
        {
            AttributeValue = value;
            return this;
        }

        public override Expression Build()
        {
            return new Expression()
            {
                ExpressionStatement = ExpressionStatement(),
                ExpressionAttributeNames = { [RenderNameKey] = AttributeNames },
                ExpressionAttributeValues = { [RenderValueKey] = AttributeValue }
            };
        }

        protected virtual string ExpressionStatement()
        {
            return $"{RenderNameKey} {Operator} {RenderValueKey}";
        }

    }


    public class ComposedConditional : ExpressionBuilderV3
    {
        private List<ExpressionBuilderV3> _conditionalExpressions;


        public ComposedConditional(List<ExpressionBuilderV3> conditionalExpressions)
        {
            _conditionalExpressions = conditionalExpressions;
        }

        public override Expression Build()
        {
           var expressions = _conditionalExpressions.Select(x => x.Build()).ToList();
           return new Expression()
           {
               ExpressionStatement = string.Join($" {Operator} ", expressions.Select(x => x.ExpressionStatement)),
               ExpressionAttributeNames = expressions.SelectMany(x => x.ExpressionAttributeNames)
                   .ToDictionary(x => x.Key, x => x.Value),
               ExpressionAttributeValues = expressions.SelectMany(x => x.ExpressionAttributeValues)
                   .ToDictionary(x => x.Key, x => x.Value)
           };
        }

        public static ComposedConditional New()
        {
            return new ComposedConditional(new List<ExpressionBuilderV3>());
        }

        public ComposedConditional WithCondition(ExpressionBuilderV3 equalTo)
        {
            _conditionalExpressions.Add(equalTo);
            return this;
        }

        public ComposedConditional And(ExpressionBuilderV3 equalTo)
        {
            _conditionalExpressions.Add(equalTo);
            Operator = "AND";
            return this;
        }
    }


#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}