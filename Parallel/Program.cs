using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel
{
    class Program
    {
        static void Main(string[] args)
        {

            //First this 0, 0
            //var numbers = Enumerable.Range(-10000, 20001)
            //   .Reverse()
            //   .ToList();

            //Console.WriteLine(numbers.Sum());

            //numbers.Sort();
            //Console.WriteLine(numbers.Sum());


            //With Parallel some strange calculation
            //var numbers = Enumerable.Range(-10000, 20001)
            //  .Reverse()
            //  .ToList();

            //Action task1 = () => Console.WriteLine(numbers.Sum());
            //Action task2 = () =>
            //{
            //    numbers.Sort();
            //    Console.WriteLine(numbers.Sum());
            //};

            //System.Threading.Tasks.Parallel.Invoke(task1, task2);

            //Then it is normalized again, all fixed
            var numbers = Enumerable.Range(-10000, 20001)
              .Reverse()
              .ToList();

            Action task1 = () => Console.WriteLine(numbers.Sum());
            Action task2 = () =>
            {
                var ordered = numbers.OrderBy(n => n);
                Console.WriteLine(ordered.Sum());
            };

            System.Threading.Tasks.Parallel.Invoke(task1, task2);


            Console.ReadKey();
        }
    }
}
