using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003密封类BaseClass
{
    //sealed class BaseClass  //这里是直接声明了一个sealed类
    class BaseClass
    {
        public virtual void Move()   //必须要是重写的方法才能被密封
        {
            Console.WriteLine("公有的Move虚方法");
        }
    }
}
