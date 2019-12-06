using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014TrapezoidalArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入梯形的上底：");
            double s = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("请输入梯形的下底：");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("请输入梯形的高");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("梯形的面积是：" + (s+d)*h/2);
            Console.ReadKey();


       }
    }
}
