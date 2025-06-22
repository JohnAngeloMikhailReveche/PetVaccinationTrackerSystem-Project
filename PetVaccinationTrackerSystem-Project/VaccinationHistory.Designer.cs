namespace PetVaccinationTrackerSystem_Project
{
    partial class VaccinationHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccinationHistory));
            label1 = new Label();
            dgvHistory = new DataGridView();
            PetName = new DataGridViewTextBoxColumn();
            Species = new DataGridViewTextBoxColumn();
            OwnerName = new DataGridViewTextBoxColumn();
            VaccineName = new DataGridViewTextBoxColumn();
            DateGiven = new DataGridViewTextBoxColumn();
            NextDueDate = new DataGridViewTextBoxColumn();
            AdministeredBy = new DataGridViewTextBoxColumn();
            BatchNo = new DataGridViewTextBoxColumn();
            VRDSButtonGoBack = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 1;
            label1.Text = "\tVaccination History";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 249, 249);
            dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.FromArgb(249, 249, 249);
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { PetName, Species, OwnerName, VaccineName, DateGiven, NextDueDate, AdministeredBy, BatchNo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(214, 180, 141);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistory.GridColor = Color.FromArgb(249, 249, 249);
            dgvHistory.Location = new Point(30, 110);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.Size = new Size(740, 415);
            dgvHistory.TabIndex = 2;
            // 
            // PetName
            // 
            PetName.HeaderText = "Pet Name";
            PetName.Name = "PetName";
            PetName.ReadOnly = true;
            // 
            // Species
            // 
            Species.FillWeight = 70F;
            Species.HeaderText = "Species";
            Species.Name = "Species";
            Species.ReadOnly = true;
            // 
            // OwnerName
            // 
            OwnerName.FillWeight = 120F;
            OwnerName.HeaderText = "Pet Owner";
            OwnerName.Name = "OwnerName";
            OwnerName.ReadOnly = true;
            // 
            // VaccineName
            // 
            VaccineName.FillWeight = 110F;
            VaccineName.HeaderText = "Vaccine";
            VaccineName.Name = "VaccineName";
            VaccineName.ReadOnly = true;
            // 
            // DateGiven
            // 
            DateGiven.FillWeight = 90F;
            DateGiven.HeaderText = "Date Administered";
            DateGiven.Name = "DateGiven";
            DateGiven.ReadOnly = true;
            // 
            // NextDueDate
            // 
            NextDueDate.FillWeight = 90F;
            NextDueDate.HeaderText = "Next Due Date";
            NextDueDate.Name = "NextDueDate";
            NextDueDate.ReadOnly = true;
            // 
            // AdministeredBy
            // 
            AdministeredBy.HeaderText = "Administered By";
            AdministeredBy.Name = "AdministeredBy";
            AdministeredBy.ReadOnly = true;
            // 
            // BatchNo
            // 
            BatchNo.FillWeight = 60F;
            BatchNo.HeaderText = "Batch No";
            BatchNo.Name = "BatchNo";
            BatchNo.ReadOnly = true;
            // 
            // VRDSButtonGoBack
            // 
            VRDSButtonGoBack.FlatStyle = FlatStyle.Flat;
            VRDSButtonGoBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VRDSButtonGoBack.ForeColor = Color.FromArgb(89, 85, 84);
            VRDSButtonGoBack.Location = new Point(30, 540);
            VRDSButtonGoBack.Name = "VRDSButtonGoBack";
            VRDSButtonGoBack.Size = new Size(100, 40);
            VRDSButtonGoBack.TabIndex = 32;
            VRDSButtonGoBack.Text = "Go Back";
            VRDSButtonGoBack.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // VaccinationHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox2);
            Controls.Add(VRDSButtonGoBack);
            Controls.Add(dgvHistory);
            Controls.Add(label1);
            Name = "VaccinationHistory";
            Size = new Size(800, 590);
            Load += VaccinationHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvHistory;
        private Button VRDSButtonGoBack;
        private DataGridViewTextBoxColumn PetName;
        private DataGridViewTextBoxColumn Species;
        private DataGridViewTextBoxColumn OwnerName;
        private DataGridViewTextBoxColumn VaccineName;
        private DataGridViewTextBoxColumn DateGiven;
        private DataGridViewTextBoxColumn NextDueDate;
        private DataGridViewTextBoxColumn AdministeredBy;
        private DataGridViewTextBoxColumn BatchNo;
        private PictureBox pictureBox2;
    }
}
