namespace PetVaccinationTrackerSystem_Project
{
    partial class vaccineReportsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vaccineReportsPanel));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label14 = new Label();
            flpVaccines = new FlowLayoutPanel();
            dgvRecords = new DataGridView();
            colVaccineName = new DataGridViewTextBoxColumn();
            colDateAdmin = new DataGridViewTextBoxColumn();
            colNextDue = new DataGridViewTextBoxColumn();
            colAdministeredBy = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            pctPetImage = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            iconSearch = new PictureBox();
            pnlPetInfo = new TableLayoutPanel();
            label13 = new Label();
            txtBreed = new TextBox();
            label2 = new Label();
            txtMicrochip = new TextBox();
            txtSpecies = new ComboBox();
            comboBox1 = new ComboBox();
            dtpDOB = new DateTimePicker();
            textBox1 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            PetProfilePanelVButtonGoBack = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flpVaccines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPetImage).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconSearch).BeginInit();
            pnlPetInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label14
            // 
            label14.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(89, 85, 84);
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 23);
            label14.TabIndex = 0;
            label14.Text = "Vaccination Details";
            // 
            // flpVaccines
            // 
            flpVaccines.Controls.Add(label14);
            flpVaccines.Controls.Add(dgvRecords);
            flpVaccines.Location = new Point(42, 279);
            flpVaccines.Name = "flpVaccines";
            flpVaccines.Size = new Size(720, 259);
            flpVaccines.TabIndex = 1;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.Columns.AddRange(new DataGridViewColumn[] { colVaccineName, colDateAdmin, colNextDue, colAdministeredBy, colNotes });
            dgvRecords.Location = new Point(3, 26);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.Size = new Size(711, 222);
            dgvRecords.TabIndex = 1;
            // 
            // colVaccineName
            // 
            colVaccineName.HeaderText = "Vaccine Name";
            colVaccineName.Name = "colVaccineName";
            // 
            // colDateAdmin
            // 
            colDateAdmin.HeaderText = "Date Administered";
            colDateAdmin.Name = "colDateAdmin";
            // 
            // colNextDue
            // 
            colNextDue.HeaderText = "Next Due Date";
            colNextDue.Name = "colNextDue";
            // 
            // colAdministeredBy
            // 
            colAdministeredBy.HeaderText = "Administered By";
            colAdministeredBy.Name = "colAdministeredBy";
            // 
            // colNotes
            // 
            colNotes.HeaderText = "Notes";
            colNotes.Name = "colNotes";
            // 
            // pctPetImage
            // 
            pctPetImage.BorderStyle = BorderStyle.Fixed3D;
            pctPetImage.Location = new Point(45, 105);
            pctPetImage.Name = "pctPetImage";
            pctPetImage.Size = new Size(150, 150);
            pctPetImage.SizeMode = PictureBoxSizeMode.Zoom;
            pctPetImage.TabIndex = 0;
            pctPetImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(249, 249, 249);
            flowLayoutPanel1.Controls.Add(lblSearch);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Controls.Add(iconSearch);
            flowLayoutPanel1.Location = new Point(536, 99);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(241, 26);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(89, 85, 84);
            lblSearch.Location = new Point(2, 6);
            lblSearch.Margin = new Padding(2, 6, 4, 2);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(48, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(56, 2);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 23);
            txtSearch.TabIndex = 1;
            // 
            // iconSearch
            // 
            iconSearch.Image = (Image)resources.GetObject("iconSearch.Image");
            iconSearch.Location = new Point(212, 4);
            iconSearch.Margin = new Padding(4, 4, 2, 2);
            iconSearch.Name = "iconSearch";
            iconSearch.Size = new Size(20, 17);
            iconSearch.SizeMode = PictureBoxSizeMode.Zoom;
            iconSearch.TabIndex = 2;
            iconSearch.TabStop = false;
            // 
            // pnlPetInfo
            // 
            pnlPetInfo.ColumnCount = 2;
            pnlPetInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.04918F));
            pnlPetInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.95082F));
            pnlPetInfo.Controls.Add(label13, 0, 0);
            pnlPetInfo.Controls.Add(txtBreed, 1, 2);
            pnlPetInfo.Controls.Add(label2, 0, 6);
            pnlPetInfo.Controls.Add(txtMicrochip, 1, 0);
            pnlPetInfo.Controls.Add(txtSpecies, 1, 1);
            pnlPetInfo.Controls.Add(comboBox1, 1, 3);
            pnlPetInfo.Controls.Add(dtpDOB, 1, 4);
            pnlPetInfo.Controls.Add(textBox1, 1, 5);
            pnlPetInfo.Controls.Add(label3, 0, 1);
            pnlPetInfo.Controls.Add(label5, 0, 4);
            pnlPetInfo.Controls.Add(label6, 0, 5);
            pnlPetInfo.Controls.Add(label4, 0, 3);
            pnlPetInfo.Controls.Add(label7, 0, 2);
            pnlPetInfo.Location = new Point(214, 99);
            pnlPetInfo.Name = "pnlPetInfo";
            pnlPetInfo.RowCount = 7;
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlPetInfo.Size = new Size(305, 162);
            pnlPetInfo.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(89, 85, 84);
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(62, 15);
            label13.TabIndex = 28;
            label13.Text = "Pet Name:";
            // 
            // txtBreed
            // 
            txtBreed.BackColor = Color.FromArgb(249, 249, 249);
            txtBreed.Location = new Point(116, 57);
            txtBreed.Name = "txtBreed";
            txtBreed.ReadOnly = true;
            txtBreed.Size = new Size(186, 23);
            txtBreed.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(3, 162);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 14;
            label2.Text = "Pet Name:";
            // 
            // txtMicrochip
            // 
            txtMicrochip.BackColor = Color.FromArgb(249, 249, 249);
            txtMicrochip.Location = new Point(116, 3);
            txtMicrochip.Name = "txtMicrochip";
            txtMicrochip.ReadOnly = true;
            txtMicrochip.Size = new Size(186, 23);
            txtMicrochip.TabIndex = 26;
            // 
            // txtSpecies
            // 
            txtSpecies.BackColor = Color.FromArgb(249, 249, 249);
            txtSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSpecies.Enabled = false;
            txtSpecies.FormattingEnabled = true;
            txtSpecies.Items.AddRange(new object[] { "Dog", "Cat", "etc." });
            txtSpecies.Location = new Point(116, 30);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(186, 23);
            txtSpecies.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(249, 249, 249);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(116, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 23);
            comboBox1.TabIndex = 27;
            // 
            // dtpDOB
            // 
            dtpDOB.Enabled = false;
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(116, 111);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(186, 23);
            dtpDOB.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(249, 249, 249);
            textBox1.Location = new Point(116, 138);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(3, 27);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 17;
            label3.Text = "Species:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(89, 85, 84);
            label5.Location = new Point(3, 108);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 19;
            label5.Text = "Date of Birth:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(89, 85, 84);
            label6.Location = new Point(3, 135);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 20;
            label6.Text = "Color/Markings:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(89, 85, 84);
            label4.Location = new Point(3, 81);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 18;
            label4.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(89, 85, 84);
            label7.Location = new Point(3, 54);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 16;
            label7.Text = "Breed:";
            // 
            // PetProfilePanelVButtonGoBack
            // 
            PetProfilePanelVButtonGoBack.FlatStyle = FlatStyle.Flat;
            PetProfilePanelVButtonGoBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PetProfilePanelVButtonGoBack.ForeColor = Color.FromArgb(89, 85, 84);
            PetProfilePanelVButtonGoBack.Location = new Point(637, 544);
            PetProfilePanelVButtonGoBack.Name = "PetProfilePanelVButtonGoBack";
            PetProfilePanelVButtonGoBack.Size = new Size(119, 36);
            PetProfilePanelVButtonGoBack.TabIndex = 33;
            PetProfilePanelVButtonGoBack.Text = "Go Back";
            PetProfilePanelVButtonGoBack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(89, 85, 84);
            button1.Location = new Point(536, 171);
            button1.Name = "button1";
            button1.Size = new Size(241, 31);
            button1.TabIndex = 34;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            // 
            // vaccineReportsPanel
            // 
            Controls.Add(button1);
            Controls.Add(PetProfilePanelVButtonGoBack);
            Controls.Add(pnlPetInfo);
            Controls.Add(pctPetImage);
            Controls.Add(flpVaccines);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Name = "vaccineReportsPanel";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flpVaccines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPetImage).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconSearch).EndInit();
            pnlPetInfo.ResumeLayout(false);
            pnlPetInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label14;
        private FlowLayoutPanel flpVaccines;
        private DataGridView dgvRecords;
        private DataGridViewTextBoxColumn colVaccineName;
        private DataGridViewTextBoxColumn colDateAdmin;
        private DataGridViewTextBoxColumn colNextDue;
        private DataGridViewTextBoxColumn colAdministeredBy;
        private DataGridViewTextBoxColumn colNotes;
        private PictureBox pctPetImage;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblSearch;
        private TextBox txtSearch;
        private PictureBox iconSearch;
        private TableLayoutPanel pnlPetInfo;
        private Label label13;
        private TextBox txtBreed;
        private Label label2;
        private TextBox txtMicrochip;
        private ComboBox txtSpecies;
        private ComboBox comboBox1;
        private DateTimePicker dtpDOB;
        private TextBox textBox1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label7;
        private Button PetProfilePanelVButtonGoBack;
        private Button button1;
    }
}