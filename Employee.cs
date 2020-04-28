using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Atyati.Models
{
    public class Employee
    {


        [Key]
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
     
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public string Role { get; set; }


        public DateTime StartDate { get; set; }
 
        public Department DepartmentId { get; set; }





    }
}
