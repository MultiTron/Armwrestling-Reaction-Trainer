namespace ArmwrestlingReactionTrainer
{
    partial class Settings
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
            isAudible = new CheckBox();
            cbDuration = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cbFrequency = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // isAudible
            // 
            isAudible.AutoSize = true;
            isAudible.Checked = true;
            isAudible.CheckState = CheckState.Checked;
            isAudible.Location = new Point(12, 234);
            isAudible.Name = "isAudible";
            isAudible.Size = new Size(65, 19);
            isAudible.TabIndex = 0;
            isAudible.Text = "Sound?";
            isAudible.UseVisualStyleBackColor = true;
            // 
            // cbDuration
            // 
            cbDuration.FormattingEnabled = true;
            cbDuration.Items.AddRange(new object[] { "1", "5", "10", "15", "20", "30", "45", "60" });
            cbDuration.Location = new Point(12, 58);
            cbDuration.Name = "cbDuration";
            cbDuration.Size = new Size(65, 23);
            cbDuration.TabIndex = 1;
            cbDuration.Text = "5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 66);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "minutes";
            // 
            // cbFrequency
            // 
            cbFrequency.FormattingEnabled = true;
            cbFrequency.Items.AddRange(new object[] { "5-15", "15-25", "25-35", "35-45" });
            cbFrequency.Location = new Point(209, 58);
            cbFrequency.Name = "cbFrequency";
            cbFrequency.Size = new Size(65, 23);
            cbFrequency.TabIndex = 1;
            cbFrequency.Text = "15-25";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 40);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Frequency";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 66);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 2;
            label4.Text = "seconds";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(209, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 262);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbFrequency);
            Controls.Add(cbDuration);
            Controls.Add(isAudible);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox isAudible;
        private ComboBox cbDuration;
        private Label label1;
        private Label label2;
        private ComboBox cbFrequency;
        private Label label3;
        private Label label4;
        private Button btnSave;
    }
}