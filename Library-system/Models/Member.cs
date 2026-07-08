using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Library_system.Models
{
    public class Member
    {
        [Key]
      
        public int member_id { get; set; }

        [Required]
        [MaxLength(100)]
        public string first_name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Last_name { get; set; }

        [Required]
        public int contact_no { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string state { get; set; }

        [Required]
        public string pin_code { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
