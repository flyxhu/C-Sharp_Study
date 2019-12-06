using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011VriableChange
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = Console.ReadLine();
            //int int1 = Convert.ToInt32(str1);
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第一个数int1为：");
            Console.WriteLine(int1);
            string str2 = Console.ReadLine();
            int int2 = Convert.ToInt32(str2);
            Console.WriteLine("输入第二个数int2为：");
            Console.WriteLine(int2);

            int temp = int1;        //交换两个赋值后的变量
            int1 = int2;
            int2 = temp;
            Console.WriteLine("交换后的值：");
            Console.WriteLine(int1 + "||" + int2);

        }
    }
}
