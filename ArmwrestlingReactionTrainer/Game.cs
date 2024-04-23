using System.Media;
using System.Timers;

namespace ArmwrestlingReactionTrainer
{
    public partial class Game : Form
    {
        public SoundPlayer Sound { get; set; }
        public GameSettings GameSettings { get; set; }
        public System.Timers.Timer RoundTimer { get; set; }
        public int timeLeft { get; set; }
        public Game()
        {
            InitializeComponent();
        }

        private void gameTmer_Tick(object? sender, EventArgs e)
        {
            if (timeLeft == 0)
            {
                EndGame();
            }

            timeLeft--;
            progressBar.Value += 1000;
        }

        private void EndGame()
        {
            gameTimer.Stop();
            RoundTimer.Stop();
        }

        public void StartGame()
        {
            gameTimer.Start();
            RoundTimer.Start();
        }

        public void ChangeInterval(object src, ElapsedEventArgs args)
        {
            var timer = src as System.Timers.Timer;

            timer.Interval = Random.Shared.Next(GameSettings.MinInterval, GameSettings.MaxInterval);
        }

        public void ChangeScreen(object src, ElapsedEventArgs args)
        {
            this.BackColor = Color.Green;
            Thread.Sleep(1500);
            this.BackColor = SystemColors.Control;
        }
        public void PlayAudio(object src, ElapsedEventArgs args)
        {
            Sound.SoundLocation = $@"..\..\..\sounds\ready_go_{Random.Shared.Next(1, 7)}.wav";
            Sound.Play();
        }

        private void Quit(object sender, EventArgs e)
        {
            EndGame();
            this.Close();
        }

        private void Game_Load(object sender, EventArgs e)
        {

            var interval = Random.Shared.Next(GameSettings.MinInterval, GameSettings.MaxInterval);
            RoundTimer = new System.Timers.Timer(interval);
            RoundTimer.Elapsed += new ElapsedEventHandler(ChangeInterval);
            if (GameSettings.IsAudible)
            {
                Sound = new SoundPlayer();
                RoundTimer.Elapsed += new ElapsedEventHandler(PlayAudio);
            }
            RoundTimer.Elapsed += new ElapsedEventHandler(ChangeScreen);

            timeLeft = GameSettings.Duration;
            progressBar.Maximum = timeLeft + 1000;
            gameTimer.Tick += gameTmer_Tick;
            StartGame();
        }
    }
}
