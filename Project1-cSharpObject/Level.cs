using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    internal class Level
    {

        public Invader[] Invaders;

        public Tower[] Towers;


        public Level(Invader[] invader, Tower[] towers)
        {
            Invaders = invader;
            Towers = towers;
        }

        //Return true if the player wins, return false if the invaders win
        public bool Play()
        {
            int remainingInvaders = Invaders.Length;


            while (remainingInvaders > 0)
            {
                    //All the towers will shoot on the invaders
                    foreach (Tower tower in Towers)
                    {
                        tower.FireOnInvader(Invaders);




                    }

                    // if the invader is alive, he will move. if the invader has scored, the method will return false.
                    remainingInvaders = 0;
                    foreach (Invader invader in Invaders)
                    {
                        if (invader.IsDead == false)
                        {
                            remainingInvaders++;
                            invader.Move();
                            if (invader.HasScored() == true)
                            {
                                return false;
                            }
                        }
                    }




            }
            return true;

        }
    }
}
