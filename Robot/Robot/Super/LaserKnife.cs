using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class LaserKnife : IKnife
    {
        public void Knife()
        {
            Console.WriteLine("레이저검 공격");
        }
    }
}
