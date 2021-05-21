using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class ShortMissile : IMissile
    {
        public void Missile()
        {
            Console.WriteLine("짧은 미사일 발사");
        }
    }
}
