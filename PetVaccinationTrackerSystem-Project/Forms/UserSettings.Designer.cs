namespace PetVaccinationTrackerSystem_Project.Forms
{
    partial class UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            groupBox1 = new GroupBox();
            btnSave = new ReaLTaiizor.Controls.HopeRoundButton();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCurrPassword = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnRequestAccDelete = new ReaLTaiizor.Controls.HopeRoundButton();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnChangePass = new ReaLTaiizor.Controls.HopeRoundButton();
            txtNewPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            mainFormVButtonExit = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.ForeColor = Color.FromArgb(89, 85, 84);
            groupBox1.Location = new Point(30, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(63, 59, 58);
            btnSave.BorderColor = Color.FromArgb(220, 223, 230);
            btnSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.HoverTextColor = Color.White;
            btnSave.InfoColor = Color.FromArgb(144, 147, 153);
            btnSave.Location = new Point(96, 160);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnSave.Size = new Size(100, 35);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            btnSave.Click += btnSave_Click;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.Location = new Point(17, 117);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(261, 25);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.Location = new Point(17, 54);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(261, 25);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 95);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 0;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // txtCurrPassword
            // 
            txtCurrPassword.BackColor = Color.White;
            txtCurrPassword.Location = new Point(17, 87);
            txtCurrPassword.Name = "txtCurrPassword";
            txtCurrPassword.Size = new Size(290, 25);
            txtCurrPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 65);
            label3.Name = "label3";
            label3.Size = new Size(121, 19);
            label3.TabIndex = 0;
            label3.Text = "Current Password:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRequestAccDelete);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.ForeColor = Color.FromArgb(89, 85, 84);
            groupBox2.Location = new Point(30, 322);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 135);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account Deletion";
            // 
            // btnRequestAccDelete
            // 
            btnRequestAccDelete.BackColor = Color.FromArgb(63, 59, 58);
            btnRequestAccDelete.BorderColor = Color.FromArgb(220, 223, 230);
            btnRequestAccDelete.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnRequestAccDelete.DangerColor = Color.FromArgb(245, 108, 108);
            btnRequestAccDelete.DefaultColor = Color.FromArgb(255, 255, 255);
            btnRequestAccDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequestAccDelete.HoverTextColor = Color.White;
            btnRequestAccDelete.InfoColor = Color.FromArgb(144, 147, 153);
            btnRequestAccDelete.Location = new Point(59, 82);
            btnRequestAccDelete.Name = "btnRequestAccDelete";
            btnRequestAccDelete.PrimaryColor = Color.FromArgb(69, 0, 0);
            btnRequestAccDelete.Size = new Size(170, 35);
            btnRequestAccDelete.SuccessColor = Color.FromArgb(103, 194, 58);
            btnRequestAccDelete.TabIndex = 19;
            btnRequestAccDelete.Text = "Request Deletion";
            btnRequestAccDelete.TextColor = Color.White;
            btnRequestAccDelete.WarningColor = Color.FromArgb(230, 162, 60);
            btnRequestAccDelete.Click += btnRequestAccDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 28);
            label4.Name = "label4";
            label4.Size = new Size(249, 38);
            label4.TabIndex = 0;
            label4.Text = "You can request to delete your account\r\nalong with the pet records.\r\n";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnChangePass);
            groupBox3.Controls.Add(txtNewPassword);
            groupBox3.Controls.Add(txtCurrPassword);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI", 10F);
            groupBox3.ForeColor = Color.FromArgb(89, 85, 84);
            groupBox3.Location = new Point(343, 95);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(324, 245);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account Details";
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(63, 59, 58);
            btnChangePass.BorderColor = Color.FromArgb(220, 223, 230);
            btnChangePass.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnChangePass.DangerColor = Color.FromArgb(245, 108, 108);
            btnChangePass.DefaultColor = Color.FromArgb(255, 255, 255);
            btnChangePass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePass.HoverTextColor = Color.White;
            btnChangePass.InfoColor = Color.FromArgb(144, 147, 153);
            btnChangePass.Location = new Point(75, 192);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnChangePass.Size = new Size(175, 35);
            btnChangePass.SuccessColor = Color.FromArgb(103, 194, 58);
            btnChangePass.TabIndex = 18;
            btnChangePass.Text = "Change Password";
            btnChangePass.TextColor = Color.White;
            btnChangePass.WarningColor = Color.FromArgb(230, 162, 60);
            btnChangePass.Click += btnChangePass_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.White;
            txtNewPassword.Location = new Point(17, 150);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(290, 25);
            txtNewPassword.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 128);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 0;
            label5.Text = "New Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 30);
            label6.Name = "label6";
            label6.Size = new Size(272, 19);
            label6.TabIndex = 0;
            label6.Text = "You can change your password by filling in:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 59, 58);
            panel1.Controls.Add(mainFormVButtonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 30);
            panel1.TabIndex = 3;
            // 
            // mainFormVButtonExit
            // 
            mainFormVButtonExit.BackColor = Color.FromArgb(63, 59, 58);
            mainFormVButtonExit.BackgroundImage = (Image)resources.GetObject("mainFormVButtonExit.BackgroundImage");
            mainFormVButtonExit.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormVButtonExit.FlatAppearance.BorderSize = 0;
            mainFormVButtonExit.FlatStyle = FlatStyle.Flat;
            mainFormVButtonExit.Location = new Point(675, 7);
            mainFormVButtonExit.Name = "mainFormVButtonExit";
            mainFormVButtonExit.Size = new Size(15, 15);
            mainFormVButtonExit.TabIndex = 14;
            mainFormVButtonExit.UseVisualStyleBackColor = false;
            mainFormVButtonExit.Click += mainFormVButtonExit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(89, 85, 84);
            label7.Location = new Point(27, 45);
            label7.Name = "label7";
            label7.Size = new Size(106, 32);
            label7.TabIndex = 15;
            label7.Text = "Settings";
            // 
            // UserSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 485);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += UserSettings_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCurrPassword;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txtNewPassword;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Button mainFormVButtonExit;
        private Label label7;
        private ReaLTaiizor.Controls.HopeRoundButton btnSave;
        private ReaLTaiizor.Controls.HopeRoundButton btnChangePass;
        private ReaLTaiizor.Controls.HopeRoundButton btnRequestAccDelete;
    }
}