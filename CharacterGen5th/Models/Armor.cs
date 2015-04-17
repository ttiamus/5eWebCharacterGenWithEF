using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Armors")]
    public class Armor
    {
        [Key]
        public int Armor_Id { get; set; }

        [Required()]
        public string Name { get; set; }

        [Required()]
        public decimal Cost { get; set; }

        [Required()]
        public decimal Weight { get; set; }

        [Required()]
        public string ArmorType { get; set; }

        [Required()]
        public int BaseAc { get; set; }

        [Required()]
        public int MaxDexMod { get; set; }

        [Required()]
        public int RequiredStr { get; set; }

        [Required()]
        public bool StealthDisadvantage { get; set; }

        [ForeignKey("Class_Id")]
        public virtual Class Class { get; set; }
        public int Class_Id { get; set; }
    }
}