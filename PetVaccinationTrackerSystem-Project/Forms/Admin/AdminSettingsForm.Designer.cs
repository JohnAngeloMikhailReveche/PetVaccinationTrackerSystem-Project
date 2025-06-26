namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class AdminSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSettingsForm));
            label2 = new Label();
            txtboxUsername = new TextBox();
            label3 = new Label();
            txtboxPassword = new TextBox();
            panel1 = new Panel();
            mainFormVButtonExit = new Button();
            label6 = new Label();
            btnSaveChanges = new ReaLTaiizor.Controls.HopeRoundButton();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(16, 34);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Font = new Font("Segoe UI", 10F);
            txtboxUsername.Location = new Point(16, 56);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(300, 25);
            txtboxUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(16, 103);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            // 
            // txtboxPassword
            // 
            txtboxPassword.Font = new Font("Segoe UI", 10F);
            txtboxPassword.Location = new Point(16, 125);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(300, 25);
            txtboxPassword.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 59, 58);
            panel1.Controls.Add(mainFormVButtonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 30);
            panel1.TabIndex = 4;
            // 
            // mainFormVButtonExit
            // 
            mainFormVButtonExit.BackColor = Color.FromArgb(63, 59, 58);
            mainFormVButtonExit.BackgroundImage = (Image)resources.GetObject("mainFormVButtonExit.BackgroundImage");
            mainFormVButtonExit.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormVButtonExit.FlatAppearance.BorderSize = 0;
            mainFormVButtonExit.FlatStyle = FlatStyle.Flat;
            mainFormVButtonExit.Location = new Point(373, 7);
            mainFormVButtonExit.Name = "mainFormVButtonExit";
            mainFormVButtonExit.Size = new Size(15, 15);
            mainFormVButtonExit.TabIndex = 13;
            mainFormVButtonExit.UseVisualStyleBackColor = false;
            mainFormVButtonExit.Click += mainFormVButtonExit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(89, 85, 84);
            label6.Location = new Point(34, 45);
            label6.Name = "label6";
            label6.Size = new Size(106, 32);
            label6.TabIndex = 14;
            label6.Text = "Settings";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(63, 59, 58);
            btnSaveChanges.BorderColor = Color.FromArgb(220, 223, 230);
            btnSaveChanges.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSaveChanges.DangerColor = Color.FromArgb(245, 108, 108);
            btnSaveChanges.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSaveChanges.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.HoverTextColor = Color.White;
            btnSaveChanges.InfoColor = Color.FromArgb(144, 147, 153);
            btnSaveChanges.Location = new Point(105, 171);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnSaveChanges.Size = new Size(120, 40);
            btnSaveChanges.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSaveChanges.TabIndex = 16;
            btnSaveChanges.Text = "Update";
            btnSaveChanges.TextColor = Color.White;
            btnSaveChanges.WarningColor = Color.FromArgb(230, 162, 60);
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtboxUsername);
            groupBox1.Controls.Add(btnSaveChanges);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtboxPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.ForeColor = Color.FromArgb(89, 85, 84);
            groupBox1.Location = new Point(34, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 230);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // AdminSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 350);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSettingsForm";
            Load += AdminSettingsForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtboxUsername;
        private Label label3;
        private TextBox txtboxPassword;
        private Panel panel1;
        private Button mainFormVButtonExit;
        private Label label6;
        private ReaLTaiizor.Controls.HopeRoundButton btnSaveChanges;
        private GroupBox groupBox1;
    }
}