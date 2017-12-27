using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HighOrderFunctions
{
    public static class Decorators
    {
        public static Func<T, TResult> PrintingResultOf<T, TResult>(this Func<T, TResult> func) => (input) =>
        {
            var result = func(input);
            Console.WriteLine($"Input: {input} with Result:{result} ");
            return result;
        };

        public static Func<T, TResult> MeasuringTimeOf<T, TResult>(this Func<T, TResult> func) => (input) =>
        {
            var before = DateTime.Now;
            var result = func(input);
            var totalTime = DateTime.Now - before;
            Console.WriteLine($"Time for {input}: {totalTime}");
            return result;
        };
    }
}
