using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009PracTrans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);

            Console.WriteLine("\n请再次输入一个整数："); 
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);

            //Console.WriteLine("\n输入的两个整数之和为：");
            int res1 = num1 + num2;
            int res2 = num1 - num2;
            int res3 = num1 * num2;
            int res4 = num1 / num2;
            int res5 = num1 % num2;

            //Console.WriteLine(res1);
            Console.WriteLine("\n输入的两个整数之和、差、积、商、取余分别为:{0}、{1}、{2}、{3}、{4}", res1, res2, res3, res4, res5);
            Console.ReadKey();
        }
    }
}
