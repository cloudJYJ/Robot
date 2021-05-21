using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class SuperRobot : IRobot
    {
        public IMissile missile = new LongMissile { };
        public IKnife knife = new LaserKnife { };
        public IFly fly = new JetPack { };

        public override void Shape()
        {
            Console.WriteLine("멋진 로봇이다.");
        }

        public override void ShootMissile()
        {
            this.missile.Missile();
        }

        public override void AttackKnife()
        {
            this.knife.Knife();
        }

        public override void TryFlying()
        {
            this.fly.Fly();
        }
    }
}
