using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rebotePelota
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Bitmap bmp;
        Ball b1;

        Rectangle ball;// ball sprite
        int dx, dy;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            ball = new Rectangle(140, 10, 30, 30);
            // Initial speeds
            dx = 5;
            dy = 5;
        }

       private void DrawBall(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Color.MediumPurple), ball);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1; //sets the frequency of elapsed events in milliseconds, important to set it 1 ms for smooth animation
            timer1.Enabled = true; //enable the timer
            MoveBall();//call move ball to update location
            Refresh();//refresh the environment
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //for smoother graphics/shapes

            DrawBall(e);//draws the ball
        }

        private void MoveBall()//this method handles ball movement within the screen
        {
            if (ball.X + dx < 0)
            {
                dx += 10;
            }
            if (ball.X + dx >= bmp.Width)
            {
                dx -= 10;
            }
            if (ball.Y + dy < 0)
            {
                dy += 5;
                if (dy == 0) { dy += 5; }
            }
            if (ball.Y + dy >= bmp.Height) //Collision with the bottom of the screen
            {
                dy -= 10;
            }

            ball.X = ball.X + dx;//update the ball x position
            ball.Y = ball.Y + dy;//update the ball y position
        }
    }
}
