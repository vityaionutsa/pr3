using System;

class DM
{
    private string dt1, dt2;

    public string Dt1
    {
        get { return dt1; }
        set { dt1 = value; }
    }
    public string Dt2
    {
        get { return dt2; }
        set { dt2 = value; }
    }
    public void Mod()
    {
        DateTime date1, date2;
        TimeSpan date3;
        date1 = Convert.ToDateTime(dt1);
        date2 = Convert.ToDateTime(dt2);
        date3 = date2.Subtract(date1);
        Console.WriteLine(date3);
    }
}

class StringTest
{
    static void Main()
    {
        DM dm = new DM();
        dm.Dt1 = "1992, 05, 31";
        dm.Dt2 = "2016, 06, 17";
        dm.Mod();
        Console.ReadLine();
    }
}
