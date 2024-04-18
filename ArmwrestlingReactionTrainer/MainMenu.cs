using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmwrestlingReactionTrainer
{
    public partial class MainMenu : Form
    {
        public GameSettings GameSettings { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            GameSettings = new GameSettings();
        }
        public void Start(object sender, EventArgs e)
        {
            var gameForm = new Game();
            gameForm.GameSettings = GameSettings;
            gameForm.Show(this);
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            new Settings().ShowDialog(this);
        }
    }
}
