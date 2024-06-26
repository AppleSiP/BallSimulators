using Timer = System.Windows.Forms.Timer;

namespace BallCommon
{
    public class Ball
    {
        private Form form;
        protected float centerX = 100;
        protected float centerY = 100;
        protected float vX = 1;
        protected float vY = 1;
        protected int maxSpeed = 10; 
        protected int radius = 10;
        protected static Random random = new Random();
        public Brush brush = Brushes.Blue;
        private Timer moveTimer;
        public Ball(Form form)
        {
            this.form = form;
            moveTimer = new Timer();
            moveTimer.Interval = 20;
            moveTimer.Tick += MoveTimer_Tick;
        }
        public void Show()
        {
            Draw(brush);
        }
        protected virtual void Go()
        {
            centerX += vX;
            centerY += vY;
        }
        public void Clear()
        {
            Draw(new SolidBrush(form.BackColor));
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void Start()
        {
            moveTimer.Enabled = true;
        }
        public void TimeSwitch()
        {
            moveTimer.Enabled = !moveTimer.Enabled;
        }
        public void Stop()
        {
            moveTimer.Stop();
        }
        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int MiddleLeftSide()
        {
            return form.ClientSize.Width / 2 - radius;
        }
        public int MiddleRightSide()
        {
            return form.ClientSize.Width / 2 + radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }
        public bool OnForm()
        {
            return (centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide());
        }
        /// <summary>
        /// Метод определяет принадлежность шарика к области
        /// </summary>
        /// <param name="x0">левая граница области</param>
        /// <param name="y0">верхняя граница области</param>
        /// <param name="x">правая граница обалсти</param>
        /// <param name="y">нижняя граница области</param>
        /// <returns></returns>
        public bool OnArea(int  x0, int y0, int x, int y)
        {
            int leftBorder = x0 + radius;
            int topBorder = y0 + radius;
            int rightBorder = x;
            int downBorder = y;
            return (centerX >= leftBorder && centerX <= rightBorder && centerY >= topBorder && centerY <= downBorder);
        }
        public bool Contains(int pointX, int pointY)
        {
            return Math.Pow((centerX - pointX), 2) + Math.Pow((centerY - pointY), 2) <= Math.Pow(radius, 2);
        }
        private void Draw(Brush brash)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brash, rectangle);
        }
        public void RandomColor()
        {
            var red = random.Next(0, 235);
            var green = random.Next(0, 235);
            var blue = random.Next(0, 235);
            brush = new SolidBrush(Color.FromArgb(red, green, blue));
        }
        public void RandomSize()
        {
            radius = random.Next(10, 35);
            if (centerX > RightSide())
            {
                centerX -= radius;
            }
            if (centerY > DownSide())
            {
                centerY -= radius;
            }
        }
        
        public void RandomSize(int minRadius, int maxRadius)
        {
            radius = random.Next(minRadius, maxRadius);
            if (centerX > RightSide())
            {
                centerX -= radius;
            }
            if (centerY > DownSide())
            {
                centerY -= radius;
            }
        }
        public Brush GetBrush()
        {
            return brush;
        }
        public bool IsMovable()
        {
            return moveTimer.Enabled;
        }
    }
}
