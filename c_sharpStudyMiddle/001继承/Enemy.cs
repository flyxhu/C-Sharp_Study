using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001继承
{
    class Enemy
    {
        private float hp;
        private float speed;

        public float HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public void AI()
        {
            //this.HP = 100;
            //this.Move();
            Console.WriteLine("这里是Enemy的公有AI方法");            
        }
        public virtual void Move()     // Move为一个虚方法
        {
            
            Console.WriteLine("这里是Enemy的公有Move方法");
        }

        public void Hide()
        {
            Console.WriteLine("这里是Enemy的公有Hide方法");
        }

    }
}
