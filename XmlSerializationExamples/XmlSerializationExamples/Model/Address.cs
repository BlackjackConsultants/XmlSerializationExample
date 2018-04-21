using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializationExamples.Model {
    [XmlRootAttribute("Address", Namespace = "http://www.cpandl.com", IsNullable = false)]
    public class Address {
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }
}
