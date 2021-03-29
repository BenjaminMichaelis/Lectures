using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string notNull = "Hello";
            string? nullable = null;
            notNull = nullable;
            int? test = null;
            string test1 = null;
        }
        public string test12 { get; set; }
    }
}
