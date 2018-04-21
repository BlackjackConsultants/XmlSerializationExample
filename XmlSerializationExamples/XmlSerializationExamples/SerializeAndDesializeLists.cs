using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlSerializationExamples.Model;
using XmlSerializationExamples.Services;

namespace XmlSerializationExamples {
    [TestClass]
    public class SerializeAndDesializeLists {
        [TestMethod]
        public void Serialize() {
			var filename = "sitemap.xml";
			var urlService = new DomainService<UrlSet>();
	        UrlSet urlSet = new UrlSet();
			urlSet.Urls.Add(new Url() {Loc = "www.yahoo.com"});
			urlService.Put(urlSet, filename);
			Assert.IsTrue(System.IO.File.Exists("sitemap.xml"));

			// test the deserialize
			urlSet = null;
			urlSet = urlService.Get(filename);
			Assert.AreEqual(urlSet.Urls[0].Loc, "www.yahoo.com");
        }
		[TestMethod]
		[DeploymentItem("TestFiles\\sitemap.xml")]
		public void DeSerialize() {
			var filename = "sitemap.xml";
			var urlService = new DomainService<UrlSet>();
			var urlSet = urlService.Get(filename);
			Assert.IsNotNull(urlSet);
            Assert.AreNotEqual(urlSet.Urls.Count, 0);
            Assert.IsNotNull(urlSet.Urls[0].Loc);
		}
    }
}
