using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046结构函数
{
    struct SampleNeme               //结构函数直接在声明的后面定义，普通函数一般定义在类Class里面
    {
        public string firstName;
        public string lastName;
        public string GetName()
        {
            return firstName + " " + lastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SampleNeme MyName;
            MyName.firstName = "Lindom";
            MyName.lastName = "Hu";
            //Console.WriteLine("My name is: " + MyName.firstName + " " + MyName.lastName);
            Console.WriteLine("My name is: " + MyName.GetName());
            Console.ReadKey();
        }
    }
}
