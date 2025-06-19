namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class AdminRegisterVetUsCo
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
            grpboxVet = new GroupBox();
            cmbboxClinic = new ComboBox();
            btnRegisterVet = new Button();
            txtboxAccountPassword = new TextBox();
            txtboxAccountUsername = new TextBox();
            txtboxLicenseNo = new TextBox();
            txtboxLastName = new TextBox();
            txtboxName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            grpboxVet.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxVet
            // 
            grpboxVet.Controls.Add(cmbboxClinic);
            grpboxVet.Controls.Add(btnRegisterVet);
            grpboxVet.Controls.Add(txtboxAccountPassword);
            grpboxVet.Controls.Add(txtboxAccountUsername);
            grpboxVet.Controls.Add(txtboxLicenseNo);
            grpboxVet.Controls.Add(txtboxLastName);
            grpboxVet.Controls.Add(txtboxName);
            grpboxVet.Controls.Add(label5);
            grpboxVet.Controls.Add(label4);
            grpboxVet.Controls.Add(label3);
            grpboxVet.Controls.Add(label2);
            grpboxVet.Controls.Add(label6);
            grpboxVet.Controls.Add(label1);
            grpboxVet.Font = new Font("Segoe UI", 20F);
            grpboxVet.Location = new Point(48, 25);
            grpboxVet.Name = "grpboxVet";
            grpboxVet.Size = new Size(704, 536);
            grpboxVet.TabIndex = 1;
            grpboxVet.TabStop = false;
            grpboxVet.Text = "Veterinarian";
            // 
            // cmbboxClinic
            // 
            cmbboxClinic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxClinic.FormattingEnabled = true;
            cmbboxClinic.Location = new Point(206, 376);
            cmbboxClinic.Name = "cmbboxClinic";
            cmbboxClinic.Size = new Size(471, 45);
            cmbboxClinic.TabIndex = 3;
            // 
            // btnRegisterVet
            // 
            btnRegisterVet.Location = new Point(206, 443);
            btnRegisterVet.Name = "btnRegisterVet";
            btnRegisterVet.Size = new Size(283, 58);
            btnRegisterVet.TabIndex = 2;
            btnRegisterVet.Text = "Register Veterinarian";
            btnRegisterVet.UseVisualStyleBackColor = true;
            btnRegisterVet.Click += btnRegisterVet_Click;
            // 
            // txtboxAccountPassword
            // 
            txtboxAccountPassword.Location = new Point(206, 288);
            txtboxAccountPassword.Name = "txtboxAccountPassword";
            txtboxAccountPassword.Size = new Size(471, 43);
            txtboxAccountPassword.TabIndex = 1;
            // 
            // txtboxAccountUsername
            // 
            txtboxAccountUsername.Location = new Point(206, 228);
            txtboxAccountUsername.Name = "txtboxAccountUsername";
            txtboxAccountUsername.Size = new Size(471, 43);
            txtboxAccountUsername.TabIndex = 1;
            // 
            // txtboxLicenseNo
            // 
            txtboxLicenseNo.Location = new Point(206, 168);
            txtboxLicenseNo.Name = "txtboxLicenseNo";
            txtboxLicenseNo.Size = new Size(471, 43);
            txtboxLicenseNo.TabIndex = 1;
            // 
            // txtboxLastName
            // 
            txtboxLastName.Location = new Point(206, 107);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(471, 43);
            txtboxLastName.TabIndex = 1;
            // 
            // txtboxName
            // 
            txtboxName.Location = new Point(206, 52);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(471, 43);
            txtboxName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 376);
            label5.Name = "label5";
            label5.Size = new Size(133, 37);
            label5.TabIndex = 0;
            label5.Text = "Clinic Site";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(28, 298);
            label4.Name = "label4";
            label4.Size = new Size(170, 28);
            label4.TabIndex = 0;
            label4.Text = "Account Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(22, 238);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 0;
            label3.Text = "Account Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(28, 178);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 0;
            label2.Text = "License Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 107);
            label6.Name = "label6";
            label6.Size = new Size(142, 37);
            label6.TabIndex = 0;
            label6.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 52);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // AdminRegisterVetUsCo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpboxVet);
            Name = "AdminRegisterVetUsCo";
            Size = new Size(800, 590);
            Load += AdminRegisterVetUsCo_Load;
            grpboxVet.ResumeLayout(false);
            grpboxVet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxVet;
        private Button btnRegisterVet;
        private TextBox txtboxLicenseNo;
        private TextBox txtboxName;
        private Label label5;
        private Label label2;
        private Label label1;
        private ComboBox cmbboxClinic;
        private TextBox txtboxAccountPassword;
        private TextBox txtboxAccountUsername;
        private Label label4;
        private Label label3;
        private TextBox txtboxLastName;
        private Label label6;
    }
}
