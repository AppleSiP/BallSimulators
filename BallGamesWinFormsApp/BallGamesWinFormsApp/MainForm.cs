using BallCommon;

namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        List<Ball> balls = new List<Ball>();
        int amountBalls = 10;
        int countBalls;
        public MainForm()
        {
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            countBalls = 0;
            FieldHelper.Clear(balls);
            for (int i = 0; i < amountBalls; i++)
            {
                var moveBall = new MoveBall(this);
                moveBall.RandomColor();
                moveBall.RandomSize();
                balls.Add(moveBall);
                moveBall.Start();
            }
            startButton.Enabled = false;
            stopButton.Enabled = true;
            statusTimer.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Stop();
                if (ball.OnForm())
                {
                    countBalls++;
                }
            }
            var message = $"Ваш результат {countBalls} шаров";
            DialogResult result = MessageBox.Show(message);
            if (result == DialogResult.OK)
            {
                FieldHelper.Clear(balls);
            }
            stopButton.Enabled = false;
            startButton.Enabled = true;
            statusTimer.Stop();
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            if (FieldHelper.Empty(balls))
            {
                statusTimer.Stop();
                MessageBox.Show("Все шарики убежали!\nВы проиграли!");
                startButton.Enabled = true;
                stopButton.Enabled = false;
            }
        }
    }
}
