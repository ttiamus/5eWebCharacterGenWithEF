using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("RaceProperties")]
    public class RaceProperty
    {
        public RaceProperty() { }

        [Key]
        public int RaceProperty_Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [ForeignKey("RaceProperty_Id")]
        public RaceProperty RacePropertyReplaces { get; set; }

        public virtual IEnumerable<RaceToRacePropertyMap> RacesWithRaceProperty { get; set; }
    }
}