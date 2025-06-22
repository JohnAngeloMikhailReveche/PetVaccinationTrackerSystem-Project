namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class HomeUserControl
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
            dgvVetList = new DataGridView();
            dgvClinicList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtboxSearchVet = new TextBox();
            cmbboxFilterVet = new ComboBox();
            btnSearchVet = new Button();
            txtboxSearchClinic = new TextBox();
            cmbboxFilterClinic = new ComboBox();
            btnSearchClinic = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVetList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClinicList).BeginInit();
            SuspendLayout();
            // 
            // dgvVetList
            // 
            dgvVetList.AllowUserToAddRows = false;
            dgvVetList.BackgroundColor = Color.White;
            dgvVetList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVetList.Location = new Point(20, 57);
            dgvVetList.MultiSelect = false;
            dgvVetList.Name = "dgvVetList";
            dgvVetList.ReadOnly = true;
            dgvVetList.Size = new Size(733, 205);
            dgvVetList.TabIndex = 0;
            dgvVetList.DoubleClick += dgvVetList_DoubleClick;
            // 
            // dgvClinicList
            // 
            dgvClinicList.AllowUserToAddRows = false;
            dgvClinicList.BackgroundColor = Color.White;
            dgvClinicList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClinicList.Location = new Point(20, 327);
            dgvClinicList.MultiSelect = false;
            dgvClinicList.Name = "dgvClinicList";
            dgvClinicList.ReadOnly = true;
            dgvClinicList.Size = new Size(733, 228);
            dgvClinicList.TabIndex = 0;
            dgvClinicList.DoubleClick += dgvClinicList_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(331, 37);
            label1.TabIndex = 1;
            label1.Text = "Registered Veterinarians";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(20, 287);
            label2.Name = "label2";
            label2.Size = new Size(244, 37);
            label2.TabIndex = 1;
            label2.Text = "Registered Clinics";
            // 
            // txtboxSearchVet
            // 
            txtboxSearchVet.Location = new Point(391, 28);
            txtboxSearchVet.Name = "txtboxSearchVet";
            txtboxSearchVet.Size = new Size(165, 23);
            txtboxSearchVet.TabIndex = 2;
            // 
            // cmbboxFilterVet
            // 
            cmbboxFilterVet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxFilterVet.FormattingEnabled = true;
            cmbboxFilterVet.Location = new Point(562, 28);
            cmbboxFilterVet.Name = "cmbboxFilterVet";
            cmbboxFilterVet.Size = new Size(121, 23);
            cmbboxFilterVet.TabIndex = 3;
            // 
            // btnSearchVet
            // 
            btnSearchVet.Location = new Point(689, 27);
            btnSearchVet.Name = "btnSearchVet";
            btnSearchVet.Size = new Size(75, 23);
            btnSearchVet.TabIndex = 4;
            btnSearchVet.Text = "Search";
            btnSearchVet.UseVisualStyleBackColor = true;
            btnSearchVet.Click += btnSearchVet_Click;
            // 
            // txtboxSearchClinic
            // 
            txtboxSearchClinic.Location = new Point(391, 298);
            txtboxSearchClinic.Name = "txtboxSearchClinic";
            txtboxSearchClinic.Size = new Size(165, 23);
            txtboxSearchClinic.TabIndex = 2;
            // 
            // cmbboxFilterClinic
            // 
            cmbboxFilterClinic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxFilterClinic.FormattingEnabled = true;
            cmbboxFilterClinic.Location = new Point(562, 298);
            cmbboxFilterClinic.Name = "cmbboxFilterClinic";
            cmbboxFilterClinic.Size = new Size(121, 23);
            cmbboxFilterClinic.TabIndex = 3;
            // 
            // btnSearchClinic
            // 
            btnSearchClinic.Location = new Point(689, 297);
            btnSearchClinic.Name = "btnSearchClinic";
            btnSearchClinic.Size = new Size(75, 23);
            btnSearchClinic.TabIndex = 4;
            btnSearchClinic.Text = "Search";
            btnSearchClinic.UseVisualStyleBackColor = true;
            btnSearchClinic.Click += btnSearchClinic_Click;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvVetList);
            Controls.Add(btnSearchClinic);
            Controls.Add(btnSearchVet);
            Controls.Add(cmbboxFilterClinic);
            Controls.Add(txtboxSearchClinic);
            Controls.Add(cmbboxFilterVet);
            Controls.Add(txtboxSearchVet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvClinicList);
            Name = "HomeUserControl";
            Size = new Size(800, 590);
            Load += HomeUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVetList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClinicList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvVetList;
        private DataGridView dgvClinicList;
        private Label label1;
        private Label label2;
        private TextBox txtboxSearchVet;
        private ComboBox cmbboxFilterVet;
        private Button btnSearchVet;
        private TextBox txtboxSearchClinic;
        private ComboBox cmbboxFilterClinic;
        private Button btnSearchClinic;
    }
}
