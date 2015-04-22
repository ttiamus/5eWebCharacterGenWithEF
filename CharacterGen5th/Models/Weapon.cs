using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Weapons")]
    public class Weapon
    {
        public Weapon() { }

        [Key]
        public int Weapon_Id { get; set; }
        
        [Required()]
        public string Name { get; set; }

        [Required()]
        public decimal Cost { get; set; }

        [Required()]
        public decimal Weight { get; set; }

        [Required()]
        public string WeaponType { get; set; }

        [Required()]
        public string Damage { get; set; }

        [Required()]
        public string DamageType { get; set; }

        [Required()]
        public bool MeleeWeapon { get; set; }

        public int Range { get; set; }

        public int RangeIncrement { get; set; }

        [Required()]
        public string ProficiencyNeeded { get; set; }

        public virtual IEnumerable<WeaponToWeaponPropertyMap> WeaponProperties { get; set; }

        public virtual IEnumerable<ClassToWeaponMap> WeaponProfByClass { get; set; }
    }
}