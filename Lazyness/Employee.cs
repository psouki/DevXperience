using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazyness
{
    public class Employee
    {
        public string Name { get; set; }
        public int SocialSecurityNumber { get; set; }

        // 1 step
        //public static string[] GetNameForEmployees(Employee[] employees)
        //{
        //    var result = new string[employees.Length];
        //    for (int i = 0; i < employees.Length; i++)
        //    {
        //        result[i] = employees[i].Name;
        //    }

        //    return result;
        //}

        // 2 step
        //public static IEnumerable<string> GetNameForEmployees(IEnumerable<Employee> employees)
        //{
        //    var result = new List<string>();
        //    foreach (Employee employee in employees)
        //    {
        //        result.Add(employee.Name);
        //    }

        //    return result;
        //}

        // 3 step
        //public static IEnumerable<string> GetNameForEmployees(IEnumerable<Employee> employees)
        //{
        //    foreach (Employee employee in employees)
        //    {
        //        yield return employee.Name;
        //    }
        //}
        
    }
}
