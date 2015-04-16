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
    public class RaceModel
    {
        [Key]
        public int Race_Id { get; set; }

        [Required()]
        public string RaceName { get; set; }

        [Required()]
        public virtual IEnumerable<LanguageModel> AvailableLanguages { get; set; }

        [Required()]
        public virtual IEnumerable<AbilityScoreModel> IncreasedAbilityScores { get; set; }

        [Required()]
        [ForeignKey("Size_Id")]
        public SizeModel Size { get; set; }
        public int Size_Id { get; set; }

        [Required()]
        public int Speed { get; set; }

        public virtual IEnumerable<RaceModel> SubRace { get; set; }
    }
}