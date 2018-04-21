using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlSerializationExamples.Model;
using XmlSerializationExamples.Services;

namespace XmlSerializationExamples {
	public class Test {
		public String value1;
		public String value2;
	}

    [TestClass]
    public class SerializeAndDesialize {
        [TestMethod]
        public void Serialize() {
            var filename = "Contact.xml";
			var contactService = new DomainService<Contact>();
            Contact contact = new Contact() {
                FirstName = "Jorge",
                LastName = "Perez"
            };
            contact.Addresses.Add(new Address() {
                Street = "1111 nw 136 ave",
                ZipCode = "11111"
            });
            contact.Addresses.Add(new Address() {
                Street = "222 nw 136 ave",
                ZipCode = "222222"
            });
            contact.Addresses.Add(new Address() {
                Street = "3333 nw 136 ave",
                ZipCode = "33333"
            });
            contactService.Put(contact, filename);
            Assert.IsTrue(System.IO.File.Exists("Contact.xml"));

            // test the deserialize
            contact = null;
            contact = contactService.Get(filename);
            Assert.AreEqual(contact.FirstName, "Jorge");
        }


		[TestMethod]
		public void DeSerializeFromString() {
			String value = "<Contact xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"http://www.cpandl.com\"><FirstName>Jorge</FirstName><LastName>Perez</LastName><Addresses><Address><Street>1111 nw 136 ave</Street><ZipCode>11111</ZipCode></Address></Addresses></Contact>";            
			//var value = @"<urlset                                            xmlns:i=""http://www.w3.org/2001/XMLSchema-instance""><url><loc>www.yahoo.com</loc></url></urlset>";
			// <?xml version=""1.0"" encoding=""utf-8""?>
			var contactService = new DomainService<Contact>();
			var urlSet = contactService.GetFromString(value);
			Assert.IsNotNull(urlSet);
		}
    }
}