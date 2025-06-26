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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablePetRecords));
            label1 = new Label();
            cmbFilter = new ComboBox();
            dgvPetRecords = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSearchPetRecord = new ReaLTaiizor.Controls.HopeRoundButton();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPetRecords).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(24, 158);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 1;
            label1.Text = "Filter and Search:";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Segoe UI", 10F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(561, 157);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(121, 25);
            cmbFilter.TabIndex = 4;
            // 
            // dgvPetRecords
            // 
            dgvPetRecords.AllowUserToAddRows = false;
            dgvPetRecords.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(89, 85, 84);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(214, 180, 141);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPetRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPetRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetRecords.Location = new Point(24, 195);
            dgvPetRecords.Name = "dgvPetRecords";
            dgvPetRecords.RowHeadersVisible = false;
            dgvPetRecords.Size = new Size(754, 380);
            dgvPetRecords.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 150);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSearchPetRecord
            // 
            btnSearchPetRecord.BackColor = Color.FromArgb(63, 59, 58);
            btnSearchPetRecord.BorderColor = Color.FromArgb(220, 223, 230);
            btnSearchPetRecord.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSearchPetRecord.DangerColor = Color.FromArgb(245, 108, 108);
            btnSearchPetRecord.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSearchPetRecord.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchPetRecord.HoverTextColor = Color.White;
            btnSearchPetRecord.InfoColor = Color.FromArgb(144, 147, 153);
            btnSearchPetRecord.Location = new Point(688, 153);
            btnSearchPetRecord.Name = "btnSearchPetRecord";
            btnSearchPetRecord.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnSearchPetRecord.Size = new Size(90, 30);
            btnSearchPetRecord.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSearchPetRecord.TabIndex = 16;
            btnSearchPetRecord.Text = "Search";
            btnSearchPetRecord.TextColor = Color.White;
            btnSearchPetRecord.WarningColor = Color.FromArgb(230, 162, 60);
            btnSearchPetRecord.Click += btnSearchPetRecord_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(151, 158);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(404, 23);
            txtSearch.TabIndex = 17;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // TablePetRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtSearch);
            Controls.Add(btnSearchPetRecord);
            Controls.Add(panel1);
            Controls.Add(dgvPetRecords);
            Controls.Add(cmbFilter);
            Controls.Add(label1);
            Name = "TablePetRecords";
            Size = new Size(800, 590);
            Load += TablePetRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPetRecords).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox cmbFilter;
        private DataGridView dgvPetRecords;
        private Panel panel1;
        private ReaLTaiizor.Controls.HopeRoundButton btnSearchPetRecord;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
    }
}
