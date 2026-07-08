using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library_system.Models
{
    public class Author
    {

        [Key]

        public string authorCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string authorName { get; set; }

        [Required]
        [MaxLength(100)]
        public string authorSubject { get; set; }

        [Required]
        [MaxLength(100)]
        public string authorQualification { get; set; }

        //Navigation 

        public ICollection<Books> books { get; set; }
    }
}
