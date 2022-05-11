using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    public class FoodSquare : Square
    {
        public FoodSquare(Square obj, Color bg)
        {
            this.Control = obj.Control;
            this.xRows = obj.xRows;
            this.yCols = obj.yCols;
            this.bg = bg;
            this.Control.BackColor = bg;
        }
    }
}
