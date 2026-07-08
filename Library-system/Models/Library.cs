using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library_system.Models
{
    public class Library
    {
        [Key] // primary key and not null 
        public string libraryName { get; set; }

        [Required] // not null
        [MaxLength(100)]
        public string libraryAddress { get; set; }

        [Required] // not null
        [MaxLength(50)]
        public int contact_no { get; set; }


        //Navigation
        public Admin Admin { get; set; }
    }
}
