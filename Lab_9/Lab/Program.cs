using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Lab_9
{
    class Program
    {
        public static void Main(string[] args)
        {
            string myData = "фваап що оо";
            Regex myReg = new Regex("о");
            myData = myReg.Replace(myData, "оОк");
            Console.WriteLine(myData);
        }
    }
}
