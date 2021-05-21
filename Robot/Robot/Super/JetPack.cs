using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class JetPack : IFly
    {
        public void Fly()
        {
            Console.WriteLine("제트팩 비행");
        }
    }
}
