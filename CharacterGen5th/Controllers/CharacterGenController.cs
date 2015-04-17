using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CharacterGen5th.Models;
using CharacterGen5th.Unity;
using CharacterGen5th.Repositories;


//Look into using Partail Views to render the webpages server side then pushing to web page. Replaces using razor and loops in the main view.
namespace CharacterGen5th.Controllers
{
    public class CharacterGenController : Controller
    {
        //Declare IRepositories here as private variables

        public CharacterGenController()
        {
            //Initialize IRepositories here
        }


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
