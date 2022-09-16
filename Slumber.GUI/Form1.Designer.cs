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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlumberForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lockButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.shutButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Slumber.GUI.Properties.Resources.bot;
            this.pictureBox.Location = new System.Drawing.Point(22, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(96, 89);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lockButton
            // 
            this.lockButton.BackColor = System.Drawing.Color.Transparent;
            this.lockButton.BackgroundImage = global::Slumber.GUI.Properties.Resources.lock_padlock_symbol_for_security_interface;
            this.lockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lockButton.FlatAppearance.BorderSize = 0;
            this.lockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lockButton.Location = new System.Drawing.Point(129, 196);
            this.lockButton.Name = "lockButton";
            this.lockButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lockButton.Size = new System.Drawing.Size(89, 66);
            this.lockButton.TabIndex = 1;
            this.lockButton.UseVisualStyleBackColor = false;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = global::Slumber.GUI.Properties.Resources.restart;
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Location = new System.Drawing.Point(129, 112);
            this.restartButton.Name = "restartButton";
            this.restartButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.restartButton.Size = new System.Drawing.Size(89, 66);
            this.restartButton.TabIndex = 2;
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // shutButton
            // 
            this.shutButton.BackColor = System.Drawing.Color.Transparent;
            this.shutButton.BackgroundImage = global::Slumber.GUI.Properties.Resources.shutdown;
            this.shutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shutButton.FlatAppearance.BorderSize = 0;
            this.shutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutButton.Location = new System.Drawing.Point(129, 28);
            this.shutButton.Name = "shutButton";
            this.shutButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shutButton.Size = new System.Drawing.Size(89, 66);
            this.shutButton.TabIndex = 3;
            this.shutButton.UseVisualStyleBackColor = false;
            this.shutButton.Click += new System.EventHandler(this.shutButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(156)))));
            this.topPanel.Controls.Add(this.cancelButton);
            this.topPanel.Controls.Add(this.pictureBox);
            this.topPanel.Controls.Add(this.confirmButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(316, 129);
            this.topPanel.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackgroundImage = global::Slumber.GUI.Properties.Resources.cancel;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(259, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelButton.Size = new System.Drawing.Size(45, 40);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.BackgroundImage = global::Slumber.GUI.Properties.Resources.check;
            this.confirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(205, 12);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirmButton.Size = new System.Drawing.Size(45, 40);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.shutButton);
            this.bottomPanel.Controls.Add(this.restartButton);
            this.bottomPanel.Controls.Add(this.lockButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 129);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(316, 326);
            this.bottomPanel.TabIndex = 7;
            // 
            // SlumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(316, 455);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(332, 494);
            this.MinimumSize = new System.Drawing.Size(332, 494);
            this.Name = "SlumberForm";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slumber";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox;
        private Button lockButton;
        private Button restartButton;
        private Button shutButton;
        private Panel topPanel;
        private Panel bottomPanel;
        private Button cancelButton;
        private Button confirmButton;
    }
}