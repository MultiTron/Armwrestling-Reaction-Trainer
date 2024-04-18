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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mainMenu = this.Owner as MainMenu;
            mainMenu.GameSettings.Duration = int.Parse(cbDuration.Text);
            var freqs = cbFrequency.Text.Split('-').Select(s => int.Parse(s)).ToArray();
            mainMenu.GameSettings.MinInterval = freqs[0];
            mainMenu.GameSettings.MaxInterval = freqs[1];
            mainMenu.GameSettings.IsAudible = isAudible.Checked;
            this.Close();
        }
    }
}
