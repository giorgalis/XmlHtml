using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "list")]
    public class List
    {
        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }
}
