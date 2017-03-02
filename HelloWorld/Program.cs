using System;
using System.Net;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Services;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            HelloWorldService helloWorldService = new HelloWorldService();
            Uri URI = new Uri(ConfigurationManager.AppSettings["HelloWorldAPIURL"] + "/Message");
            Console.WriteLine(helloWorldService.GetGetHelloWorldMessage(URI));
            Console.ReadLine();

        }
    }
}
