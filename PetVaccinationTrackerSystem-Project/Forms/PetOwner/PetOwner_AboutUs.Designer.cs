namespace PetVaccinationTrackerSystem_Project.Forms.PetOwner
{
    partial class PetOwner_AboutUs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetOwner_AboutUs));
            headerPanel = new Panel();
            homePanelBanner = new PictureBox();
            label1 = new Label();
            descriptionTitle = new Label();
            descriptionContent = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            missionTitle = new Label();
            missionText = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            visionTitle = new Label();
            visionText = new Label();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homePanelBanner).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(168, 130, 95);
            headerPanel.Controls.Add(homePanelBanner);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(800, 201);
            headerPanel.TabIndex = 1;
            // 
            // homePanelBanner
            // 
            homePanelBanner.Dock = DockStyle.Fill;
            homePanelBanner.Image = (Image)resources.GetObject("homePanelBanner.Image");
            homePanelBanner.Location = new Point(0, 0);
            homePanelBanner.Name = "homePanelBanner";
            homePanelBanner.Size = new Size(800, 201);
            homePanelBanner.SizeMode = PictureBoxSizeMode.Zoom;
            homePanelBanner.TabIndex = 0;
            homePanelBanner.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(25, 224);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 2;
            label1.Text = "ABOUT US";
            // 
            // descriptionTitle
            // 
            descriptionTitle.AutoSize = true;
            descriptionTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            descriptionTitle.ForeColor = Color.FromArgb(85, 82, 81);
            descriptionTitle.Location = new Point(25, 261);
            descriptionTitle.Name = "descriptionTitle";
            descriptionTitle.Size = new Size(200, 32);
            descriptionTitle.TabIndex = 3;
            descriptionTitle.Text = "What is Pet Vax?";
            // 
            // descriptionContent
            // 
            descriptionContent.AutoSize = true;
            descriptionContent.Font = new Font("Segoe UI", 10F);
            descriptionContent.ForeColor = Color.FromArgb(85, 82, 81);
            descriptionContent.Location = new Point(31, 298);
            descriptionContent.MaximumSize = new Size(740, 0);
            descriptionContent.Name = "descriptionContent";
            descriptionContent.Size = new Size(737, 57);
            descriptionContent.TabIndex = 4;
            descriptionContent.Text = resources.GetString("descriptionContent.Text");
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 249, 249);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(31, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(73, 71);
            panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // missionTitle
            // 
            missionTitle.AutoSize = true;
            missionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            missionTitle.ForeColor = Color.FromArgb(89, 85, 84);
            missionTitle.Location = new Point(113, 390);
            missionTitle.Name = "missionTitle";
            missionTitle.Size = new Size(80, 25);
            missionTitle.TabIndex = 7;
            missionTitle.Text = "Mission";
            // 
            // missionText
            // 
            missionText.AutoSize = true;
            missionText.Font = new Font("Segoe UI", 10F);
            missionText.ForeColor = Color.FromArgb(89, 85, 84);
            missionText.Location = new Point(113, 420);
            missionText.MaximumSize = new Size(650, 0);
            missionText.Name = "missionText";
            missionText.Size = new Size(626, 38);
            missionText.TabIndex = 8;
            missionText.Text = "To help pet owners and veterinarians track pet vaccinations easily by providing a simple, reliable, and user-friendly system that promotes responsible pet care.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 249, 249);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(31, 488);
            panel1.Name = "panel1";
            panel1.Size = new Size(73, 71);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // visionTitle
            // 
            visionTitle.AutoSize = true;
            visionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            visionTitle.ForeColor = Color.FromArgb(89, 85, 84);
            visionTitle.Location = new Point(116, 489);
            visionTitle.Name = "visionTitle";
            visionTitle.Size = new Size(67, 25);
            visionTitle.TabIndex = 10;
            visionTitle.Text = "Vision";
            // 
            // visionText
            // 
            visionText.AutoSize = true;
            visionText.Font = new Font("Segoe UI", 10F);
            visionText.ForeColor = Color.FromArgb(89, 85, 84);
            visionText.Location = new Point(116, 519);
            visionText.MaximumSize = new Size(650, 0);
            visionText.Name = "visionText";
            visionText.Size = new Size(619, 38);
            visionText.TabIndex = 11;
            visionText.Text = "To build a healthier and safer world for pets through technology that supports timely and complete vaccination.";
            // 
            // PetOwner_AboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(visionTitle);
            Controls.Add(visionText);
            Controls.Add(panel1);
            Controls.Add(missionTitle);
            Controls.Add(missionText);
            Controls.Add(panel2);
            Controls.Add(descriptionContent);
            Controls.Add(descriptionTitle);
            Controls.Add(label1);
            Controls.Add(headerPanel);
            Name = "PetOwner_AboutUs";
            Size = new Size(800, 590);
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)homePanelBanner).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerPanel;
        private PictureBox homePanelBanner;
        private Label label1;
        private Label descriptionTitle;
        private Label descriptionContent;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label missionTitle;
        private Label missionText;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label visionTitle;
        private Label visionText;
    }
}
