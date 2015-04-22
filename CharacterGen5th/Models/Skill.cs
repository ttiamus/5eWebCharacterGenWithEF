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
    public class Skill
    {
        public Skill() { }

        [Key]
        public int Skill_Id { get; set; }

        [Required]
        public string SkillName { get; set; }

        [Required]
        [ForeignKey("AbilityScore_Id")]
        public AbilityScore AbilityScore { get; set; }
        public int? AbilityScore_Id { get; set; }

        public virtual IEnumerable<BackgroundToSkillMap> BackgroundThatGiveSkill { get; set; }
    }
}