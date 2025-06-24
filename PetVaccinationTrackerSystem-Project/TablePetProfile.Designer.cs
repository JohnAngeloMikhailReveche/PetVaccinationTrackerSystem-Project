namespace PetVaccinationTrackerSystem_Project
{
    partial class TablePetProfile
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
            label2 = new Label();
            dgvClinicList = new DataGridView();
            txtboxSearchClinic = new TextBox();
            cmbboxFilterClinic = new ComboBox();
            comboBox1 = new ComboBox();
            btnSearchClinic = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClinicList).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(14, 154);
            label2.Name = "label2";
            label2.Size = new Size(254, 37);
            label2.TabIndex = 7;
            label2.Text = "Pet Profile Dsiplay";
            // 
            // dgvClinicList
            // 
            dgvClinicList.AllowUserToAddRows = false;
            dgvClinicList.BackgroundColor = Color.White;
            dgvClinicList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClinicList.Location = new Point(34, 198);
            dgvClinicList.MultiSelect = false;
            dgvClinicList.Name = "dgvClinicList";
            dgvClinicList.ReadOnly = true;
            dgvClinicList.Size = new Size(733, 358);
            dgvClinicList.TabIndex = 8;
            // 
            // txtboxSearchClinic
            // 
            txtboxSearchClinic.Location = new Point(274, 169);
            txtboxSearchClinic.Name = "txtboxSearchClinic";
            txtboxSearchClinic.Size = new Size(165, 23);
            txtboxSearchClinic.TabIndex = 9;
            // 
            // cmbboxFilterClinic
            // 
            cmbboxFilterClinic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxFilterClinic.FormattingEnabled = true;
            cmbboxFilterClinic.Items.AddRange(new object[] { "Male", "Female" });
            cmbboxFilterClinic.Location = new Point(445, 169);
            cmbboxFilterClinic.Name = "cmbboxFilterClinic";
            cmbboxFilterClinic.Size = new Size(121, 23);
            cmbboxFilterClinic.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dog", "Cat" });
            comboBox1.Location = new Point(572, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // btnSearchClinic
            // 
            btnSearchClinic.Location = new Point(699, 169);
            btnSearchClinic.Name = "btnSearchClinic";
            btnSearchClinic.Size = new Size(75, 23);
            btnSearchClinic.TabIndex = 12;
            btnSearchClinic.Text = "Search";
            btnSearchClinic.UseVisualStyleBackColor = true;
            // 
            // TablePetProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearchClinic);
            Controls.Add(comboBox1);
            Controls.Add(cmbboxFilterClinic);
            Controls.Add(txtboxSearchClinic);
            Controls.Add(dgvClinicList);
            Controls.Add(label2);
            Name = "TablePetProfile";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)dgvClinicList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvClinicList;
        private TextBox txtboxSearchClinic;
        private ComboBox cmbboxFilterClinic;
        private ComboBox comboBox1;
        private Button btnSearchClinic;
    }
}
