using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializationExamples.Model {
	[XmlType(TypeName = "")]
	[XmlRoot("urlset", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9", IsNullable = false)]
	public class UrlSet {
		public UrlSet() {
			this.Urls = new List<Url>();
		}
		[XmlElement("url")]
		public List<Url> Urls { get; set; }

		[XmlAttribute(AttributeName = "xmlns")]
		public string xmlns { get; set; }
	}
}
