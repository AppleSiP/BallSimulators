using BallCommon;

namespace SalutWinFormsApp
{
    public class SalutBall : MoveBall
    {
        private float g = 0.2f;
        public SalutBall(Form form, float centerX, float centerY) : base(form)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            RandomSize(3, 5);
            RandomColor();
            vY = -Math.Abs(vY);
        }
        public SalutBall(Form form) : base(form)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            RandomSize(3, 5);
            RandomColor();
            vY = -Math.Abs(vY);
        }
        protected override void Go()
        {
            base.Go();
            vY += g;
            if (centerY >= DownSide() + 2 * radius)
            {
                Stop();
            }
        }

    }
}
