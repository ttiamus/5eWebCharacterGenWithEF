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

        public IEnumerable<WeaponProperty> WeaponProperties { get; set; }

        [Required()]
        public string ProficiencyNeeded { get; set; }

        [ForeignKey("Class_Id")]
        public virtual Class Class { get; set; }
        public int? Class_Id { get; set; }

        [ForeignKey("Character_Id")]
        public virtual Character Character { get; set; }
        public int? Character_Id { get; set; }
    }
}