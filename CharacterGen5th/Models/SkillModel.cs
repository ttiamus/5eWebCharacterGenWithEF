using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CharacterGen5th.Models
{
    public class SkillModel
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string AbilityScore { get; set; }
    }
}