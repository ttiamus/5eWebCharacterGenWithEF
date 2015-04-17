﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("AbilityScores")]
    public class AbilityScore
    {
        [Key]
        public int AbilityScore_Id { get; set; }

        [Required()]
        public string Ability { get; set; }

        [ForeignKey("Race_Id")]
        public virtual Race Race { get; set; }
        public int Race_Id { get; set; }

        [ForeignKey("Skill_Id")]
        public virtual Skill Skill { get; set; }
        public int Skill_Id { get; set; }
    }
}