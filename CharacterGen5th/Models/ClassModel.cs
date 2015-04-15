using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CharacterGen5th.Models
{
    public class ClassModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HitDie { get; set; }
        public string PrimaryAbility { get; set; }
        public List<string> SavingThrowProf { get; set; }
        public virtual List<WeaponModel> WeaponProf { get; set; }
        public virtual List<ArmorModel> ArmorProf { get; set; }

    }
}