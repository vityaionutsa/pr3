﻿using System;

class Person
{
    private int age;
    private string name;

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
    public void PrintPerson()
    {
        Console.WriteLine("{0}, {1} years old.", name, age);
    }

}

class p2
{
    static void Main()
    {
        Person[] child = new Person[20];
        int n, k;
        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("k = ");
        k = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            child[i] = new Person();
        }
        if (k == 1)//1
        {
            for (int i = 0; i < n; i++)
            {
                child[i].def1();
            }
            for (int i = 0; i < n; i++)
            {
                child[i].PrintPerson();
            }
        }
        if (k == 2)//2
        {
            for (int i = 0; i < n; i++)
            {
                child[i].def2();
            }
            for (int i = 0; i < n; i++)
            {
                child[i].PrintPerson();
            }
        }
        if (k == 3)//3
        {
            for(int i=0;i<n;i++)
            {
                child[i].def3();
            }
            for (int i = 0; i < n; i++)
            {
                child[i].PrintPerson();
            }
        }
    }
}