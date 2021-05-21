using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class WoodenKnife : IKnife
    {
        public void Knife() 
        {
            Console.WriteLine("목검 공격");
        }
    }
}
