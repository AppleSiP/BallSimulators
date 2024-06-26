using System.Drawing;
using System.Windows.Forms;

namespace Ball.Commons
{
    public class RandomPointColorSizeBall : RandomPointAndSizeBall
    {
        public RandomPointColorSizeBall(Form form) : base(form)
        {
            var red = random.Next(0, 235);
            var green = random.Next(0, 235);
            var blue = random.Next(0, 235);
            brush = new SolidBrush(Color.FromArgb(red, green, blue));
            RandomSpeedAndDirection();
        }
    }
}
