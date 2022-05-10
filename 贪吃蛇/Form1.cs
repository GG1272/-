using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贪吃蛇
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
             game = new Game(panel1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //测试
            //第二次测试
            game.Start();
        }
    }
}
