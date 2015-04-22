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

        [Required()]
        public string Name { get; set; }

        [Required()]
        public string Description { get; set; }

        [Required()]
        public int HitDie { get; set; }

        [Required()]
        public string PrimaryAbility { get; set; }

        [Required()]
        public List<string> SavingThrowProf { get; set; }

        [Required()]
        public virtual IEnumerable<ClassToWeaponMap> WeaponProf { get; set; }

        [Required()]
        public virtual IEnumerable<ClassToArmorMap> ArmorProf { get; set; }

        public virtual IEnumerable<ClassToSpellMap> ClassSpells { get; set; }
    }
}