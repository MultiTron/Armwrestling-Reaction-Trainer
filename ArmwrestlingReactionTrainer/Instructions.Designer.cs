namespace ArmwrestlingReactionTrainer
{
    partial class Instructions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            instructionStep1 = new InstructionStep();
            instructionStep2 = new InstructionStep();
            instructionStep3 = new InstructionStep();
            SuspendLayout();
            // 
            // instructionStep1
            // 
            instructionStep1.Location = new Point(12, 12);
            instructionStep1.Name = "instructionStep1";
            instructionStep1.Size = new Size(250, 400);
            instructionStep1.TabIndex = 0;
            // 
            // instructionStep2
            // 
            instructionStep2.Location = new Point(268, 12);
            instructionStep2.Name = "instructionStep2";
            instructionStep2.Size = new Size(250, 400);
            instructionStep2.TabIndex = 0;
            // 
            // instructionStep3
            // 
            instructionStep3.Location = new Point(524, 12);
            instructionStep3.Name = "instructionStep3";
            instructionStep3.Size = new Size(250, 400);
            instructionStep3.TabIndex = 0;
            // 
            // Instructions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 434);
            Controls.Add(instructionStep3);
            Controls.Add(instructionStep2);
            Controls.Add(instructionStep1);
            Name = "Instructions";
            Text = "Instructions";
            ResumeLayout(false);
        }

        #endregion

        private InstructionStep instructionStep1;
        private InstructionStep instructionStep2;
        private InstructionStep instructionStep3;
    }
}