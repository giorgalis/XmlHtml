using System.Xml.Serialization;

namespace XmlHtml
{
    [XmlRoot(ElementName = "seealso")]
    public class Seealso
    {
        [XmlAttribute(AttributeName = "cref")]
        public string Cref { get; set; }
    }
}
