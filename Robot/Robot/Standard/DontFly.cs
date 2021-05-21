using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class DontFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("이로봇은 날 수 없다.");
        }
    }
}
