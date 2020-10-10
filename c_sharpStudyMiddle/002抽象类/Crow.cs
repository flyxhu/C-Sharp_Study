using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002抽象类
{
    class Crow : Bird
    {
        //当继承一个抽象类的时候，必须去实现抽象方法
        public override void Fly()
        {
            Console.WriteLine("乌鸦在飞行");
        }
    }
}
