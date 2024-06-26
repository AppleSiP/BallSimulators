using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ball.Commons
{
    public class Ball
    {
        private Form form;
        protected int x = 10;
        protected int y = 10;
        private int vX = 1;
        private int vY = 1;
        private int maxSpeed = 10; 
        protected int size = 50;
        protected static Random random = new Random();
        protected Brush brush = Brushes.Red;
        public Ball(Form form)
        {
            this.form = form;
        }
        public void Show()
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
        private void Go()
        {
            x += vX;
            y += vY;
        }
        public void Clear()
        {
            var graphics = form.CreateGraphics();
            var brash = new SolidBrush(form.BackColor);
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brash, rectangle);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
            
        }
        public bool OnForm()
        {
            if (x >= 0 && x + size <= form.ClientSize.Width && y >= 0 && y + size <= form.ClientSize.Height)
            {
                return true;
            }
            return false;
        }
        public void RandomSpeedAndDirection()
        {
            vX = Convert.ToInt32(Math.Pow(-1, random.Next(0, 2)) * random.Next(0, maxSpeed));
            vY = Convert.ToInt32(Math.Pow(-1, random.Next(0, 2)) * random.Next(0, maxSpeed));
            if (vX == 0 && vY == 0)
            {
                if (random.Next(0, 2) == 0)
                {
                    vX++;
                }
                else
                {
                    vY++;
                }
            }
        }
        public bool Contains(int pointX, int pointY)
        {
            var radius = size / 2;
            var centreX = x + radius;
            var centreY = y + radius;
            return Math.Pow((centreX - pointX), 2) + Math.Pow((centreY - pointY), 2) <= Math.Pow(radius, 2);
        }
    }
}
