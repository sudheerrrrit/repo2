namespace Best_Notepad
{
    partial class SpeechForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeechForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.speakbutton = new System.Windows.Forms.Button();
            this.soundtrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.speedtrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.personcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.soundtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-2, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(440, 330);
            this.textBox1.TabIndex = 0;
            // 
            // speakbutton
            // 
            this.speakbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speakbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speakbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.speakbutton.Location = new System.Drawing.Point(1, 2);
            this.speakbutton.Name = "speakbutton";
            this.speakbutton.Size = new System.Drawing.Size(130, 31);
            this.speakbutton.TabIndex = 1;
            this.speakbutton.Text = "&Speak";
            this.speakbutton.UseVisualStyleBackColor = true;
            this.speakbutton.Click += new System.EventHandler(this.speakbutton_Click);
            // 
            // soundtrackBar
            // 
            this.soundtrackBar.Location = new System.Drawing.Point(318, 367);
            this.soundtrackBar.Maximum = 100;
            this.soundtrackBar.Name = "soundtrackBar";
            this.soundtrackBar.Size = new System.Drawing.Size(104, 45);
            this.soundtrackBar.TabIndex = 2;
            this.soundtrackBar.Value = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(270, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Volume:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // speedtrackBar
            // 
            this.speedtrackBar.Location = new System.Drawing.Point(73, 367);
            this.speedtrackBar.Minimum = -10;
            this.speedtrackBar.Name = "speedtrackBar";
            this.speedtrackBar.Size = new System.Drawing.Size(104, 45);
            this.speedtrackBar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Speed:";
            // 
            // personcomboBox
            // 
            this.personcomboBox.BackColor = System.Drawing.Color.LightGray;
            this.personcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personcomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.personcomboBox.FormattingEnabled = true;
            this.personcomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.personcomboBox.Location = new System.Drawing.Point(371, 6);
            this.personcomboBox.Name = "personcomboBox";
            this.personcomboBox.Size = new System.Drawing.Size(67, 23);
            this.personcomboBox.TabIndex = 6;
            this.personcomboBox.Text = "Male";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(313, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Voice of:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // SpeechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(440, 400);
            this.Controls.Add(this.personcomboBox);
            this.Controls.Add(this.speedtrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soundtrackBar);
            this.Controls.Add(this.speakbutton);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpeechForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPEECH-BOX                                Hassan Malik";
            ((System.ComponentModel.ISupportInitialize)(this.soundtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedtrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button speakbutton;
        private System.Windows.Forms.TrackBar soundtrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar speedtrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox personcomboBox;
        private System.Windows.Forms.Label label4;
    }
}