using System;
namespace consoleAooDemo
{

    internal class valreftypes
    {
        public static void main()
        {
            Console.WriteLine("enter the 2 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine((a < b) ? a : b);

        }
    }
}