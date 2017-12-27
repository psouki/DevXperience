using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HighOrderFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Transformed into the PrintResultOf method 
            //1 step
            //Func<int, int> fibo = n =>
            //{
            //    var result = Fibonacci(n);
            //    Console.WriteLine($"Results for {n} is {result}");
            //    return result;
            //};

            //2 step
            // Func<int, int> operation = (n) => PrintResultOf(Fibonacci, n);
            //var operation = Decorators.PrintingResultOf<int, int>(Fibonacci);

            //4 step Building the promise with extension method
            //var operation = ((Func<int, int>)Fibonacci)
            //    .PrintingResultOf()
            //    .MeasuringTimeOf();

            //var f30 = operation(30);
            //var f35 = operation(35);
            //var f40 = operation(40);
            //WriteLine($"Results: {f30}, {f35}, {f40}");

            // <--> //
            // 1 step
            //using (var r = new Resource())
            //{
            //    r.Foo();
            //    r.Fee();
            //}

            // 2 step
            // This encapsulate the dispose in the same way of the using
            Resource.Use(r =>
            {
                r.Foo();
                r.Fee();
            });

            ReadKey();

        }

        // 3 step
        //This in its turn was transformed into the  Decorators.PrintingResultOf
        //public static int PrintResultOf(Func<int, int> func, int n)
        //{
        //    var result = func(n);
        //    Console.Write($"Result for {n} is {result}");
        //    return result;
        //}

        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);

        }
    }
}
