using Holidaysheet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Holidaysheet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    

        public ActionResult Holiday()
        {
            ViewBag.Message = "Your contact page.";

            var lista = new List<Holiday>();

            lista.Add(new Holiday() { Name = "Kovács", Days = 5 });
            lista.Add(new Holiday() { Name = "Kaszás", Days = 1 });
            lista.Add(new Holiday() { Name = "Fehér", Days = 15 });
            lista.Add(new Holiday() { Name = "Fekete", Days = 22 });
            lista.Add(new Holiday() { Name = "Bíró", Days = 0 });
            lista.Add(new Holiday() { Name = "Pupovszky", Days = 3 });
            
            


            return View(lista);
        }
    }
}