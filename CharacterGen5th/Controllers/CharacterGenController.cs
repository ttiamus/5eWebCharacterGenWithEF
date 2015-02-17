using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterGen5th.Controllers
{
    public class CharacterGenController : Controller
    {
        //
        // GET: /CharacterGen/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /CharacterGen/StatsInput
        public ActionResult StatsInput()
        {
            return View("StatsInput");
        }

        // GET: /CharacterGen/Items
        public ActionResult Items()
        {
            return View("Items");
        }

        // GET: /CharacterGen/Skills
        public ActionResult Skills()
        {
            return View("Skills");
        }

        // GET: /CharacterGen/Class
        public ActionResult Class()
        {
            return View("Class");
        }

        // GET: /CharacterGen/ClassOptions
        public ActionResult ClassOptions()
        {
            return View("ClassOptions");
        }

    }
}
