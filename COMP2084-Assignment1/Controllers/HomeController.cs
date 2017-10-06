using COMP2084_Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2084_Assignment1.Controllers
{
    public class HomeController : Controller
    {

        GameConsoleModel db = new GameConsoleModel();
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consoles()
        {
            ViewBag.Message = "Your list of consoles are here.";

            var consoles = db.consoles.ToList();

            return View(consoles);
        }

        public ActionResult Games(string console)
        {
            ViewBag.Message = "Archive of Games for ";


            var c = db.consoles.Include("games").SingleOrDefault(con => con.name == console);

            return View(c);
        }
    }
}