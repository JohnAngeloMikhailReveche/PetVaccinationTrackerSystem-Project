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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            label2 = new Label();
            txtboxEmail = new TextBox();
            label3 = new Label();
            txtboxPassword = new TextBox();
            btnLogin = new Button();
            btnShowPassword = new Button();
            panel1 = new Panel();
            mainFormVButtonExit = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(45, 210);
            label2.Name = "label2";
            label2.Size = new Size(163, 19);
            label2.TabIndex = 1;
            label2.Text = "Enter your email address:";
            // 
            // txtboxEmail
            // 
            txtboxEmail.BackColor = Color.FromArgb(249, 249, 249);
            txtboxEmail.Font = new Font("Segoe UI", 10F);
            txtboxEmail.Location = new Point(45, 232);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(310, 25);
            txtboxEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(45, 285);
            label3.Name = "label3";
            label3.Size = new Size(138, 19);
            label3.TabIndex = 1;
            label3.Text = "Enter your password:";
            // 
            // txtboxPassword
            // 
            txtboxPassword.BackColor = Color.FromArgb(249, 249, 249);
            txtboxPassword.Font = new Font("Segoe UI", 10F);
            txtboxPassword.Location = new Point(45, 307);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(310, 25);
            txtboxPassword.TabIndex = 2;
            txtboxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(89, 85, 84);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(150, 387);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.FromArgb(249, 249, 249);
            btnShowPassword.BackgroundImage = (Image)resources.GetObject("btnShowPassword.BackgroundImage");
            btnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.Location = new Point(330, 309);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(18, 18);
            btnShowPassword.TabIndex = 4;
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.MouseDown += btnShowPassword_MouseDown;
            btnShowPassword.MouseUp += btnShowPassword_MouseUp;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(mainFormVButtonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 50);
            panel1.TabIndex = 5;
            // 
            // mainFormVButtonExit
            // 
            mainFormVButtonExit.BackColor = Color.White;
            mainFormVButtonExit.BackgroundImage = (Image)resources.GetObject("mainFormVButtonExit.BackgroundImage");
            mainFormVButtonExit.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormVButtonExit.FlatAppearance.BorderSize = 0;
            mainFormVButtonExit.FlatStyle = FlatStyle.Flat;
            mainFormVButtonExit.Location = new Point(363, 12);
            mainFormVButtonExit.Name = "mainFormVButtonExit";
            mainFormVButtonExit.Size = new Size(25, 25);
            mainFormVButtonExit.TabIndex = 1;
            mainFormVButtonExit.UseVisualStyleBackColor = false;
            mainFormVButtonExit.Click += mainFormVButtonExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 150);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtboxPassword);
            Controls.Add(txtboxEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(400, 480);
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthForm";
            Shown += AuthForm_Shown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtboxEmail;
        private Label label3;
        private TextBox txtboxPassword;
        private Button btnLogin;
        private Button btnShowPassword;
        private Panel panel1;
        private Panel panel2;
        private Button mainFormVButtonExit;
        private PictureBox pictureBox1;
    }
}