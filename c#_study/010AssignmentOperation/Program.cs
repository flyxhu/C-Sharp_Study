using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010AssignmentOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            num += 100;
            num -= 100;
            num *= 4;
            num /= 2;
            num %= 3;

            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
