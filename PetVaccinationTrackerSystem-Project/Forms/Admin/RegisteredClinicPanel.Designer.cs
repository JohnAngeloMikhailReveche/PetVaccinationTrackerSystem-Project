namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class RegisteredClinicPanel
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
            btnSearchClinic = new Button();
            cmbboxFilterClinic = new ComboBox();
            txtboxSearchClinic = new TextBox();
            label2 = new Label();
            dgvClinicList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClinicList).BeginInit();
            SuspendLayout();
            // 
            // btnSearchClinic
            // 
            btnSearchClinic.Location = new Point(693, 24);
            btnSearchClinic.Name = "btnSearchClinic";
            btnSearchClinic.Size = new Size(75, 23);
            btnSearchClinic.TabIndex = 9;
            btnSearchClinic.Text = "Search";
            btnSearchClinic.UseVisualStyleBackColor = true;
            btnSearchClinic.Click += btnSearchClinic_Click;
            // 
            // cmbboxFilterClinic
            // 
            cmbboxFilterClinic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxFilterClinic.FormattingEnabled = true;
            cmbboxFilterClinic.Location = new Point(566, 25);
            cmbboxFilterClinic.Name = "cmbboxFilterClinic";
            cmbboxFilterClinic.Size = new Size(121, 23);
            cmbboxFilterClinic.TabIndex = 8;
            // 
            // txtboxSearchClinic
            // 
            txtboxSearchClinic.Location = new Point(395, 25);
            txtboxSearchClinic.Name = "txtboxSearchClinic";
            txtboxSearchClinic.Size = new Size(165, 23);
            txtboxSearchClinic.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(24, 14);
            label2.Name = "label2";
            label2.Size = new Size(244, 37);
            label2.TabIndex = 6;
            label2.Text = "Registered Clinics";
            // 
            // dgvClinicList
            // 
            dgvClinicList.AllowUserToAddRows = false;
            dgvClinicList.BackgroundColor = Color.White;
            dgvClinicList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClinicList.Location = new Point(24, 54);
            dgvClinicList.MultiSelect = false;
            dgvClinicList.Name = "dgvClinicList";
            dgvClinicList.ReadOnly = true;
            dgvClinicList.Size = new Size(733, 521);
            dgvClinicList.TabIndex = 5;
            dgvClinicList.DoubleClick += dgvClinicList_DoubleClick;
            // 
            // RegisteredClinicPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearchClinic);
            Controls.Add(cmbboxFilterClinic);
            Controls.Add(txtboxSearchClinic);
            Controls.Add(label2);
            Controls.Add(dgvClinicList);
            Name = "RegisteredClinicPanel";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)dgvClinicList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchClinic;
        private ComboBox cmbboxFilterClinic;
        private TextBox txtboxSearchClinic;
        private Label label2;
        private DataGridView dgvClinicList;
    }
}
