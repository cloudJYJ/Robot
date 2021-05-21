using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args) 
        {
            StandardRobot standardRobot = new StandardRobot();
            SuperRobot superRobot = new SuperRobot();

            Console.WriteLine("\n일반 로봇\n");
            standardRobot.Run();
            standardRobot.Walk();
            standardRobot.Shape();
            standardRobot.ShootMissile();
            standardRobot.AttackKnife();
            standardRobot.TryFlying();
            standardRobot.knife = new LaserKnife();
            standardRobot.AttackKnife();

            Console.WriteLine("\n슈퍼 로봇\n");
            superRobot.Run();
            superRobot.Walk();
            superRobot.Shape();
            superRobot.ShootMissile();
            superRobot.AttackKnife();
            superRobot.TryFlying();
            superRobot.fly = new DontFly();
            superRobot.TryFlying();

            Console.ReadKey();
        }
    }
}
