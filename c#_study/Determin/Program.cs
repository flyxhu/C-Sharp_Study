using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013Determin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入a的值：");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            if (a < 10)
            {
                Console.WriteLine("a为{0}小于10", a);
            }
            else
            {
                Console.WriteLine("a为{0}大于10", a);
            }

            Console.ReadKey();
        }
    }
}
