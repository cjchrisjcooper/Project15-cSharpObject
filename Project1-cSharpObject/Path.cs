using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    internal class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;


        public Path(MapLocation[] path)
        {
            _path = path;
        }


        public MapLocation GetLocationAt(int pathStep)
        {
            if(pathStep < _path.Length)
            {
                return _path[pathStep];
            }
            else { return null; }
           
        }

      
        



    }
}
