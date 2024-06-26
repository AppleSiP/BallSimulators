using BallCommon;
using Timer = System.Windows.Forms.Timer;

namespace BilliardBallWinFormsApp
{
    public partial class MainForm : Form
    {
        List<Ball> balls = new List<Ball>();
        public int amountcount = 10;
        private Timer statusTimer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            statusTimer.Interval = 20;
            statusTimer.Tick += StatusTimer_Tick;
            statusTimer.Start();
        }

        private void StatusTimer_Tick(object? sender, EventArgs e)
        {
            var leftCountRedBalls = 0;
            var leftCountBlueBalls = 0;
            var rightCountRedBalls = 0;
            var rightCountBlueBalls = 0;
            FieldHelper.DrawCentreLine(this);
            foreach (var ball in balls)
            {
                if (ball.OnArea(ball.LeftSide(), ball.TopSide(), ball.MiddleLeftSide(), ball.DownSide()))
                {
                    if (ball.GetBrush() == Brushes.Red)
                    {
                        leftCountRedBalls++;
                    }
                    else
                    {
                        leftCountBlueBalls++;
                    }
                }
                else if (ball.OnArea(ball.MiddleRightSide(), ball.TopSide(), ball.RightSide(), ball.DownSide()))
                {
                    if (ball.GetBrush() == Brushes.Red)
                    {
                        rightCountRedBalls++;
                    }
                    else
                    {
                        rightCountBlueBalls++;
                    }
                }
            }
            if (leftCountRedBalls == rightCountRedBalls && leftCountBlueBalls == rightCountBlueBalls
                && leftCountRedBalls + leftCountBlueBalls == amountcount && rightCountBlueBalls + rightCountRedBalls == amountcount)
            {
                statusTimer.Stop();
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
                MessageBox.Show("Äèôôóçèÿ!", "Óïñ!");
                playToolStripMenuItem.Visible = false;
                balls.Clear();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FieldHelper.Clear(balls);
            for (int i = 0; i < amountcount; i++)
            {
                var ball = new BilliardBall(this, Brushes.Blue, 0, this.ClientSize.Width / 2);
                ball.OnHited += Ball_OnHited_1;
                balls.Add(ball);
                ball = new BilliardBall(this, Brushes.Red, this.ClientSize.Width / 2, this.ClientSize.Width);
                ball.OnHited += Ball_OnHited_2;
                balls.Add(ball);
            }
        }

        private void Ball_OnHited_1(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabelBlue.Text = (Convert.ToInt32(leftLabelBlue.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabelBlue.Text = (Convert.ToInt32(rightLabelBlue.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabelBlue.Text = (Convert.ToInt32(topLabelBlue.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabelBlue.Text = (Convert.ToInt32(downLabelBlue.Text) + 1).ToString();
                    break;
            }
        }
        private void Ball_OnHited_2(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabelRed.Text = (Convert.ToInt32(leftLabelRed.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabelRed.Text = (Convert.ToInt32(rightLabelRed.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabelRed.Text = (Convert.ToInt32(topLabelRed.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabelRed.Text = (Convert.ToInt32(downLabelRed.Text) + 1).ToString();
                    break;
            }
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Freeze();
        }

        private void ïåðåçàïóñêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void Freeze()
        {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].TimeSwitch();
            }
            if (playToolStripMenuItem.Text == "Ñòàðò")
            {
                playToolStripMenuItem.Text = "Còîï";
            }
            else
            {
                playToolStripMenuItem.Text = "Ñòàðò";
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Freeze();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y <= menuStrip.Height && !menuStrip.Visible)
                menuStrip.Visible = true;
            if (e.Y > menuStrip.Height && menuStrip.Visible)
                menuStrip.Visible = false;
        }
    }
}
