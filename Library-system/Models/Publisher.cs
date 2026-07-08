using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library_system.Models
{
    public class Publisher
    {
        [Key] //primary key and not null
        public string publisherCode { get; set; }

        [Required]
        public string publisherName { get; set; }

        [Required]
        public string publisherCountry { get; set; }
    }
}
