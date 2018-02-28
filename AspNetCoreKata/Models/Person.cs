using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreKata.Models
{
    public class Person
    {
        public string Name {get; set;}
        public int Age { get; set; }
        public bool isMinor => Age >= 18;
    }
}
