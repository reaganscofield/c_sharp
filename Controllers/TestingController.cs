using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_application.Models;

namespace web_application.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Testing()
        {
            List<Models.PersonModel> peope = new List<Models.PersonModel>();
            peope.Add(new PersonModel { FirstName = "Reagan", LastName = "Scofield", Age = 34, IsAlive = true });
            peope.Add(new PersonModel { FirstName = "Judith", LastName = "Scofield", Age = 28, IsAlive = true });
            peope.Add(new PersonModel { FirstName = "Almeida", LastName = "Scofield", Age = 6, IsAlive = true });
            peope.Add(new PersonModel { FirstName = "Aleah", LastName = "Scofield", Age = 2, IsAlive = true });

            return View(peope);
        }
    }
}