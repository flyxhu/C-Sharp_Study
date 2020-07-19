using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044函数
{
    class Program
    {
        static void Write() //定义一个函数，void表示没有返回值（返回值类型），Write叫做方法名
        {
            Console.WriteLine("Text outport from function"); //函数体/方法体，可以写0行、1行或多行
            return; //这里表示结束函数
        }

        static int Plus(int number1,int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        static void Main(string[] args)
        {
            Write(); //调用上面这个函数，函数加括号，括号内写参数

            int number1 = 10;
            int number2 = 30;
            int res1 = Plus(number1, number2);
            int res2 = Plus(20, 45);

            Console.WriteLine("打印方法的返回结果:{0},{1}", res1, res2);
            Console.ReadKey();
        }
    }
}
