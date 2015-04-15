using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CharacterGen5th.Models
{
    public class RaceModel
    {
        public int Id { get; set; }
        public string RaceName { get; set; }
        public virtual List<LanguageModel> AvailableLanguages { get; set; }
        public virtual List<AbilityScoreModel> IncreasedAbilityScores { get; set; }
        public SizeModel Size { get; set; }
        public int Speed { get; set; }
        public virtual List<RaceModel> SubRaces { get; set; }
    }
}