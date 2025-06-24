namespace PetVaccinationTrackerSystem_Project
{
    partial class TablePetRecords
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            PetID = new DataGridViewTextBoxColumn();
            PetName = new DataGridViewTextBoxColumn();
            Species = new DataGridViewTextBoxColumn();
            VaccineName = new DataGridViewTextBoxColumn();
            DateGiven = new DataGridViewTextBoxColumn();
            NextDueDate = new DataGridViewTextBoxColumn();
            AdministeredBy = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(30, 100);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 1;
            label1.Text = "Pet Records";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(344, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(471, 100);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(168, 130, 95);
            button1.Location = new Point(598, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
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
            dataGridView1.Location = new Point(40, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(719, 350);
            dataGridView1.TabIndex = 6;
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
            // TablePetRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TablePetRecords";
            Size = new Size(800, 590);
            Load += TablePetRecords_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
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
