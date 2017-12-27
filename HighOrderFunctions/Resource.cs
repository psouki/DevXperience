using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HighOrderFunctions
{
    public class Resource : IDisposable
    {
        public Resource()
        {
            WriteLine("Created...");
        }

        public void Foo() => WriteLine("Foo");
        public void Fee() => WriteLine("Fee");

        public void Dispose()
        {
            WriteLine("Cleanup ...");
        }

        public static void Use(Action<Resource> block)
        {
            var r = new Resource();
            try { block(r); } finally { r.Dispose(); }

        }
    }
}
