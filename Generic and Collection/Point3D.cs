using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Collection
{
    internal class Point3D:Point2d<int>
    {   
        public int Z {  get; set; }
        public Point3D(int x, int y, int z):base(x, y)
        {
            z = Z;
        }

        public override string ToString()
        {
            return $"x = {X},y = {Y},z = {Z}";
        }
    }
}
