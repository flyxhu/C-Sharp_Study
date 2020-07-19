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
            Console.WriteLine("打印str1" + "：" + str1);
        
            string str2 = Console.ReadLine();
            int Int1 = Convert.ToInt32(str2);
            Int1++;
            Console.WriteLine("打印Int1" + "：" + Int1);
            Console.ReadKey();

            string str3 = Console.ReadLine();
            double doub2 = Convert.ToDouble(str3);
            Console.WriteLine("打印doub2" + "：" + doub2);
        }
    }
}
