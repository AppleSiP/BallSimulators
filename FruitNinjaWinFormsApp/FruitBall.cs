using BallCommon;

namespace FruitNinjaWinFormsApp
{
    public class FruitBall : MoveBall
    {
        private float g = 0.2f;
        public FruitBall(Form form) : base (form)
        {
            RandomColor();
            RandomSize();
            centerX = (float)random.Next(LeftSide(), RightSide());
            centerY = form.ClientSize.Height + radius;
            vY = (float)random.NextDouble() * -6 - 7;
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
