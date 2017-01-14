namespace XmlHtml
{
    using System.Xml.Serialization;
    using System.Collections.Generic;
    namespace Xml2CSharp
    {
        [XmlRoot(ElementName = "assembly")]
        public class Assembly
        {
            [XmlElement(ElementName = "name")]
            public string Name { get; set; }
        }

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

        [XmlRoot(ElementName = "seealso")]
        public class Seealso
        {
            [XmlAttribute(AttributeName = "cref")]
            public string Cref { get; set; }
        }

        [XmlRoot(ElementName = "see")]
        public class See
        {
            [XmlAttribute(AttributeName = "cref")]
            public string Cref { get; set; }
            [XmlAttribute(AttributeName = "href")]
            public string Href { get; set; }
        }

        [XmlRoot(ElementName = "summary")]
        public class Summary
        {
            [XmlElement(ElementName = "see")]
            public See See { get; set; }
            [XmlElement(ElementName = "list")]
            public List List { get; set; }
        }

        [XmlRoot(ElementName = "param")]
        public class Param
        {
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

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

}
