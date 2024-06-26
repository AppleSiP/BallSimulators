using Timer = System.Windows.Forms.Timer;

namespace SalutWinFormsApp
{
    public partial class MainForm : Form
    {
        private int timeStartFireworks;
        private int timeTick = 0;
        private Timer timerStartFireworks;
        public MainForm()
        {
            InitializeComponent();
            timerStartFireworks = new Timer();
            timerStartFireworks.Interval = 400;
            timerStartFireworks.Tick += TimerStartFireworks_Tick;
        }

        private void TimerStartFireworks_Tick(object? sender, EventArgs e)
        {
            if (timeTick >= timeStartFireworks)
            {
                var ball = new StartSalutBall(this);
                ball.TopReached += Ball_TopReached;
                ball.Start();
                timeTick = 0;
                GenerationTimeStartFireworks();
            }
            timeTick++;
        }

        private void Ball_TopReached(object? sender, TopReachedEventArgs e)
        {
            for (int i = 0; i < new Random().Next(15, 30); i++)
            {
                var salutBall = new SalutBall(this, e.X, e.Y);
                salutBall.Start();
            }
        }

        private void GenerationTimeStartFireworks()
        {
            timeStartFireworks = new Random().Next(3, 7);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var random = new Random();
            var count = random.Next(5, 20);
            for (int i = 1; i <= count; i++)
            {
                var salut = new SalutBall(this, e.X, e.Y);
                salut.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerationTimeStartFireworks();
            timerStartFireworks.Start();
        }
    }
}
