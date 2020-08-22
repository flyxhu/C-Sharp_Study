using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059属性的定义和使用
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProperty property = new MyProperty();

            property.MyProperty = 600;
            int temp = property.MyProperty;
            
            Console.WriteLine(temp);
            Console.ReadKey();

        }
    }
}
