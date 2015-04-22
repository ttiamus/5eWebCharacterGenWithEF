using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CharacterGen5th.Models;
using CharacterGen5th.Repositories;
using CharacterGen5th.Bootstraper.Models;


//Look into using Partail Views to render the webpages server side then pushing to web page. Replaces using razor and loops in the main view.
namespace CharacterGen5th.Controllers
{
    public class CharacterGenController : Controller
    {
        //Declare IRepositories here as private variables
        private IItemRepository ItemRepo;
        private IAbilityScoreRepository AbilityScoreRepo;
        private ISkillRepository SkillRepo;

        public CharacterGenController(IItemRepository items, IAbilityScoreRepository abilityScores, ISkillRepository skills)
        {
            //Initialize IRepositories here
            this.ItemRepo = items;
            this.AbilityScoreRepo = abilityScores;
            this.SkillRepo = skills;
        }


        //
        // GET: /CharacterGen/
        public ActionResult Index()
        {
            AbilityScore str = new AbilityScore("Str");
            AbilityScore dex = new AbilityScore("Dex");
            AbilityScore con = new AbilityScore("Con");
            AbilityScore intel = new AbilityScore("Int");
            AbilityScore wis = new AbilityScore("Wis");
            AbilityScore cha = new AbilityScore("Cha");

           /* AbilityScoreRepo.CreateAbilityScore(str);
            AbilityScoreRepo.CreateAbilityScore(dex);
            AbilityScoreRepo.CreateAbilityScore(con);
            AbilityScoreRepo.CreateAbilityScore(intel);
            AbilityScoreRepo.CreateAbilityScore(wis);
            AbilityScoreRepo.CreateAbilityScore(cha);
            AbilityScoreRepo.Save();
            */
            Skill acrobatics = new Skill();
            acrobatics.SkillName = "Acrobatics";
            acrobatics.AbilityScore = AbilityScoreRepo.GetAbiltyScoreById(2);
            SkillRepo.CreateSkill(acrobatics);

            


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
