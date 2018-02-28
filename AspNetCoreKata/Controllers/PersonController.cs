using System.Collections.Generic;
using AspNetCoreKata.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreKata.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<Person>
            {
                new Person {Name = "Jack Mentzer", Age = 27},
                new Person {Name = "Jack Mentzer", Age = 27},
                new Person {Name = "Jack Mentzer", Age = 27},
                new Person {Name = "Jack Mentzer", Age = 27},
                new Person {Name = "Jack Mentzer", Age = 27},
                new Person {Name = "Jack Mentzer", Age = 27},
                new Person {Name = "Jack Mentzer", Age = 27},
                new Person {Name = "Jack Mentzer", Age = 27},
                new Person {Name = "Jack Mentzer", Age = 27},

            };
            return View(list);
        }
    }
}