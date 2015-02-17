namespace CharacterGen5th.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Armor")]
    public partial class Armor
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Type { get; set; }

        public int? AC { get; set; }

        [Column("Stealth Disadvantage")]
        public bool? Stealth_Disadvantage { get; set; }

        [Column("Strength Requirement")]
        public int? Strength_Requirement { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cost { get; set; }
    }
}
