namespace PetVaccinationTrackerSystem_Project.Forms.PetOwner.InnerRecords
{
    partial class PetOwner_VaccinationRecordInstance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetOwner_VaccinationRecordInstance));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            PetID = new DataGridViewTextBoxColumn();
            PetName = new DataGridViewTextBoxColumn();
            Species = new DataGridViewTextBoxColumn();
            VaccineName = new DataGridViewTextBoxColumn();
            DateGiven = new DataGridViewTextBoxColumn();
            NextDueDate = new DataGridViewTextBoxColumn();
            AdministeredBy = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 150);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(848, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(89, 85, 84);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(214, 180, 141);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PetID, PetName, Species, VaccineName, DateGiven, NextDueDate, AdministeredBy });
            dataGridView1.Location = new Point(51, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(754, 380);
            dataGridView1.TabIndex = 9;
            // 
            // PetID
            // 
            PetID.HeaderText = "Pet ID";
            PetID.Name = "PetID";
            PetID.Width = 70;
            // 
            // PetName
            // 
            PetName.HeaderText = "Pet Name";
            PetName.Name = "PetName";
            // 
            // Species
            // 
            Species.HeaderText = "Species";
            Species.Name = "Species";
            Species.Width = 90;
            // 
            // VaccineName
            // 
            VaccineName.HeaderText = "Vaccine Name";
            VaccineName.Name = "VaccineName";
            VaccineName.Width = 130;
            // 
            // DateGiven
            // 
            DateGiven.HeaderText = "Date Administered";
            DateGiven.Name = "DateGiven";
            DateGiven.Width = 105;
            // 
            // NextDueDate
            // 
            NextDueDate.HeaderText = "Next Due Date";
            NextDueDate.Name = "NextDueDate";
            NextDueDate.Width = 105;
            // 
            // AdministeredBy
            // 
            AdministeredBy.HeaderText = "Administered By";
            AdministeredBy.Name = "AdministeredBy";
            AdministeredBy.Width = 120;
            // 
            // PetOwner_VaccinationRecordInstance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 574);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PetOwner_VaccinationRecordInstance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetOwner_VaccinationRecordInstance";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PetID;
        private DataGridViewTextBoxColumn PetName;
        private DataGridViewTextBoxColumn Species;
        private DataGridViewTextBoxColumn VaccineName;
        private DataGridViewTextBoxColumn DateGiven;
        private DataGridViewTextBoxColumn NextDueDate;
        private DataGridViewTextBoxColumn AdministeredBy;
    }
}