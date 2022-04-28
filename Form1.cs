using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyingbird
{
    public partial class Form1 : Form
    {
        int movespeed = 10;
        int downspeed = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += downspeed;
            Ground.Left -= movespeed;
            Score.Text = score.ToString();
            Top.Left -= movespeed;
            if (Ground.Left < -100) {  
                Ground.Left = 1000;
                Top.Left = 1000;
                score++;

            }

            if (Bird.Bounds.IntersectsWith(Ground.Bounds) || Bird.
                Bounds.IntersectsWith(Top.Bounds)){
                EndGame();
            }

          

        }



        private void gameKeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                downspeed = 10;
            }
         
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                downspeed = -10;
            }

        }
        private void EndGame() { 
            Timer.Stop();
            Score.Text = "Game over your score is :" + score.ToString();

        }
    }
}
