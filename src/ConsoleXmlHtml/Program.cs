
using System;
using System.Linq;

namespace ConsoleXmlHtml
{
    public class Program
    {
        public const string Method = "T";
        public const string Property = "P";
        public const string Constructor = "M";

        public static void Main(string[] args)
        {
            XmlHtml.Main main = new XmlHtml.Main(@"");

            var Methods = from c in main.doc.Members.Member where c.Name.StartsWith(Method) select c;
            foreach (var v in Methods)
            {
                Console.WriteLine(v.Name.ToString());
            }
            Console.WriteLine("# # # # # # # # # # # # # # # # # # # # # ");
            var Properties = from c in main.doc.Members.Member where c.Name.StartsWith(Property) select c;
            foreach (var v in Properties)
            {
                Console.WriteLine(v.Name.ToString());
            }
            Console.WriteLine("# # # # # # # # # # # # # # # # # # # # # ");
            var Constructors = from c in main.doc.Members.Member where c.Name.StartsWith(Constructor) select c;
            foreach (var v in Constructors)
            {
                Console.WriteLine(v.Name.ToString());
            }
           
            Console.ReadLine();
        }
    }
}
