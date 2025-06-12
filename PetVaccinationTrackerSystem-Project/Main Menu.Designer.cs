namespace PetVaccinationTrackerSystem_Project
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            sidePanelNav = new Panel();
            sidePanelHighlight = new Panel();
            buttonSettings = new Button();
            buttonAlerts = new Button();
            buttonLogOut = new ReaLTaiizor.Controls.HopeRoundButton();
            buttonVaccinationReports = new Button();
            buttonVaccinationRecords = new Button();
            buttonPetProfile = new Button();
            buttonHome = new Button();
            sidePanelPBPanel = new Panel();
            userPictureBox = new PictureBox();
            mainPanel = new Panel();
            sidePanelNav.SuspendLayout();
            sidePanelPBPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sidePanelNav
            // 
            sidePanelNav.BackColor = SystemColors.ButtonFace;
            sidePanelNav.Controls.Add(sidePanelHighlight);
            sidePanelNav.Controls.Add(buttonSettings);
            sidePanelNav.Controls.Add(buttonAlerts);
            sidePanelNav.Controls.Add(buttonLogOut);
            sidePanelNav.Controls.Add(buttonVaccinationReports);
            sidePanelNav.Controls.Add(buttonVaccinationRecords);
            sidePanelNav.Controls.Add(buttonPetProfile);
            sidePanelNav.Controls.Add(buttonHome);
            sidePanelNav.Controls.Add(sidePanelPBPanel);
            sidePanelNav.Dock = DockStyle.Left;
            sidePanelNav.Location = new Point(0, 0);
            sidePanelNav.Name = "sidePanelNav";
            sidePanelNav.Size = new Size(202, 593);
            sidePanelNav.TabIndex = 0;
            // 
            // sidePanelHighlight
            // 
            sidePanelHighlight.BackColor = Color.FromArgb(168, 130, 95);
            sidePanelHighlight.Location = new Point(0, 170);
            sidePanelHighlight.Name = "sidePanelHighlight";
            sidePanelHighlight.Size = new Size(10, 50);
            sidePanelHighlight.TabIndex = 0;
            // 
            // buttonSettings
            // 
            buttonSettings.Dock = DockStyle.Top;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSettings.ForeColor = Color.FromArgb(89, 85, 84);
            buttonSettings.Location = new Point(0, 420);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(202, 50);
            buttonSettings.TabIndex = 7;
            buttonSettings.Text = "        Settings";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonAlerts
            // 
            buttonAlerts.Dock = DockStyle.Top;
            buttonAlerts.FlatAppearance.BorderSize = 0;
            buttonAlerts.FlatStyle = FlatStyle.Flat;
            buttonAlerts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAlerts.ForeColor = Color.FromArgb(89, 85, 84);
            buttonAlerts.Location = new Point(0, 370);
            buttonAlerts.Name = "buttonAlerts";
            buttonAlerts.Size = new Size(202, 50);
            buttonAlerts.TabIndex = 6;
            buttonAlerts.Text = "        Alerts";
            buttonAlerts.TextAlign = ContentAlignment.MiddleLeft;
            buttonAlerts.UseVisualStyleBackColor = true;
            buttonAlerts.Click += buttonAlerts_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BorderColor = Color.FromArgb(220, 223, 230);
            buttonLogOut.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            buttonLogOut.DangerColor = Color.FromArgb(245, 108, 108);
            buttonLogOut.DefaultColor = Color.FromArgb(255, 255, 255);
            buttonLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOut.ForeColor = Color.Black;
            buttonLogOut.HoverTextColor = Color.FromArgb(48, 49, 51);
            buttonLogOut.InfoColor = Color.FromArgb(144, 147, 153);
            buttonLogOut.Location = new Point(30, 535);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.PrimaryColor = Color.FromArgb(89, 85, 84);
            buttonLogOut.Size = new Size(140, 40);
            buttonLogOut.SuccessColor = Color.FromArgb(103, 194, 58);
            buttonLogOut.TabIndex = 5;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.TextColor = Color.White;
            buttonLogOut.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // buttonVaccinationReports
            // 
            buttonVaccinationReports.Dock = DockStyle.Top;
            buttonVaccinationReports.FlatAppearance.BorderSize = 0;
            buttonVaccinationReports.FlatStyle = FlatStyle.Flat;
            buttonVaccinationReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVaccinationReports.ForeColor = Color.FromArgb(89, 85, 84);
            buttonVaccinationReports.Location = new Point(0, 320);
            buttonVaccinationReports.Name = "buttonVaccinationReports";
            buttonVaccinationReports.Size = new Size(202, 50);
            buttonVaccinationReports.TabIndex = 4;
            buttonVaccinationReports.Text = "        Vaccine Reports";
            buttonVaccinationReports.TextAlign = ContentAlignment.MiddleLeft;
            buttonVaccinationReports.UseVisualStyleBackColor = true;
            buttonVaccinationReports.Click += buttonVaccinationReports_Click;
            // 
            // buttonVaccinationRecords
            // 
            buttonVaccinationRecords.Dock = DockStyle.Top;
            buttonVaccinationRecords.FlatAppearance.BorderSize = 0;
            buttonVaccinationRecords.FlatStyle = FlatStyle.Flat;
            buttonVaccinationRecords.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVaccinationRecords.ForeColor = Color.FromArgb(89, 85, 84);
            buttonVaccinationRecords.Location = new Point(0, 270);
            buttonVaccinationRecords.Name = "buttonVaccinationRecords";
            buttonVaccinationRecords.Size = new Size(202, 50);
            buttonVaccinationRecords.TabIndex = 3;
            buttonVaccinationRecords.Text = "        Vaccine Records";
            buttonVaccinationRecords.TextAlign = ContentAlignment.MiddleLeft;
            buttonVaccinationRecords.UseVisualStyleBackColor = true;
            buttonVaccinationRecords.Click += buttonVaccinationRecords_Click;
            // 
            // buttonPetProfile
            // 
            buttonPetProfile.Dock = DockStyle.Top;
            buttonPetProfile.FlatAppearance.BorderSize = 0;
            buttonPetProfile.FlatStyle = FlatStyle.Flat;
            buttonPetProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPetProfile.ForeColor = Color.FromArgb(89, 85, 84);
            buttonPetProfile.Location = new Point(0, 220);
            buttonPetProfile.Name = "buttonPetProfile";
            buttonPetProfile.Size = new Size(202, 50);
            buttonPetProfile.TabIndex = 2;
            buttonPetProfile.Text = "        Pet Profile";
            buttonPetProfile.TextAlign = ContentAlignment.MiddleLeft;
            buttonPetProfile.UseVisualStyleBackColor = true;
            buttonPetProfile.Click += buttonPetProfile_Click;
            // 
            // buttonHome
            // 
            buttonHome.Dock = DockStyle.Top;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = Color.FromArgb(89, 85, 84);
            buttonHome.Location = new Point(0, 170);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(202, 50);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "        Home";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // sidePanelPBPanel
            // 
            sidePanelPBPanel.Controls.Add(userPictureBox);
            sidePanelPBPanel.Dock = DockStyle.Top;
            sidePanelPBPanel.Location = new Point(0, 0);
            sidePanelPBPanel.Name = "sidePanelPBPanel";
            sidePanelPBPanel.Size = new Size(202, 170);
            sidePanelPBPanel.TabIndex = 0;
            // 
            // userPictureBox
            // 
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(40, 25);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(120, 120);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 0;
            userPictureBox.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(202, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(780, 593);
            mainPanel.TabIndex = 1;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 593);
            Controls.Add(mainPanel);
            Controls.Add(sidePanelNav);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 640);
            Name = "mainMenu";
            Text = "Main Menu";
            sidePanelNav.ResumeLayout(false);
            sidePanelPBPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanelNav;
        private Panel mainPanel;
        private Button buttonHome;
        private Panel sidePanelPBPanel;
        private Button buttonVaccinationReports;
        private Button buttonVaccinationRecords;
        private Button buttonPetProfile;
        private PictureBox userPictureBox;
        private Panel sidePanelHighlight;
        private ReaLTaiizor.Controls.HopeRoundButton buttonLogOut;
        private Button buttonSettings;
        private Button buttonAlerts;
    }
}