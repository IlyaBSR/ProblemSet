using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet.DataStructures
{
    /// <summary>
    /// Provides a way to represent the location on a 2-D matrix using integers
    /// </summary>
    public struct Coordinate
    {
        public override bool Equals(Object obj) 
        {
            return obj is Coordinate && this == (Coordinate)obj;
        }
       public override int GetHashCode() 
       {
          return x.GetHashCode() ^ y.GetHashCode();
       }
       public static bool operator ==(Coordinate cor1, Coordinate cor2) 
       {
           return cor1.x == cor2.x && cor1.y == cor2.y;
       }

       public static bool operator !=(Coordinate cor1, Coordinate cor2)
       {
           return cor1.x != cor2.x && cor1.y != cor2.y;
       }

        public int x;
        public int y;
    }
}
