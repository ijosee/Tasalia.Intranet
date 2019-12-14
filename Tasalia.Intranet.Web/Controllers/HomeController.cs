using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Tasalia.Intranet.DataBase.Models;
using Tasalia.Intranet.Web.Models;

namespace Tasalia.Intranet.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            using (var db = new TasaliaContext())
            {

                IEnumerable<City> dbResult = from city in db.City
                                             select city;

                foreach (var item in dbResult)
                {

                    Console.WriteLine($"Item :  {item.City1}");

                }

            }


            return View();
        }

        public IActionResult Ficha()
        {




            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
