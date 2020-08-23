using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _057类的定义和使用2;

namespace _060匿名类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //当匿名类型首次赋值给一个变量时，数据类型就已经确定了，不能再更改类型进行赋值
            var intAnonymous = 12;
            var strAnonymous = "test";
            var longAnonymous = 780000;
            var v1 = new Vector3();

            Console.WriteLine("第一个值为:{0},第二个值为:{1},第三个值为:{2}", intAnonymous, strAnonymous, longAnonymous);
            Console.WriteLine(v1);
            Console.ReadKey();

        }
    }
}
