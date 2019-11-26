using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocinante.Models
{
    public class Job
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Snippet { get; set; }
        public string Link { get; set; }
        public string Company { get; set; }
        public string Updated { get; set; }

        public Job()
        {
        }

        public Job(JToken t)
        {
           
            this.Title = t["title"].ToString();
            this.Location = t["location"].ToString();
            this.Snippet = t["snippet"].ToString();
            this.Link = t["link"].ToString();
            this.Company = t["company"].ToString();
            this.Updated = t["updated"].ToString();           
        }
    }
}
