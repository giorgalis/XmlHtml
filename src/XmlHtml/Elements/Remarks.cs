using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "remarks")]
    public class Remarks
    {
        [XmlElement(ElementName = "see")]
        public See See { get; set; }
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }
    }
}
