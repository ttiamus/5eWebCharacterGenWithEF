using System.Linq;
using System.Web.Mvc;
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
        private IRaceRepository RaceRepo;
        private IArmorRepository ArmorRepo;
        private IWeaponRepository WeaponRepo;
        private IAlignmentRepository AlignmentRepo;
        private IGodRepository GodRepo;

        public CharacterGenController(IItemRepository items, IAbilityScoreRepository abilityScores, ISkillRepository skills, IClassRepository classes, IRaceRepository races, IArmorRepository armorRepo, IWeaponRepository weaponRepo, IAlignmentRepository alignmentRepo, IGodRepository godRepo)
        {
            //Initialize IRepositories here
            this.AbilityScoreRepo = abilityScores;
            this.ItemRepo = items;
            this.SkillRepo = skills;
            this.ClassRepo = classes;
            this.RaceRepo = races;
            this.ArmorRepo = armorRepo;
            this.WeaponRepo = weaponRepo;
            this.AlignmentRepo = alignmentRepo;
            this.GodRepo = godRepo;
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
            return View("Demographic");
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

        // GET: /CharacterGen/DemographicInit
        public ActionResult DemographicInit()
        {
            var demoViewModel = new DemographicViewModel();
            demoViewModel.Races = RaceRepo.GetRaces();
            demoViewModel.Gods = GodRepo.GetGods();
            demoViewModel.Alignments = AlignmentRepo.GetAlignments();

            return Json(demoViewModel, JsonRequestBehavior.AllowGet);
        }

        // GET: /CharacterGen/ClassInit
        public ActionResult ClassInit()
        {
            var classViewModel = new ClassViewModel();
            classViewModel.Classes = ClassRepo.GetClasses();
            return Json(classViewModel, JsonRequestBehavior.AllowGet);
        }

        // GET: /CharacterGen/SkillInit
        public ActionResult SkillInit()
        {
            var skillViewModel = new SkillViewModel();
            skillViewModel.Skills = SkillRepo.GetSkills();
            skillViewModel.Str = 0;
            skillViewModel.Dex = 0;
            skillViewModel.Con = 0;
            skillViewModel.Int = 0;
            skillViewModel.Wis = 0;
            skillViewModel.Cha = 0;

            return Json(skillViewModel, JsonRequestBehavior.AllowGet);
        }

        // GET: /CharacterGen/ItemInit
        public ActionResult ItemInit()
        {
            ItemsViewModel itemViewModel = new ItemsViewModel();
            itemViewModel.Armors = ArmorRepo.GetArmors().OrderBy(x => x.Name);
            itemViewModel.ItemsAmmunition = ItemRepo.GetItems().Where(x => x.ItemType == "Ammunition").OrderBy(x => x.Name);
            itemViewModel.ItemsGeneral = ItemRepo.GetItems().Where(x => x.ItemType != "Ammunition").OrderBy(x => x.Name);
            itemViewModel.Weapons = WeaponRepo.GetWeapons().OrderBy(x => x.Name);

            return Json(itemViewModel, JsonRequestBehavior.AllowGet);
        }

        // GET: /CharacterGen/DemographicInit
        public ActionResult GetGodsByAlignment(int alignmentId)
        {
            var godList = GodRepo.GetGodsByAlignment(alignmentId);

            return Json(godList, JsonRequestBehavior.AllowGet);
        }

        // GET: /CharacterGen/RaceChosen
        public ActionResult RaceChosen(int id)
        {
            var data = RaceRepo.FindRaceById(id);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        // GET: /CharacterGen/RaceChosen
        public ActionResult GodChosen(int id)
        {
            var data = GodRepo.GetGodById(id);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
