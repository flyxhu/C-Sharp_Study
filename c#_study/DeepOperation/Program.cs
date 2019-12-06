using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006DeepOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //关于加法运算符的更多使用
            //字符串相加，用来连接两个字符串，会返回一个字符串的结果
            string str1 = "123456";
            string str2 = "/百度www.baidu.com";
            string str = str1 + str2;
            Console.WriteLine(str);

            //当一个字符串与一个数字相加，首先会把数字转换成字符串，然后返回一个字符串的结果.
            //应用于一个数字与一个空字符串相加，返回一个数字的字符串
            string str3 = "123";
            int num1 = 456789;
            string str4 = str3 + num1;
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.ReadKey();
        }
    }
}
