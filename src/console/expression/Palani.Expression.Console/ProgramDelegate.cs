using System;

namespace Palani.Expression.Console
{
    delegate void MeDelegate();
    delegate int OperationDelegate(int n1, int n2);

    class ProgramDelegate
    {
        public int Number1{get;set;}
        public int Number2{get;set;}

        static void Main(string[] args)
        {
            MeDelegate del = Foo;
            InvokeDelegate(del);

            var obj = new ProgramDelegate{Number1 = 10, Number2 = 5};

            OperationDelegate oDel = obj.AddOperation;
            //var sum = obj.InvokeOpDelegate(oDel);
            var sum = obj.InvokeOpDelegate((i, j)=> {return i + j;});
            System.Console.WriteLine($"Sum is {sum}");

            oDel = obj.SubtractOperation;
            //var res = obj.InvokeOpDelegate(oDel);
            var res = obj.InvokeOpDelegate((i, j)=> {return i - j;});
            System.Console.WriteLine($"Subtraction result is {res}");

            //sum = obj.InvokeOpDelegate()
        }

        static void InvokeDelegate(MeDelegate deler)
        {
            deler();
        }

        int InvokeOpDelegate(Func<int,int,int> deler)
        {
           return deler(Number1, Number2);
        }
/*
        int InvokeOpDelegate(OperationDelegate deler)
        {
           return deler(Number1, Number2);
        }
*/
        static void Foo()
        {
            System.Console.WriteLine("This is Foo()");
        }

        int AddOperation(int n1, int n2)
        {
            return n1 + n2;
        }

        int SubtractOperation(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}