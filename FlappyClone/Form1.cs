using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyClone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            gameoverpanel.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveBg(3);
            movePipe(5);
            gameOver();
        }

        Random rnd = new Random();

        void movePipe(int speed)
        {
            if (p1.Left >= -99) { p1.Left += -speed; } else { p1.Left = 720; p1.Height = rnd.Next(130, 250); }
            if (p2.Left >= -99) { p2.Left += -speed; } else { p2.Left = 720; p2.Top = rnd.Next(300, 470); }
            if (p3.Left >= -99) { p3.Left += -speed; } else { p3.Left = 720; p3.Height = rnd.Next(130, 250); }
            if (p4.Left >= -99) { p4.Left += -speed; } else { p4.Left = 720; p4.Top = rnd.Next(300, 500); }
        }

        void moveBg(int speed) // dvigaem bg
        {
            if (t1.Left >= -130) { t1.Left += -speed; } else { t1.Left = 720; }
            if (t2.Left >= -130) { t2.Left += -speed; } else { t2.Left = 720; }
            if (t3.Left >= -130) { t3.Left += -speed; } else { t3.Left = 720; }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (nlo.Top <= 440)
            nlo.Top += 1;
            score++;
            points.Text = score.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                nlo.Top += -35;
            }
        }

        int score = 0;

        void gameOver()
        {
            if ((nlo.Bounds.IntersectsWith(p1.Bounds)) ||
                (nlo.Bounds.IntersectsWith(p2.Bounds)) ||
                (nlo.Bounds.IntersectsWith(p3.Bounds)) ||
                (nlo.Bounds.IntersectsWith(p4.Bounds)))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                gameoverpanel.Visible = true;
            }
        }
    }
}
