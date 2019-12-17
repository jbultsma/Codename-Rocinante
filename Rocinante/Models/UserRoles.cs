using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocinante.Models
{
    public class UserRoles
    {
        [Required]
        public string RoleName { get; set; }
    }
}
