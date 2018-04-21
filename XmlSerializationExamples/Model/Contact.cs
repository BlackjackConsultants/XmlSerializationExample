using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializationExamples.Model {
    [XmlRootAttribute("Contact", Namespace = "http://www.cpandl.com", IsNullable = false)]
    public class Contact {
        public Contact() {
            Addresses = new List<Address>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Address> Addresses { get; set; }

    }
}
