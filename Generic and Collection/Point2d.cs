using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Collection
{
    public class Point2d<T>
    {
        public T X {  get; set; }
        public T Y { get; set; }

        public Point2d(T x, T y) {  X = x; Y = y; }

    }

        
      

}
