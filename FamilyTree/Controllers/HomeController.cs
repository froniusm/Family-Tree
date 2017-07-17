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
    }
}