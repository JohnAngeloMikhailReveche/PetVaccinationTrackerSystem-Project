namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class RegisteredVetPanel
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
            btnSearchVet = new Button();
            cmbboxFilterVet = new ComboBox();
            txtboxSearchVet = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVetList).BeginInit();
            SuspendLayout();
            // 
            // dgvVetList
            // 
            dgvVetList.AllowUserToAddRows = false;
            dgvVetList.BackgroundColor = Color.White;
            dgvVetList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVetList.Location = new Point(27, 60);
            dgvVetList.MultiSelect = false;
            dgvVetList.Name = "dgvVetList";
            dgvVetList.ReadOnly = true;
            dgvVetList.Size = new Size(733, 506);
            dgvVetList.TabIndex = 5;
            dgvVetList.DoubleClick += dgvVetList_DoubleClick;
            // 
            // btnSearchVet
            // 
            btnSearchVet.Location = new Point(696, 30);
            btnSearchVet.Name = "btnSearchVet";
            btnSearchVet.Size = new Size(75, 23);
            btnSearchVet.TabIndex = 9;
            btnSearchVet.Text = "Search";
            btnSearchVet.UseVisualStyleBackColor = true;
            btnSearchVet.Click += btnSearchVet_Click;
            // 
            // cmbboxFilterVet
            // 
            cmbboxFilterVet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxFilterVet.FormattingEnabled = true;
            cmbboxFilterVet.Location = new Point(569, 31);
            cmbboxFilterVet.Name = "cmbboxFilterVet";
            cmbboxFilterVet.Size = new Size(121, 23);
            cmbboxFilterVet.TabIndex = 8;
            // 
            // txtboxSearchVet
            // 
            txtboxSearchVet.Location = new Point(398, 31);
            txtboxSearchVet.Name = "txtboxSearchVet";
            txtboxSearchVet.Size = new Size(165, 23);
            txtboxSearchVet.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(331, 37);
            label1.TabIndex = 6;
            label1.Text = "Registered Veterinarians";
            // 
            // RegisteredVetPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvVetList);
            Controls.Add(btnSearchVet);
            Controls.Add(cmbboxFilterVet);
            Controls.Add(txtboxSearchVet);
            Controls.Add(label1);
            Name = "RegisteredVetPanel";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)dgvVetList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVetList;
        private Button btnSearchVet;
        private ComboBox cmbboxFilterVet;
        private TextBox txtboxSearchVet;
        private Label label1;
    }
}
