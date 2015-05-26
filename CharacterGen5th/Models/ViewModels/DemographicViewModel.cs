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
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }

        public string PlayerName { get; set; }
        public string CharacterName { get; set; }
        public int? Age { get; set; }
        public bool Male { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public string Eyes { get; set; }
        public string Hair { get; set; }
        public string Skin { get; set; }
        public string Wealth { get; set; }

        public IEnumerable<Race> Races { get; set; }
        public IEnumerable<Alignment> Alignments { get; set; }
        public IEnumerable<God> Gods { get; set; }

        public DemographicViewModel()
        {
            Str = Dex = Con = Int = Wis = Cha = 10; // Set all inital stats to 10
            PlayerName = "";
            CharacterName = "";
            Age = null;
            Male = true;
            Height = null;
            Weight = null;
            Eyes = "";
            Hair = "";
            Skin = "";
            Wealth = "";
        }

        public DemographicViewModel(int characterId)
        {
            //Find character Id in the database.
            //If it exists, initialize all stats from what is there.
        }

    }
}