using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008Transformation
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = Console.ReadLine();
            Console.WriteLine(str1);
        
            string str2 = Console.ReadLine();
            int num1 = Convert.ToInt32(str2);
            num1++;
            Console.WriteLine(num1);
            Console.ReadKey();

            string str3 = Console.ReadLine();
            double num2 = Convert.ToDouble(str3);
            Console.WriteLine(num2);
        }
    }
}
