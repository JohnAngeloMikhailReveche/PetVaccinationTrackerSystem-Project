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
            label1 = new Label();
            txtboxEmail = new TextBox();
            btnRequest = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(230, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter the Email Associated with this Clinic:";
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(12, 104);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(327, 23);
            txtboxEmail.TabIndex = 1;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(106, 142);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(121, 45);
            btnRequest.TabIndex = 2;
            btnRequest.Text = "Request Change";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(299, 45);
            label2.TabIndex = 0;
            label2.Text = "The admins will reset your password to \"default\" \r\nwait for their message before entering and immediately\r\nchange your password.\r\n";
            // 
            // AuthRequestPasswordChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 205);
            Controls.Add(btnRequest);
            Controls.Add(txtboxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AuthRequestPasswordChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request to Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtboxEmail;
        private Button btnRequest;
        private Label label2;
    }
}