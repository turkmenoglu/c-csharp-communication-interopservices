using System;
using System.Runtime.InteropServices;

namespace Csharp
{
    class Program
    {
        [DllImport("c.dll")]
        public static extern void hi();

        static void Main(string[] args)
        {
            hi();

            Console.ReadKey();
        }
    }
}
