using PetVaccinationTrackerSystem_Project.Forms.Admin;

namespace PetVaccinationTrackerSystem_Project
{
    partial class MainFormVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormVet));
            mainFormVTopB = new Panel();
            mainFormVButtonAlerts = new Button();
            mainFormVButtonSettings = new Button();
            mainFormVButtonExit = new Button();
            mainFormVSideB = new Panel();
            mainFormVButtonVH = new Button();
            mainFormVSideBHighlight = new Panel();
            mainFormVButtonRegister = new Button();
            mainFormVButtonLO = new ReaLTaiizor.Controls.HopeRoundButton();
            mainFormVButtonVRTS = new Button();
            mainFormVButtonVRDS = new Button();
            mainFormVButtonPetP = new Button();
            mainFormVButtonHome = new Button();
            mainFormVPB = new Panel();
            pictureBox1 = new PictureBox();
            homePanel1V = new homePanel();
            registerPetOwnerPanel1V = new registerPetOwnerPanel();
            vaccineRecordsPanel1V = new VaccineRecordsPanelVet();
            petProfilePanel1V = new petProfilePanelVet();
            vaccinationHistory1 = new VaccinationHistory();
            pet_Reports1 = new Pet_Reports();
            mainFormVTopB.SuspendLayout();
            mainFormVSideB.SuspendLayout();
            mainFormVPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainFormVTopB
            // 
            mainFormVTopB.BackColor = Color.FromArgb(89, 85, 84);
            mainFormVTopB.Controls.Add(mainFormVButtonAlerts);
            mainFormVTopB.Controls.Add(mainFormVButtonSettings);
            mainFormVTopB.Controls.Add(mainFormVButtonExit);
            mainFormVTopB.Dock = DockStyle.Top;
            mainFormVTopB.Location = new Point(0, 0);
            mainFormVTopB.Name = "mainFormVTopB";
            mainFormVTopB.Size = new Size(1000, 50);
            mainFormVTopB.TabIndex = 2;
            // 
            // mainFormVButtonAlerts
            // 
            mainFormVButtonAlerts.BackColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonAlerts.BackgroundImage = (Image)resources.GetObject("mainFormVButtonAlerts.BackgroundImage");
            mainFormVButtonAlerts.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormVButtonAlerts.FlatAppearance.BorderSize = 0;
            mainFormVButtonAlerts.FlatStyle = FlatStyle.Flat;
            mainFormVButtonAlerts.Location = new Point(881, 12);
            mainFormVButtonAlerts.Name = "mainFormVButtonAlerts";
            mainFormVButtonAlerts.Size = new Size(25, 25);
            mainFormVButtonAlerts.TabIndex = 2;
            mainFormVButtonAlerts.UseVisualStyleBackColor = false;
            // 
            // mainFormVButtonSettings
            // 
            mainFormVButtonSettings.BackColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonSettings.BackgroundImage = (Image)resources.GetObject("mainFormVButtonSettings.BackgroundImage");
            mainFormVButtonSettings.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormVButtonSettings.FlatAppearance.BorderSize = 0;
            mainFormVButtonSettings.FlatStyle = FlatStyle.Flat;
            mainFormVButtonSettings.Location = new Point(922, 12);
            mainFormVButtonSettings.Name = "mainFormVButtonSettings";
            mainFormVButtonSettings.Size = new Size(25, 25);
            mainFormVButtonSettings.TabIndex = 1;
            mainFormVButtonSettings.UseVisualStyleBackColor = false;
            // 
            // mainFormVButtonExit
            // 
            mainFormVButtonExit.BackColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonExit.BackgroundImage = (Image)resources.GetObject("mainFormVButtonExit.BackgroundImage");
            mainFormVButtonExit.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormVButtonExit.FlatAppearance.BorderSize = 0;
            mainFormVButtonExit.FlatStyle = FlatStyle.Flat;
            mainFormVButtonExit.Location = new Point(963, 12);
            mainFormVButtonExit.Name = "mainFormVButtonExit";
            mainFormVButtonExit.Size = new Size(25, 25);
            mainFormVButtonExit.TabIndex = 0;
            mainFormVButtonExit.UseVisualStyleBackColor = false;
            mainFormVButtonExit.Click += mainFormVButtonExit_Click;
            // 
            // mainFormVSideB
            // 
            mainFormVSideB.BackColor = Color.FromArgb(249, 249, 249);
            mainFormVSideB.Controls.Add(mainFormVButtonVH);
            mainFormVSideB.Controls.Add(mainFormVSideBHighlight);
            mainFormVSideB.Controls.Add(mainFormVButtonRegister);
            mainFormVSideB.Controls.Add(mainFormVButtonLO);
            mainFormVSideB.Controls.Add(mainFormVButtonVRTS);
            mainFormVSideB.Controls.Add(mainFormVButtonVRDS);
            mainFormVSideB.Controls.Add(mainFormVButtonPetP);
            mainFormVSideB.Controls.Add(mainFormVButtonHome);
            mainFormVSideB.Controls.Add(mainFormVPB);
            mainFormVSideB.Dock = DockStyle.Left;
            mainFormVSideB.Location = new Point(0, 50);
            mainFormVSideB.Name = "mainFormVSideB";
            mainFormVSideB.Size = new Size(200, 590);
            mainFormVSideB.TabIndex = 3;
            // 
            // mainFormVButtonVH
            // 
            mainFormVButtonVH.Dock = DockStyle.Top;
            mainFormVButtonVH.FlatAppearance.BorderSize = 0;
            mainFormVButtonVH.FlatStyle = FlatStyle.Flat;
            mainFormVButtonVH.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormVButtonVH.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonVH.Location = new Point(0, 425);
            mainFormVButtonVH.Name = "mainFormVButtonVH";
            mainFormVButtonVH.Size = new Size(200, 50);
            mainFormVButtonVH.TabIndex = 7;
            mainFormVButtonVH.Text = "        Vaccine History";
            mainFormVButtonVH.TextAlign = ContentAlignment.MiddleLeft;
            mainFormVButtonVH.UseVisualStyleBackColor = true;
            mainFormVButtonVH.Click += mainFormVButtonVH_Click;
            // 
            // mainFormVSideBHighlight
            // 
            mainFormVSideBHighlight.BackColor = Color.FromArgb(168, 130, 95);
            mainFormVSideBHighlight.Location = new Point(0, 175);
            mainFormVSideBHighlight.Name = "mainFormVSideBHighlight";
            mainFormVSideBHighlight.Size = new Size(10, 50);
            mainFormVSideBHighlight.TabIndex = 2;
            // 
            // mainFormVButtonRegister
            // 
            mainFormVButtonRegister.Dock = DockStyle.Top;
            mainFormVButtonRegister.FlatAppearance.BorderSize = 0;
            mainFormVButtonRegister.FlatStyle = FlatStyle.Flat;
            mainFormVButtonRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormVButtonRegister.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonRegister.Location = new Point(0, 375);
            mainFormVButtonRegister.Name = "mainFormVButtonRegister";
            mainFormVButtonRegister.Size = new Size(200, 50);
            mainFormVButtonRegister.TabIndex = 6;
            mainFormVButtonRegister.Text = "        Register Pet Owner";
            mainFormVButtonRegister.TextAlign = ContentAlignment.MiddleLeft;
            mainFormVButtonRegister.UseVisualStyleBackColor = true;
            mainFormVButtonRegister.Click += mainFormVButtonRegister_Click;
            // 
            // mainFormVButtonLO
            // 
            mainFormVButtonLO.BackColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonLO.BorderColor = Color.FromArgb(220, 223, 230);
            mainFormVButtonLO.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            mainFormVButtonLO.DangerColor = Color.FromArgb(245, 108, 108);
            mainFormVButtonLO.DefaultColor = Color.FromArgb(255, 255, 255);
            mainFormVButtonLO.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormVButtonLO.HoverTextColor = Color.White;
            mainFormVButtonLO.InfoColor = Color.FromArgb(144, 147, 153);
            mainFormVButtonLO.Location = new Point(38, 535);
            mainFormVButtonLO.Name = "mainFormVButtonLO";
            mainFormVButtonLO.PrimaryColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonLO.Size = new Size(125, 40);
            mainFormVButtonLO.SuccessColor = Color.FromArgb(103, 194, 58);
            mainFormVButtonLO.TabIndex = 5;
            mainFormVButtonLO.Text = "Log Out";
            mainFormVButtonLO.TextColor = Color.White;
            mainFormVButtonLO.WarningColor = Color.FromArgb(230, 162, 60);
            mainFormVButtonLO.Click += mainFormVButtonLO_Click;
            // 
            // mainFormVButtonVRTS
            // 
            mainFormVButtonVRTS.Dock = DockStyle.Top;
            mainFormVButtonVRTS.FlatAppearance.BorderSize = 0;
            mainFormVButtonVRTS.FlatStyle = FlatStyle.Flat;
            mainFormVButtonVRTS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormVButtonVRTS.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonVRTS.Location = new Point(0, 325);
            mainFormVButtonVRTS.Name = "mainFormVButtonVRTS";
            mainFormVButtonVRTS.Size = new Size(200, 50);
            mainFormVButtonVRTS.TabIndex = 4;
            mainFormVButtonVRTS.Text = "        Vaccine Reports";
            mainFormVButtonVRTS.TextAlign = ContentAlignment.MiddleLeft;
            mainFormVButtonVRTS.UseVisualStyleBackColor = true;
            mainFormVButtonVRTS.Click += mainFormVButtonVRTS_Click;
            // 
            // mainFormVButtonVRDS
            // 
            mainFormVButtonVRDS.Dock = DockStyle.Top;
            mainFormVButtonVRDS.FlatAppearance.BorderSize = 0;
            mainFormVButtonVRDS.FlatStyle = FlatStyle.Flat;
            mainFormVButtonVRDS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormVButtonVRDS.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonVRDS.Location = new Point(0, 275);
            mainFormVButtonVRDS.Name = "mainFormVButtonVRDS";
            mainFormVButtonVRDS.Size = new Size(200, 50);
            mainFormVButtonVRDS.TabIndex = 3;
            mainFormVButtonVRDS.Text = "        Vaccine Records";
            mainFormVButtonVRDS.TextAlign = ContentAlignment.MiddleLeft;
            mainFormVButtonVRDS.UseVisualStyleBackColor = true;
            mainFormVButtonVRDS.Click += mainFormVButtonVRDS_Click;
            // 
            // mainFormVButtonPetP
            // 
            mainFormVButtonPetP.Dock = DockStyle.Top;
            mainFormVButtonPetP.FlatAppearance.BorderSize = 0;
            mainFormVButtonPetP.FlatStyle = FlatStyle.Flat;
            mainFormVButtonPetP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormVButtonPetP.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonPetP.Location = new Point(0, 225);
            mainFormVButtonPetP.Name = "mainFormVButtonPetP";
            mainFormVButtonPetP.Size = new Size(200, 50);
            mainFormVButtonPetP.TabIndex = 2;
            mainFormVButtonPetP.Text = "        Pet Profiles";
            mainFormVButtonPetP.TextAlign = ContentAlignment.MiddleLeft;
            mainFormVButtonPetP.UseVisualStyleBackColor = true;
            mainFormVButtonPetP.Click += mainFormVButtonPetP_Click;
            // 
            // mainFormVButtonHome
            // 
            mainFormVButtonHome.Dock = DockStyle.Top;
            mainFormVButtonHome.FlatAppearance.BorderSize = 0;
            mainFormVButtonHome.FlatStyle = FlatStyle.Flat;
            mainFormVButtonHome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormVButtonHome.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonHome.Location = new Point(0, 175);
            mainFormVButtonHome.Name = "mainFormVButtonHome";
            mainFormVButtonHome.Size = new Size(200, 50);
            mainFormVButtonHome.TabIndex = 1;
            mainFormVButtonHome.Text = "        Home";
            mainFormVButtonHome.TextAlign = ContentAlignment.MiddleLeft;
            mainFormVButtonHome.UseVisualStyleBackColor = true;
            mainFormVButtonHome.Click += mainFormVButtonHome_Click;
            // 
            // mainFormVPB
            // 
            mainFormVPB.Controls.Add(pictureBox1);
            mainFormVPB.Dock = DockStyle.Top;
            mainFormVPB.Location = new Point(0, 0);
            mainFormVPB.Name = "mainFormVPB";
            mainFormVPB.Size = new Size(200, 175);
            mainFormVPB.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // homePanel1V
            // 
            homePanel1V.BackColor = Color.White;
            homePanel1V.Dock = DockStyle.Fill;
            homePanel1V.Location = new Point(200, 50);
            homePanel1V.Name = "homePanel1V";
            homePanel1V.Size = new Size(800, 590);
            homePanel1V.TabIndex = 4;
            // 
            // registerPetOwnerPanel1V
            // 
            registerPetOwnerPanel1V.BackColor = Color.White;
            registerPetOwnerPanel1V.Dock = DockStyle.Fill;
            registerPetOwnerPanel1V.Location = new Point(200, 50);
            registerPetOwnerPanel1V.Name = "registerPetOwnerPanel1V";
            registerPetOwnerPanel1V.Size = new Size(800, 590);
            registerPetOwnerPanel1V.TabIndex = 5;
            // 
            // vaccineRecordsPanel1V
            // 
            vaccineRecordsPanel1V.BackColor = Color.White;
            vaccineRecordsPanel1V.Dock = DockStyle.Fill;
            vaccineRecordsPanel1V.Location = new Point(200, 50);
            vaccineRecordsPanel1V.Name = "vaccineRecordsPanel1V";
            vaccineRecordsPanel1V.Size = new Size(800, 590);
            vaccineRecordsPanel1V.TabIndex = 6;
            // 
            // petProfilePanel1V
            // 
            petProfilePanel1V.BackColor = Color.White;
            petProfilePanel1V.Dock = DockStyle.Fill;
            petProfilePanel1V.Location = new Point(200, 50);
            petProfilePanel1V.Name = "petProfilePanel1V";
            petProfilePanel1V.Size = new Size(800, 590);
            petProfilePanel1V.TabIndex = 7;
            // 
            // vaccinationHistory1
            // 
            vaccinationHistory1.BackColor = Color.White;
            vaccinationHistory1.Dock = DockStyle.Fill;
            vaccinationHistory1.Location = new Point(200, 50);
            vaccinationHistory1.Name = "vaccinationHistory1";
            vaccinationHistory1.Size = new Size(800, 590);
            vaccinationHistory1.TabIndex = 8;
            // 
            // pet_Reports1
            // 
            pet_Reports1.BackColor = Color.White;
            pet_Reports1.Dock = DockStyle.Fill;
            pet_Reports1.Location = new Point(200, 50);
            pet_Reports1.Name = "pet_Reports1";
            pet_Reports1.Size = new Size(800, 590);
            pet_Reports1.TabIndex = 9;
            // 
            // MainFormVet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 640);
            Controls.Add(pet_Reports1);
            Controls.Add(vaccinationHistory1);
            Controls.Add(petProfilePanel1V);
            Controls.Add(vaccineRecordsPanel1V);
            Controls.Add(registerPetOwnerPanel1V);
            Controls.Add(homePanel1V);
            Controls.Add(mainFormVSideB);
            Controls.Add(mainFormVTopB);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 640);
            Name = "MainFormVet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainFormVet";
            mainFormVTopB.ResumeLayout(false);
            mainFormVSideB.ResumeLayout(false);
            mainFormVPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainFormVTopB;
        private Button mainFormVButtonAlerts;
        private Button mainFormVButtonSettings;
        private Button mainFormVButtonExit;
        private Panel mainFormVSideB;
        private Panel mainFormVSideBHighlight;
        private Button mainFormVButtonRegister;
        private ReaLTaiizor.Controls.HopeRoundButton mainFormVButtonLO;
        private Button mainFormVButtonVRTS;
        private Button mainFormVButtonVRDS;
        private Button mainFormVButtonPetP;
        private Button mainFormVButtonHome;
        private Panel mainFormVPB;
        private PictureBox pictureBox1;
        private homePanel homePanel1V;
        private registerPetOwnerPanel registerPetOwnerPanel1V;
        private VaccineRecordsPanelVet vaccineRecordsPanel1V;
        private petProfilePanelVet petProfilePanel1V;
        private HomeUserControl homeUserControl1V;
        private Button mainFormVButtonVH;
        private VaccinationHistory vaccinationHistory1;
        private Pet_Reports pet_Reports1;
    }
}