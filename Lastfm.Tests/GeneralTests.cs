using System;
using System.Xml.Linq;
using Lastfm.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Deserializers;

namespace Lastfm.Tests
{
    /// <summary>
    /// Summary description for General
    /// </summary>
    [TestClass]
    public class General
    {
        public General()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void Can_Deserialize_Error()
        {
            var xmlpath = Environment.CurrentDirectory + @"\..\..\..\Lastfm.Tests\Responses\Error.xml";
            var doc = XDocument.Load(xmlpath);
            var response = new RestResponse { Content = doc.ToString() };

            var d = new XmlDeserializer();
            var output = d.Deserialize<LastfmResponse<EventsList>>(response);

            Assert.IsNotNull(output.Error);
            Assert.AreEqual(6, output.Error.Code);
        }
    }
}
