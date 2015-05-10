using CharacterGen5th.Bootstraper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("ClassToAbilityScores")]
    public class ClassToAbilityScoreMap
    {
        [Key]
        public int ClassToSaving_Id { get; set; }

        [ForeignKey("Class_Id")]
        public Class Class { get; set; }
        public int Class_Id { get; set; }

        [ForeignKey("AbilityScore_Id")]
        public AbilityScore AbilityScore { get; set; }
        public int AbilityScore_Id { get; set; }
    }
}