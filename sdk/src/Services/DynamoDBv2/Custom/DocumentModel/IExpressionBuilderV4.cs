using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Amazon.DynamoDBv2.DocumentModel.Ex
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member


    internal enum ConditionMode
    {
        // Catches errors for unset ConditionBuilder structs
        Unset = 0,

        // Comparison Conditions
        Equal,
        NotEqual,
        LessThan,
        LessThanOrEqual,
        GreaterThan,
        GreaterThanOrEqual,

        // Logical Conditions
        And,
        Or,
        Not,

        // Function-based Conditions
        Between,
        In,
        AttributeExists,
        AttributeNotExists,
        AttributeType,
        BeginsWith,
        Contains
    }

    public abstract class ExpressionBuilder
    {
        protected List<ConditionBuilder> Conditions { get; set; }
        protected List<OperandBuilder> Operands { get; set; }

        public abstract Expression Build();
    }

    public class ConditionBuilder : ExpressionBuilder
    {
        private ConditionMode _conditionMode;

        protected ConditionBuilder()
        {
            _conditionMode = ConditionMode.Unset;
            Operands = new List<OperandBuilder>();
            Conditions = new List<ConditionBuilder>();
        }

        private ConditionBuilder(List<OperandBuilder> operandBuilders, ConditionMode mode) : this()
        {

            _conditionMode = mode;
            Operands = operandBuilders;
        }

        private ConditionBuilder(List<ConditionBuilder> conditionBuilders, ConditionMode mode) : this()
        {
            _conditionMode = mode;
            Conditions = conditionBuilders;
        }

        public static ConditionBuilder New()
        {
            return new ConditionBuilder();
        }

        public ConditionBuilder WithCondition(ConditionBuilder condition)
        {
            Conditions.Add(condition);
            return this;
        }

        public NameBuilder WithName(string path)
        {
            return new NameBuilder(path);
        }

        internal static ConditionBuilder Equal(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.Equal);
            return condition;
        }

        public ConditionBuilder NotEqual(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.NotEqual);
            return condition;
        }

        public ConditionBuilder LesThan(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.LessThan);
            return condition;
        }

        public static ConditionBuilder And(ConditionBuilder left, ConditionBuilder right,
            params ConditionBuilder[] others)
        {
            var allConditions = new List<ConditionBuilder> { left, right };
            if (others is { Length: > 0 })
            {
                allConditions.AddRange(others);
            }

            return new ConditionBuilder(allConditions, ConditionMode.And);
        }

        public ConditionBuilder And(ConditionBuilder right, params ConditionBuilder[] others)
        {
            var allConditions = new List<ConditionBuilder> { this, right };
            if (others is { Length: > 0 })
            {
                allConditions.AddRange(others);
            }

            return new ConditionBuilder(allConditions, ConditionMode.And);
        }

        public static ConditionBuilder Not(ConditionBuilder condition)
        {
            var allConditions = new List<ConditionBuilder> { condition };
            return new ConditionBuilder(allConditions, ConditionMode.Not);
        }

        public ConditionBuilder Not()
        {
            var allConditions = new List<ConditionBuilder> { this };
            return new ConditionBuilder(allConditions, ConditionMode.Not);
        }

        public override Expression Build()
        {
            var expressionTree = BuildTree();

            var aliasList = new AliasList();

            var expression = new Expression()
            {
                ExpressionStatement = expressionTree.BuildExpressionString(aliasList)
            };

            if (aliasList.NamesList != null && aliasList.NamesList.Count != 0)
            {
                var namesDictionary = new Dictionary<string, string>();
                for (int i = 0; i < aliasList.NamesList.Count; i++)
                {
                    namesDictionary[$"#{i}"] = aliasList.NamesList[i];
                }

                expression.ExpressionAttributeNames = namesDictionary;
            }

            if (aliasList.ValuesList != null && aliasList.ValuesList.Count != 0)
            {
                var values = new Dictionary<string, DynamoDBEntry>();
                for (int i = 0; i < aliasList.ValuesList.Count; i++)
                {
                    values[$":{i}"] = aliasList.ValuesList[i];
                }

                expression.ExpressionAttributeValues = values;
            }

            return expression;
        }

        internal ExpressionNode BuildTree()
        {
            var childNodes = BuildChildNodes();

            var node = new ExpressionNode
            {
                Children = childNodes,
            };

            return _conditionMode switch
            {
                ConditionMode.Equal or
                    ConditionMode.NotEqual or
                    ConditionMode.LessThan or
                    ConditionMode.LessThanOrEqual or
                    ConditionMode.GreaterThan or
                    ConditionMode.GreaterThanOrEqual =>
                    CompareBuildCondition(_conditionMode, node),

                ConditionMode.And or ConditionMode.Or =>
                    CompoundBuildCondition(this, node),

                ConditionMode.Not =>
                    NotBuildCondition(node),

                ConditionMode.Between =>
                    BetweenBuildCondition(node),

                ConditionMode.In =>
                    InBuildCondition(this, node),

                ConditionMode.AttributeExists =>
                    AttributeExistsBuildCondition(node),

                ConditionMode.AttributeNotExists =>
                    AttributeNotExistsBuildCondition(node),

                ConditionMode.AttributeType =>
                    AttributeTypeBuildCondition(node),

                ConditionMode.BeginsWith =>
                    BeginsWithBuildCondition(node),

                ConditionMode.Contains =>
                    ContainsBuildCondition(node),

                ConditionMode.Unset =>
                    throw new InvalidOperationException("ConditionBuilder"),

                _ =>
                    throw new InvalidOperationException($"Build condition error: unsupported mode: {_conditionMode}")
            };
        }

        private ExpressionNode NotBuildCondition(ExpressionNode node)
        {
            node.FormatedExpression = string.Join($" NOT ", node.Children.Select(c => "$c"));
            return node;
        }

        #region statement_build

        private ExpressionNode CompoundBuildCondition(ConditionBuilder conditionBuilder, ExpressionNode node)
        {
            var mode = conditionBuilder._conditionMode switch
            {
                ConditionMode.And => "AND",
                ConditionMode.Or => "OR",
                _ => throw new InvalidOperationException(
                    $"Unsupported condition operator: {conditionBuilder._conditionMode}")
            };
            node.FormatedExpression = string.Join($" {conditionBuilder._conditionMode} ",
                node.Children.Select(c => "$c"));
            return node;
        }

        private ExpressionNode CompareBuildCondition(ConditionMode conditionMode, ExpressionNode node)
        {
            switch (conditionMode)
            {
                case ConditionMode.Equal:
                    node.FormatedExpression =
                        $"$c = $c";
                    break;
                case ConditionMode.NotEqual:
                    node.FormatedExpression =
                        $"$c <> $c";
                    break;
                case ConditionMode.LessThan:
                    node.FormatedExpression =
                        $"$c < $c";
                    break;
                case ConditionMode.LessThanOrEqual:
                    node.FormatedExpression =
                        $"$c <= $c";
                    break;
                case ConditionMode.GreaterThan:
                    node.FormatedExpression =
                        $"$c > $c";
                    break;
                case ConditionMode.GreaterThanOrEqual:
                    node.FormatedExpression =
                        $"$c >= $c";
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported mode: {conditionMode}");
            }

            return node;
        }

        private ExpressionNode ContainsBuildCondition(ExpressionNode node)
        {
            throw new NotImplementedException();
        }

        private ExpressionNode BeginsWithBuildCondition(ExpressionNode node)
        {
            throw new NotImplementedException();
        }

        private ExpressionNode AttributeTypeBuildCondition(ExpressionNode node)
        {
            throw new NotImplementedException();
        }

        private ExpressionNode AttributeNotExistsBuildCondition(ExpressionNode node)
        {
            throw new NotImplementedException();
        }

        private ExpressionNode AttributeExistsBuildCondition(ExpressionNode node)
        {
            throw new NotImplementedException();
        }

        private ExpressionNode InBuildCondition(ConditionBuilder conditionBuilder, ExpressionNode node)
        {
            throw new NotImplementedException();
        }

        private ExpressionNode BetweenBuildCondition(ExpressionNode node)
        {
            throw new NotImplementedException();
        }

        #endregion

        private List<ExpressionNode> BuildChildNodes1()
        {
            return Conditions.Select(cond => cond.BuildTree()).ToList();
        }

        private Stack<ExpressionNode> BuildChildNodes()
        {
            var childNodes = new Stack<ExpressionNode>();

            foreach (var condition in Conditions)
            {
                ExpressionNode node;
                try
                {
                    node = condition.BuildTree();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Failed to build condition tree", ex);
                }

                childNodes.Push(node);
            }

            foreach (var operand in Operands)
            {
                ExpressionNode node;
                try
                {
                    node = operand.Build();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Failed to build operand", ex);
                }

                childNodes.Push(node);
            }

            return childNodes;
        }
    }

    public abstract class OperandBuilder
    {
        internal abstract ExpressionNode Build();
    }

    internal class AliasList
    {
        public List<string> NamesList { get; set; } = new();
        public List<DynamoDBEntry> ValuesList { get; set; } = new();
    }

    internal class ExpressionNode
    {
        public Stack<string> Names { get; set; } = new();
        public Stack<DynamoDBEntry> Values { get; set; } = new();
        public string FormatedExpression { get; set; }
        public Stack<ExpressionNode> Children { get; set; } = new();


        internal string BuildExpressionString(AliasList aliasList)
            {
                var result = new StringBuilder();
                int i = 0;

                while (i < FormatedExpression.Length)
                {
                    if (FormatedExpression[i] == '$' && i + 1 < FormatedExpression.Length)
                    {
                        var next = FormatedExpression[i + 1];
                        switch (next)
                        {
                            case 'n':
                                {
                                    if (Names.Count == 0)
                                        throw new InvalidOperationException("Missing name for $n");

                                    string name = Names.Pop();
                                    string alias = $"#{aliasList.NamesList.Count}";
                                    aliasList.NamesList.Add(name);
                                    result.Append(alias);
                                    break;
                                }
                            case 'v':
                                {
                                    if (Values.Count == 0)
                                        throw new InvalidOperationException("Missing value for $v");

                                    var val = Values.Pop();
                                    string alias = $":{aliasList.ValuesList.Count}";
                                    aliasList.ValuesList.Add(val);
                                    result.Append(alias);
                                    break;
                                }
                            case 'c':
                                {
                                    if (Children.Count == 0)
                                        throw new InvalidOperationException("Missing child for $c");

                                    var child = Children.Pop();
                                    string subExpr = child.BuildExpressionString(aliasList);
                                    result.Append(subExpr);
                                    break;
                                }
                            default:
                                result.Append(FormatedExpression[i]); // not a known placeholder
                                break;
                        }
                        i += 2; // skip the placeholder
                    }
                    else
                    {
                        result.Append(FormatedExpression[i]);
                        i++;
                    }
                }

                return result.ToString();
            }
        }

    public class NameBuilder: OperandBuilder
    {
        private readonly IEnumerable<string> _names;

        public NameBuilder(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                _names = name.Split('.');
            }
        }

        public ConditionBuilder Equal(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return ConditionBuilder.Equal(this, rightOperand);
        }

        public ConditionBuilder NotEqual(OperandBuilder right)
        {
            return ConditionBuilder.Equal(this, right);
        }

        internal override ExpressionNode Build()
        {
            if (!_names.Any())
                throw new InvalidOperationException($"Unset name parameter");

            var node = new ExpressionNode
            {
                Names = new Stack<string>()
            };

            var fmtNames = new List<string>(_names.Count());

            foreach (var originalWord in _names)
            {
                if (string.IsNullOrEmpty(originalWord))
                    throw new InvalidOperationException("Invalid parameter Name");

                var word = originalWord;
                var substr = string.Empty;

                // Ensure brackets are matched and contain only digits
                var bracketPattern = new Regex(@"\[(\d+)\]");
                var bracketMatches = bracketPattern.Matches(word);

                if (word.Count(c => c == '[') != word.Count(c => c == ']'))
                    throw new InvalidOperationException("Invalid parameter Name");

                foreach (Match match in bracketMatches)
                {
                    if (!match.Success || match.Groups[1].Length == 0)
                        throw new InvalidOperationException("Invalid parameter Name");
                }

                // Extract suffix like [0][1] if present
                if (word.EndsWith("]"))
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] == '[')
                        {
                            substr = word.Substring(j);
                            word = word.Substring(0, j);
                            break;
                        }
                    }
                }

                if (string.IsNullOrEmpty(word))
                    throw new InvalidOperationException("Invalid parameter Name");

                node.Names.Push(word);
                //TODO: Check this
                fmtNames.Add($"$n{substr}");
            }

            node.FormatedExpression = string.Join(".", fmtNames);

            return node;
        }
    }

    public class ValueBuilder: OperandBuilder
    {
        private DynamoDBEntry _value;

        public ValueBuilder(DynamoDBEntry value)
        {
            _value = value;
        }

        public ConditionBuilder Equal(OperandBuilder right)
        {   
            return ConditionBuilder.Equal(this, right);
        }

        public ConditionBuilder NotEqual(OperandBuilder right)
        {
            return ConditionBuilder.Equal(this, right);
        }

        internal override ExpressionNode Build()
        {
            var values = new Stack<DynamoDBEntry>();
            values.Push(_value);
            return new ExpressionNode
            {
                Values = values,
                FormatedExpression = "$v"
            };
        }
    }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}