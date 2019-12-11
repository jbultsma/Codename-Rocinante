using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rocinante.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public DateTime ActivityDate { get; set; }
        public string Action { get; set; }
        public string Comment { get; set; }
        // public virtual Job job { get; set; }
        [ForeignKey("job")]
        public string JobId { get; set; }
    }
}
