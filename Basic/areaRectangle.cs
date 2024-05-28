using System;
namespace Basic
{
    class areaRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side of square:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square:"+a*a);
        }
    }
}