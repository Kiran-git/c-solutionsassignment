using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class swap
    {
        public static void Swap(ref int a, ref int b)
        {
            a = a * b;
            b = b / a;
            a = a / b;
        }
        public static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine($"before swap a= {a} b= {b}");
            Swap(ref a, ref b);

            Console.WriteLine($"before swap a= {a} b= {b}");

        }
    }
}