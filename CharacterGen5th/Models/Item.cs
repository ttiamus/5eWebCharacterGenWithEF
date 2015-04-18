﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int Item_Id { get; set; }

        [Required()]
        public string Name { get; set; }

        [Required()]
        public decimal Cost { get; set; }

        [Required()]
        public decimal Weight { get; set; }

        [Required()]
        public string ItemType { get; set; }

        [ForeignKey("Background_Id")]
        public virtual Background Background  { get; set; }
        public int? Background_Id { get; set; }

        [ForeignKey("Character_Id")]
        public virtual Character Character { get; set; }
        public int? Character_Id { get; set; }
    }
}