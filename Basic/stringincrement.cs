using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class stringincrement
    {
        static void Main(string[] args)
        {
            string str1 = "mahesh";
            string incstring=new string(str1.Select(c => (char)(c+1)).ToArray());
            Console.WriteLine(incstring);

        }
    }
}
