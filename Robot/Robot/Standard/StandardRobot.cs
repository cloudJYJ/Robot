using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class StandardRobot : IRobot
    {
        public IMissile missile = new ShortMissile();
        public IFly fly = new DontFly();
        public IKnife knife = new WoodenKnife();

        public override void Shape()
        {
            Console.WriteLine("평범한 로봇이다.");
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
