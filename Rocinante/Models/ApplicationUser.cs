using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocinante.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Photo")]
        public string PhotoPath { get; set; }

        [Display(Name = "Resume")]
        public string ResumePath { get; set; }

        public string City { get; set; }

        [Display(Name = "Make Profile Public to Employers?")]
        public bool MakeProfilePublic { get; set; }
    }
}
