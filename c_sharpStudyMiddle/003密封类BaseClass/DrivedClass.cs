using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003密封类BaseClass
{
    //class DrivedClass:BaseClass     //sealed密封类无法被继承
    class DrivedClass:BaseClass
    {
        public sealed override void Move()  //可以把一个重写的方法声明为一个密封的方法，表示这个方法不能再被重写
        {
            base.Move();
        }
    }
}
