namespace ArmwrestlingReactionTrainer
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            btnQuit = new Button();
            progressBar = new ProgressBar();
            gameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnQuit
            // 
            btnQuit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnQuit.Location = new Point(713, 415);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 30);
            btnQuit.TabIndex = 0;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += Quit;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(12, 415);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(695, 30);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 1;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 1000;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(progressBar);
            Controls.Add(btnQuit);
            Name = "Game";
            ShowIcon = false;
            Text = "Game";
            WindowState = FormWindowState.Maximized;
            Load += Game_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnQuit;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer gameTimer;
    }
}