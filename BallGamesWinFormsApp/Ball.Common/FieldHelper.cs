
using System.Windows.Forms;

namespace BallCommon
{
    public static class FieldHelper
    {
        public static void Clear(List<Ball> moveBalls)
        {
            foreach (var ball in moveBalls)
            {
                ball.Stop();
                ball.Clear();

            }
            moveBalls.Clear();
        }
        public static bool Empty(List<Ball> moveBalls)
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
        public static void DrawCentreLine(Form form)
        {
            var graphics = form.CreateGraphics();
            graphics.DrawLine(Pens.Black, form.ClientSize.Width / 2, 0, form.ClientSize.Width / 2, form.ClientSize.Height);
        }
    }
}
