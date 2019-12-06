//引用
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//命名空间
namespace _001My_First_Project_Of_C_Sharp
{
    //定义一个类
    class Program
    {
        //定义Main方法
        static void Main(string[] args)
        {
            //方法体
            Console.Write("Hello World1");
            Console.WriteLine("Hello World2");
            Console.WriteLine("Hello World3");
            Console.WriteLine("替代标记:{0}+{1}={2}", 5, 8, 13);
            Console.WriteLine("多重替代标记:{1},{0} and {1}", 4, 8);
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.ReadKey();
            //多行注释Ctrl+k,Ctrl+c;  多行取消注释：Ctrl+k,Ctrl+u;

        }
    }
}
