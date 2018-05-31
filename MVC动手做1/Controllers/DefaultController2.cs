using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC动手做1.Controllers
{
    public class DefaultController2 : Controller
    {
        public string Username { get; private set; }

        // GET: DefaultController2
        public ActionResult Index()
        {
            var Uname = new Models.Class1( Username = "(4),D");
            return View(Uname);
        }
    }
}