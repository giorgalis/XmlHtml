using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "doc")]
    public class Doc
    {
        [XmlElement(ElementName = "assembly")]
        public Assembly Assembly { get; set; }

        [XmlElement(ElementName = "members")]
        public Members Members { get; set; }
    }
}
