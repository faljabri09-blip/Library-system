using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library_system.Models
{
    public class Admin
    {
        [Key] // primary key and not null

        public int AdminId { get; set; }

        [Required] // not null
        [MaxLength(100)]
        public string AdminName { get; set; }

        [Required] //NotNull
        [MaxLength(50)]
        public string contact_no { get; set; }

    }
}
