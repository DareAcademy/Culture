using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Localization_Session.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "NameRequired")]
        public string Name { get; set; }

        [Required(ErrorMessage = "PhoneRequired")]
        public string Phone { get; set; }

    }
}
