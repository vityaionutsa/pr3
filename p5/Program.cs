using System;

class DM
{
    public static void Mod(string dt1,string dt2)
    {
        DateTime date1,date2;
        date1 = Convert.ToDateTime(dt1);
        date2 = Convert.ToDateTime(dt2);
        Console.WriteLine(date2.Subtract(date1));
    }
}

class StringTest
{
    static void Main()
    {
        string dt1="1992, 05, 31", dt2="2016, 06, 17";
        /*Console.Write("dt1(year, month, day): ");
        dt1 = Console.ReadLine();
        Console.Write("dt2(year, month, day): ");
        dt2 = Console.ReadLine();*/
        DM.Mod(dt1,dt2);
    }
}