using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("ClassRacialBonusMap")]
    public class ClassToRaceMap
    {
        [Key]
        public int ClassToRace_Id { get; set; }

        [ForeignKey("Class_Id")]
        public Class Class { get; set; }
        public int Class_Id { get; set; }

        [ForeignKey("Race_Id")]
        public Race Race { get; set; }
        public int Race_Id { get; set; }

        public string Description { get; set; }
    }
}