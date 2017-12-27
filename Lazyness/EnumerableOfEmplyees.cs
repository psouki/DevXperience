using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazyness
{
    public static class EnumerableOfEmplyees
    {
        // 4 step change the concrete implementation for the generic one. 
        //public static IEnumerable<string> GetNames(this IEnumerable<Employee> employees)
        //{
        //    foreach (Employee employee in employees)
        //    {
        //        yield return employee.Name;
        //    }
        //}

        //public static IEnumerable<int> GetSocialSecurityNumber(this IEnumerable<Employee> employees)
        //{
        //    foreach (Employee employee in employees)
        //    {
        //        yield return employee.SocialSecurityNumber;
        //    }
        //}

        // Part of the step 5 see the method Enumerables
        //public static IEnumerable<TResult> Get<TResult>(this IEnumerable<Employee> employees, Func<Employee, TResult> selector)
        //{
        //    foreach (Employee employee in employees)
        //    {
        //        yield return selector(employee);
        //    }
        //} 
    }
}
