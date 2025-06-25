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
            groupBox1 = new GroupBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCurrPassword = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnRequestAccDelete = new Button();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnChangePass = new Button();
            txtNewPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(90, 61);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(156, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(90, 31);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(156, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 64);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // txtCurrPassword
            // 
            txtCurrPassword.Location = new Point(124, 54);
            txtCurrPassword.Name = "txtCurrPassword";
            txtCurrPassword.Size = new Size(156, 23);
            txtCurrPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 57);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 0;
            label3.Text = "Current Password";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRequestAccDelete);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 121);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account Deletion";
            // 
            // btnRequestAccDelete
            // 
            btnRequestAccDelete.Location = new Point(72, 69);
            btnRequestAccDelete.Name = "btnRequestAccDelete";
            btnRequestAccDelete.Size = new Size(110, 35);
            btnRequestAccDelete.TabIndex = 1;
            btnRequestAccDelete.Text = "Request Deletion";
            btnRequestAccDelete.UseVisualStyleBackColor = true;
            btnRequestAccDelete.Click += btnRequestAccDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 26);
            label4.Name = "label4";
            label4.Size = new Size(213, 30);
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
            groupBox3.Location = new Point(305, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(301, 173);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account Details";
            // 
            // btnChangePass
            // 
            btnChangePass.Location = new Point(170, 121);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(110, 35);
            btnChangePass.TabIndex = 1;
            btnChangePass.Text = "Change Password";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(124, 89);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(156, 23);
            txtNewPassword.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 92);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 0;
            label5.Text = "New Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 23);
            label6.Name = "label6";
            label6.Size = new Size(236, 15);
            label6.TabIndex = 0;
            label6.Text = "You can change your password by filling in:";
            // 
            // UserSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 273);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            ResumeLayout(false);
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
        private Button btnRequestAccDelete;
        private GroupBox groupBox3;
        private TextBox txtNewPassword;
        private Label label5;
        private Label label6;
        private Button btnChangePass;
    }
}