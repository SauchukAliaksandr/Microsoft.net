using System.Xml.Linq;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument();
            XElement line1 = new XElement("line");

            XElement sum_positive1 = new XElement("sum_positive");
            XElement number_negative1 = new XElement("number_negative");
            XElement NumberElem = new XElement("number", "6");
            XElement NumberElem1 = new XElement("number", "66");
            XElement NumberElem2 = new XElement("number", "666");
            XElement NumberElem3 = new XElement("number", "-6666");

            line1.Add(sum_positive1);
            line1.Add(number_negative1);
            sum_positive1.Add(NumberElem);
            sum_positive1.Add(NumberElem1);
            number_negative1.Add(NumberElem2);
            number_negative1.Add(NumberElem3);

            XElement line2 = new XElement("line");
            XElement sum_positive2 = new XElement("sum_positive");
            XElement number_negative2 = new XElement("number_negative");
            XElement NumberElem4 = new XElement("number", "-66666");
            XElement NumberElem5 = new XElement("number", "666666");
            XElement NumberElem6 = new XElement("number", "-6666666");
            XElement NumberElem7 = new XElement("number", "66666666");

            line2.Add(sum_positive2);
            line2.Add(number_negative2);
            sum_positive2.Add(NumberElem4);
            sum_positive2.Add(NumberElem5);
            number_negative2.Add(NumberElem6);
            number_negative2.Add(NumberElem7);

            XElement line3 = new XElement("line");
            XElement sum_positive3 = new XElement("sum_positive");
            XElement number_negative3 = new XElement("number_negative");
            XElement NumberElem8 = new XElement("number", "-666666666");
            XElement NumberElem9 = new XElement("number", "6666666666");
            XElement NumberElem10 = new XElement("number", "-66666666666");
            XElement NumberElem11 = new XElement("number", "666666666666");

            line3.Add(sum_positive3);
            line3.Add(number_negative3);
            sum_positive3.Add(NumberElem8);
            sum_positive3.Add(NumberElem9);
            number_negative3.Add(NumberElem10);
            number_negative3.Add(NumberElem11);

            XElement roots = new XElement("root");
            roots.Add(line1);
            roots.Add(line2);
            roots.Add(line3);
            xdoc.Add(roots);
            xdoc.Save("roots.xml");
        }
    }
}
