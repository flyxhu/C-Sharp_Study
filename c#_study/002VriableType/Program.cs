using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//变量类型
namespace _002_Variable_type
{
    class Program
    {
        static void Main(string[] args)

        {   //整数
            byte myByte = 12;
            int myScore = 8000;
            long myCount = 25000088;

            Console.WriteLine("byte_value:{0},int_value:{1},long_value:{2}", myByte, myScore, myCount);

            //小数
            float myFloat = 12.8f;
            double myDouble = 28.8;
            Console.WriteLine("float_value:{0},double_value:{1}", myFloat, myDouble);

            //非整数
            char myChar = 'a';                  //字符，规定用单引号表示
            string myString1 = "wea 125";       //字符串，规定用双引号表示，可以为空
            string myString2 = "";
            bool myBoll = true;                 //布尔型，应用比较判断中
            Console.WriteLine("char_value:{0},string1_value:{1},string2_value:{2},bool_value:{3}", myChar, myString1, myString2, myBoll);
            Console.ReadKey();
        }
    }
}