using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_system.Models
{
    [Table("Books")]
    public class Books
    {
        [Key] //primary key and not null
        public int bookId {  get; set; }

        [Required]
        public bool satus { get; set; }

        [Required]
        public decimal bookPrice { get; set; }

        public ICollection<Vendor> vendors { get; set; } // Navigation

        public Employee Employee { get; set; }
    }
}
