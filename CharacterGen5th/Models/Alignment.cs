using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    public class Alignment
    {
        [Key]
        public int Alignment_Id  { get; set; }

        [Required]
        public string Alignment_Name { get; set; }
    }
}