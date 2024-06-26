using System.Windows.Forms;

namespace Ball.Commons
{
    public class RandomPointAndSizeBall : RandomPointBall
    {
        public RandomPointAndSizeBall(Form form) : base(form)
        {
            size = random.Next(30, 150);
            if (x + size > form.ClientSize.Width)
            {
                x -= size;
            }
            if (y + size > form.ClientSize.Height)
            {
                y -= size;
            }
        }
    }
}
