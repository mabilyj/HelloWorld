using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace HelloWorld.Services
{
    public class HelloWorldService
    {
       
        public string GetGetHelloWorldMessage(Uri URI)
        {
            HttpWebRequest http = (HttpWebRequest)WebRequest.Create(URI);
            WebResponse response = http.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string content = sr.ReadToEnd();

            return content;
        }
    }
}
