using System.Collections.Generic;

namespace Ball.Commons
{
    public static class FieldHelper
    {
        public static void Clear(List<MoveBall> moveBalls)
        {
            foreach (var ball in moveBalls)
            {
                ball.Stop();
                ball.Clear();

            }
            moveBalls.Clear();
        }
        public static bool Empty(List<MoveBall> moveBalls)
        {
            var countBallOnForm = 0;
            foreach (var ball in moveBalls)
            {
                if (ball.OnForm())
                {
                    countBallOnForm++;
                }
            }
            return (countBallOnForm == 0);
        }
    }
}
