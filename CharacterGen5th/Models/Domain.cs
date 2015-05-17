using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("Domains")]
    public class Domain
    {
        [Key]
        public int Domain_Id { get; set; }

        public string DomainName { get; set; }

        public virtual IEnumerable<GodToDomainMap> GodsWithDomain { get; set; }
    }
}