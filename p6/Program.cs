using System;

namespace p5
{
    internal class Program
    {
        static void Main()
        {
            DateTime dt1 = new DateTime(1992, 05, 31);
            DateTime dt2 = new DateTime(2016, 06, 17);
            DateTime dt3;
            string str = "2016, 06, 17";
            dt3 = Convert.ToDateTime(str);
            Console.WriteLine(dt3.Subtract(dt1));
            Console.WriteLine(dt3);
        }
    }
}
