using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FamilyTree.Models;
using FamilyTree.DAL;

namespace FamilyTree.Controllers
{
    public class HomeController : Controller
    {
        private IPersonDAL personDAL;

        public HomeController(IPersonDAL personDAL)
        {
            this.personDAL = personDAL;
        }

        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult PersonOne(Person p)
        {
            Person one = new Person();
            one.FirstName = p.FirstName;
            one.MiddleInitial = p.MiddleInitial;
            one.LastName = p.LastName;
            one.BirthDate = p.BirthDate;
            one.IsAlive = p.IsAlive;
            one.DeathDate = p.DeathDate;
            one.Gender = p.Gender;

            return View("PersonOne", one);
        }
    }
}