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
            lblClinic = new Label();
            lblVetName = new Label();
            label2 = new Label();
            label1 = new Label();
            mainFormVButtonAlerts = new Button();
            mainFormVButtonSettings = new Button();
            mainFormVButtonExit = new Button();
            mainFormVSideB = new Panel();
            mainFormVSideBHighlight = new Panel();
            button1 = new Button();
            btnRegisterPetOwner = new Button();
            btnVaccineReports = new Button();
            btnAddVaccineRecord = new Button();
            mainFormVButtonLO = new ReaLTaiizor.Controls.HopeRoundButton();
            btnVaccineRecords = new Button();
            btnAddPetProfile = new Button();
            btnPetProfiles = new Button();
            btnHome = new Button();
            mainFormVPB = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            registerPetOwnerPanel1 = new registerPetOwnerPanel();
            vaccineRecordsPanelVet1 = new VaccineRecordsPanelVet();
            pet_Reports1 = new Pet_Reports();
            tablePetRecords1 = new TablePetRecords();
            petProfilePanelVet1 = new petProfilePanelVet();
            tablePetProfile1 = new TablePetProfile();
            homePanel1 = new homePanel();
            mainFormVTopB.SuspendLayout();
            mainFormVSideB.SuspendLayout();
            mainFormVPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormVTopB
            // 
            mainFormVTopB.BackColor = Color.FromArgb(63, 59, 58);
            mainFormVTopB.Controls.Add(lblClinic);
            mainFormVTopB.Controls.Add(lblVetName);
            mainFormVTopB.Controls.Add(label2);
            mainFormVTopB.Controls.Add(label1);
            mainFormVTopB.Controls.Add(mainFormVButtonAlerts);
            mainFormVTopB.Controls.Add(mainFormVButtonSettings);
            mainFormVTopB.Controls.Add(mainFormVButtonExit);
            mainFormVTopB.Dock = DockStyle.Top;
            mainFormVTopB.Location = new Point(0, 0);
            mainFormVTopB.Name = "mainFormVTopB";
            mainFormVTopB.Size = new Size(1000, 50);
            mainFormVTopB.TabIndex = 2;
            // 
            // lblClinic
            // 
            lblClinic.AutoSize = true;
            lblClinic.Font = new Font("Segoe UI", 10F);
            lblClinic.ForeColor = SystemColors.Control;
            lblClinic.Location = new Point(139, 4);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(54, 19);
            lblClinic.TabIndex = 3;
            lblClinic.Text = "Clinic A";
            // 
            // lblVetName
            // 
            lblVetName.AutoSize = true;
            lblVetName.Font = new Font("Segoe UI", 10F);
            lblVetName.ForeColor = SystemColors.Control;
            lblVetName.Location = new Point(139, 25);
            lblVetName.Name = "lblVetName";
            lblVetName.Size = new Size(65, 19);
            lblVetName.TabIndex = 3;
            lblVetName.Text = "Jane Doe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 4);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 3;
            label2.Text = "Clinic:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 3;
            label1.Text = "Logged In As:";
            // 
            // mainFormVButtonAlerts
            // 
            mainFormVButtonAlerts.BackColor = Color.FromArgb(63, 59, 58);
            mainFormVButtonAlerts.BackgroundImage = (Image)resources.GetObject("mainFormVButtonAlerts.BackgroundImage");
            mainFormVButtonAlerts.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormVButtonAlerts.FlatAppearance.BorderSize = 0;
            mainFormVButtonAlerts.FlatStyle = FlatStyle.Flat;
            mainFormVButtonAlerts.Location = new Point(881, 12);
            mainFormVButtonAlerts.Name = "mainFormVButtonAlerts";
            mainFormVButtonAlerts.Size = new Size(25, 25);
            mainFormVButtonAlerts.TabIndex = 2;
            mainFormVButtonAlerts.UseVisualStyleBackColor = false;
            mainFormVButtonAlerts.Click += mainFormVButtonAlerts_Click;
            // 
            // mainFormVButtonSettings
            // 
            mainFormVButtonSettings.BackColor = Color.FromArgb(63, 59, 58);
            mainFormVButtonSettings.BackgroundImage = (Image)resources.GetObject("mainFormVButtonSettings.BackgroundImage");
            mainFormVButtonSettings.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormVButtonSettings.FlatAppearance.BorderSize = 0;
            mainFormVButtonSettings.FlatStyle = FlatStyle.Flat;
            mainFormVButtonSettings.Location = new Point(922, 12);
            mainFormVButtonSettings.Name = "mainFormVButtonSettings";
            mainFormVButtonSettings.Size = new Size(25, 25);
            mainFormVButtonSettings.TabIndex = 1;
            mainFormVButtonSettings.UseVisualStyleBackColor = false;
            mainFormVButtonSettings.Click += mainFormVButtonSettings_Click;
            // 
            // mainFormVButtonExit
            // 
            mainFormVButtonExit.BackColor = Color.FromArgb(63, 59, 58);
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
            mainFormVSideB.BackColor = Color.White;
            mainFormVSideB.Controls.Add(mainFormVSideBHighlight);
            mainFormVSideB.Controls.Add(button1);
            mainFormVSideB.Controls.Add(btnRegisterPetOwner);
            mainFormVSideB.Controls.Add(btnVaccineReports);
            mainFormVSideB.Controls.Add(btnAddVaccineRecord);
            mainFormVSideB.Controls.Add(mainFormVButtonLO);
            mainFormVSideB.Controls.Add(btnVaccineRecords);
            mainFormVSideB.Controls.Add(btnAddPetProfile);
            mainFormVSideB.Controls.Add(btnPetProfiles);
            mainFormVSideB.Controls.Add(btnHome);
            mainFormVSideB.Controls.Add(mainFormVPB);
            mainFormVSideB.Dock = DockStyle.Left;
            mainFormVSideB.Location = new Point(0, 50);
            mainFormVSideB.Name = "mainFormVSideB";
            mainFormVSideB.Size = new Size(200, 590);
            mainFormVSideB.TabIndex = 3;
            // 
            // mainFormVSideBHighlight
            // 
            mainFormVSideBHighlight.BackColor = Color.FromArgb(168, 130, 95);
            mainFormVSideBHighlight.Location = new Point(0, 145);
            mainFormVSideBHighlight.Name = "mainFormVSideBHighlight";
            mainFormVSideBHighlight.Size = new Size(10, 45);
            mainFormVSideBHighlight.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(89, 85, 84);
            button1.Location = new Point(0, 460);
            button1.Name = "button1";
            button1.Size = new Size(200, 45);
            button1.TabIndex = 9;
            button1.Text = "        About Us";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPetOwner
            // 
            btnRegisterPetOwner.Dock = DockStyle.Top;
            btnRegisterPetOwner.FlatAppearance.BorderSize = 0;
            btnRegisterPetOwner.FlatStyle = FlatStyle.Flat;
            btnRegisterPetOwner.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterPetOwner.ForeColor = Color.FromArgb(89, 85, 84);
            btnRegisterPetOwner.Location = new Point(0, 415);
            btnRegisterPetOwner.Name = "btnRegisterPetOwner";
            btnRegisterPetOwner.Size = new Size(200, 45);
            btnRegisterPetOwner.TabIndex = 8;
            btnRegisterPetOwner.Text = "        Register Pet Owner";
            btnRegisterPetOwner.TextAlign = ContentAlignment.MiddleLeft;
            btnRegisterPetOwner.UseVisualStyleBackColor = true;
            btnRegisterPetOwner.Click += btnRegisterPetOwner_Click;
            // 
            // btnVaccineReports
            // 
            btnVaccineReports.Dock = DockStyle.Top;
            btnVaccineReports.FlatAppearance.BorderSize = 0;
            btnVaccineReports.FlatStyle = FlatStyle.Flat;
            btnVaccineReports.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVaccineReports.ForeColor = Color.FromArgb(89, 85, 84);
            btnVaccineReports.Location = new Point(0, 370);
            btnVaccineReports.Name = "btnVaccineReports";
            btnVaccineReports.Size = new Size(200, 45);
            btnVaccineReports.TabIndex = 7;
            btnVaccineReports.Text = "        Vaccine Reports";
            btnVaccineReports.TextAlign = ContentAlignment.MiddleLeft;
            btnVaccineReports.UseVisualStyleBackColor = true;
            btnVaccineReports.Click += btnVaccineReports_Click;
            // 
            // btnAddVaccineRecord
            // 
            btnAddVaccineRecord.Dock = DockStyle.Top;
            btnAddVaccineRecord.FlatAppearance.BorderSize = 0;
            btnAddVaccineRecord.FlatStyle = FlatStyle.Flat;
            btnAddVaccineRecord.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddVaccineRecord.ForeColor = Color.FromArgb(89, 85, 84);
            btnAddVaccineRecord.Location = new Point(0, 325);
            btnAddVaccineRecord.Name = "btnAddVaccineRecord";
            btnAddVaccineRecord.Size = new Size(200, 45);
            btnAddVaccineRecord.TabIndex = 6;
            btnAddVaccineRecord.Text = "        Add Vaccine Record";
            btnAddVaccineRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnAddVaccineRecord.UseVisualStyleBackColor = true;
            btnAddVaccineRecord.Click += btnAddVaccineRecord_Click;
            // 
            // mainFormVButtonLO
            // 
            mainFormVButtonLO.BackColor = Color.FromArgb(63, 59, 58);
            mainFormVButtonLO.BorderColor = Color.FromArgb(220, 223, 230);
            mainFormVButtonLO.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            mainFormVButtonLO.DangerColor = Color.FromArgb(245, 108, 108);
            mainFormVButtonLO.DefaultColor = Color.FromArgb(255, 255, 255);
            mainFormVButtonLO.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormVButtonLO.HoverTextColor = Color.White;
            mainFormVButtonLO.InfoColor = Color.FromArgb(144, 147, 153);
            mainFormVButtonLO.Location = new Point(38, 532);
            mainFormVButtonLO.Name = "mainFormVButtonLO";
            mainFormVButtonLO.PrimaryColor = Color.FromArgb(63, 59, 58);
            mainFormVButtonLO.Size = new Size(125, 40);
            mainFormVButtonLO.SuccessColor = Color.FromArgb(103, 194, 58);
            mainFormVButtonLO.TabIndex = 5;
            mainFormVButtonLO.Text = "Log Out";
            mainFormVButtonLO.TextColor = Color.White;
            mainFormVButtonLO.WarningColor = Color.FromArgb(230, 162, 60);
            mainFormVButtonLO.Click += mainFormVButtonLO_Click;
            // 
            // btnVaccineRecords
            // 
            btnVaccineRecords.Dock = DockStyle.Top;
            btnVaccineRecords.FlatAppearance.BorderSize = 0;
            btnVaccineRecords.FlatStyle = FlatStyle.Flat;
            btnVaccineRecords.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVaccineRecords.ForeColor = Color.FromArgb(89, 85, 84);
            btnVaccineRecords.Location = new Point(0, 280);
            btnVaccineRecords.Name = "btnVaccineRecords";
            btnVaccineRecords.Size = new Size(200, 45);
            btnVaccineRecords.TabIndex = 4;
            btnVaccineRecords.Text = "        Vaccine Records";
            btnVaccineRecords.TextAlign = ContentAlignment.MiddleLeft;
            btnVaccineRecords.UseVisualStyleBackColor = true;
            btnVaccineRecords.Click += btnVaccineRecords_Click;
            // 
            // btnAddPetProfile
            // 
            btnAddPetProfile.Dock = DockStyle.Top;
            btnAddPetProfile.FlatAppearance.BorderSize = 0;
            btnAddPetProfile.FlatStyle = FlatStyle.Flat;
            btnAddPetProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPetProfile.ForeColor = Color.FromArgb(89, 85, 84);
            btnAddPetProfile.Location = new Point(0, 235);
            btnAddPetProfile.Name = "btnAddPetProfile";
            btnAddPetProfile.Size = new Size(200, 45);
            btnAddPetProfile.TabIndex = 3;
            btnAddPetProfile.Text = "        Add Pet Profile";
            btnAddPetProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnAddPetProfile.UseVisualStyleBackColor = true;
            btnAddPetProfile.Click += btnAddPetProfile_Click;
            // 
            // btnPetProfiles
            // 
            btnPetProfiles.Dock = DockStyle.Top;
            btnPetProfiles.FlatAppearance.BorderSize = 0;
            btnPetProfiles.FlatStyle = FlatStyle.Flat;
            btnPetProfiles.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPetProfiles.ForeColor = Color.FromArgb(89, 85, 84);
            btnPetProfiles.Location = new Point(0, 190);
            btnPetProfiles.Name = "btnPetProfiles";
            btnPetProfiles.Size = new Size(200, 45);
            btnPetProfiles.TabIndex = 2;
            btnPetProfiles.Text = "        Pet Profiles";
            btnPetProfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnPetProfiles.UseVisualStyleBackColor = true;
            btnPetProfiles.Click += btnPetProfiles_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(89, 85, 84);
            btnHome.Location = new Point(0, 145);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 45);
            btnHome.TabIndex = 1;
            btnHome.Text = "        Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // mainFormVPB
            // 
            mainFormVPB.Controls.Add(pictureBox1);
            mainFormVPB.Dock = DockStyle.Top;
            mainFormVPB.Location = new Point(0, 0);
            mainFormVPB.Name = "mainFormVPB";
            mainFormVPB.Size = new Size(200, 145);
            mainFormVPB.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(registerPetOwnerPanel1);
            panel1.Controls.Add(vaccineRecordsPanelVet1);
            panel1.Controls.Add(pet_Reports1);
            panel1.Controls.Add(tablePetRecords1);
            panel1.Controls.Add(petProfilePanelVet1);
            panel1.Controls.Add(tablePetProfile1);
            panel1.Controls.Add(homePanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 590);
            panel1.TabIndex = 4;
            // 
            // registerPetOwnerPanel1
            // 
            registerPetOwnerPanel1.BackColor = Color.White;
            registerPetOwnerPanel1.Dock = DockStyle.Fill;
            registerPetOwnerPanel1.Location = new Point(0, 0);
            registerPetOwnerPanel1.Name = "registerPetOwnerPanel1";
            registerPetOwnerPanel1.Size = new Size(800, 590);
            registerPetOwnerPanel1.TabIndex = 6;
            // 
            // vaccineRecordsPanelVet1
            // 
            vaccineRecordsPanelVet1.BackColor = Color.White;
            vaccineRecordsPanelVet1.Dock = DockStyle.Fill;
            vaccineRecordsPanelVet1.Location = new Point(0, 0);
            vaccineRecordsPanelVet1.Name = "vaccineRecordsPanelVet1";
            vaccineRecordsPanelVet1.Size = new Size(800, 590);
            vaccineRecordsPanelVet1.TabIndex = 5;
            // 
            // pet_Reports1
            // 
            pet_Reports1.BackColor = Color.White;
            pet_Reports1.Dock = DockStyle.Fill;
            pet_Reports1.Location = new Point(0, 0);
            pet_Reports1.Name = "pet_Reports1";
            pet_Reports1.Size = new Size(800, 590);
            pet_Reports1.TabIndex = 4;
            // 
            // tablePetRecords1
            // 
            tablePetRecords1.BackColor = Color.White;
            tablePetRecords1.Dock = DockStyle.Fill;
            tablePetRecords1.Location = new Point(0, 0);
            tablePetRecords1.Name = "tablePetRecords1";
            tablePetRecords1.Size = new Size(800, 590);
            tablePetRecords1.TabIndex = 3;
            // 
            // petProfilePanelVet1
            // 
            petProfilePanelVet1.BackColor = Color.White;
            petProfilePanelVet1.Dock = DockStyle.Fill;
            petProfilePanelVet1.Location = new Point(0, 0);
            petProfilePanelVet1.Name = "petProfilePanelVet1";
            petProfilePanelVet1.Size = new Size(800, 590);
            petProfilePanelVet1.TabIndex = 2;
            petProfilePanelVet1.Click += btnAddPetProfile_Click;
            // 
            // tablePetProfile1
            // 
            tablePetProfile1.BackColor = Color.White;
            tablePetProfile1.Dock = DockStyle.Fill;
            tablePetProfile1.Location = new Point(0, 0);
            tablePetProfile1.Name = "tablePetProfile1";
            tablePetProfile1.Size = new Size(800, 590);
            tablePetProfile1.TabIndex = 1;
            tablePetProfile1.Click += btnPetProfiles_Click;
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
            // MainFormVet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 640);
            Controls.Add(panel1);
            Controls.Add(mainFormVSideB);
            Controls.Add(mainFormVTopB);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 640);
            Name = "MainFormVet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainFormVet";
            Load += MainFormVet_Load;
            mainFormVTopB.ResumeLayout(false);
            mainFormVTopB.PerformLayout();
            mainFormVSideB.ResumeLayout(false);
            mainFormVPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainFormVTopB;
        private Button mainFormVButtonAlerts;
        private Button mainFormVButtonSettings;
        private Button mainFormVButtonExit;
        private Panel mainFormVSideB;
        private Panel mainFormVSideBHighlight;
        private Button btnAddVaccineRecord;
        private ReaLTaiizor.Controls.HopeRoundButton mainFormVButtonLO;
        private Button btnVaccineRecords;
        private Button btnAddPetProfile;
        private Button btnPetProfiles;
        private Button btnHome;
        private Panel mainFormVPB;
        private PictureBox pictureBox1;
        private HomeUserControl homeUserControl1V;
        private Label lblVetName;
        private Label label1;
        private Button btnVaccineReports;
        private Label lblClinic;
        private Label label2;
        private Button btnRegisterPetOwner;
        private Panel panel1;
        private TablePetProfile tablePetProfile1;
        private homePanel homePanel1;
        private petProfilePanelVet petProfilePanelVet1;
        private Pet_Reports pet_Reports1;
        private TablePetRecords tablePetRecords1;
        private VaccineRecordsPanelVet vaccineRecordsPanelVet1;
        private registerPetOwnerPanel registerPetOwnerPanel1;
        private Button button1;
    }
}