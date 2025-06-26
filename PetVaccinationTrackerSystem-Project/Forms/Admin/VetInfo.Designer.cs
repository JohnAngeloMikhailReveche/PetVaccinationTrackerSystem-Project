namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class VetInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VetInfo));
            cmbboxClinic = new ComboBox();
            txtboxLicenseNo = new TextBox();
            txtboxFirstName = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtboxLastName = new TextBox();
            label4 = new Label();
            txtboxAccountEmail = new TextBox();
            mainFormVButtonExit = new Button();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            btnUpdate = new ReaLTaiizor.Controls.HopeRoundButton();
            btnDelete = new ReaLTaiizor.Controls.HopeRoundButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbboxClinic
            // 
            cmbboxClinic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxClinic.Font = new Font("Segoe UI", 10F);
            cmbboxClinic.FormattingEnabled = true;
            cmbboxClinic.Location = new Point(20, 281);
            cmbboxClinic.Name = "cmbboxClinic";
            cmbboxClinic.Size = new Size(300, 25);
            cmbboxClinic.TabIndex = 9;
            // 
            // txtboxLicenseNo
            // 
            txtboxLicenseNo.Font = new Font("Segoe UI", 10F);
            txtboxLicenseNo.Location = new Point(20, 216);
            txtboxLicenseNo.Name = "txtboxLicenseNo";
            txtboxLicenseNo.Size = new Size(300, 25);
            txtboxLicenseNo.TabIndex = 7;
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Font = new Font("Segoe UI", 10F);
            txtboxFirstName.Location = new Point(20, 85);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(300, 25);
            txtboxFirstName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(89, 85, 84);
            label5.Location = new Point(20, 259);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 4;
            label5.Text = "Clinic Site:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(20, 194);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 5;
            label2.Text = "License Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(20, 63);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 6;
            label1.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(20, 129);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 6;
            label3.Text = "Last Name:";
            // 
            // txtboxLastName
            // 
            txtboxLastName.Font = new Font("Segoe UI", 10F);
            txtboxLastName.Location = new Point(20, 151);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(300, 25);
            txtboxLastName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(89, 85, 84);
            label4.Location = new Point(20, 323);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 6;
            label4.Text = "Account Email:";
            // 
            // txtboxAccountEmail
            // 
            txtboxAccountEmail.Font = new Font("Segoe UI", 10F);
            txtboxAccountEmail.Location = new Point(20, 345);
            txtboxAccountEmail.Name = "txtboxAccountEmail";
            txtboxAccountEmail.Size = new Size(300, 25);
            txtboxAccountEmail.TabIndex = 8;
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
            mainFormVButtonExit.TabIndex = 12;
            mainFormVButtonExit.UseVisualStyleBackColor = false;
            mainFormVButtonExit.Click += mainFormVButtonExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 59, 58);
            panel1.Controls.Add(mainFormVButtonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 30);
            panel1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(89, 85, 84);
            label6.Location = new Point(15, 11);
            label6.Name = "label6";
            label6.Size = new Size(238, 32);
            label6.TabIndex = 13;
            label6.Text = "Veterinarian Details";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtboxFirstName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtboxLastName);
            panel2.Controls.Add(txtboxAccountEmail);
            panel2.Controls.Add(cmbboxClinic);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtboxLicenseNo);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(30, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 390);
            panel2.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderColor = Color.FromArgb(220, 223, 230);
            btnUpdate.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnUpdate.DangerColor = Color.FromArgb(245, 108, 108);
            btnUpdate.DefaultColor = Color.FromArgb(255, 255, 255);
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.HoverTextColor = Color.White;
            btnUpdate.InfoColor = Color.FromArgb(144, 147, 153);
            btnUpdate.Location = new Point(70, 435);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.SuccessColor = Color.FromArgb(103, 194, 58);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.TextColor = Color.White;
            btnUpdate.WarningColor = Color.FromArgb(230, 162, 60);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderColor = Color.FromArgb(220, 223, 230);
            btnDelete.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDelete.DangerColor = Color.FromArgb(245, 108, 108);
            btnDelete.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.HoverTextColor = Color.White;
            btnDelete.InfoColor = Color.FromArgb(144, 147, 153);
            btnDelete.Location = new Point(210, 435);
            btnDelete.Name = "btnDelete";
            btnDelete.PrimaryColor = Color.FromArgb(69, 0, 0);
            btnDelete.Size = new Size(120, 40);
            btnDelete.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.White;
            btnDelete.WarningColor = Color.FromArgb(230, 162, 60);
            btnDelete.Click += btnDelete_Click;
            // 
            // VetInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 500);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VetInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VetInfo";
            Load += VetInfo_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbboxClinic;
        private TextBox txtboxLicenseNo;
        private TextBox txtboxFirstName;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtboxLastName;
        private Label label4;
        private TextBox txtboxAccountEmail;
        private Button mainFormVButtonExit;
        private Panel panel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.HopeRoundButton btnUpdate;
        private ReaLTaiizor.Controls.HopeRoundButton btnDelete;
        private Label label6;
    }
}