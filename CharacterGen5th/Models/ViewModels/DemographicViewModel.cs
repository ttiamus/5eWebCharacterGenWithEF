using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models.ViewModels
{
    public class DemographicViewModel
    {
        //These are items that would get posted back
        public AbilityScore Str { get; set; }
        public AbilityScore Dex { get; set; }
        public AbilityScore Con { get; set; }
        public AbilityScore Int { get; set; }
        public AbilityScore Wis { get; set; }
        public AbilityScore Cha { get; set; }

        public string PlayerName { get; set; }
        public string CharacterName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Eyes { get; set; }
        public string Hair { get; set; }
        public string Skin { get; set; }
        public string Wealth { get; set; }

        public Race Race { get; set; }

        public Alignment Alignment { get; set; }
        public God God { get; set; }
    }
}