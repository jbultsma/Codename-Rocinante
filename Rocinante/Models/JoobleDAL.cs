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
        public List<Job> CallJooble(string location, string keywords)
        {
            var url = Secret.Url;
            var key = Secret.APIkey;
            //  create request object
            WebRequest request = HttpWebRequest.Create(url + key);
            //set http method
            request.Method = "POST";
            //set content type
            request.ContentType = "application/x-www-form-urlencoded";

            //create request writer
            var writer = new StreamWriter(request.GetRequestStream());
            string requestFormat = string.Format("{{\"keywords\":\"{0}\",\"location\":\"{1}\"}}", location, keywords);
            //write request body
            writer.Write(requestFormat);
            //close writer
            writer.Close();
            //get response reader
            var response = request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            var APIText = reader.ReadToEnd();
            JToken token = JToken.Parse(APIText);

            List<JToken> ts = token["jobs"].ToList();

            List<Job> jobs = new List<Job>();

            foreach (JToken t in ts)
            {
                Job a = new Job(t);
                jobs.Add(a);
            }

            return jobs;
        }

    }
}
