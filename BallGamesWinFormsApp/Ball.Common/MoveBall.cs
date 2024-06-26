

namespace BallCommon
{
    public class MoveBall : RandomPointBall
    {
        public MoveBall(Form form) : base(form)
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
            CorrectPositionBall();
        }
        public MoveBall(Form form, int borderLeft, int borderRight) : base(form, borderLeft, borderRight)
        {
            vX = Convert.ToInt32(Math.Pow(-1, random.Next(0, 2)) * random.Next(1, maxSpeed));
            vY = Convert.ToInt32(Math.Pow(-1, random.Next(0, 2)) * random.Next(1, maxSpeed));
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
            CorrectPositionBall();
        }
        private void CorrectPositionBall()
        {
            if (centerX + vX >= RightSide() || centerX + vX <= LeftSide())
            {
                vX = -vX;
            }
            if (centerY + vY >= DownSide() || centerY + vY <= TopSide())
            {
                vY = -vY;
            }
        }
    }
}
