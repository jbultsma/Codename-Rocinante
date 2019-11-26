using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace Rocinante.Models
{
    public class JoobleDAL
    {
        string url = "https://jooble.org/api/";
        string key = "d6b2d219-1285-4613-869a-372e9e5b6ad2";

        public string CallJooble(string keyword, string location)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"{url}{key}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            return APIText;
        }
    }
}
