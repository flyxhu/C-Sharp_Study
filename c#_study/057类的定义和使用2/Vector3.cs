using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057类的定义和使用2
{
    class Vector3
    {
        //public float x, y, z;
        private float x, y, z;       //编程规范上习惯把类里面数据成员的所有字段设置private的访问修饰符，只供内部访问，不允许对象访问

        public void SetX(float x)   //为字段提供set方法，来设置参数的值
        {
            this.x = x;             //我们可以通过this.方法表示访问类（对象）的字段
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        
        public float Length()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);

        }
    }
}
