using PetVaccinationTrackerSystem_Project.Properties;

namespace PetVaccinationTrackerSystem_Project
{
    partial class AboutUs
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            headerPanel = new Panel();
            homePanelBanner = new PictureBox();
            label1 = new Label();
            descriptionTitle = new Label();
            descriptionContent = new Label();
            missionTitle = new Label();
            missionText = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            visionTitle = new Label();
            visionText = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
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
            headerPanel.TabIndex = 0;
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
            label1.Location = new Point(30, 220);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 1;
            label1.Text = "ABOUT US";
            // 
            // descriptionTitle
            // 
            descriptionTitle.AutoSize = true;
            descriptionTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            descriptionTitle.ForeColor = Color.FromArgb(85, 82, 81);
            descriptionTitle.Location = new Point(30, 250);
            descriptionTitle.Name = "descriptionTitle";
            descriptionTitle.Size = new Size(200, 32);
            descriptionTitle.TabIndex = 2;
            descriptionTitle.Text = "What is Pet Vax?";
            // 
            // descriptionContent
            // 
            descriptionContent.AutoSize = true;
            descriptionContent.Font = new Font("Segoe UI", 10F);
            descriptionContent.ForeColor = Color.FromArgb(85, 82, 81);
            descriptionContent.Location = new Point(30, 296);
            descriptionContent.MaximumSize = new Size(740, 0);
            descriptionContent.Name = "descriptionContent";
            descriptionContent.Size = new Size(737, 57);
            descriptionContent.TabIndex = 3;
            descriptionContent.Text = resources.GetString("descriptionContent.Text");
            // 
            // missionTitle
            // 
            missionTitle.AutoSize = true;
            missionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            missionTitle.ForeColor = Color.FromArgb(89, 85, 84);
            missionTitle.Location = new Point(113, 377);
            missionTitle.Name = "missionTitle";
            missionTitle.Size = new Size(80, 25);
            missionTitle.TabIndex = 5;
            missionTitle.Text = "Mission";
            // 
            // missionText
            // 
            missionText.AutoSize = true;
            missionText.Font = new Font("Segoe UI", 10F);
            missionText.ForeColor = Color.FromArgb(89, 85, 84);
            missionText.Location = new Point(113, 407);
            missionText.MaximumSize = new Size(650, 0);
            missionText.Name = "missionText";
            missionText.Size = new Size(626, 38);
            missionText.TabIndex = 6;
            missionText.Text = "To help pet owners and veterinarians track pet vaccinations easily by providing a simple, reliable, and user-friendly system that promotes responsible pet care.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 249, 249);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(30, 377);
            panel2.Name = "panel2";
            panel2.Size = new Size(73, 71);
            panel2.TabIndex = 4;
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
            // visionTitle
            // 
            visionTitle.AutoSize = true;
            visionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            visionTitle.ForeColor = Color.FromArgb(89, 85, 84);
            visionTitle.Location = new Point(113, 478);
            visionTitle.Name = "visionTitle";
            visionTitle.Size = new Size(67, 25);
            visionTitle.TabIndex = 8;
            visionTitle.Text = "Vision";
            // 
            // visionText
            // 
            visionText.AutoSize = true;
            visionText.Font = new Font("Segoe UI", 10F);
            visionText.ForeColor = Color.FromArgb(89, 85, 84);
            visionText.Location = new Point(113, 508);
            visionText.MaximumSize = new Size(650, 0);
            visionText.Name = "visionText";
            visionText.Size = new Size(619, 38);
            visionText.TabIndex = 9;
            visionText.Text = "To build a healthier and safer world for pets through technology that supports timely and complete vaccination.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 249, 249);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(30, 478);
            panel1.Name = "panel1";
            panel1.Size = new Size(73, 71);
            panel1.TabIndex = 7;
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
            // AboutUs
            // 
            BackColor = Color.White;
            Controls.Add(headerPanel);
            Controls.Add(label1);
            Controls.Add(descriptionTitle);
            Controls.Add(descriptionContent);
            Controls.Add(panel2);
            Controls.Add(missionTitle);
            Controls.Add(missionText);
            Controls.Add(panel1);
            Controls.Add(visionTitle);
            Controls.Add(visionText);
            Name = "AboutUs";
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
        private Label missionTitle;
        private Label missionText;
        private Label visionTitle;
        private Label visionText;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
