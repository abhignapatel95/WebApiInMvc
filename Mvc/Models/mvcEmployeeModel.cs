using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Mvc.Models
{
    public class mvcEmployeeModel
    {
            
        public int EmployeeID { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public Nullable<int> Age { get; set; }

        [Required]
        public Nullable<int> Salary { get; set; }
    }
}