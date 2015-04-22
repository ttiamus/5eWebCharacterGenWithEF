using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("RaceToRaceProperties")]
    public class RaceToRacePropertyMap
    {
        [Key]
        public int RaceToRaceProperty_Id { get; set; }

        [ForeignKey("Race_Id")]
        public Race Race { get; set; }
        public int Race_Id { get; set; }

        [ForeignKey("RaceProperty_Id")]
        public RaceProperty RaceProperty { get; set; }
        public int RaceProperty_Id { get; set; }
    }
}