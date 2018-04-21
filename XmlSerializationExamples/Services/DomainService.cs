// -----------------------------------------------------------------------
// <copyright file="BookService.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
using System;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerializationExamples.Services {
	/// <summary>
	///     TODO: Update summary.
	/// </summary>
	public class DomainService<T> {
		public T Get(string filename) {
			try {
				var serializer = new XmlSerializer(typeof(T));
				T model;
				using (var fs = new FileStream(filename, FileMode.Open))
					model = (T)serializer.Deserialize(fs);
				return model;
			}
			catch (Exception exc) {
				string test = exc.Message;
				throw;
			}
		}

		/// <summary>
		///     Saves a contact
		/// </summary>
		/// <param name="book"></param>
		/// <param name="filename"></param>
		/// <param name="urlSet"></param>
		public void Put(T model, string filename) {
			var x = new XmlSerializer(typeof(T));
			TextWriter writer = new StreamWriter(filename);
			x.Serialize(writer, model);
			writer.Close();
		}

		/// <summary>
		/// Deserialize from string
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public T GetFromString(string xml) {
			try {
				var serializer = new XmlSerializer(typeof(T));
				T model;
				using (TextReader reader = new StringReader(xml))
					model = (T)serializer.Deserialize(reader);

				return model;
			}
			catch (Exception exc) {
				string test = exc.Message;
				throw;
			}
		}
	}
}