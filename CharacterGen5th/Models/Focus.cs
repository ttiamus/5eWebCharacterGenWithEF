namespace CharacterGen5th.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Focus")]
    public partial class Focus
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cost { get; set; }
    }
}
