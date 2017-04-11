using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CustomSerialization
{
  public  class XmlSerializationClass
    {
        public static void ObjectToXml(Company employee)
        {


            XmlSerializer xmlSerialization = new XmlSerializer(typeof(Company));
            using (TextWriter writer = new StreamWriter(Environment.CurrentDirectory + "/Xml.txt"))
            {
                xmlSerialization.Serialize(writer, employee);
                writer.Close();
            }
        }
        public static void XmlToObjectNotation()
        {



            XmlSerializer deserializer = new XmlSerializer(typeof(Company));
            using (TextReader reader = new StreamReader(Environment.CurrentDirectory + "/Xml.txt"))
            {
                var classObject = deserializer.Deserialize(reader);
                Company XmlData = (Company)classObject;

            }
        }
    }
}
