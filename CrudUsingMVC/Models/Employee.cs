using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudUsingMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the First Name!.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter the Last Name!.")]
        public string  LastName { get; set; }
        public string DOJ { get; set; }
        [MaxLength(6)]
        public string EmpID { get; set; }
        public string Package { get; set; }
    }
}
