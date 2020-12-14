using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;
        int Score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ground_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            YellowFuck.Top += gravity;
            TopPipe.Left -= pipeSpeed;
            BottomPipe.Left -= pipeSpeed;
            Counter.Text = $"score: {Score}"; 

            if (TopPipe.Left < -100)
            {
                TopPipe.Left = 500;
                Score++;
            }

            if (YellowFuck.Top < -25)
            {
                gameOver();    
            }

            if (BottomPipe.Left < -100) 
            {
                BottomPipe.Left = 600;
                Score++; 
            }

            if(YellowFuck.Bounds.IntersectsWith(TopPipe.Bounds) || YellowFuck.Bounds.IntersectsWith(BottomPipe.Bounds) || YellowFuck.Bounds.IntersectsWith(Ground.Bounds))
            {
                gameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = +5;
            }
        }
        private void gameOver()
        {
            Time.Stop();
            Counter.Text = $"You suck, now go play outside!";
            Restart.Visible = true; 
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
