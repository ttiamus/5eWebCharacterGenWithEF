using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Races")]
    public class Race
    {
        public Race() { }

        [Key]
        public int Race_Id { get; set; }

        [Required()]
        public string RaceName { get; set; }

        public string Type { get; set; }

        [Required()]
        public virtual IEnumerable<RaceToLanguagesMap> AvailableLanguages { get; set; }

        [Required()]
        public virtual IEnumerable<RaceToAbililtyScoreMap> IncreasedAbilityScores { get; set; }

        [Required()]
        [ForeignKey("Size_Id")]
        public Size Size { get; set; }
        public int? Size_Id { get; set; }

        [Required()]
        public int Speed { get; set; }

        public virtual IEnumerable<Race> SubRaces { get; set; }

        public virtual IEnumerable<RaceToRacePropertyMap> RaceProperties { get; set; }
    }
}