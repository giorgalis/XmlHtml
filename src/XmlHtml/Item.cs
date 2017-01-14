using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
    }
}
