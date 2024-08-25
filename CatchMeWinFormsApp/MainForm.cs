using BallCommon;

namespace CatchMeWinFormsApp
{
    public partial class MainForm : Form
    {
        private int amountBallsOnForm = 10;
        public List<Ball> balls = new List<Ball>();
        private int countCatchBalls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            countCatchBalls = 0;
            for (int i = 0; i < amountBallsOnForm; i++)
            {
                var moveBall = new MoveBall(this);
                moveBall.RandomColor();
                moveBall.RandomSize();
                balls.Add(moveBall);
                moveBall.Start();
            }
            startButton.Enabled = false;
            clearButton.Enabled = true;
            statusTimer.Enabled = true;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (balls != null)
            {
                for (int i = 0; i < balls.Count;i++)
                {
                    if (balls[i].Contains(e.X, e.Y))
                    {
                        balls[i].Stop();
                        balls[i].Clear();
                        balls.Remove(balls[i]);
                        countCatchBalls++;
                    }
                    countcatchBallsLabel.Text = $"Поймано: {countCatchBalls}";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            FieldHelper.Clear(balls);
            statusTimer.Enabled = false;
            startButton.Enabled = true;
            clearButton.Enabled = false;
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            var ending = "ов";
            switch (countCatchBalls % 10)
            {
                case 1: ending = ""; break;
                case 2: ending = "a"; break;
                case 3: ending = "a"; break;
                case 4: ending = "a"; break;
            }
            if (countCatchBalls % 100 == 11)
            {
                ending = "ов";
            }
            if (FieldHelper.Empty(balls))
            {
                statusTimer.Enabled = false;
                if (countCatchBalls == 0)
                {
                    MessageBox.Show("Все шарики убежали!\nВы проиграли!");
                }
                else
                {
                    MessageBox.Show($"Ваш результат: {countCatchBalls} шар{ending}");
                }
                startButton.Enabled = true;
                clearButton.Enabled = false;
            }

        }
    }
}
