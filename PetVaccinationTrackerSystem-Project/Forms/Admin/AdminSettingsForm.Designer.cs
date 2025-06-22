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
            label1 = new Label();
            label2 = new Label();
            txtboxUsername = new TextBox();
            label3 = new Label();
            txtboxPassword = new TextBox();
            btnSaveChanges = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(214, 37);
            label1.TabIndex = 0;
            label1.Text = "Admin Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(23, 99);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Location = new Point(109, 99);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(214, 23);
            txtboxUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(23, 128);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(109, 128);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(214, 23);
            txtboxPassword.TabIndex = 2;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(227, 162);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(96, 36);
            btnSaveChanges.TabIndex = 3;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // AdminSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtboxPassword);
            Controls.Add(label3);
            Controls.Add(txtboxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSettingsForm";
            Load += AdminSettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtboxUsername;
        private Label label3;
        private TextBox txtboxPassword;
        private Button btnSaveChanges;
    }
}