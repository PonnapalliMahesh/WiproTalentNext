using System;
namespace operators
{
    class arithematicop
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number1:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);
            Console.Write("Enter number2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2);
            num2 = ++num1;
            Console.WriteLine(num2);
            num2 = num1++;
            Console.WriteLine(num2);
            int t = num2;
            num2 = num1;
            num1 = t;
            Console.WriteLine(t);
        }
    }
}