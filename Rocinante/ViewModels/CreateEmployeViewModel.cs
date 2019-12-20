using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocinante.ViewModels
{
    public class CreateEmployeViewModel
    {
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string PhotoPath { get; set; }

        public string ResumePath { get; set; }

        [Display(Name = "Update Photo")]
        public string Photo { get; set; }

        [Display(Name = "Update Resume")]
        public string Resume { get; set; }

        public string City { get; set; }

        [Display(Name = "Make Profile Public to Employers?")]
        public bool MakeProfilePublic { get; set; }
    }
}
