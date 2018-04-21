using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializationExamples.Model {
	[XmlType(TypeName = "url")]
	[XmlRoot("url", IsNullable = false)]
	public class Url {
		[XmlElement(ElementName = "loc")]
		public string Loc {
			get;
			set;
		}
	}
}
