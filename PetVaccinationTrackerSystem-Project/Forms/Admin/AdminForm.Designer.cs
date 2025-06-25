namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            mainFormVTopB = new Panel();
            mainFormVButtonSettings = new Button();
            mainFormVButtonExit = new Button();
            mainFormVSideB = new Panel();
            mainFormVSideBHighlight = new Panel();
            mainFormVButtonLO = new ReaLTaiizor.Controls.HopeRoundButton();
            btnRegisterVet = new Button();
            btnRegisterClinic = new Button();
            btnVeterinarianList = new Button();
            btnClinicList = new Button();
            mainFormVButtonHome = new Button();
            mainFormVPB = new Panel();
            pictureBox1 = new PictureBox();
            adminRegisterClinicUsCo1V = new AdminRegisterClinicUsCo();
            adminRegisterVetUsCo1V = new AdminRegisterVetUsCo();
            homeUserControl1V = new HomeUserControl();
            registeredClinicPanel1V = new RegisteredClinicPanel();
            registeredVetPanel1V = new RegisteredVetPanel();
            mainFormVTopB.SuspendLayout();
            mainFormVSideB.SuspendLayout();
            mainFormVPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainFormVTopB
            // 
            mainFormVTopB.BackColor = Color.FromArgb(89, 85, 84);
            mainFormVTopB.Controls.Add(mainFormVButtonSettings);
            mainFormVTopB.Controls.Add(mainFormVButtonExit);
            mainFormVTopB.Dock = DockStyle.Top;
            mainFormVTopB.Location = new Point(0, 0);
            mainFormVTopB.Name = "mainFormVTopB";
            mainFormVTopB.Size = new Size(1000, 50);
            mainFormVTopB.TabIndex = 3;
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
            mainFormVButtonSettings.Click += mainFormVButtonSettings_Click;
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
            mainFormVSideB.BackColor = Color.White;
            mainFormVSideB.Controls.Add(mainFormVSideBHighlight);
            mainFormVSideB.Controls.Add(mainFormVButtonLO);
            mainFormVSideB.Controls.Add(btnRegisterVet);
            mainFormVSideB.Controls.Add(btnRegisterClinic);
            mainFormVSideB.Controls.Add(btnVeterinarianList);
            mainFormVSideB.Controls.Add(btnClinicList);
            mainFormVSideB.Controls.Add(mainFormVButtonHome);
            mainFormVSideB.Controls.Add(mainFormVPB);
            mainFormVSideB.Dock = DockStyle.Left;
            mainFormVSideB.Location = new Point(0, 50);
            mainFormVSideB.Name = "mainFormVSideB";
            mainFormVSideB.Size = new Size(200, 590);
            mainFormVSideB.TabIndex = 4;
            // 
            // mainFormVSideBHighlight
            // 
            mainFormVSideBHighlight.BackColor = Color.FromArgb(168, 130, 95);
            mainFormVSideBHighlight.Location = new Point(0, 150);
            mainFormVSideBHighlight.Name = "mainFormVSideBHighlight";
            mainFormVSideBHighlight.Size = new Size(10, 50);
            mainFormVSideBHighlight.TabIndex = 2;
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
            // btnRegisterVet
            // 
            btnRegisterVet.Dock = DockStyle.Top;
            btnRegisterVet.FlatAppearance.BorderSize = 0;
            btnRegisterVet.FlatStyle = FlatStyle.Flat;
            btnRegisterVet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterVet.ForeColor = Color.FromArgb(89, 85, 84);
            btnRegisterVet.Location = new Point(0, 350);
            btnRegisterVet.Name = "btnRegisterVet";
            btnRegisterVet.Size = new Size(200, 50);
            btnRegisterVet.TabIndex = 6;
            btnRegisterVet.Text = "     Register Veterinarian";
            btnRegisterVet.TextAlign = ContentAlignment.MiddleLeft;
            btnRegisterVet.UseVisualStyleBackColor = true;
            btnRegisterVet.Click += mainFormVButtonRegister_Click;
            // 
            // btnRegisterClinic
            // 
            btnRegisterClinic.Dock = DockStyle.Top;
            btnRegisterClinic.FlatAppearance.BorderSize = 0;
            btnRegisterClinic.FlatStyle = FlatStyle.Flat;
            btnRegisterClinic.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterClinic.ForeColor = Color.FromArgb(89, 85, 84);
            btnRegisterClinic.Location = new Point(0, 300);
            btnRegisterClinic.Name = "btnRegisterClinic";
            btnRegisterClinic.Size = new Size(200, 50);
            btnRegisterClinic.TabIndex = 7;
            btnRegisterClinic.Text = "     Register Clinic";
            btnRegisterClinic.TextAlign = ContentAlignment.MiddleLeft;
            btnRegisterClinic.UseVisualStyleBackColor = true;
            btnRegisterClinic.Click += btnRegisterClinic_Click;
            // 
            // btnVeterinarianList
            // 
            btnVeterinarianList.Dock = DockStyle.Top;
            btnVeterinarianList.FlatAppearance.BorderSize = 0;
            btnVeterinarianList.FlatStyle = FlatStyle.Flat;
            btnVeterinarianList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVeterinarianList.ForeColor = Color.FromArgb(89, 85, 84);
            btnVeterinarianList.Location = new Point(0, 250);
            btnVeterinarianList.Name = "btnVeterinarianList";
            btnVeterinarianList.Size = new Size(200, 50);
            btnVeterinarianList.TabIndex = 8;
            btnVeterinarianList.Text = "     Veterinarian List";
            btnVeterinarianList.TextAlign = ContentAlignment.MiddleLeft;
            btnVeterinarianList.UseVisualStyleBackColor = true;
            btnVeterinarianList.Click += btnVeterinarianList_Click;
            // 
            // btnClinicList
            // 
            btnClinicList.Dock = DockStyle.Top;
            btnClinicList.FlatAppearance.BorderSize = 0;
            btnClinicList.FlatStyle = FlatStyle.Flat;
            btnClinicList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClinicList.ForeColor = Color.FromArgb(89, 85, 84);
            btnClinicList.Location = new Point(0, 200);
            btnClinicList.Name = "btnClinicList";
            btnClinicList.Size = new Size(200, 50);
            btnClinicList.TabIndex = 9;
            btnClinicList.Text = "     Clinic List";
            btnClinicList.TextAlign = ContentAlignment.MiddleLeft;
            btnClinicList.UseVisualStyleBackColor = true;
            btnClinicList.Click += btnClinicList_Click;
            // 
            // mainFormVButtonHome
            // 
            mainFormVButtonHome.Dock = DockStyle.Top;
            mainFormVButtonHome.FlatAppearance.BorderSize = 0;
            mainFormVButtonHome.FlatStyle = FlatStyle.Flat;
            mainFormVButtonHome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormVButtonHome.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormVButtonHome.Location = new Point(0, 150);
            mainFormVButtonHome.Name = "mainFormVButtonHome";
            mainFormVButtonHome.Size = new Size(200, 50);
            mainFormVButtonHome.TabIndex = 1;
            mainFormVButtonHome.Text = "     Home";
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
            mainFormVPB.Size = new Size(200, 150);
            mainFormVPB.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // adminRegisterClinicUsCo1V
            // 
            adminRegisterClinicUsCo1V.BackColor = Color.White;
            adminRegisterClinicUsCo1V.Location = new Point(200, 50);
            adminRegisterClinicUsCo1V.Name = "adminRegisterClinicUsCo1V";
            adminRegisterClinicUsCo1V.Size = new Size(800, 590);
            adminRegisterClinicUsCo1V.TabIndex = 6;
            // 
            // adminRegisterVetUsCo1V
            // 
            adminRegisterVetUsCo1V.BackColor = Color.White;
            adminRegisterVetUsCo1V.Location = new Point(200, 50);
            adminRegisterVetUsCo1V.Name = "adminRegisterVetUsCo1V";
            adminRegisterVetUsCo1V.Size = new Size(800, 590);
            adminRegisterVetUsCo1V.TabIndex = 7;
            adminRegisterVetUsCo1V.Load += adminRegisterVetUsCo1V_Load;
            // 
            // homeUserControl1V
            // 
            homeUserControl1V.BackColor = Color.White;
            homeUserControl1V.Location = new Point(200, 50);
            homeUserControl1V.Name = "homeUserControl1V";
            homeUserControl1V.Size = new Size(800, 590);
            homeUserControl1V.TabIndex = 8;
            // 
            // registeredClinicPanel1V
            // 
            registeredClinicPanel1V.BackColor = Color.White;
            registeredClinicPanel1V.Location = new Point(200, 50);
            registeredClinicPanel1V.Name = "registeredClinicPanel1V";
            registeredClinicPanel1V.Size = new Size(800, 590);
            registeredClinicPanel1V.TabIndex = 9;
            // 
            // registeredVetPanel1V
            // 
            registeredVetPanel1V.BackColor = Color.White;
            registeredVetPanel1V.Location = new Point(200, 50);
            registeredVetPanel1V.Name = "registeredVetPanel1V";
            registeredVetPanel1V.Size = new Size(800, 590);
            registeredVetPanel1V.TabIndex = 10;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 640);
            Controls.Add(registeredVetPanel1V);
            Controls.Add(registeredClinicPanel1V);
            Controls.Add(homeUserControl1V);
            Controls.Add(adminRegisterVetUsCo1V);
            Controls.Add(adminRegisterClinicUsCo1V);
            Controls.Add(mainFormVSideB);
            Controls.Add(mainFormVTopB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            mainFormVTopB.ResumeLayout(false);
            mainFormVSideB.ResumeLayout(false);
            mainFormVPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainFormVTopB;
        private Button mainFormVButtonSettings;
        private Button mainFormVButtonExit;
        private Panel mainFormVSideB;
        private Panel mainFormVSideBHighlight;
        private Button btnRegisterVet;
        private ReaLTaiizor.Controls.HopeRoundButton mainFormVButtonLO;
        private Button mainFormVButtonHome;
        private Panel mainFormVPB;
        private PictureBox pictureBox1;
        private Button btnRegisterClinic;
        private AdminRegisterClinicUsCo adminRegisterClinicUsCo1V;
        private AdminRegisterVetUsCo adminRegisterVetUsCo1V;
        private HomeUserControl homeUserControl1V;
        private Button btnVeterinarianList;
        private Button btnClinicList;
        private RegisteredClinicPanel registeredClinicPanel1V;
        private RegisteredVetPanel registeredVetPanel1V;
    }
}