using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rebotePelota
{
    public class Ball
    {
        public Rectangle ball;//our ball sprite
        public int dx, dy;
        Form1 f;

        public Ball()
        {
            ball = new Rectangle(140, 10, 20, 20);
            dx = 5;//initial speeds
            dy = 5;
        }
    }
}
