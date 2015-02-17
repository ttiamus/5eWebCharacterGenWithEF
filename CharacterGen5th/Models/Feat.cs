namespace CharacterGen5th.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Feat
    {
        public int Id { get; set; }

        [Column("Feat")]
        [Required]
        [StringLength(20)]
        public string Feat1 { get; set; }

        [StringLength(50)]
        public string Prerequisite { get; set; }

        public string Description { get; set; }

        public string Benefit { get; set; }
    }
}
