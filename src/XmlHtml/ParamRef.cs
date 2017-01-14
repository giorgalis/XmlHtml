using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "paramref")]
    public class Paramref
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }
}
