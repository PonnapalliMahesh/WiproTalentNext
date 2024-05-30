using System;
namespace Loops
{
    class whileloop
    {
        static void Main(string[] args)
        {
            int num=Convert.ToInt32(Console.ReadLine());
            int start = 0;
            while(start<=num)
            {
                Console.WriteLine(start);
                start+=2;
            }
        }
    }
}