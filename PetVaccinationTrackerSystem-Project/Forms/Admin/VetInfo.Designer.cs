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
            cmbboxClinic = new ComboBox();
            txtboxLicenseNo = new TextBox();
            txtboxFirstName = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            label3 = new Label();
            txtboxLastName = new TextBox();
            label4 = new Label();
            txtboxAccountEmail = new TextBox();
            SuspendLayout();
            // 
            // cmbboxClinic
            // 
            cmbboxClinic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxClinic.FormattingEnabled = true;
            cmbboxClinic.Location = new Point(180, 200);
            cmbboxClinic.Name = "cmbboxClinic";
            cmbboxClinic.Size = new Size(471, 23);
            cmbboxClinic.TabIndex = 9;
            // 
            // txtboxLicenseNo
            // 
            txtboxLicenseNo.Location = new Point(180, 156);
            txtboxLicenseNo.Name = "txtboxLicenseNo";
            txtboxLicenseNo.Size = new Size(471, 23);
            txtboxLicenseNo.TabIndex = 7;
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Location = new Point(180, 51);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(471, 23);
            txtboxFirstName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 203);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Clinic Site";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(13, 148);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 5;
            label2.Text = "License Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 54);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(309, 248);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 51);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(489, 248);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 51);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete Record";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 85);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // txtboxLastName
            // 
            txtboxLastName.Location = new Point(180, 82);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(471, 23);
            txtboxLastName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 116);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "Account Email";
            // 
            // txtboxAccountEmail
            // 
            txtboxAccountEmail.Location = new Point(180, 113);
            txtboxAccountEmail.Name = "txtboxAccountEmail";
            txtboxAccountEmail.Size = new Size(471, 23);
            txtboxAccountEmail.TabIndex = 8;
            // 
            // VetInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 314);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(cmbboxClinic);
            Controls.Add(txtboxLicenseNo);
            Controls.Add(txtboxAccountEmail);
            Controls.Add(txtboxLastName);
            Controls.Add(txtboxFirstName);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "VetInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VetInfo";
            Load += VetInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbboxClinic;
        private TextBox txtboxLicenseNo;
        private TextBox txtboxFirstName;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label3;
        private TextBox txtboxLastName;
        private Label label4;
        private TextBox txtboxAccountEmail;
    }
}