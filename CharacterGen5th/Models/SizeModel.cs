using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CharacterGen5th.Models
{
    public class SizeModel
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public bool AcIncrease { get; set; }
        public int AcMod { get; set; }

    }
}