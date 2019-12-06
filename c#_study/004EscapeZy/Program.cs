using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//转义
namespace _004EscapeZy
{
    class Program
    {
        static void Main(string[] args)
        {


            //@:前面加@，可以把一个字符串定义在多行；
            //对所在行不会再去识别字符串中的转义字符；
            //如果需要在字符串里使用双引号的话，可以在字符串中加上两个双引号
            //*不需要在打印路径时加上转义

            string str1 = "常规换行开始.";
            string str2 = @"使用@换行开始.
我是第二行";
            Console.WriteLine("str1{0}\n我是第二行", str1);
            Console.WriteLine("str2{0}", str2);

            string example1 = @"现在的时候正合适\n开始进行转义了";   
            string example2 = @"现在的时候正合适""开始进行转义了";
            Console.WriteLine("str1:{0}", example1);
            Console.WriteLine("str2:{0}", example2);

            string path1 = "D:\\xxxx\\xxx\\xx\\x";
            string path2 = @"D:\xxxx\xxx\xx\x";
            Console.WriteLine("转义之前的路径:{0}", path1);
            Console.WriteLine("转义之后的路径:{0}", path2);

            Console.ReadKey();




        }
    }
}
