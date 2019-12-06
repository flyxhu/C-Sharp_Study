using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020ElseIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您考试的分数S(0<S<=100),系统将输出对应等级");
            //string StrInput = Console.ReadLine();
            double resScore = Convert.ToDouble(Console.ReadLine());

            if (resScore >= 90 )
            {
                Console.WriteLine("优");
            }
            else if (resScore < 90 && resScore >= 80)
            {
                Console.WriteLine("良");
            }
            else if (resScore < 80 && resScore >= 60)
            {
                Console.WriteLine("中");
            }
            else
                Console.WriteLine("差，继续努力哦！");

            Console.ReadKey();
        }
    }
}
