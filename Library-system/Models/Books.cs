using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library_system.Models
{
    public class Books
    {
        [Key] //primary key and not null
        public int bookId {  get; set; }

        [Required]
        public bool satus { get; set; }
        [Required]
        public decimal bookPrice { get; set; }
    }
}
