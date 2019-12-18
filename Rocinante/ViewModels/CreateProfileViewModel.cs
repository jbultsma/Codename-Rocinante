using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocinante.ViewModels
{
    public class CreateProfileViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Contact Email Address")]
        public string ContactEmail { get; set; }

        [Display(Name = "Contact Phone Number")]
        public string ContactPhone { get; set; }

        [Display(Name = "Photo")]
        public IFormFile Photo { get; set; }

        [Display(Name = "Resume")]
        public IFormFile Resume { get; set; }

        public string City { get; set; }

        [Display(Name = "Make Profile Public to Employers?")]
        public bool MakeProfilePublic { get; set; }
    }
}
