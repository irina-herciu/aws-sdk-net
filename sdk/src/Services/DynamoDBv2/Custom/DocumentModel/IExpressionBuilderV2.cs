//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;

//namespace Amazon.DynamoDBv2.DocumentModel
//{
//#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
//    public abstract class Operand
//        {
//            public abstract string Render();
//        }

//        public class PathOperand : Operand
//        {
//            public string Path { get; }

//            public PathOperand(string path)
//            {
//                Path = path;
//            }

//            public override string Render() => Path;
//        }

//        public class ValueOperand : Operand
//        {
//            public object Value { get; }

//            public ValueOperand(object value)
//            {
//                Value = value;
//            }

//            public override string Render() => $":{Value}";
//        }

//        public class FunctionOperand : Operand
//        {
//            public string FunctionName { get; }
//            public List<Operand> Arguments { get; }

//            public FunctionOperand(string functionName, params Operand[] args)
//            {
//                FunctionName = functionName;
//                Arguments = args.ToList();
//            }

//            public override string Render()
//            {
//                var renderedArgs = string.Join(", ", Arguments.Select(a => a.Render()));
//                return $"{FunctionName}({renderedArgs})";
//            }
//        }

//        public class ArithmeticOperand : Operand
//        {
//            public Operand Left { get; }
//            public string Operator { get; }
//            public Operand Right { get; }

//            public ArithmeticOperand(Operand left, string op, Operand right)
//            {
//                Left = left;
//                Operator = op;
//                Right = right;
//            }

//            public override string Render() => $"({Left.Render()} {Operator} {Right.Render()})";
//        }

//        public class ParenthesizedOperand : Operand
//        {
//            private readonly Operand inner;

//            public ParenthesizedOperand(Operand inner)
//            {
//                this.inner = inner;
//            }

//            public override string Render() => $"({inner.Render()})";
//        }

//        public class ComparisonOperand : Operand
//        {
//            public Operand Left { get; }
//            public string Operator { get; }
//            public Operand Right { get; }

//            public ComparisonOperand(Operand left, string op, Operand right)
//            {
//                Left = left;
//                Operator = op;
//                Right = right;
//            }

//            public override string Render() => $"({Left.Render()} {Operator} {Right.Render()})";
//        }

//        public class LogicalOperand : Operand
//        {
//            private readonly string op;
//            private readonly List<Operand> operands;

//            public LogicalOperand(string op, params Operand[] operands)
//            {
//                this.op = op.ToUpper();
//                this.operands = operands.ToList();
//            }

//            public override string Render()
//            {
//                if (op == "NOT")
//                    return $"NOT {operands[0].Render()}";

//                var rendered = operands.Select(o => o.Render());
//                return $"({string.Join($" {op} ", rendered)})";
//            }
//        }

//        public enum ConditionMode
//        {
//            OperandList,
//            ConditionList
//        }


//    public class OperandBuilder
//    {
//        private Operand operand;

//        public List<OperandBuilder> OperandList { get; } = new();
//        public List<ConditionBuilder> ConditionList { get; } = new();
//        public ConditionMode Mode { get; private set; }

//        private OperandBuilder(Operand operand)
//        {
//            this.operand = operand;
//        }

//        public static OperandBuilder Path(string path) =>
//            new OperandBuilder(new PathOperand(path));

//        public static OperandBuilder Value(object value) =>
//            new OperandBuilder(new ValueOperand(value));

//        public static OperandBuilder Function(string name, params OperandBuilder[] args)
//        {
//            var operands = args.Select(a => a.operand).ToArray();
//            return new OperandBuilder(new FunctionOperand(name, operands));
//        }

//        public OperandBuilder Add(OperandBuilder other) =>
//            new OperandBuilder(new ArithmeticOperand(this.operand, "+", other.operand));

//        public OperandBuilder Subtract(OperandBuilder other) =>
//            new OperandBuilder(new ArithmeticOperand(this.operand, "-", other.operand));

//        public OperandBuilder Multiply(OperandBuilder other) =>
//            new OperandBuilder(new ArithmeticOperand(this.operand, "*", other.operand));

//        public OperandBuilder Divide(OperandBuilder other) =>
//            new OperandBuilder(new ArithmeticOperand(this.operand, "/", other.operand));

//        public OperandBuilder EqualTo(OperandBuilder other) =>
//            new OperandBuilder(new ComparisonOperand(this.operand, "=", other.operand));

//        public OperandBuilder NotEqualTo(OperandBuilder other) =>
//            new OperandBuilder(new ComparisonOperand(this.operand, "<>", other.operand));

//        public OperandBuilder GreaterThan(OperandBuilder other) =>
//            new OperandBuilder(new ComparisonOperand(this.operand, ">", other.operand));

//        public OperandBuilder LessThan(OperandBuilder other) =>
//            new OperandBuilder(new ComparisonOperand(this.operand, "<", other.operand));

//        public OperandBuilder GreaterThanOrEqualTo(OperandBuilder other) =>
//            new OperandBuilder(new ComparisonOperand(this.operand, ">=", other.operand));

//        public OperandBuilder LessThanOrEqualTo(OperandBuilder other) =>
//            new OperandBuilder(new ComparisonOperand(this.operand, "<=", other.operand));

//        public OperandBuilder And(OperandBuilder other) =>
//            new OperandBuilder(new LogicalOperand("AND", this.operand, other.operand));

//        public OperandBuilder Or(OperandBuilder other) =>
//            new OperandBuilder(new LogicalOperand("OR", this.operand, other.operand));

//        public OperandBuilder Not() =>
//            new OperandBuilder(new LogicalOperand("NOT", this.operand));

//        public OperandBuilder Parenthesize() =>
//            new OperandBuilder(new ParenthesizedOperand(operand));

//        public string Build() => operand.Render();

//        public static implicit operator Operand(OperandBuilder builder) => builder.operand;
//    }

//    public class ConditionBuilder
//    {
//        private readonly Operand operand;

//        private ConditionBuilder(Operand operand)
//        {
//            this.operand = operand;
//        }

//        public static ConditionBuilder AttributeExists(OperandBuilder path)
//        {
//            var func = OperandBuilder.Function("attribute_exists", path);
//            return new ConditionBuilder(func);
//        }

//        public static ConditionBuilder AttributeNotExists(OperandBuilder path)
//        {
//            var func = OperandBuilder.Function("attribute_not_exists", path);
//            return new ConditionBuilder(func);
//        }

//        public static ConditionBuilder BeginsWith(OperandBuilder path, OperandBuilder substr)
//        {
//            var func = OperandBuilder.Function("begins_with", path, substr);
//            return new ConditionBuilder(func);
//        }

//        public static ConditionBuilder Contains(OperandBuilder path, OperandBuilder operand)
//        {
//            var func = OperandBuilder.Function("contains", path, operand);
//            return new ConditionBuilder(func);
//        }

//        public static ConditionBuilder Between(OperandBuilder target, OperandBuilder lower, OperandBuilder upper)
//        {
//            var lowerCond = target.GreaterThanOrEqualTo(lower);
//            var upperCond = target.LessThanOrEqualTo(upper);
//            return new ConditionBuilder(lowerCond.And(upperCond));
//        }

//        public string Build() => operand.Render();

//        public override string ToString() => Build();
//    }
//#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
//}