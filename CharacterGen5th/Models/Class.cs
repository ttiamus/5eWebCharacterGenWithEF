using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Classes")]
    public class Class
    {
        public Class() { }

        [Key]
        public int Class_Id { get; set; }

        public string Name { get; set; }

        public int HitDie { get; set; }
       
        //Class Skiills

        public virtual IEnumerable<ClassToWeaponMap> WeaponProf { get; set; }

        public virtual IEnumerable<ClassToArmorMap> ArmorProf { get; set; }

        public virtual IEnumerable<ClassToSpellMap> ClassSpells { get; set; }

        public virtual IEnumerable<ClassToRaceMap> ClassRacialBonuses { get; set; }
    }
}