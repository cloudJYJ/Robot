using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public abstract class IRobot
    {
        IKnife knife { get; set; }
        IMissile missile { get; set; }
        IFly fly { get; set; }

        public void Run()
        {
            Console.WriteLine("로봇이 달린다.");
        }

        public void Walk()
        {
            Console.WriteLine("로봇이 걷는다.");
        }

        public abstract void Shape();
        public abstract void AttackKnife();
        public abstract void ShootMissile();
        public abstract void TryFlying();
    }
}
