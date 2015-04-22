using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("BackgroundToSkill")]
    public class BackgroundToSkillMap
    {
        public BackgroundToSkillMap() { }

        [Key]
        public int BackgroundToSkill_Id { get; set; }

        [ForeignKey("Background_Id")]
        public virtual Background Background { get; set; }
        public int Background_Id { get; set; }

        [ForeignKey("Skill_Id")]
        public virtual Skill Skill { get; set; }
        public int Skill_Id { get; set; }
    }
}