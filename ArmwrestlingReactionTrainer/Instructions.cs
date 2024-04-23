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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
            instructionStep1.Title = "Step 1. Preparation";
            instructionStep1.Description = "First you need to find a sturdy table. Then you need to tie a resistance band to the leg of the table as shown on the image.";
            instructionStep2.Title = "Step 2. Settings";
            instructionStep2.Description = "You can fine-tune your experience via the settings menu. You will find options for the duration and frequency of the training, as well as if audio should be enabled.";
            instructionStep3.Title = "Step 3. Training";
            instructionStep3.Description = "Put the band over your hand where you find it most comfortable (over the thumb for pronation or you can even use a bottle for cupping). When you see/hear the signal your goal is to pin the band to the table as fast as possible.";
        }
    }
}
