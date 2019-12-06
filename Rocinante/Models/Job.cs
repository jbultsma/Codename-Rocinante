
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
        public string JobId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Snippet { get; set; }
        public string Link { get; set; }
        public string Company { get; set; }
        public string Updated { get; set; }
        public string ContactPerson { get; set; }
        public string ApplicationMethod { get; set; }
        public string DateOfApplication { get; set; }
        public string FollowUpDate { get; set; }
        public string CompanyWebsite { get; set; }
        public string WhoDoYouKnowHere { get; set; }
        public string Result { get; set; }
       // public virtual IdentityUser User { get; set; }
        //[Required]
        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }
        public virtual ICollection<Activiy> activities { get; set; } = new List<Activiy>();
        public Job()
        {
        }

        public Job(JToken t)
        {

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