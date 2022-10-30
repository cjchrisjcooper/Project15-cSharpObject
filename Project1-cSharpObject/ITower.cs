using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    internal interface ITower
    {

       MapLocation Location { get; set; }

        int Range { get; }

        int Damage { get; }
        double Accuracy { get; }

 
        void FireOnInvader(Invader[] invaders);
       

    }
}
