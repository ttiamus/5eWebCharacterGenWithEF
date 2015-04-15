using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CharacterGen5th.Models
{
    public class BackgroundModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<SkillModel> SkillProficiencies { get; set; }
        public virtual List<LanguageModel> Languages { get; set; }
        public virtual List<ItemModel> Equipment { get; set; }
    }
}