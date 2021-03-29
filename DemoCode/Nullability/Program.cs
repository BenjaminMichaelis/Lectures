using System;
using System.Collections.Generic;

namespace Nullability
{
    class Program
    {
        static void Main(string[] args)
        {
            // string notNull = "Hello";
            // string? nullable = null;
            // notNull = nullable;
            // int? test = null;
            // string test1 = null;
            // notNull = notNull + "World";
            // Console.WriteLine(notNull);
            // // Warning: CS8714 - Nullability of type argument 'string?' doesn't match 'notnull' constraint
            // var d1 = new Dictionary<string?, string>(10);
               
            // // And as expected, using 'null' as a key for a non-nullable key type is a warning...
            // var d2 = new Dictionary<string, string>(10);
               
            // // Warning: CS8625 - Cannot convert to non-nullable reference type.
            // var nothing = d2[null];
        }
        // public string test12 { get; set; }
    }
}
