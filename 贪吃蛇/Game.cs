using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace 贪吃蛇
{
    class Game
    {
        Square[,] data;
        int rows;
        int cols;
        int fWidth;
        int fHeight;
        Panel control;
        Color bg;
        public Game(Panel panel)
        {
            this.control = panel;
        }
          void InitData()
        {
            fWidth = 30;
            fHeight = 30;
            rows = this.control.Height / fHeight;
            cols = this.control.Width / fWidth;
            data = new Square[rows, cols];
            bg = Color.Green;
        }
         void DrawGround()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    data[i, j] = new Square(i, j, bg);
                    data[i, j].Control.Size = new Size(fWidth, fHeight);
                    data[i, j].Control.Location = new Point(j * fWidth, i * fHeight);
                    data[i, j].Control.BorderStyle = BorderStyle.FixedSingle;
                    this.control.Controls.Add(data[i, j].Control);
                }
            }
        }
        public void Start()
        {
            InitData();
            DrawGround();
        }
    }
}
