using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace 贪吃蛇
{
    public class BgSquare:Square
    {
        public BgSquare(int rows, int cols, Color bg) : base(rows, cols, bg)
        {

        }
    }
}
