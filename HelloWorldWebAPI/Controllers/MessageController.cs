using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.Data;

namespace HelloWorldWebAPI.Controllers
{
    
    public class MessageController : ApiController
    {
        // GET api/Message
        public string GetMessage()
        {
            return HelloWorldData.Message;
        }

       
    }
}
