using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldWebAPI;
using HelloWorldWebAPI.Controllers;



namespace HelloWorldWebAPI.Tests.Controllers
{
    [TestClass]
    public class MessageControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            MessageController controller = new MessageController();

            // Act
           string result = controller.GetMessage();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result);
            
        }
    }
}
