using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "member")]
    public class Member
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "seealso")]
        public List<Seealso> Seealso { get; set; }
        [XmlElement(ElementName = "summary")]
        public Summary Summary { get; set; }
        [XmlElement(ElementName = "param")]
        public List<Param> Param { get; set; }
        [XmlElement(ElementName = "exception")]
        public List<Exception> Exception { get; set; }
        [XmlElement(ElementName = "remarks")]
        public List<Remarks> Remarks { get; set; }
        [XmlElement(ElementName = "see")]
        public See See { get; set; }
        [XmlElement(ElementName = "value")]
        public Value Value { get; set; }
        [XmlElement(ElementName = "returns")]
        public string Returns { get; set; }
    }
}
