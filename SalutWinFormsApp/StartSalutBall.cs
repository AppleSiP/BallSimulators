
namespace SalutWinFormsApp
{
    public class StartSalutBall : SalutBall
    {
        private static Random randomX;
        
        public event EventHandler<TopReachedEventArgs> TopReached;
        public StartSalutBall(Form form) : base(form)
        {
            centerX = (float)random.Next(LeftSide(),RightSide());
            centerY = form.ClientSize.Height;
            vY = (float) random.NextDouble() * -6 -7;
            vX = 0;
            radius = 10;
        }
        protected override void Go()
        {
            base.Go();
            if (vY > 0)
            {
                Stop();
                //Clear(); - почему-то рисует уже после Stop();
                brush = Brushes.White;
                TopReached?.Invoke(this, new TopReachedEventArgs(centerX, centerY));
            }
        }
    }
}
