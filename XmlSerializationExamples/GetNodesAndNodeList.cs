using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlSerializationExamples.Model;
using XmlSerializationExamples.Services;

namespace XmlSerializationExamples {
    [TestClass]
	public class GetNodesAndNodeList {
        [TestMethod]
        public void Serialize() {
			string filename = "sitemap.xml";
	        var doc = new XmlDocument();
			doc.Load(filename);
	        var el = doc.GetElementsByTagName("loc");

			// test the deserialize
			Assert.IsNotNull(el);
        }
    }
}
