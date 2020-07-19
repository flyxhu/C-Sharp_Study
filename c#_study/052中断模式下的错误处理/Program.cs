using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052中断模式下的错误处理
{
    class Program
    {
        static void Test()
        {
            Console.WriteLine("Test Method");
        }
        static void Main(string[] args)
        {
            int num1 = 56;
            int num2 = 68;
            Test();             //逐语句和逐过程都是一行一行语句执行，区别在于逐过程遇到函数不会跳到函数里面去执行
            int sum = num1 + num2;
            string str1 = "tress";
            Console.Write(sum);
            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
