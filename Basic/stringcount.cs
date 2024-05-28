using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class stringcount
    {
        static void Main(string[] args)
        {
            string str1 = "hello123";
            int digitcount = str1.Count(char.IsDigit);
            int charcount=str1.Count(char.IsLetter);
            Console.WriteLine(digitcount);
            Console.WriteLine(charcount);

        }
    }
}
