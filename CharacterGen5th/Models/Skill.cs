namespace CharacterGen5th.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Skill
    {
        public int Id { get; set; }

        [Column("Skill")]
        [Required]
        [StringLength(20)]
        public string Skill1 { get; set; }

        [Required]
        [StringLength(20)]
        public string Attribute { get; set; }
    }
}
