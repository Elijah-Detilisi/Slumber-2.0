namespace Slumber.GUI
{
    partial class SlumberForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lockButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.shutButton = new System.Windows.Forms.Button();
            this.progressBar = new CircularProgressBar_NET5.CircularProgressBar();
            this.exitButton = new System.Windows.Forms.Button();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.timerWidget = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Slumber.GUI.Properties.Resources.chatbot;
            this.pictureBox.Location = new System.Drawing.Point(10, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(75, 59);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lockButton
            // 
            this.lockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.lockButton.BackgroundImage = global::Slumber.GUI.Properties.Resources.lock_padlock_symbol_for_security_interface;
            this.lockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lockButton.FlatAppearance.BorderSize = 0;
            this.lockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lockButton.Location = new System.Drawing.Point(125, 331);
            this.lockButton.Name = "lockButton";
            this.lockButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lockButton.Size = new System.Drawing.Size(89, 66);
            this.lockButton.TabIndex = 1;
            this.lockButton.UseVisualStyleBackColor = false;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.restartButton.BackgroundImage = global::Slumber.GUI.Properties.Resources.restart;
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Location = new System.Drawing.Point(125, 249);
            this.restartButton.Name = "restartButton";
            this.restartButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.restartButton.Size = new System.Drawing.Size(89, 66);
            this.restartButton.TabIndex = 2;
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // shutButton
            // 
            this.shutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.shutButton.BackgroundImage = global::Slumber.GUI.Properties.Resources.shutdown;
            this.shutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shutButton.FlatAppearance.BorderSize = 0;
            this.shutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutButton.Location = new System.Drawing.Point(125, 160);
            this.shutButton.Name = "shutButton";
            this.shutButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shutButton.Size = new System.Drawing.Size(89, 66);
            this.shutButton.TabIndex = 3;
            this.shutButton.UseVisualStyleBackColor = false;
            this.shutButton.Click += new System.EventHandler(this.shutButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            this.progressBar.AnimationSpeed = 500;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.progressBar.InnerMargin = 2;
            this.progressBar.InnerWidth = -1;
            this.progressBar.Location = new System.Drawing.Point(125, 57);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.progressBar.OuterMargin = -25;
            this.progressBar.OuterWidth = 26;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressBar.ProgressWidth = 10;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressBar.Size = new System.Drawing.Size(89, 78);
            this.progressBar.StartAngle = 270;
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.progressBar.SubscriptText = "";
            this.progressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar.SuperscriptText = "";
            this.progressBar.TabIndex = 4;
            this.progressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.progressBar.Value = 20;
            this.progressBar.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Firebrick;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(229, 410);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 33);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondsTextBox.BackColor = System.Drawing.Color.Silver;
            this.secondsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondsTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.secondsTextBox.ForeColor = System.Drawing.Color.Black;
            this.secondsTextBox.Location = new System.Drawing.Point(184, 110);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(73, 25);
            this.secondsTextBox.TabIndex = 12;
            this.secondsTextBox.Text = "60";
            this.secondsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerWidget
            // 
            this.timerWidget.Interval = 1000;
            this.timerWidget.Tick += new System.EventHandler(this.timerWidget_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Minutes:";
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minutesTextBox.BackColor = System.Drawing.Color.Silver;
            this.minutesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minutesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minutesTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.minutesTextBox.ForeColor = System.Drawing.Color.Black;
            this.minutesTextBox.Location = new System.Drawing.Point(184, 71);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(73, 25);
            this.minutesTextBox.TabIndex = 14;
            this.minutesTextBox.Text = "1";
            this.minutesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Seconds:";
            // 
            // SlumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(316, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.shutButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.lockButton);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(332, 494);
            this.MinimumSize = new System.Drawing.Size(332, 494);
            this.Name = "SlumberForm";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slumber";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private Button lockButton;
        private Button restartButton;
        private Button shutButton;
        private CircularProgressBar_NET5.CircularProgressBar progressBar;
        private Button exitButton;
        private TextBox secondsTextBox;
        private System.Windows.Forms.Timer timerWidget;
        private Label label1;
        private TextBox minutesTextBox;
        private Label label2;
    }
}