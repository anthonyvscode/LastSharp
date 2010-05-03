using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using RestSharp;
using RestSharp.Deserializers;
using Lastfm.Model;
using System.IO;

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
            DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string[] upperDir = dir.ToString().Split('\\');

            var directory = new StringBuilder();

            for (int i = 0; i < upperDir.Length - 2; i++)
            {
                directory.Append(upperDir[i].ToString() + "\\");
            }

            var xmlpath = directory.ToString() + "Responses\\Artist\\artistGetEvents.xml";
            var doc = System.Xml.Linq.XDocument.Load(xmlpath);
            var response = new RestResponse { Content = doc.ToString() };

            var d = new XmlDeserializer();
            var output = d.Deserialize<EventsList>(response);

            Assert.AreEqual(33, output.events.Count);
            Assert.AreEqual("1295595", output.events[0].id);
        }

        [TestMethod]
        public void Can_Deserialize_artistGetImages()
        {
            DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string[] upperDir = dir.ToString().Split('\\');

            var directory = new StringBuilder();

            for (int i = 0; i < upperDir.Length - 2; i++)
            {
                directory.Append(upperDir[i].ToString() + "\\");
            }

            var xmlpath = directory.ToString() + "Responses\\Artist\\artistGetImages.xml";
            var doc = System.Xml.Linq.XDocument.Load(xmlpath);
            var response = new RestResponse { Content = doc.ToString() };

            var d = new XmlDeserializer();
            var output = d.Deserialize<ImageList>(response);

            Assert.AreEqual(50, output.images.Count);

            Assert.AreEqual("VanderWaals", output.images[1].owner.name);
            Assert.AreEqual(6, output.images[1].sizes.Count);

        }

        [TestMethod]
        public void Can_Deserialize_artistGetInfo()
        {
            DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string[] upperDir = dir.ToString().Split('\\');

            var directory = new StringBuilder();

            for (int i = 0; i < upperDir.Length - 2; i++)
            {
                directory.Append(upperDir[i].ToString() + "\\");
            }

            var xmlpath = directory.ToString() + "Responses\\Artist\\artistGetInfo.xml";
            var doc = System.Xml.Linq.XDocument.Load(xmlpath);
            var response = new RestResponse { Content = doc.ToString() };

            var d = new XmlDeserializer();
            var output = d.Deserialize<Artist>(response);

            Assert.AreEqual("Blur", output.name);
            Assert.AreEqual(5, output.similar.Count);
            Assert.AreEqual("http://www.last.fm/music/Blur", output.url);
        }

        [TestMethod]
        public void Can_Deserialize_artistGetPastEvents()
        {
            DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string[] upperDir = dir.ToString().Split('\\');

            var directory = new StringBuilder();

            for (int i = 0; i < upperDir.Length - 2; i++)
            {
                directory.Append(upperDir[i].ToString() + "\\");
            }

            var xmlpath = directory.ToString() + "Responses\\Artist\\artistGetPastEvents.xml";
            var doc = System.Xml.Linq.XDocument.Load(xmlpath);
            var response = new RestResponse { Content = doc.ToString() };

            var d = new XmlDeserializer();
            var output = d.Deserialize<EventsList>(response);

            Assert.AreEqual("Blur", output.events[2].headliner);
        }
    }
}
