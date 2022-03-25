using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Employee
    {

        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage ="Employee name can't Empty")]
        [MinLength(3,ErrorMessage ="Name must be be min 3")]
        public string Name{ get; set; }
        [Display(Name= "Employee Email Address")]
        [Required(ErrorMessage = "Employee Email can't Empty")]
        public string Email{ get; set; }
        [Display(Name = "Employee Phone number")]
        [Required(ErrorMessage = "Employee phone can't Empty")]
        [RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$",ErrorMessage="Invalid phone")]
        public string Phone{ get; set; }
        [Display(Name = "Employee Address")]
        [Required(ErrorMessage = "Employee Address can't Empty")]
        public string Address { get; set; }


    }
}
