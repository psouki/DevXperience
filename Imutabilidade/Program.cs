using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imutabilidade
{
    class Program
    {
        static void Main(string[] args)
        {
            Hint hint = new Hint("top", 3);
            Hint hint2 = new Hint("down", 1);
            Hint hint3 = new Hint("up", 7);
            Hint hint4 = new Hint("lower", 2);
            Hint hint5 = new Hint("high", 13);
            IList<Hint> list = new List<Hint>() { hint, hint2, hint3, hint4, hint5 };

            hint.ApplyMutation(list, 131, 0);

            IList<Hint> list2 = new List<Hint>() { null, null, null, null, null };
            hint.FillWithCrossovers(list2);
        }
    }
}
