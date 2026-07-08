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
        public string AdminName { get; set; }

        [Required] //NotNull
        public string contact_no { get; set; }

    }
}
