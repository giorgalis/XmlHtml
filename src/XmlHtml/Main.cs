using System.IO;

namespace XmlHtml
{
    public class Main
    {
        public Doc doc { get; private set; }
        public Main(string xmlFile)
        {
            using (FileStream fs = new FileStream(xmlFile, FileMode.Open))
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Doc));
                doc = (Doc)serializer.Deserialize(fs);
            }
        }
    }
}
