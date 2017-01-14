using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "value")]
    public class Value
    {
        [XmlElement(ElementName = "c")]
        public List<string> C { get; set; }
    }
}
