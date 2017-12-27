using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lazyness
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee first = new Employee() {Name = "Pedro", SocialSecurityNumber = 555555478};
            Employee second = new Employee() {Name = "Elemar", SocialSecurityNumber = 555555546};
            Employee third = new Employee() {Name = "Eduardo", SocialSecurityNumber = 555557923};

            Employee[] array = {first, second, third};

            //IEnumerable<string> names = Employee.GetNameForEmployees(array);
            //IEnumerable<string> names = array.GetNames();
            IEnumerable<string> names = array.Get(e => e.Name);
            IEnumerable<int> ssn = array.Get(e => e.SocialSecurityNumber);

            // 6 step if you change the method name form Get to Select you get the LINQ below :)
            IEnumerable<string> linqNames = array.Select(e => e.Name);

            IEnumerable<Employee> namesFiltered = array.WhereFilter(e => e.Name == "Pedro");

            // 7 step if you change the method name form WhereFilter to Where you get the LINQ below :)
            IEnumerable<Employee> namesFilteredLinq = array.Where(e => e.Name == "Pedro");


            //  Pause to understand
            //WriteLine("Before calling Get4");
            //var elements = Get4();
            //WriteLine("After calling Get4");

            //foreach (int e in elements)
            //{
            //    WriteLine(e);
            //}

            // ReadKey();
        }

        private static IEnumerable<int> Get4()
        {
            for (int i = 1; i <= 4; i++)
            {
                WriteLine($"Before Yield {i}");
                yield return i;
                WriteLine($"After Yield {i}");
            }
        }
    }
}
