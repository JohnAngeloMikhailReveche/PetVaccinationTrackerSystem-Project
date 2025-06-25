namespace PetVaccinationTrackerSystem_Project.Forms.Auth
{
    partial class AuthRequestPasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthRequestPasswordChange));
            label1 = new Label();
            txtboxEmail = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            mainFormVButtonExit = new Button();
            btnRequest = new ReaLTaiizor.Controls.HopeRoundButton();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(26, 175);
            label1.Name = "label1";
            label1.Size = new Size(169, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter the email address:";
            // 
            // txtboxEmail
            // 
            txtboxEmail.Font = new Font("Segoe UI", 10F);
            txtboxEmail.Location = new Point(26, 197);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(285, 25);
            txtboxEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(14, 70);
            label2.Name = "label2";
            label2.Size = new Size(290, 57);
            label2.TabIndex = 0;
            label2.Text = "Admins will reset your password to \"default.\" \r\nPlease wait for their message, then log in and \r\nchange it right away.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 59, 58);
            panel1.Controls.Add(mainFormVButtonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 30);
            panel1.TabIndex = 3;
            // 
            // mainFormVButtonExit
            // 
            mainFormVButtonExit.BackColor = Color.FromArgb(63, 59, 58);
            mainFormVButtonExit.BackgroundImage = (Image)resources.GetObject("mainFormVButtonExit.BackgroundImage");
            mainFormVButtonExit.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormVButtonExit.FlatAppearance.BorderSize = 0;
            mainFormVButtonExit.FlatStyle = FlatStyle.Flat;
            mainFormVButtonExit.Location = new Point(317, 7);
            mainFormVButtonExit.Name = "mainFormVButtonExit";
            mainFormVButtonExit.Size = new Size(15, 15);
            mainFormVButtonExit.TabIndex = 14;
            mainFormVButtonExit.UseVisualStyleBackColor = false;
            mainFormVButtonExit.Click += mainFormVButtonExit_Click;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.FromArgb(63, 59, 58);
            btnRequest.BorderColor = Color.FromArgb(220, 223, 230);
            btnRequest.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnRequest.DangerColor = Color.FromArgb(245, 108, 108);
            btnRequest.DefaultColor = Color.FromArgb(255, 255, 255);
            btnRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.White;
            btnRequest.HoverTextColor = Color.White;
            btnRequest.InfoColor = Color.FromArgb(144, 147, 153);
            btnRequest.Location = new Point(83, 265);
            btnRequest.Name = "btnRequest";
            btnRequest.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnRequest.Size = new Size(170, 40);
            btnRequest.SuccessColor = Color.FromArgb(103, 194, 58);
            btnRequest.TabIndex = 8;
            btnRequest.Text = "Request Reset";
            btnRequest.TextColor = Color.White;
            btnRequest.WarningColor = Color.FromArgb(230, 162, 60);
            btnRequest.Click += btnRequest_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(14, 40);
            label3.Name = "label3";
            label3.Size = new Size(229, 21);
            label3.TabIndex = 16;
            label3.Text = "Request to Change Password";
            // 
            // AuthRequestPasswordChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(340, 335);
            Controls.Add(label3);
            Controls.Add(btnRequest);
            Controls.Add(panel1);
            Controls.Add(txtboxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthRequestPasswordChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request to Change Password";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtboxEmail;
        private Label label2;
        private Panel panel1;
        private Button mainFormVButtonExit;
        private ReaLTaiizor.Controls.HopeRoundButton btnRequest;
        private Label label3;
    }
}