using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class stringmanipulation
    {
        static void Main(string[] args)

        {
            Console.Write("Enter a String:");
            string str1=Console.ReadLine();
            char ch1 = 'e'; 
            Console.WriteLine(str1);
            Console.WriteLine(str1.Substring(1,str1.Length-1));
            Console.WriteLine(str1.Replace(ch1, '$'));
        }
    }
}
