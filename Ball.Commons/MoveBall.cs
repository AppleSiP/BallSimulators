using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Ball.Commons
{
    public class MoveBall : RandomPointColorSizeBall
    {
        private Timer moveTimer;
        public MoveBall(Form form) : base(form)
        {
            moveTimer = new Timer();
            moveTimer.Interval = 20;
            moveTimer.Tick += MoveTimer_Tick;
        }
        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            moveTimer.Start();
        }
        public void Stop()
        {
            moveTimer.Stop();
        }
    }
}
