using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CharacterGen5th.Models;
using CharacterGen5th.Repositories;
using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models.ViewModels;


//Look into using Partail Views to render the webpages server side then pushing to web page. Replaces using razor and loops in the main view.
namespace CharacterGen5th.Controllers
{
    public class CharacterGenController : Controller
    {
        //Declare IRepositories here as private variables
        private IAbilityScoreRepository AbilityScoreRepo;
        private IItemRepository ItemRepo;
        private ISkillRepository SkillRepo;
        private IClassRepository ClassRepo;

        public CharacterGenController(IItemRepository items, IAbilityScoreRepository abilityScores, ISkillRepository skills, IClassRepository classes)
        {
            //Initialize IRepositories here
            this.AbilityScoreRepo = abilityScores;
            this.ItemRepo = items;
            this.SkillRepo = skills;
            this.ClassRepo = classes;
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
            DemographicViewModel demoVM = new DemographicViewModel();
            return View("StatsInput", demoVM);
        }

        // GET: /CharacterGen/Items
        public ActionResult Items()
        {
            return View("Items", ItemRepo.GetItems());
        }

        // GET: /CharacterGen/Skills
        public ActionResult Skills()
        {
            return View("Skills", SkillRepo.GetSkills());
        }

        // GET: /CharacterGen/Class
        public ActionResult Class()
        {
            return View("Class", ClassRepo.GetClasses());
        }

        // GET: /CharacterGen/ClassOptions
        public ActionResult ClassOptions()
        {
            return View("ClassOptions");
        }

    }
}
