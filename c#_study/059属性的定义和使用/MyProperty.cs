using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059属性的定义和使用
{
    class MyProperty
    {
        public int MyProperty
        {
            set 
            {
                Console.WriteLine("属性中的get块被调用");
                Console.WriteLine("在set块中value的值是：" + value);
            }
            get 
            {
                Console.WriteLine("属性中的get块被调用");
                return 100;
            }
        }
    }
}
