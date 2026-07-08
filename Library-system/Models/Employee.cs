using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library_system.Models
{
    public class Employee
    {
        [Key] 
        public int employeeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string employeeName { get; set; }

        [Required]
        [MaxLength(100)]
        public string employeeDesignation { get; set; }

        [Required]
        [MaxLength(50)]
        public int mobile_no { get; set; }
    }
}
