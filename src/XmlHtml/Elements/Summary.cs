using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "summary")]
    public class Summary
    {
        [XmlElement(ElementName = "see")]
        public See See { get; set; }
        [XmlElement(ElementName = "list")]
        public List List { get; set; }
    }
}
