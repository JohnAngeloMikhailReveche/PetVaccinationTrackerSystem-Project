namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class AdminRegisterClinicUsCo
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
            grpboxClinic = new GroupBox();
            btnRegisterClinic = new Button();
            txtboxZipCode = new TextBox();
            txtboxState = new TextBox();
            txtboxCity = new TextBox();
            txtboxStreet = new TextBox();
            txtboxClinicName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpboxClinic.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxClinic
            // 
            grpboxClinic.Controls.Add(btnRegisterClinic);
            grpboxClinic.Controls.Add(txtboxZipCode);
            grpboxClinic.Controls.Add(txtboxState);
            grpboxClinic.Controls.Add(txtboxCity);
            grpboxClinic.Controls.Add(txtboxStreet);
            grpboxClinic.Controls.Add(txtboxClinicName);
            grpboxClinic.Controls.Add(label5);
            grpboxClinic.Controls.Add(label4);
            grpboxClinic.Controls.Add(label3);
            grpboxClinic.Controls.Add(label2);
            grpboxClinic.Controls.Add(label1);
            grpboxClinic.Font = new Font("Segoe UI", 20F);
            grpboxClinic.Location = new Point(40, 25);
            grpboxClinic.Name = "grpboxClinic";
            grpboxClinic.Size = new Size(704, 541);
            grpboxClinic.TabIndex = 0;
            grpboxClinic.TabStop = false;
            grpboxClinic.Text = "Clinic";
            // 
            // btnRegisterClinic
            // 
            btnRegisterClinic.Location = new Point(259, 433);
            btnRegisterClinic.Name = "btnRegisterClinic";
            btnRegisterClinic.Size = new Size(207, 58);
            btnRegisterClinic.TabIndex = 2;
            btnRegisterClinic.Text = "Register Clinic";
            btnRegisterClinic.UseVisualStyleBackColor = true;
            btnRegisterClinic.Click += btnRegisterClinic_Click;
            // 
            // txtboxZipCode
            // 
            txtboxZipCode.Location = new Point(206, 352);
            txtboxZipCode.Name = "txtboxZipCode";
            txtboxZipCode.Size = new Size(471, 43);
            txtboxZipCode.TabIndex = 1;
            // 
            // txtboxState
            // 
            txtboxState.Location = new Point(206, 285);
            txtboxState.Name = "txtboxState";
            txtboxState.Size = new Size(471, 43);
            txtboxState.TabIndex = 1;
            // 
            // txtboxCity
            // 
            txtboxCity.Location = new Point(206, 217);
            txtboxCity.Name = "txtboxCity";
            txtboxCity.Size = new Size(471, 43);
            txtboxCity.TabIndex = 1;
            // 
            // txtboxStreet
            // 
            txtboxStreet.Location = new Point(206, 150);
            txtboxStreet.Name = "txtboxStreet";
            txtboxStreet.Size = new Size(471, 43);
            txtboxStreet.TabIndex = 1;
            // 
            // txtboxClinicName
            // 
            txtboxClinicName.Location = new Point(206, 72);
            txtboxClinicName.Name = "txtboxClinicName";
            txtboxClinicName.Size = new Size(471, 43);
            txtboxClinicName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 352);
            label5.Name = "label5";
            label5.Size = new Size(125, 37);
            label5.TabIndex = 0;
            label5.Text = "Zip Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 285);
            label4.Name = "label4";
            label4.Size = new Size(76, 37);
            label4.TabIndex = 0;
            label4.Text = "State";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 217);
            label3.Name = "label3";
            label3.Size = new Size(63, 37);
            label3.TabIndex = 0;
            label3.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 150);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 0;
            label2.Text = "Street";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 72);
            label1.Name = "label1";
            label1.Size = new Size(160, 37);
            label1.TabIndex = 0;
            label1.Text = "Clinic Name";
            // 
            // AdminRegisterClinicUsCo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpboxClinic);
            Name = "AdminRegisterClinicUsCo";
            Size = new Size(800, 590);
            grpboxClinic.ResumeLayout(false);
            grpboxClinic.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxClinic;
        private TextBox txtboxClinicName;
        private Label label1;
        private TextBox txtboxZipCode;
        private TextBox txtboxState;
        private TextBox txtboxCity;
        private TextBox txtboxStreet;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnRegisterClinic;
    }
}
