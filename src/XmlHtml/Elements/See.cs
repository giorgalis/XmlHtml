using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "see")]
    public class See
    {
        [XmlAttribute(AttributeName = "cref")]
        public string Cref { get; set; }
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }
}
