using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "exception")]
    public class Exception
    {
        [XmlAttribute(AttributeName = "cref")]
        public string Cref { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "paramref")]
        public Paramref Paramref { get; set; }
    }
}