using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreKata.Models
{
    public class Person
    {
        public static string Name {get; set;}
        public static int Age { get; set; }
        public bool isMinor => Age >= 18;
    }
}
