using System;

class Person
{
    private int age;
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }


    public void PrintPerson()
    {
        Console.WriteLine("{0}, {1} years old.", name, age);
    }
}

class StringTest
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        Person[] person=new Person[n];
        for (int i=0;i<n;i++)
        {
            person[i]=new Person();
            Console.Write("Name: ");
            person[i].Name = Console.ReadLine();
            Console.Write("How old is {0}: ", person[i].Name);
            person[i].Age = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            person[i].PrintPerson();
        }
    }
}