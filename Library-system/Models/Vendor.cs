using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_system.Models
{
    [Table("Vendor")]
    public class Vendor
    {
        [Key] //primary key and not null 
        public string VendorCode { get; set; }

        [Required] // not null
        [MaxLength(50)]
        public int Contact_no { get; set; }

        //Relationship (navigation)

        public Books Books { get; set; } // one booke vendor
    }
}
