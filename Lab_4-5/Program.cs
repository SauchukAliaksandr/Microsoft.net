using System;
using System.Collections.Generic;
using System.IO;

namespace laba4
{
    class AutoStantion
    {
        public string City { set; get; }
        public DateTime TimeOut { get; set; }
        public DateTime TimeIn { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }
        public AutoStantion() { }
        public AutoStantion(string City, DateTime TimeOut, DateTime TimeIn, string Type, int Number)
        {
            this.City = City;
            this.TimeOut = TimeOut;
            this.TimeIn = TimeIn;
            this.Type = Type;
            this.Number = Number;
        }
        public override string ToString()
        {
            return String.Format("{4}\tМаршрут: {0}\tВремя отправления: {1}\tВремя прибытия: {2:C}\tТип: {3}",
            this.City, Convert.ToString(this.TimeOut), Convert.ToString(this.TimeIn), this.Type, this.Number);
        }
    }
    class CompInv<T> : IComparer<T>
    where T : AutoStantion
    {
        public int Compare(T x, T y)
        {
            if (x.TimeOut > y.TimeOut)
                return 1;
            if (x.TimeOut < y.TimeOut)
                return -1;
            else return 0;
        }
    }
    class Program
    {
        static void Main()
        {
            CompInv<AutoStantion> cp = new CompInv<AutoStantion>();
            List<AutoStantion> dic = new List<AutoStantion>();

            try
            {
                StreamReader sr = new StreamReader(@"D:\Proga\Microsoft.net\Lab_4\Inlet.in");
                string readPath = sr.ReadToEnd();
                string[] separators = { ";" };
                string[] separators2 = { "," };
                string[] DataAuto = readPath.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(DataAuto[0]);

                foreach (string data in DataAuto)
                {
                    string[] datas = data.Split(separators2, StringSplitOptions.RemoveEmptyEntries);
                    dic.Add(new AutoStantion(datas[0], Convert.ToDateTime(datas[1]), Convert.ToDateTime(datas[2]), datas[3], Convert.ToInt32(datas[4])));
                }

                Console.WriteLine("Исходное расписание \n");
                Console.WindowWidth = 120;
                foreach (AutoStantion a in dic)
                    Console.WriteLine(a);

                Console.WriteLine("\nОтсортированное: \n");
                dic.Sort(cp);
                foreach (AutoStantion car in dic) Console.WriteLine(car);

                string write = @"D:\Proga\Microsoft.net\Lab_4\Outlet.out";

                try
                {
                    using (StreamWriter sw = new StreamWriter(write, false, System.Text.Encoding.Default))
                    {

                        foreach (AutoStantion auto in dic)
                        {

                            sw.WriteLine(auto.City + ", " + auto.TimeOut + ", " + auto.TimeIn + ", " + auto.Type + ", " + auto.Number + ";");
                        }

                    }
                    Console.WriteLine("Запись выполнена");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
