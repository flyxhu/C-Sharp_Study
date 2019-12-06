using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //隐式转换，将小盒子的东西放到大盒子的时候，类型自动进行转换
            byte Mybyte1 = 201;
            int Myint = Mybyte1; 

            byte Mybyte2 = 202;
            float Myfloat = Mybyte2;

            byte Mybyte3 = 203;
            double Mydouble = Mybyte3;

            byte Mybyte4 = 204;
            long Mylong = Mybyte4;


            //显式转换（又叫做强制转换），将大盒子的东西放到小盒子的时候，需要进行显式转换，()括号里面加上需要转换的类型
            int Myint1 = 101;
            byte Mybyte_a = (byte)Myint1;

            float Myfloat1 = 102;
            byte Mybyte_b = (byte)Myfloat1;

            double Mydouble1 = 103;
            byte Mybyte_c = (byte)Mydouble;

            long Mylong1 = 104;
            byte Mybyte_d = (byte)Mylong1;

            byte Mybyte5 = 97;
            char Mychar = (char)Mybyte5;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", Myint, Myfloat, Mydouble, 
                Mylong, Mybyte_a, Mybyte_b, Mybyte_c, Mybyte_d, Mychar);
            Console.ReadKey();

        }
    }
}
