using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocinante.Models
{
    public class JobTracker
    {
        [Key]
        public int TrackerId { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public string UserId { get; set; }


    }
}
