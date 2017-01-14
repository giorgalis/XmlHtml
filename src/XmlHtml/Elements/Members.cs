using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "members")]
    public class Members
    {
        [XmlElement(ElementName = "member")]
        public List<Member> Member { get; set; }
    }
}
