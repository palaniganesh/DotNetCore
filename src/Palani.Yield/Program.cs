using System;
using System.Collections.Generic;

namespace Palani.Yield
{
    class Program
    {
        static List<int> MyList = new List<int>();

        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(3);
            MyList.Add(2);
            MyList.Add(4);
            MyList.Add(5);
        }

        static IEnumerable<int> Filter()
        {
            foreach(var i in MyList)
            {
                if( i < 3)
                    yield return i;
            }
        }

        static IEnumerable<int> RunningTotal()
        {
            int runningTotal = 0;
            foreach(var i in MyList)
            {
                runningTotal = runningTotal + i;
                yield return runningTotal;
            }
        }

        static void GenerateFibonacci(int fibCount)
        {
            var fib = new List<int>();
            int previousNumber = -1;
            int currentNumber = 1;
            for(int i=0; i < fibCount; i++)
            {
                var sum = previousNumber + currentNumber;
                fib.Add(sum);
                Console.WriteLine(sum);
                previousNumber = currentNumber;
                currentNumber = sum;
            }
        }

        static void Main(string[] args)
        {
            /*
            FillValues();
            foreach(var i in MyList)
            {
                Console.WriteLine(i);
            }

            var lessthan3 = Filter();
            foreach(var i in lessthan3)
                Console.WriteLine(i);

            foreach(var i in RunningTotal())
            {
                Console.WriteLine($"Running total is {i}");
            }
            */
            GenerateFibonacci(10);
        }
    }
}
