// See https://aka.ms/new-console-template for more information
using System.Reflection;

class MyClass
{
    enum Grade { pass = 60, Distinction = 85 };

    public static void Main()
    {
        int empid;
        int mark;

        Console.WriteLine("Hello, World!");
        Console.WriteLine("what your empide?");
        empid = int.Parse(Console.ReadLine());
        Console.WriteLine($"thanks for giving ur id {empid}");

        Console.WriteLine("enter your sql marks?");
        mark = Convert.ToInt32(Console.ReadLine());
        if (mark >=(int) Grade.Distinction)
        {
            Console.WriteLine("you are in distinction grade");
        }
        else if (mark >=(int)Grade.pass)
        { Console.WriteLine("your in pass grade"); }
        else
        {
            Console.WriteLine("sorry ur grade is fail");
        }
    }
}


