using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "assembly")]
    public class Assembly
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }
}
