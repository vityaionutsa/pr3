using System;

class Child
{
    private int age;
    private string name;
    public Child() { }

    public Child(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void PrintChild()
    {
        Console.WriteLine("{0}, {1} years old.", name, age);
    }
}

class StringTest
{
    static void Main()
    {
        int n;
        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());
        string[] name = new string[n];
        int[] age = new int[n];
        Child[] a = new Child[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Name: ");
            name[i] = Console.ReadLine();
            Console.Write("How old is {0}: ", name[i]);
            age[i] = Convert.ToInt32(Console.ReadLine());

            a[i] = new Child(name[i], age[i]);
        }
        for (int i = 0; i < n; i++)
        {
            a[i].PrintChild();
        }
    }
}