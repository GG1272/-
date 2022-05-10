using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace 贪吃蛇
{
    class Square
    {
        public Label Control { get; set; }
        public int xRows { get; set; }
        public int yCols { get; set; }
        public Color bg { get; set; }
        public Square(int rows, int cols, Color bg)
        {
            this.xRows = rows;
            this.yCols = cols;
            this.bg = bg;
            this.Control = new Label();
            this.Control.BackColor = bg;
        }
    }
}
