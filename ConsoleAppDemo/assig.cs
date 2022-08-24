using System;
public class Exercise1
{
    public static int multiply( int firstno,int secondno, int thirdno)
    {
        return firstno * secondno * thirdno;

    }
    public static void Main()
    {
        int first, second, third;

        Console.Write("Input the first number to multiply: ");
        first= int.Parse(Console.ReadLine());

        Console.Write("Input the second number to multiply: ");
        second= int.Parse(Console.ReadLine());

        Console.Write("Input the third number to multiply: ");
        third = int.Parse(Console.ReadLine());

        int mulof3nos = multiply(first, second, third); 
        Console.WriteLine($" the multiplication of three nos are {mulof3nos}");



    }
}