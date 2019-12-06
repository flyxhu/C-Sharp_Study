using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015AreaOfTheCircle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入圆的半径：");
            string r = Console.ReadLine();
            double R = Convert.ToDouble(r);
            double S = 3.14 * R * R;
            double C = 3.14 * 2 * R;

            Console.WriteLine("计算圆的面积为:{0},圆的周长为:{1}",S,C);
            Console.ReadKey();
        }
    }
}
