using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVN.Lib
{
    class Pixel
    {
        #region Public Properties

        public Point Position { get; set; }
        public Color color { get; set; }

        #endregion

        #region Constructor

        public Pixel(Point Position, Color color)
        {
            this.Position = Position;
            this.color = color;
        }

        #endregion
    }
}
