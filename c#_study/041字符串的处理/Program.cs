using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041字符串的处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "www.BaiDu.Com";
            Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)    //.lenth:可以通过.lenth访问一个字符串的长度
            {
                Console.WriteLine(str[i]);
            }

            string res1 = str.ToLower();    //把字符串转换成小写并返回，对原字符串没有影响
            string res2 = str.ToUpper();    //把字符串转换成大写并返回，对原字符串没有影响
            string str_k = "  www. baidu.com    ";
            Console.WriteLine(str_k + "|");
            string res3 = str_k.Trim();
            string res4 = str_k.TrimStart();
            string res5 = str_k.TrimEnd();
            string[] strArray = str.Split('.');    //对字符串按照指定的字符进行拆分，得到一个拆分后字符串的结果，指定字符用单引号括起来

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine("去掉前后:" + res3 + "|");
            Console.WriteLine("只去掉前面:" + res4 + "|");
            Console.WriteLine("只去掉后面:" + res5 + "|");

            foreach (string temp in strArray) 
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}
