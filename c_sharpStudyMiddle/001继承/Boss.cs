using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001继承
{
    class Boss : Enemy 
    {
        //重写父类的虚方法
        public override void Move()
        {
            Console.WriteLine("这里是重写的Move方法");
        }
        //当子类里面有一个签名和父类方法定义相同的时候，父类里面的方法就会被隐藏，实际这个方法还存在
        public new void Hide()
        {
            Console.WriteLine("这里是Boss的公有Hide方法");
        }

        public void Attack()
        {
            AI();
            Move();
            this.HP = 100;
            // this访问当前类中定义的字段，属性和方法，有咩有this都可以访问，有this可以让ide编辑器给出提示
            // 另外当方法的参数和字段重名的时候，使用this可以表明访问的是类中的字段.
            base.Move();
            // base可以调用父类中的方法和字段
            Console.WriteLine("boss开始发起攻击");
        }
    }
}
