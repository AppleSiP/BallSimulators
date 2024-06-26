
namespace BallCommon
{
    public class RandomPointBall : Ball
    {
        public RandomPointBall(Form form) : base(form)
        {
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }
        public RandomPointBall(Form form, int borderLeft, int borderRight) : base(form)
        {
            centerX = random.Next(borderLeft + radius, borderRight - radius);
            centerY = random.Next(TopSide(), DownSide());
        }
    }
}
