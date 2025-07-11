﻿namespace PetVaccinationTrackerSystem_Project.Forms.PetOwner
{
    partial class PetOwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetOwnerForm));
            mainFormVTopB = new Panel();
            lblPetOwnerName = new Label();
            label1 = new Label();
            btnInbox = new Button();
            btnSettings = new Button();
            btnExit = new Button();
            mainFormVPB = new Panel();
            pictureBox1 = new PictureBox();
            btnHome = new Button();
            btnPetProfiles = new Button();
            btnAboutUs = new Button();
            btnLogOut = new ReaLTaiizor.Controls.HopeRoundButton();
            mainFormVSideBHighlight = new Panel();
            mainFormVSideB = new Panel();
            mainPanel = new Panel();
            homePanel1 = new homePanel();
            homePanelPetOwner1 = new HomePanelPetOwner();
            mainFormVTopB.SuspendLayout();
            mainFormVPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainFormVSideB.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormVTopB
            // 
            mainFormVTopB.BackColor = Color.FromArgb(63, 59, 58);
            mainFormVTopB.Controls.Add(lblPetOwnerName);
            mainFormVTopB.Controls.Add(label1);
            mainFormVTopB.Controls.Add(btnInbox);
            mainFormVTopB.Controls.Add(btnSettings);
            mainFormVTopB.Controls.Add(btnExit);
            mainFormVTopB.Dock = DockStyle.Top;
            mainFormVTopB.Location = new Point(0, 0);
            mainFormVTopB.Name = "mainFormVTopB";
            mainFormVTopB.Size = new Size(1000, 50);
            mainFormVTopB.TabIndex = 3;
            // 
            // lblPetOwnerName
            // 
            lblPetOwnerName.AutoSize = true;
            lblPetOwnerName.Font = new Font("Segoe UI", 10F);
            lblPetOwnerName.ForeColor = SystemColors.Control;
            lblPetOwnerName.Location = new Point(150, 14);
            lblPetOwnerName.Name = "lblPetOwnerName";
            lblPetOwnerName.Size = new Size(65, 19);
            lblPetOwnerName.TabIndex = 3;
            lblPetOwnerName.Text = "Jane Doe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 3;
            label1.Text = "Logged In As:";
            // 
            // btnInbox
            // 
            btnInbox.BackColor = Color.FromArgb(63, 59, 58);
            btnInbox.BackgroundImage = (Image)resources.GetObject("btnInbox.BackgroundImage");
            btnInbox.BackgroundImageLayout = ImageLayout.Zoom;
            btnInbox.FlatAppearance.BorderSize = 0;
            btnInbox.FlatStyle = FlatStyle.Flat;
            btnInbox.Location = new Point(881, 12);
            btnInbox.Name = "btnInbox";
            btnInbox.Size = new Size(25, 25);
            btnInbox.TabIndex = 2;
            btnInbox.UseVisualStyleBackColor = false;
            btnInbox.Click += btnInbox_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(63, 59, 58);
            btnSettings.BackgroundImage = (Image)resources.GetObject("btnSettings.BackgroundImage");
            btnSettings.BackgroundImageLayout = ImageLayout.Zoom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Location = new Point(922, 12);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(25, 25);
            btnSettings.TabIndex = 1;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(63, 59, 58);
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(963, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 25);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // mainFormVPB
            // 
            mainFormVPB.Controls.Add(pictureBox1);
            mainFormVPB.Dock = DockStyle.Top;
            mainFormVPB.Location = new Point(0, 0);
            mainFormVPB.Name = "mainFormVPB";
            mainFormVPB.Size = new Size(200, 160);
            mainFormVPB.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(89, 85, 84);
            btnHome.Location = new Point(0, 160);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 50);
            btnHome.TabIndex = 1;
            btnHome.Text = "        Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnPetProfiles
            // 
            btnPetProfiles.Dock = DockStyle.Top;
            btnPetProfiles.FlatAppearance.BorderSize = 0;
            btnPetProfiles.FlatStyle = FlatStyle.Flat;
            btnPetProfiles.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPetProfiles.ForeColor = Color.FromArgb(89, 85, 84);
            btnPetProfiles.Location = new Point(0, 210);
            btnPetProfiles.Name = "btnPetProfiles";
            btnPetProfiles.Size = new Size(200, 50);
            btnPetProfiles.TabIndex = 2;
            btnPetProfiles.Text = "        Pet Profiles";
            btnPetProfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnPetProfiles.UseVisualStyleBackColor = true;
            btnPetProfiles.Click += btnPetProfiles_Click;
            // 
            // btnAboutUs
            // 
            btnAboutUs.Dock = DockStyle.Top;
            btnAboutUs.FlatAppearance.BorderSize = 0;
            btnAboutUs.FlatStyle = FlatStyle.Flat;
            btnAboutUs.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAboutUs.ForeColor = Color.FromArgb(89, 85, 84);
            btnAboutUs.Location = new Point(0, 260);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Size = new Size(200, 50);
            btnAboutUs.TabIndex = 6;
            btnAboutUs.Text = "        About Us";
            btnAboutUs.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutUs.UseVisualStyleBackColor = true;
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(63, 59, 58);
            btnLogOut.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogOut.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogOut.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogOut.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.HoverTextColor = Color.White;
            btnLogOut.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogOut.Location = new Point(38, 532);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnLogOut.Size = new Size(125, 40);
            btnLogOut.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextColor = Color.White;
            btnLogOut.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogOut.Click += btnLogOut_Click;
            // 
            // mainFormVSideBHighlight
            // 
            mainFormVSideBHighlight.BackColor = Color.FromArgb(168, 130, 95);
            mainFormVSideBHighlight.Location = new Point(0, 160);
            mainFormVSideBHighlight.Name = "mainFormVSideBHighlight";
            mainFormVSideBHighlight.Size = new Size(10, 50);
            mainFormVSideBHighlight.TabIndex = 2;
            // 
            // mainFormVSideB
            // 
            mainFormVSideB.BackColor = Color.White;
            mainFormVSideB.Controls.Add(mainFormVSideBHighlight);
            mainFormVSideB.Controls.Add(btnLogOut);
            mainFormVSideB.Controls.Add(btnAboutUs);
            mainFormVSideB.Controls.Add(btnPetProfiles);
            mainFormVSideB.Controls.Add(btnHome);
            mainFormVSideB.Controls.Add(mainFormVPB);
            mainFormVSideB.Dock = DockStyle.Left;
            mainFormVSideB.Location = new Point(0, 50);
            mainFormVSideB.Name = "mainFormVSideB";
            mainFormVSideB.Size = new Size(200, 590);
            mainFormVSideB.TabIndex = 4;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(homePanelPetOwner1);
            mainPanel.Controls.Add(homePanel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 50);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 590);
            mainPanel.TabIndex = 5;
            // 
            // homePanel1
            // 
            homePanel1.BackColor = Color.White;
            homePanel1.Dock = DockStyle.Fill;
            homePanel1.Location = new Point(0, 0);
            homePanel1.Name = "homePanel1";
            homePanel1.Size = new Size(800, 590);
            homePanel1.TabIndex = 0;
            // 
            // homePanelPetOwner1
            // 
            homePanelPetOwner1.BackColor = Color.White;
            homePanelPetOwner1.Dock = DockStyle.Fill;
            homePanelPetOwner1.Location = new Point(0, 0);
            homePanelPetOwner1.Name = "homePanelPetOwner1";
            homePanelPetOwner1.Size = new Size(800, 590);
            homePanelPetOwner1.TabIndex = 1;
            // 
            // PetOwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 640);
            Controls.Add(mainPanel);
            Controls.Add(mainFormVSideB);
            Controls.Add(mainFormVTopB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PetOwnerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetOwnerForm";
            Load += PetOwnerForm_Load;
            mainFormVTopB.ResumeLayout(false);
            mainFormVTopB.PerformLayout();
            mainFormVPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainFormVSideB.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainFormVTopB;
        private Label lblPetOwnerName;
        private Label label1;
        private Button btnInbox;
        private Button btnSettings;
        private Button btnExit;
        private Panel mainFormVPB;
        private PictureBox pictureBox1;
        private Button btnHome;
        private Button btnPetProfiles;
        private Button btnAboutUs;
        private ReaLTaiizor.Controls.HopeRoundButton btnLogOut;
        private Panel mainFormVSideBHighlight;
        private Panel mainFormVSideB;
        private Panel mainPanel;
        private homePanel homePanel1;
        private HomePanelPetOwner homePanelPetOwner1;
    }
}