using System;
using System.Xml.Linq;
using Lastfm.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Deserializers;

namespace Lastfm.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Artists
    {
        public Artists()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void Can_Deserialize_artistGetEvents()
        {
            var xmlpath = Environment.CurrentDirectory + @"\..\..\..\Lastfm.Tests\Responses\Artist\artistGetEvents.xml";
            var doc = XDocument.Load(xmlpath);
            var response = new RestResponse { Content = doc.ToString() };

            var d = new XmlAttributeDeserializer();
            var output = d.Deserialize<LastfmResponse<EventsList>>(response);

            Assert.AreEqual(33, output.Value.Events.Count);
            Assert.AreEqual("1295595", output.Value.Events[0].Id);
        }

        [TestMethod]
        public void Can_Deserialize_artistGetImages()
        {
            var xmlpath = Environment.CurrentDirectory + @"\..\..\..\Lastfm.Tests\Responses\Artist\artistGetImages.xml";
            var doc = XDocument.Load(xmlpath);
            var response = new RestResponse { Content = doc.ToString() };

            var d = new XmlAttributeDeserializer();
            var output = d.Deserialize<LastfmResponse<ImageList>>(response);

            Assert.AreEqual(50, output.Value.images.Count);

            Assert.AreEqual("VanderWaals", output.Value.images[1].owner.name);
            Assert.AreEqual(6, output.Value.images[1].sizes.Count);

        }

        [TestMethod]
        public void Can_Deserialize_artistGetInfo()
        {
            var xmlpath = Environment.CurrentDirectory + @"\..\..\..\Lastfm.Tests\Responses\Artist\artistGetInfo.xml";
            var doc = XDocument.Load(xmlpath);
            var response = new RestResponse { Content = doc.ToString() };

            var d = new XmlAttributeDeserializer();
            var output = d.Deserialize<LastfmResponse<Artist>>(response);

            Assert.AreEqual("Blur", output.Value.Name);
            Assert.AreEqual(5, output.Value.similar.Count);
            Assert.AreEqual("http://www.last.fm/music/Blur", output.Value.Url);
            Assert.AreEqual("ba853904-ae25-4ebb-89d6-c44cfbd71bd2", output.Value.MusicBrainzID);
        }

        [TestMethod]
        public void Can_Deserialize_artistGetPastEvents()
        {
            var xmlpath = Environment.CurrentDirectory + @"\..\..\..\Lastfm.Tests\Responses\Artist\artistGetPastEvents.xml";
            var doc = XDocument.Load(xmlpath);
            var response = new RestResponse { Content = doc.ToString() };

            var d = new XmlAttributeDeserializer();
            var output = d.Deserialize<LastfmResponse<EventsList>>(response);

            Assert.AreEqual("Blur", output.Value.Events[2].Headliner);
        }
    }
}
