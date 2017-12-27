using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazyness
{
    public static class Enumerables
    {
        // 5 step this method substitutes the EnumerableOfEmplyees Get to became even more generic.
        public static IEnumerable<TResult> Get<TResult, T>(this IEnumerable<T> elements, Func<T, TResult> selector)
        {
            foreach (T element in elements)
            {
                yield return selector(element);
            }
        }

        // 6 step if you change the method name form Get to Select it becomes the beginning of LINQ

        // Method WHERE from LINQ reimplemented  
        public static IEnumerable<T> WhereFilter<T>(this IEnumerable<T> elements, Func<T, bool> filter)
        {
            //foreach (var element in elements)
            //{
            //    if (filter(element))
            //    {
            //        yield return element;
            //    }
            //}

            // this code below is what happens behind the scenes in the foreach statement It is called Enumerable for that the Enumerator :)
            using (var enumerator = elements.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    if (filter(enumerator.Current))
                    {
                        yield return enumerator.Current;
                    }
                }
            }
        }
    }
}
