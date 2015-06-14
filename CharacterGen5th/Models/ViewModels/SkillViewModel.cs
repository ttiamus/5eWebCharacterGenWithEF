using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Models.ViewModels
{
    public class SkillViewModel
    {
        public IEnumerable<SkillDto> Skills { get; set; }
    }

    public class SkillDto
    {
        public SkillDto() { }

        [Key]
        public int Skill_Id { get; set; }

        [Required]
        public string SkillName { get; set; }
        
        public string AbilityName { get; set; }

        public int AbilityScore { get; set; }

        public int Rank { get; set; }

        public int MiscMod { get; set; }
    }
}
