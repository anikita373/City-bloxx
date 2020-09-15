using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Bloxx
{

    public partial class GameForm : Form
    {
        int x = 0;
        int x_save = 0;
        int speed = 5;
        Bitmap bmp;
        Graphics graph;
        Pen pen;
        int blocks=0;


        public GameForm()
        {
            InitializeComponent();
            bmp = new Bitmap(607, 312);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Red, 4);


        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            graph.Clear(Color.Transparent);
            x += speed;
            if (x < 0 || x + 124 > 600)
            {
                speed = -speed;
            }
            block.Left +=speed;
            blockdown.Left = 100;

        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                if (blocks==0) {
                    x_save = x;

                }
                if (blocks>1)
                {
                    if ((x_save>=x+124)&(x_save<=x-124)){
                        blocks++;
                       
                    }
                }
            }
        }
    }
}
