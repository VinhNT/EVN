using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVN.Lib
{
    class MyPoint :IComparable
    {
        public int X { get; set; }

        public int Y { get; set; }



        public bool CompareTo(MyPoint point)
        {
            return (this.Y < point.Y) || (this.Y < point.Y && this.X < point.X);
        }

        int IComparable.CompareTo(object obj)
        {
            if (this.X == ((MyPoint)obj).X)
                return this.Y - ((MyPoint)obj).Y;
            else
                return this.X - ((MyPoint)obj).X;
        }
    }
}
