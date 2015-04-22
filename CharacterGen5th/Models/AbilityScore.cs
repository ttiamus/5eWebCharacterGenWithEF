using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("AbilityScores")]
    public class AbilityScore
    {
        public AbilityScore()
        {

        }

        public AbilityScore(string ability)
        {
            this.Ability = ability;
        }

        [Key]
        public int AbilityScore_Id { get; set; }

        [Required()]
        public string Ability { get; set; }

        public virtual IEnumerable<RaceToAbililtyScoreMap> RacesWithAbilityScore { get; set; }
    }
}