using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004定义和实现接口
{
    class Bird:IFly,IB     //这里类实现接口的功能，相当于继承了接口。
    {
        public void Fly()       
        {

        }

        public void MethodA()
        {

        }

        public void Method1()       //IA接口的方法，IB继承了IA的接口
        {

        }

        public void Method2()       //IB接口本身具有的方法
        {

        }
    }

}
