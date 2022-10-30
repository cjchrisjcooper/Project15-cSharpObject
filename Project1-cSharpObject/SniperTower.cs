using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    internal class SniperTower : Tower
    {
        public override int Range { get; } = 5;
        public override int Damage { get;  } = 4;
        public override double Accuracy { get; } = .9;


        public SniperTower(MapLocation location) : base(location)
        {

        }

        public void Shoot()
        {
            Console.WriteLine("BOOM!!!");
        }

       
    }
}
