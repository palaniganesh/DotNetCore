using System;
using System.Linq.Expressions;

namespace Palani.CSharp.Concepts
{
    class ProgramExpressions
    {
        static void Main(string[] args)
        {
            //Func<int,bool> mydel = i => i > 5;
            //Console.WriteLine(mydel(6));
            //Console.WriteLine(mydel(3));
            
            Expression<Func<int,bool>> myExpr = i => i > 5;
            //Console.WriteLine(myExpr.NodeType);
            //Console.WriteLine(myExpr.Body);
            //Console.WriteLine(myExpr.Body.GetType());

            //BinaryExpression biExpression = (BinaryExpression) myExpr.Body;
            //Console.WriteLine(biExpression.Left);
            //System.Console.WriteLine(biExpression.Right);

            ConstantExpression constExpr = Expression.Constant(5,typeof(int));
            ParameterExpression iExpression = Expression.Parameter(typeof(int),"i");
            BinaryExpression binaryExpression = Expression.GreaterThan(iExpression, constExpr);
            LambdaExpression lambExpression = Expression.Lambda<Func<int,bool>>(binaryExpression,iExpression);
            //System.Console.WriteLine(lambExpression.NodeType);
            //System.Console.WriteLine(lambExpression.Name);
            //System.Console.WriteLine(lambExpression.Body);
            
            //myExpr and lambExpression are the same/equal/identical

            Expression<Func<int,bool>> myExpr2 = Expression.Lambda<Func<int,bool>>(binaryExpression,iExpression);
            
            //This should be avoided for production as this is expensive in performancewise
            Func<int,bool> myDele = myExpr2.Compile();
            System.Console.WriteLine(myDele(3));
            System.Console.WriteLine(myDele(8));
        }
    }
}
