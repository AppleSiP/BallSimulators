using BallCommon;
using Timer = System.Windows.Forms.Timer;

namespace FruitNinjaWinFormsApp
{
    public partial class MainForm : Form
    {
        private static Random random = new Random();
        private List<FruitBall> fruitBalls = new List<FruitBall>();
        private Timer timer;
        public MainForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            scoreLabel.Text = "0";
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            for (int i = 0; i <= random.Next(4, 9); i++)
            {
                var bombNumber = random.Next(8);
                var ball = bombNumber == 7 ? new BombBall(this) : new FruitBall(this);
                fruitBalls.Add(ball);
                ball.Start();
            }
            timer.Interval = random.Next(1000, 5000);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruit in fruitBalls)
            {
                if (fruit.IsMovable() && fruit.Contains(e.X, e.Y))
                {
                    fruit.Stop();
                    if (fruit is BombBall)
                    {
                        EndGame();
                        return;
                    }
                    fruit.Clear();
                    scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
                }
            }
        }

        private void EndGame()
        {
            timer.Stop();
            foreach(var fruit in fruitBalls)
            {
                fruit.Stop();
            }
            var result = MessageBox.Show($"Вы проиграли, ваш результат {scoreLabel.Text}\nНажмите .\"ОК\" чтобы начать заново,\nили \"Отмена\" чтобы выйти", "Конец!",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Restart();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
