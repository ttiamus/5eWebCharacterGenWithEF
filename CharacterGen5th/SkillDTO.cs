using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGen5th.Models;

namespace CharacterGen5th
{
    public class SkillDto
    {
        public AbilityScore AbilityScore { get; set; }

        public string SkillName { get; set; }

        public string SkillRank { get; set; }

        public string SkillMiscMod { get; set; }
    }
}
