using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CharacterGen5th.Models
{
    public class SpellModel
    {
        public int Id { get; set; }
        public string SpellName { get; set; }
        public virtual List<ClassModel> Classes { get; set; }
        public int SpellDc { get; set; }
        public string CastTime { get; set; }
        public string Duration { get; set; }
        public string Components { get; set; }
        public string Range { get; set; }
        public string Target { get; set; }
        public string AreaOfEffect { get; set; }

    }
}