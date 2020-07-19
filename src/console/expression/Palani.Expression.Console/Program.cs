using System;
using System.Linq;
using Expressions = System.Linq.Expressions;

namespace Palani.Expression.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Func<int, bool> test = i => i == 5;
            Expressions.ConstantExpression constExpr = Expressions.Expression.Constant(5, typeof(int));

            System.Console.WriteLine(constExpr.NodeType);
            System.Console.WriteLine(constExpr.Type);
            System.Console.WriteLine(constExpr.Value);
        }
    }
}
