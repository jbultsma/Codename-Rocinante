using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Rocinante.Models
{
    public class JoobleDAL
    {
        string url = "https://jooble.org/api/";
        string key = "d6b2d219-1285-4613-869a-372e9e5b6ad2";

        public string CallJooble()
        {
            var url = "https://jooble.org/api/";
            var key = "d6b2d219-1285-4613-869a-372e9e5b6ad2";
            //  create request object
            WebRequest request = HttpWebRequest.Create(url + key);
            //set http method
            request.Method = "POST";
            //set content type
            request.ContentType = "application/x-www-form-urlencoded";
            //create request writer
            var writer = new StreamWriter(request.GetRequestStream());
            //write request body
            writer.Write("{ keywords: 'it', location: 'Bern'}");
            //close writer
            writer.Close();
            //get response reader
            var response = request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            string APIText = reader.ReadToEnd();

            return APIText;
        }

        // Method to search and create list of recipes
        //public static List<Job> GetJob(string keywords, string location)
        //{
        //    // Return APICall with search parameters as a string
        //    string APIText = GetJob(keywords, location);

        //    List<Job> jobs = new List<Job>();

        //    // Create JToken to access API and a list to searchthe results
        //    JToken t = JToken.Parse(APIText);
        //    List<JToken> results = t["jobs"].ToList();

        //    foreach (JToken job in results)
        //    {
        //        Job j = new Job(job);
        //        jobs.Add(j);
        //    }

        //    return jobs;
        //}
    }
}
