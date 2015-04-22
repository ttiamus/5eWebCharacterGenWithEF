using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("RaceToAbilityScores")]
    public class RaceToAbililtyScoreMap
    {
        [Key]
        public int RaceToAbilityScore_Id { get; set; }

        [ForeignKey("Race_Id")]
        public Race Race { get; set; }
        public int Race_Id { get; set; }

        [ForeignKey("AbilityScore_1")]
        public AbilityScore AbiltyScore_1 { get; set; }
        public int AbilityScore_1 { get; set; }

        public int AbilityScore_1_Bonus { get; set; }

        [ForeignKey("AbilityScore_2")]
        public AbilityScore AbiltyScore_2 { get; set; }
        public int? AbilityScore_2 { get; set; }

        public int AbilityScore_2_Bonus { get; set; }
    }
}