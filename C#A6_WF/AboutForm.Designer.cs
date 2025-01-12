namespace C_A6_WF
{
    partial class AboutForm
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
            pictureBox1 = new PictureBox();
            versionLabel = new Label();
            appNameLabel = new Label();
            authorLabel = new Label();
            descriptionLabel = new Label();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.new_data_services_zsV5auL_hs0_unsplash;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 209);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new Point(12, 277);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(0, 15);
            versionLabel.TabIndex = 1;
            // 
            // appNameLabel
            // 
            appNameLabel.AutoSize = true;
            appNameLabel.Location = new Point(12, 252);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(0, 15);
            appNameLabel.TabIndex = 2;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(12, 304);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(0, 15);
            authorLabel.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 333);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(0, 15);
            descriptionLabel.TabIndex = 4;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ButtonShadow;
            closeButton.FlatStyle = FlatStyle.Popup;
            closeButton.ForeColor = SystemColors.ControlText;
            closeButton.Location = new Point(12, 379);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(307, 59);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(331, 450);
            Controls.Add(closeButton);
            Controls.Add(descriptionLabel);
            Controls.Add(authorLabel);
            Controls.Add(appNameLabel);
            Controls.Add(versionLabel);
            Controls.Add(pictureBox1);
            Name = "AboutForm";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label versionLabel;
        private Label appNameLabel;
        private Label authorLabel;
        private Label descriptionLabel;
        private Button closeButton;
    }
}