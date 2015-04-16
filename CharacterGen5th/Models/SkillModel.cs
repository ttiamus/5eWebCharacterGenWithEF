using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Skills")]
    public class SkillModel
    {
        [Key]
        public int Skill_Id { get; set; }

        [Required]
        public string SkillName { get; set; }

        [Required]
        [ForeignKey("AbilityScore_Id")]
        public AbilityScoreModel AbilityScore { get; set; }
        public int AbilityScore_Id { get; set; }

        [ForeignKey("Background_Id")]
        public virtual BackgroundModel Background { get; set; }
        public int Background_Id { get; set; }
    }
}