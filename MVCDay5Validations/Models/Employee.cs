using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDay5Validations.Models
{
    public class Employee
    {
        [DisplayName("Enter First Name:")]
        [Required(ErrorMessage ="First Name is a Mandatory Field")]
        public string FirstName { get; set; }

        [DisplayName("Enter Last Name:")]
        [Required(ErrorMessage = "Last Name is a Mandatory Field")]
        public string LastName { get; set; }

    }
}