using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054异常处理2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;int num2 = 0;
            Console.WriteLine("请输入第一个整数");
            while (true)
            {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                   
                    break;
                }
                catch 
                {

                    Console.WriteLine("您输入的不是一个整数，请输入一个整数");
                }
            }
                //break; 
            Console.WriteLine("请输入第二个整数");
            while (true)
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                catch
                {

                    Console.WriteLine("您输入的不是一个整数，请输入一个整数");
                }
            }
            int sum1 = num1 + 1;
            int sum2 = num1 + num2;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.ReadKey();

        }
    }
}
