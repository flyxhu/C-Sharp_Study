using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002抽象类
{
    abstract class Bird //当一个类里面定义了抽象方法，那这个类必须声明是抽象类，就是一个不完整的模板
    {
        private float speed;
        public void Eat()
        {
            Console.WriteLine("鸟在吃东西");
        }

        public abstract void Fly();
       
    }
}
