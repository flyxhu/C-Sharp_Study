using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042作业练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 练习1：3个可乐瓶子可以换一瓶可乐，现在又364个瓶子，问一共可以喝多少瓶可乐
            //int p = 364;
            int P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("可乐瓶子数量为：{0}", P);
            int Kele = P / 3;
            int P1 = P % 3;
            Console.WriteLine("可以喝的可乐瓶数：{0},剩余的瓶子数量为：{1}", Kele,P1);
            Console.ReadKey();
        }
    }
}
