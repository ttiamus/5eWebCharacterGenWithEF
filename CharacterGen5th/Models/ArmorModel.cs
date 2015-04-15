using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CharacterGen5th.Models
{
    public class ArmorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public decimal Weight { get; set; }
        public string ArmorType { get; set; }
        public int BaseAc { get; set; }
        public int MaxDexMod { get; set; }
        public int RequiredStr { get; set; }
        public bool StealthDisadvantage { get; set; }
    }
}