namespace BallCommon
{
    public partial class BilliardBall : MoveBall
    {
        public BilliardBall(Form form) : base(form) 
        {
        }
        public BilliardBall(Form form, Brush brush, int borderLeft, int borderRight) : base(form, borderLeft, borderRight)
        {
            this.brush = brush;
        }
        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                vX = -vX;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                vX = -vX;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                vY = -vY;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                vY = -vY;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
        public event EventHandler<HitEventArgs> OnHited;
    }
}
