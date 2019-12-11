
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rocinante.Models
{
    public class Job
    {
        [Key]
        public string Id { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Id")]
        public string JobId { get; set; }
        [Display(Name = "Job Title")]
        public string Title { get; set; }
        public string Location { get; set; }
        public string Snippet { get; set; }
        public string Link { get; set; }
        public string Company { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Saved Date")]
        public DateTime SavedDate { get; set; }
        [Display(Name = "Posted")]
        public string Updated { get; set; }
        [Display(Name = "Job status")]
        public string Result { get; set; }
        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }
        public virtual ICollection<Activity> activities { get; set; } = new List<Activity>();
        public Job()
        {
        }

        public Job(JToken t)
        {
            this.SavedDate = DateTime.Now;
            this.Result = "Saved";
            this.JobId = t["id"].ToString();
            this.Title = t["title"].ToString();
            this.Location = t["location"].ToString();
            this.Snippet = t["snippet"].ToString();
            this.Link = t["link"].ToString();
            this.Company = t["company"].ToString();
            this.Updated = t["updated"].ToString();
        }
    }
}