namespace PetVaccinationTrackerSystem_Project.Forms.Auth
{
    partial class AuthForm
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
            label1 = new Label();
            label2 = new Label();
            txtboxEmail = new TextBox();
            label3 = new Label();
            txtboxPassword = new TextBox();
            btnLogin = new Button();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 137);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 0;
            label1.Text = "Login To\r\nPet Vaccination Tracker System!\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 189);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(232, 186);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(297, 23);
            txtboxEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 228);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(232, 225);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(297, 23);
            txtboxPassword.TabIndex = 2;
            txtboxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(338, 273);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(535, 224);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(50, 23);
            btnShowPassword.TabIndex = 4;
            btnShowPassword.Text = "Show";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.MouseDown += btnShowPassword_MouseDown;
            btnShowPassword.MouseUp += btnShowPassword_MouseUp;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtboxPassword);
            Controls.Add(txtboxEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthForm";
            Shown += AuthForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtboxEmail;
        private Label label3;
        private TextBox txtboxPassword;
        private Button btnLogin;
        private Button btnShowPassword;
    }
}