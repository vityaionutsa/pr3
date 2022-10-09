using System;

class Person
{
    public int age;
    public string name;

    public void def1()//1
    {
        age = 1;
        name = "No name";
    }
    public void def2()//2
    {
        name = "No name";
        Console.Write("Age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }
    public void def3()//3
    {
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }

    public static int max(int[] ages, int n, int k)
    {
        int max = ages[0];
        for (int i = 0; i < n; i++)
        {
            if (max < ages[i])
            {
                max = ages[i];
                k = i;
            }
        }
        return k;
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
        Person[] child = new Person[20];
        int[] ages = new int[20];
        int n, k = 0;
        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            child[i] = new Person();
        }
        for (int i = 0; i < n; i++)
        {
            child[i].def3();
        }
        for (int i=0;i<n;i++)
        {
            if(child[i].age>30)
            {
                child[i].PrintPerson();
            }
        }
    }
}