using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012GetContrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入三个整数：");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            string str3 = Console.ReadLine();
            int num3 = Convert.ToInt32(str3);
            int num = num1 * num2 * num3;
            Console.WriteLine("输入三个整数的乘积为:{0}\n", num);

            Console.WriteLine("请输入一个三位的整数：");
            string str = Console.ReadLine();
            int res = Convert.ToInt32(str);
            int gefenwei = res % 10;
            int shifenwei = res / 10 % 10;
            int baifenwei = res / 100;
            Console.WriteLine(gefenwei + "" + shifenwei + "" + baifenwei );
            Console.ReadKey();
        }
    }
}
