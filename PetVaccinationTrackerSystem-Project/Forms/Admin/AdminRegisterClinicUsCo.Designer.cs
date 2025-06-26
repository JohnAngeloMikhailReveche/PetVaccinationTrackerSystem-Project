namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class AdminRegisterClinicUsCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegisterClinicUsCo));
            txtboxZipCode = new TextBox();
            txtboxState = new TextBox();
            txtboxCity = new TextBox();
            txtboxStreet = new TextBox();
            txtboxClinicName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label7 = new Label();
            label14 = new Label();
            registerPORegisterPanel = new Panel();
            btnRegisterClinic = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            registerPORegisterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // txtboxZipCode
            // 
            txtboxZipCode.Font = new Font("Segoe UI", 10F);
            txtboxZipCode.Location = new Point(192, 211);
            txtboxZipCode.Name = "txtboxZipCode";
            txtboxZipCode.Size = new Size(113, 25);
            txtboxZipCode.TabIndex = 1;
            // 
            // txtboxState
            // 
            txtboxState.Font = new Font("Segoe UI", 10F);
            txtboxState.Location = new Point(13, 211);
            txtboxState.Name = "txtboxState";
            txtboxState.Size = new Size(164, 25);
            txtboxState.TabIndex = 1;
            // 
            // txtboxCity
            // 
            txtboxCity.Font = new Font("Segoe UI", 10F);
            txtboxCity.Location = new Point(13, 150);
            txtboxCity.Name = "txtboxCity";
            txtboxCity.Size = new Size(292, 25);
            txtboxCity.TabIndex = 1;
            // 
            // txtboxStreet
            // 
            txtboxStreet.Font = new Font("Segoe UI", 10F);
            txtboxStreet.Location = new Point(13, 89);
            txtboxStreet.Name = "txtboxStreet";
            txtboxStreet.Size = new Size(292, 25);
            txtboxStreet.TabIndex = 1;
            // 
            // txtboxClinicName
            // 
            txtboxClinicName.Font = new Font("Segoe UI", 10F);
            txtboxClinicName.Location = new Point(13, 33);
            txtboxClinicName.Name = "txtboxClinicName";
            txtboxClinicName.Size = new Size(292, 25);
            txtboxClinicName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(89, 85, 84);
            label5.Location = new Point(192, 189);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 0;
            label5.Text = "Zip Code:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(89, 85, 84);
            label4.Location = new Point(13, 189);
            label4.Name = "label4";
            label4.Size = new Size(43, 19);
            label4.TabIndex = 0;
            label4.Text = "State:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(13, 128);
            label3.Name = "label3";
            label3.Size = new Size(36, 19);
            label3.TabIndex = 0;
            label3.Text = "City:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(13, 67);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 0;
            label2.Text = "Street:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 0;
            label1.Text = "Clinic Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(232, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 249, 249);
            panel1.Controls.Add(btnRegisterClinic);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(registerPORegisterPanel);
            panel1.Location = new Point(226, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 375);
            panel1.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(89, 85, 84);
            label7.Location = new Point(19, 30);
            label7.Name = "label7";
            label7.Size = new Size(305, 19);
            label7.TabIndex = 25;
            label7.Text = "Please provide valid veterinary clinic information.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(89, 85, 84);
            label14.Location = new Point(19, 8);
            label14.Name = "label14";
            label14.Size = new Size(110, 21);
            label14.TabIndex = 2;
            label14.Text = "Clinic Details";
            // 
            // registerPORegisterPanel
            // 
            registerPORegisterPanel.BackColor = Color.White;
            registerPORegisterPanel.Controls.Add(txtboxClinicName);
            registerPORegisterPanel.Controls.Add(txtboxZipCode);
            registerPORegisterPanel.Controls.Add(label1);
            registerPORegisterPanel.Controls.Add(txtboxState);
            registerPORegisterPanel.Controls.Add(label2);
            registerPORegisterPanel.Controls.Add(label5);
            registerPORegisterPanel.Controls.Add(txtboxCity);
            registerPORegisterPanel.Controls.Add(label4);
            registerPORegisterPanel.Controls.Add(txtboxStreet);
            registerPORegisterPanel.Controls.Add(label3);
            registerPORegisterPanel.Location = new Point(23, 58);
            registerPORegisterPanel.Name = "registerPORegisterPanel";
            registerPORegisterPanel.Size = new Size(316, 255);
            registerPORegisterPanel.TabIndex = 19;
            // 
            // btnRegisterClinic
            // 
            btnRegisterClinic.BackColor = Color.FromArgb(63, 59, 58);
            btnRegisterClinic.BorderColor = Color.FromArgb(220, 223, 230);
            btnRegisterClinic.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnRegisterClinic.DangerColor = Color.FromArgb(245, 108, 108);
            btnRegisterClinic.DefaultColor = Color.FromArgb(255, 255, 255);
            btnRegisterClinic.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterClinic.ForeColor = Color.White;
            btnRegisterClinic.HoverTextColor = Color.White;
            btnRegisterClinic.InfoColor = Color.FromArgb(144, 147, 153);
            btnRegisterClinic.Location = new Point(219, 323);
            btnRegisterClinic.Name = "btnRegisterClinic";
            btnRegisterClinic.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnRegisterClinic.Size = new Size(120, 40);
            btnRegisterClinic.SuccessColor = Color.FromArgb(103, 194, 58);
            btnRegisterClinic.TabIndex = 26;
            btnRegisterClinic.Text = "Register";
            btnRegisterClinic.TextColor = Color.White;
            btnRegisterClinic.WarningColor = Color.FromArgb(230, 162, 60);
            btnRegisterClinic.Click += btnRegisterClinic_Click;
            // 
            // AdminRegisterClinicUsCo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AdminRegisterClinicUsCo";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            registerPORegisterPanel.ResumeLayout(false);
            registerPORegisterPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtboxClinicName;
        private Label label1;
        private TextBox txtboxZipCode;
        private TextBox txtboxState;
        private TextBox txtboxCity;
        private TextBox txtboxStreet;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label7;
        private Label label14;
        private Panel registerPORegisterPanel;
        private ReaLTaiizor.Controls.HopeRoundButton btnRegisterClinic;
    }
}
