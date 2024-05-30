using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class dowhile
    {
        static void Main(string[] args)
        {
            int num=Convert.ToInt32(Console.ReadLine());
            int start = 0;
            do
            {
                Console.WriteLine(start);
                start += 2;
            }
            while(start<=num);
        }
    }
}
