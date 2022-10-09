using System;

class DM
{
    public static TimeSpan Mod(string dt1,string dt2)
    {
        DateTime date1,date2;
        TimeSpan date3;
        date1 = Convert.ToDateTime(dt1);
        date2 = Convert.ToDateTime(dt2);
        date3=date2.Subtract(date1);
        return date3;
    }
}

class StringTest
{
    static void Main()
    {
        string dt1="1992, 05, 31", dt2="2016, 06, 17";
        TimeSpan date;
        /*Console.Write("dt1(year, month, day): ");
        dt1 = Console.ReadLine();
        Console.Write("dt2(year, month, day): ");
        dt2 = Console.ReadLine();*/
        date=DM.Mod(dt1,dt2);
        Console.WriteLine(date);
        Console.ReadLine();
    }
}