namespace PetVaccinationTrackerSystem_Project
{
    partial class VaccineRecordsPanelVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccineRecordsPanelVet));
            VRDSVaccineDetailsPanel = new Panel();
            VRDSButtonAddRecord = new Button();
            label14 = new Label();
            VRDSVaccineCard = new Panel();
            dgvPetInfo = new DataGridView();
            txtNotes = new TextBox();
            label12 = new Label();
            txtBatchNo = new TextBox();
            label11 = new Label();
            txtAdministeredBy = new TextBox();
            label10 = new Label();
            dtpNextDue = new DateTimePicker();
            label9 = new Label();
            dtpDateGiven = new DateTimePicker();
            label8 = new Label();
            cmbVaccineName = new ComboBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            VRDSButtonClear = new Button();
            VRDSButtonGoBack = new Button();
            VRDSPetPBPanel = new Panel();
            VRDSPetPB = new PictureBox();
            VRDSPetInfoPanel = new TableLayoutPanel();
            label13 = new Label();
            txtMicrochip = new TextBox();
            dtpDOB = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtSpecies = new ComboBox();
            txtBreed = new TextBox();
            comboBox1 = new ComboBox();
            VRDSVaccineDetailsPanel.SuspendLayout();
            VRDSVaccineCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPetInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            VRDSPetPBPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VRDSPetPB).BeginInit();
            VRDSPetInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // VRDSVaccineDetailsPanel
            // 
            VRDSVaccineDetailsPanel.BackColor = Color.FromArgb(249, 249, 249);
            VRDSVaccineDetailsPanel.Controls.Add(VRDSButtonAddRecord);
            VRDSVaccineDetailsPanel.Controls.Add(label14);
            VRDSVaccineDetailsPanel.Controls.Add(VRDSVaccineCard);
            VRDSVaccineDetailsPanel.Location = new Point(53, 258);
            VRDSVaccineDetailsPanel.Name = "VRDSVaccineDetailsPanel";
            VRDSVaccineDetailsPanel.Size = new Size(697, 271);
            VRDSVaccineDetailsPanel.TabIndex = 17;
            // 
            // VRDSButtonAddRecord
            // 
            VRDSButtonAddRecord.FlatStyle = FlatStyle.Flat;
            VRDSButtonAddRecord.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VRDSButtonAddRecord.ForeColor = Color.FromArgb(89, 85, 84);
            VRDSButtonAddRecord.Location = new Point(17, 224);
            VRDSButtonAddRecord.Name = "VRDSButtonAddRecord";
            VRDSButtonAddRecord.Size = new Size(100, 40);
            VRDSButtonAddRecord.TabIndex = 28;
            VRDSButtonAddRecord.Text = "+ Record";
            VRDSButtonAddRecord.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(89, 85, 84);
            label14.Location = new Point(21, 4);
            label14.Name = "label14";
            label14.Size = new Size(157, 21);
            label14.TabIndex = 2;
            label14.Text = "Vaccination Details";
            // 
            // VRDSVaccineCard
            // 
            VRDSVaccineCard.BackColor = Color.White;
            VRDSVaccineCard.BorderStyle = BorderStyle.FixedSingle;
            VRDSVaccineCard.Controls.Add(dgvPetInfo);
            VRDSVaccineCard.Controls.Add(txtNotes);
            VRDSVaccineCard.Controls.Add(label12);
            VRDSVaccineCard.Controls.Add(txtBatchNo);
            VRDSVaccineCard.Controls.Add(label11);
            VRDSVaccineCard.Controls.Add(txtAdministeredBy);
            VRDSVaccineCard.Controls.Add(label10);
            VRDSVaccineCard.Controls.Add(dtpNextDue);
            VRDSVaccineCard.Controls.Add(label9);
            VRDSVaccineCard.Controls.Add(dtpDateGiven);
            VRDSVaccineCard.Controls.Add(label8);
            VRDSVaccineCard.Controls.Add(cmbVaccineName);
            VRDSVaccineCard.Controls.Add(label7);
            VRDSVaccineCard.Location = new Point(17, 28);
            VRDSVaccineCard.Margin = new Padding(20, 5, 0, 0);
            VRDSVaccineCard.Name = "VRDSVaccineCard";
            VRDSVaccineCard.Size = new Size(663, 191);
            VRDSVaccineCard.TabIndex = 1;
            // 
            // dgvPetInfo
            // 
            dgvPetInfo.AllowUserToAddRows = false;
            dgvPetInfo.AllowUserToResizeColumns = false;
            dgvPetInfo.AllowUserToResizeRows = false;
            dgvPetInfo.BackgroundColor = Color.FromArgb(249, 249, 249);
            dgvPetInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetInfo.ColumnHeadersVisible = false;
            dgvPetInfo.Location = new Point(61, -1);
            dgvPetInfo.Name = "dgvPetInfo";
            dgvPetInfo.RowHeadersVisible = false;
            dgvPetInfo.Size = new Size(507, 160);
            dgvPetInfo.TabIndex = 21;
            dgvPetInfo.CellContentClick += dgvPetInfo_CellContentClick;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(249, 249, 249);
            txtNotes.Location = new Point(79, 120);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(561, 60);
            txtNotes.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.ForeColor = Color.FromArgb(89, 85, 84);
            label12.Location = new Point(15, 120);
            label12.Name = "label12";
            label12.Size = new Size(48, 19);
            label12.TabIndex = 19;
            label12.Text = "Notes:";
            // 
            // txtBatchNo
            // 
            txtBatchNo.BackColor = Color.FromArgb(249, 249, 249);
            txtBatchNo.Font = new Font("Segoe UI", 10F);
            txtBatchNo.Location = new Point(480, 47);
            txtBatchNo.Name = "txtBatchNo";
            txtBatchNo.Size = new Size(160, 25);
            txtBatchNo.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.FromArgb(89, 85, 84);
            label11.Location = new Point(360, 50);
            label11.Name = "label11";
            label11.Size = new Size(93, 19);
            label11.TabIndex = 17;
            label11.Text = "Batch/Lot No:";
            // 
            // txtAdministeredBy
            // 
            txtAdministeredBy.BackColor = Color.FromArgb(249, 249, 249);
            txtAdministeredBy.Font = new Font("Segoe UI", 10F);
            txtAdministeredBy.Location = new Point(480, 12);
            txtAdministeredBy.Name = "txtAdministeredBy";
            txtAdministeredBy.Size = new Size(160, 25);
            txtAdministeredBy.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.FromArgb(89, 85, 84);
            label10.Location = new Point(360, 15);
            label10.Name = "label10";
            label10.Size = new Size(112, 19);
            label10.TabIndex = 15;
            label10.Text = "Administered By:";
            // 
            // dtpNextDue
            // 
            dtpNextDue.Format = DateTimePickerFormat.Short;
            dtpNextDue.Location = new Point(145, 82);
            dtpNextDue.Name = "dtpNextDue";
            dtpNextDue.Size = new Size(200, 23);
            dtpNextDue.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.FromArgb(89, 85, 84);
            label9.Location = new Point(15, 85);
            label9.Name = "label9";
            label9.Size = new Size(102, 19);
            label9.TabIndex = 13;
            label9.Text = "Next Due Date:";
            // 
            // dtpDateGiven
            // 
            dtpDateGiven.Format = DateTimePickerFormat.Short;
            dtpDateGiven.Location = new Point(145, 47);
            dtpDateGiven.Name = "dtpDateGiven";
            dtpDateGiven.Size = new Size(200, 23);
            dtpDateGiven.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(89, 85, 84);
            label8.Location = new Point(15, 50);
            label8.Name = "label8";
            label8.Size = new Size(126, 19);
            label8.TabIndex = 11;
            label8.Text = "Date Administered:";
            // 
            // cmbVaccineName
            // 
            cmbVaccineName.BackColor = Color.FromArgb(249, 249, 249);
            cmbVaccineName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVaccineName.Font = new Font("Segoe UI", 10F);
            cmbVaccineName.FormattingEnabled = true;
            cmbVaccineName.Items.AddRange(new object[] { "Rabies", "DHPP", "5-in-1", "6-in-1", "Canine Parvovirus", "Canine Distemper", "Canine Hepatitis", "Leptospirosis", "Bordetella", "Canine Influenza", "Lyme Disease", "Coronavirus (CCV)", "FVRCP", "FVR", "Calicivirus", "Panleukopenia", "FeLV (Feline Leukemia)", "FIV (Feline Immunodeficiency Virus)", "Chlamydia", "Myxomatosis (Rabbit)", "RHDV1 (Rabbit)", "RHDV2 (Rabbit)" });
            cmbVaccineName.Location = new Point(145, 12);
            cmbVaccineName.Name = "cmbVaccineName";
            cmbVaccineName.Size = new Size(200, 25);
            cmbVaccineName.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(89, 85, 84);
            label7.Location = new Point(15, 15);
            label7.Name = "label7";
            label7.Size = new Size(97, 19);
            label7.TabIndex = 0;
            label7.Text = "Vaccine Name:";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // VRDSButtonClear
            // 
            VRDSButtonClear.FlatStyle = FlatStyle.Flat;
            VRDSButtonClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VRDSButtonClear.ForeColor = Color.FromArgb(89, 85, 84);
            VRDSButtonClear.Location = new Point(650, 535);
            VRDSButtonClear.Name = "VRDSButtonClear";
            VRDSButtonClear.Size = new Size(100, 40);
            VRDSButtonClear.TabIndex = 29;
            VRDSButtonClear.Text = "Clear";
            VRDSButtonClear.UseVisualStyleBackColor = true;
            // 
            // VRDSButtonGoBack
            // 
            VRDSButtonGoBack.FlatStyle = FlatStyle.Flat;
            VRDSButtonGoBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VRDSButtonGoBack.ForeColor = Color.FromArgb(89, 85, 84);
            VRDSButtonGoBack.Location = new Point(539, 535);
            VRDSButtonGoBack.Name = "VRDSButtonGoBack";
            VRDSButtonGoBack.Size = new Size(100, 40);
            VRDSButtonGoBack.TabIndex = 31;
            VRDSButtonGoBack.Text = "Go Back";
            VRDSButtonGoBack.UseVisualStyleBackColor = true;
            // 
            // VRDSPetPBPanel
            // 
            VRDSPetPBPanel.Controls.Add(VRDSPetPB);
            VRDSPetPBPanel.Location = new Point(53, 90);
            VRDSPetPBPanel.Name = "VRDSPetPBPanel";
            VRDSPetPBPanel.Size = new Size(160, 160);
            VRDSPetPBPanel.TabIndex = 32;
            // 
            // VRDSPetPB
            // 
            VRDSPetPB.Dock = DockStyle.Fill;
            VRDSPetPB.Image = (Image)resources.GetObject("VRDSPetPB.Image");
            VRDSPetPB.Location = new Point(0, 0);
            VRDSPetPB.Name = "VRDSPetPB";
            VRDSPetPB.Size = new Size(160, 160);
            VRDSPetPB.SizeMode = PictureBoxSizeMode.Zoom;
            VRDSPetPB.TabIndex = 0;
            VRDSPetPB.TabStop = false;
            // 
            // VRDSPetInfoPanel
            // 
            VRDSPetInfoPanel.BackColor = Color.FromArgb(249, 249, 249);
            VRDSPetInfoPanel.ColumnCount = 2;
            VRDSPetInfoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            VRDSPetInfoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            VRDSPetInfoPanel.Controls.Add(label13, 0, 0);
            VRDSPetInfoPanel.Controls.Add(txtMicrochip, 1, 0);
            VRDSPetInfoPanel.Controls.Add(dtpDOB, 1, 4);
            VRDSPetInfoPanel.Controls.Add(label3, 0, 1);
            VRDSPetInfoPanel.Controls.Add(label5, 0, 4);
            VRDSPetInfoPanel.Controls.Add(label4, 0, 3);
            VRDSPetInfoPanel.Controls.Add(label2, 0, 2);
            VRDSPetInfoPanel.Controls.Add(txtSpecies, 1, 1);
            VRDSPetInfoPanel.Controls.Add(txtBreed, 1, 3);
            VRDSPetInfoPanel.Controls.Add(comboBox1, 1, 2);
            VRDSPetInfoPanel.Location = new Point(243, 90);
            VRDSPetInfoPanel.Name = "VRDSPetInfoPanel";
            VRDSPetInfoPanel.Padding = new Padding(10);
            VRDSPetInfoPanel.RowCount = 5;
            VRDSPetInfoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            VRDSPetInfoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            VRDSPetInfoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            VRDSPetInfoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            VRDSPetInfoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            VRDSPetInfoPanel.Size = new Size(507, 160);
            VRDSPetInfoPanel.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.ForeColor = Color.FromArgb(89, 85, 84);
            label13.Location = new Point(13, 10);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 5, 0, 0);
            label13.Size = new Size(71, 24);
            label13.TabIndex = 28;
            label13.Text = "Pet Name:";
            // 
            // txtMicrochip
            // 
            txtMicrochip.BackColor = Color.White;
            txtMicrochip.Font = new Font("Segoe UI", 9F);
            txtMicrochip.Location = new Point(256, 13);
            txtMicrochip.Name = "txtMicrochip";
            txtMicrochip.ReadOnly = true;
            txtMicrochip.Size = new Size(238, 23);
            txtMicrochip.TabIndex = 26;
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarMonthBackground = Color.White;
            dtpDOB.Enabled = false;
            dtpDOB.Font = new Font("Segoe UI", 9F);
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(256, 121);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(238, 23);
            dtpDOB.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(13, 37);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 5, 0, 0);
            label3.Size = new Size(56, 24);
            label3.TabIndex = 17;
            label3.Text = "Species:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(89, 85, 84);
            label5.Location = new Point(13, 118);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 5, 0, 0);
            label5.Size = new Size(90, 24);
            label5.TabIndex = 19;
            label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(89, 85, 84);
            label4.Location = new Point(13, 91);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 5, 0, 0);
            label4.Size = new Size(57, 24);
            label4.TabIndex = 18;
            label4.Text = "Gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(13, 63);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 5, 0, 0);
            label2.Size = new Size(47, 24);
            label2.TabIndex = 16;
            label2.Text = "Breed:";
            // 
            // txtSpecies
            // 
            txtSpecies.BackColor = Color.White;
            txtSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSpecies.Enabled = false;
            txtSpecies.Font = new Font("Segoe UI", 9F);
            txtSpecies.FormattingEnabled = true;
            txtSpecies.Items.AddRange(new object[] { "Dog", "Cat", "etc." });
            txtSpecies.Location = new Point(256, 40);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(238, 23);
            txtSpecies.TabIndex = 22;
            // 
            // txtBreed
            // 
            txtBreed.BackColor = Color.White;
            txtBreed.Font = new Font("Segoe UI", 9F);
            txtBreed.Location = new Point(256, 94);
            txtBreed.Name = "txtBreed";
            txtBreed.ReadOnly = true;
            txtBreed.Size = new Size(238, 23);
            txtBreed.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Enabled = false;
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(256, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 23);
            comboBox1.TabIndex = 27;
            // 
            // VaccineRecordsPanelVet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(VRDSPetPBPanel);
            Controls.Add(VRDSButtonGoBack);
            Controls.Add(VRDSButtonClear);
            Controls.Add(pictureBox2);
            Controls.Add(VRDSVaccineDetailsPanel);
            Controls.Add(VRDSPetInfoPanel);
            Name = "VaccineRecordsPanelVet";
            Size = new Size(800, 590);
            VRDSVaccineDetailsPanel.ResumeLayout(false);
            VRDSVaccineDetailsPanel.PerformLayout();
            VRDSVaccineCard.ResumeLayout(false);
            VRDSVaccineCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPetInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            VRDSPetPBPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VRDSPetPB).EndInit();
            VRDSPetInfoPanel.ResumeLayout(false);
            VRDSPetInfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel VRDSVaccineDetailsPanel;
        private Label label14;
        private Panel VRDSVaccineCard;
        private TextBox txtNotes;
        private Label label12;
        private TextBox txtBatchNo;
        private Label label11;
        private TextBox txtAdministeredBy;
        private Label label10;
        private DateTimePicker dtpNextDue;
        private Label label9;
        private DateTimePicker dtpDateGiven;
        private Label label8;
        private ComboBox cmbVaccineName;
        private Label label7;
        private PictureBox pictureBox2;
        private Button VRDSButtonAddRecord;
        private Button VRDSButtonClear;
        private Button VRDSButtonGoBack;
        private Panel VRDSPetPBPanel;
        private PictureBox VRDSPetPB;
        private TableLayoutPanel VRDSPetInfoPanel;
        private Label label13;
        private TextBox txtMicrochip;
        private ComboBox comboBox1;
        private DateTimePicker dtpDOB;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtBreed;
        private ComboBox txtSpecies;
        private DataGridView dgvPetInfo;
    }
}
