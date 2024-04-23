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
    public partial class InstructionStep : UserControl
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public InstructionStep()
        {
            InitializeComponent();
        }

        private void InstructionStep_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Image;
            lblTitle.Text = Title;
            lblDescription.Text = Description;
        }
    }
}
