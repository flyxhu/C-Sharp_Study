using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//运算
namespace _005Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 99;
            int num2 = 4;

            int res1 = num1 + num2;
            int res2 = num1 - num2;
            int res3 = num1 * num2;
            int res4 = num2 / num2;
            int res5 = num1 % num2;
            double res6 = 653.2 % 3;

            Console.WriteLine("加法的结果:{0};\n减法的结果:{1};\n乘法的结果:{2};\n除法的结果:{3};\n", res1, res2, res3, res4);
            Console.WriteLine("取余的结果:{0};\n{1}", res5,res6);
                 
            Console.ReadKey();           
        }
    }
}
