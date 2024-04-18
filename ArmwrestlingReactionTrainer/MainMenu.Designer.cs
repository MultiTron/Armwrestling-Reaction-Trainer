namespace ArmwrestlingReactionTrainer
{
    partial class MainMenu
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
            btnInstructions = new Button();
            btnSettings = new Button();
            btnStart = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnInstructions
            // 
            btnInstructions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnInstructions.Location = new Point(146, 246);
            btnInstructions.Name = "btnInstructions";
            btnInstructions.Size = new Size(147, 82);
            btnInstructions.TabIndex = 0;
            btnInstructions.Text = "Instructions";
            btnInstructions.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSettings.Location = new Point(534, 246);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(147, 82);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += OpenSettings;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnStart.Location = new Point(340, 246);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 82);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += Start;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(713, 415);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += Exit;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(239, 71);
            label1.Name = "label1";
            label1.Size = new Size(354, 96);
            label1.TabIndex = 2;
            label1.Text = "Welcome, to the\r\nMOST ELITE\r\nArmwrestling reaction trainer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(btnSettings);
            Controls.Add(btnInstructions);
            Name = "MainMenu";
            Text = "Armwrestling Reaction Trainer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInstructions;
        private Button btnSettings;
        private Button btnStart;
        private Button btnExit;
        private Label label1;
    }
}