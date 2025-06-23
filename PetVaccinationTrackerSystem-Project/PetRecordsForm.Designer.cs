namespace PetVaccinationTrackerSystem_Project
{
    partial class PetRecordsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            lblVaxHistory = new Label();
            dgvVaxHistory = new DataGridView();
            PetID = new DataGridViewTextBoxColumn();
            PetName = new DataGridViewTextBoxColumn();
            Species = new DataGridViewTextBoxColumn();
            VaccineName = new DataGridViewTextBoxColumn();
            DateGiven = new DataGridViewTextBoxColumn();
            NextDueDate = new DataGridViewTextBoxColumn();
            AdministeredBy = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVaxHistory).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(780, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblVaxHistory
            // 
            lblVaxHistory.AutoSize = true;
            lblVaxHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVaxHistory.ForeColor = Color.FromArgb(89, 85, 84);
            lblVaxHistory.Location = new Point(30, 95);
            lblVaxHistory.Name = "lblVaxHistory";
            lblVaxHistory.Size = new Size(99, 21);
            lblVaxHistory.TabIndex = 3;
            lblVaxHistory.Text = "Pet Records";
            // 
            // dgvVaxHistory
            // 
            dgvVaxHistory.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 249, 249);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(214, 180, 141);
            dgvVaxHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVaxHistory.BackgroundColor = Color.FromArgb(249, 249, 249);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(168, 130, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVaxHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVaxHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVaxHistory.Columns.AddRange(new DataGridViewColumn[] { PetID, PetName, Species, VaccineName, DateGiven, NextDueDate, AdministeredBy });
            dgvVaxHistory.EnableHeadersVisualStyles = false;
            dgvVaxHistory.Location = new Point(40, 135);
            dgvVaxHistory.Name = "dgvVaxHistory";
            dgvVaxHistory.ReadOnly = true;
            dgvVaxHistory.RowHeadersVisible = false;
            dgvVaxHistory.Size = new Size(700, 360);
            dgvVaxHistory.TabIndex = 4;
            // 
            // PetID
            // 
            PetID.HeaderText = "Pet ID";
            PetID.Name = "PetID";
            PetID.ReadOnly = true;
            PetID.Width = 70;
            // 
            // PetName
            // 
            PetName.HeaderText = "Pet Name";
            PetName.Name = "PetName";
            PetName.ReadOnly = true;
            // 
            // Species
            // 
            Species.HeaderText = "Species";
            Species.Name = "Species";
            Species.ReadOnly = true;
            Species.Width = 90;
            // 
            // VaccineName
            // 
            VaccineName.HeaderText = "Vaccine Name";
            VaccineName.Name = "VaccineName";
            VaccineName.ReadOnly = true;
            VaccineName.Width = 130;
            // 
            // DateGiven
            // 
            DateGiven.HeaderText = "Date Administered";
            DateGiven.Name = "DateGiven";
            DateGiven.ReadOnly = true;
            // 
            // NextDueDate
            // 
            NextDueDate.HeaderText = "Next Due Date";
            NextDueDate.Name = "NextDueDate";
            NextDueDate.ReadOnly = true;
            // 
            // AdministeredBy
            // 
            AdministeredBy.HeaderText = "Administered By";
            AdministeredBy.Name = "AdministeredBy";
            AdministeredBy.ReadOnly = true;
            AdministeredBy.Width = 110;
            // 
            // PetRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 593);
            Controls.Add(dgvVaxHistory);
            Controls.Add(lblVaxHistory);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PetRecordsForm";
            Text = "PetRecordsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVaxHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblVaxHistory;
        private DataGridView dgvVaxHistory;
        private DataGridViewTextBoxColumn PetID;
        private DataGridViewTextBoxColumn PetName;
        private DataGridViewTextBoxColumn Species;
        private DataGridViewTextBoxColumn VaccineName;
        private DataGridViewTextBoxColumn DateGiven;
        private DataGridViewTextBoxColumn NextDueDate;
        private DataGridViewTextBoxColumn AdministeredBy;
    }
}