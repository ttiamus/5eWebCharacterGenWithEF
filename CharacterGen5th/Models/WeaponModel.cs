using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CharacterGen5th.Models
{
    public class WeaponModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public decimal Weight { get; set; }
        public string WeaponType { get; set; }
        public string Damage { get; set; }
        public string DamageType { get; set; }
        public bool MeleeWeapon { get; set; }
        public int Range { get; set; }
        public int RangeIncrement { get; set; }
        public List<WeaponPropertyModel> WeaponProperties { get; set; }
        public string ProficiencyNeeded { get; set; }
    }
}