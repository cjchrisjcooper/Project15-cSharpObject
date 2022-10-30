using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    abstract class Tower : ITower
    {
        public MapLocation Location { get; set; }

        public virtual int Range { get; } = 3;

        public virtual int Damage { get; } = 4;
        public virtual double Accuracy { get; } = .75;

        private static Random random = new Random();



        public Tower(MapLocation location)
        {
            Location = location;
        }


        public void FireOnInvader(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(Location.DistanceTo(invader.Location) <= Range && invader.IsDead == false)
                {
                    if(random.NextDouble() < Accuracy)
                    {
                        Console.WriteLine("We have shot at an invader");
                        invader.DecreaseHealth(Damage);
                        break;
                    }
                    else { Console.WriteLine("We have missed an invader"); }
                   
                 
                }
            }
        }


        



    }
}
