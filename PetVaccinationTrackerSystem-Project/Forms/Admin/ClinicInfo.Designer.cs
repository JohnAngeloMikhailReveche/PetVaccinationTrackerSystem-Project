
namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class ClinicInfo
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
            btnDelete = new Button();
            btnUpdate = new Button();
            txtboxCity = new TextBox();
            txtboxStreet = new TextBox();
            txtboxClinicName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtboxState = new TextBox();
            label5 = new Label();
            txtboxZipCode = new TextBox();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(507, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 51);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete Record";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(330, 195);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 51);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtboxCity
            // 
            txtboxCity.Location = new Point(204, 95);
            txtboxCity.Name = "txtboxCity";
            txtboxCity.Size = new Size(471, 23);
            txtboxCity.TabIndex = 17;
            txtboxCity.TextChanged += txtboxAccountEmail_TextChanged;
            // 
            // txtboxStreet
            // 
            txtboxStreet.Location = new Point(204, 64);
            txtboxStreet.Name = "txtboxStreet";
            txtboxStreet.Size = new Size(471, 23);
            txtboxStreet.TabIndex = 18;
            // 
            // txtboxClinicName
            // 
            txtboxClinicName.Location = new Point(204, 33);
            txtboxClinicName.Name = "txtboxClinicName";
            txtboxClinicName.Size = new Size(471, 23);
            txtboxClinicName.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 98);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 13;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 64);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 14;
            label3.Text = "Street";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 36);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 15;
            label1.Text = "Clinic Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 127);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 13;
            label2.Text = "State";
            // 
            // txtboxState
            // 
            txtboxState.Location = new Point(204, 124);
            txtboxState.Name = "txtboxState";
            txtboxState.Size = new Size(471, 23);
            txtboxState.TabIndex = 17;
            txtboxState.TextChanged += txtboxAccountEmail_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 156);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 13;
            label5.Text = "Zip Code";
            // 
            // txtboxZipCode
            // 
            txtboxZipCode.Location = new Point(204, 153);
            txtboxZipCode.Name = "txtboxZipCode";
            txtboxZipCode.Size = new Size(471, 23);
            txtboxZipCode.TabIndex = 17;
            txtboxZipCode.TextChanged += txtboxAccountEmail_TextChanged;
            // 
            // ClinicInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 314);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtboxZipCode);
            Controls.Add(txtboxState);
            Controls.Add(txtboxCity);
            Controls.Add(label5);
            Controls.Add(txtboxStreet);
            Controls.Add(label2);
            Controls.Add(txtboxClinicName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "ClinicInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClinicInfo";
            Load += ClinicInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtboxCity;
        private TextBox txtboxStreet;
        private TextBox txtboxClinicName;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtboxState;
        private Label label5;
        private TextBox txtboxZipCode;
    }
}