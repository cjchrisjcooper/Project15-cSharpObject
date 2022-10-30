using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    internal class Invader
    {
            private readonly Path _path;
            public int Health { get; private set; } = 5;

            public bool HasScored()
            {
            return _pathStep >= _path.Length;
            }

            public bool IsDead => Health <= 0;
        

            private int _pathStep = 0;

            public MapLocation Location { get; private set; }


            public Invader(Path path)
            {
                _path = path;
                SetLocation();
            }

            public void Move()
            {
                _pathStep++;
                SetLocation();
            }

            public void DecreaseHealth(int Damage)
            {
                Health -= Damage;
            }

            public void SetLocation() => Location = _path.GetLocationAt(_pathStep);
            
    

    }
}
