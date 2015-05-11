using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("GodToDomains")]
    public class GodToDomainMap
    {
        [Key]
        public int GodToDomainMap_Id { get; set; }

        [ForeignKey("God_Id")]
        public God God { get; set; }
        public int God_Id { get; set; }

        [ForeignKey("Domain_Id")]
        public Domain Domain { get; set; }
        public int Domain_Id { get; set; }
    }
}