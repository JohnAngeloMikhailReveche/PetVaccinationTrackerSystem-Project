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
            btnClear = new ReaLTaiizor.Controls.HopeRoundButton();
            btnAddRecord = new ReaLTaiizor.Controls.HopeRoundButton();
            label6 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label5 = new Label();
            txtBreed = new TextBox();
            label1 = new Label();
            txtPetName = new TextBox();
            txtSpecies = new TextBox();
            label4 = new Label();
            txtPetID = new TextBox();
            txtGender = new TextBox();
            label3 = new Label();
            label14 = new Label();
            VRDSVaccineCard = new Panel();
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
            VRDSVaccineDetailsPanel.SuspendLayout();
            panel1.SuspendLayout();
            VRDSVaccineCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // VRDSVaccineDetailsPanel
            // 
            VRDSVaccineDetailsPanel.BackColor = Color.FromArgb(249, 249, 249);
            VRDSVaccineDetailsPanel.Controls.Add(btnClear);
            VRDSVaccineDetailsPanel.Controls.Add(btnAddRecord);
            VRDSVaccineDetailsPanel.Controls.Add(label6);
            VRDSVaccineDetailsPanel.Controls.Add(panel1);
            VRDSVaccineDetailsPanel.Controls.Add(label14);
            VRDSVaccineDetailsPanel.Controls.Add(VRDSVaccineCard);
            VRDSVaccineDetailsPanel.Location = new Point(51, 85);
            VRDSVaccineDetailsPanel.Name = "VRDSVaccineDetailsPanel";
            VRDSVaccineDetailsPanel.Size = new Size(697, 479);
            VRDSVaccineDetailsPanel.TabIndex = 17;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(63, 59, 58);
            btnClear.BorderColor = Color.FromArgb(220, 223, 230);
            btnClear.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnClear.DangerColor = Color.FromArgb(245, 108, 108);
            btnClear.DefaultColor = Color.FromArgb(255, 255, 255);
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.HoverTextColor = Color.White;
            btnClear.InfoColor = Color.FromArgb(144, 147, 153);
            btnClear.Location = new Point(560, 424);
            btnClear.Name = "btnClear";
            btnClear.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnClear.Size = new Size(120, 40);
            btnClear.SuccessColor = Color.FromArgb(103, 194, 58);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.TextColor = Color.White;
            btnClear.WarningColor = Color.FromArgb(230, 162, 60);
            btnClear.Click += btnClear_Click;
            // 
            // btnAddRecord
            // 
            btnAddRecord.BackColor = Color.FromArgb(63, 59, 58);
            btnAddRecord.BorderColor = Color.FromArgb(220, 223, 230);
            btnAddRecord.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnAddRecord.DangerColor = Color.FromArgb(245, 108, 108);
            btnAddRecord.DefaultColor = Color.FromArgb(255, 255, 255);
            btnAddRecord.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRecord.HoverTextColor = Color.White;
            btnAddRecord.InfoColor = Color.FromArgb(144, 147, 153);
            btnAddRecord.Location = new Point(414, 424);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnAddRecord.Size = new Size(140, 40);
            btnAddRecord.SuccessColor = Color.FromArgb(103, 194, 58);
            btnAddRecord.TabIndex = 32;
            btnAddRecord.Text = "Add Record";
            btnAddRecord.TextColor = Color.White;
            btnAddRecord.WarningColor = Color.FromArgb(230, 162, 60);
            btnAddRecord.Click += btnAddRecord_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(89, 85, 84);
            label6.Location = new Point(17, 16);
            label6.Name = "label6";
            label6.Size = new Size(131, 21);
            label6.TabIndex = 31;
            label6.Text = "Pet Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBreed);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPetName);
            panel1.Controls.Add(txtSpecies);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPetID);
            panel1.Controls.Add(txtGender);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(17, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 140);
            panel1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 1;
            label2.Text = "Pet Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(89, 85, 84);
            label5.Location = new Point(360, 75);
            label5.Name = "label5";
            label5.Size = new Size(47, 19);
            label5.TabIndex = 4;
            label5.Text = "Breed:";
            // 
            // txtBreed
            // 
            txtBreed.BackColor = Color.White;
            txtBreed.Font = new Font("Segoe UI", 10F);
            txtBreed.Location = new Point(360, 97);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(284, 25);
            txtBreed.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(360, 14);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 0;
            label1.Text = "Pet ID:";
            // 
            // txtPetName
            // 
            txtPetName.BackColor = Color.White;
            txtPetName.Font = new Font("Segoe UI", 10F);
            txtPetName.Location = new Point(17, 36);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(330, 25);
            txtPetName.TabIndex = 6;
            // 
            // txtSpecies
            // 
            txtSpecies.BackColor = Color.White;
            txtSpecies.Font = new Font("Segoe UI", 10F);
            txtSpecies.Location = new Point(190, 97);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(137, 25);
            txtSpecies.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(89, 85, 84);
            label4.Location = new Point(190, 75);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 3;
            label4.Text = "Species:";
            // 
            // txtPetID
            // 
            txtPetID.BackColor = Color.White;
            txtPetID.Font = new Font("Segoe UI", 10F);
            txtPetID.Location = new Point(360, 36);
            txtPetID.Name = "txtPetID";
            txtPetID.Size = new Size(284, 25);
            txtPetID.TabIndex = 5;
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.White;
            txtGender.Font = new Font("Segoe UI", 10F);
            txtGender.Location = new Point(17, 97);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(140, 25);
            txtGender.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(17, 75);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 2;
            label3.Text = "Gender:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(89, 85, 84);
            label14.Location = new Point(17, 196);
            label14.Name = "label14";
            label14.Size = new Size(157, 21);
            label14.TabIndex = 2;
            label14.Text = "Vaccination Details";
            // 
            // VRDSVaccineCard
            // 
            VRDSVaccineCard.BackColor = Color.White;
            VRDSVaccineCard.BorderStyle = BorderStyle.FixedSingle;
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
            VRDSVaccineCard.Location = new Point(17, 220);
            VRDSVaccineCard.Margin = new Padding(20, 5, 0, 0);
            VRDSVaccineCard.Name = "VRDSVaccineCard";
            VRDSVaccineCard.Size = new Size(663, 191);
            VRDSVaccineCard.TabIndex = 1;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(249, 249, 249);
            txtNotes.Location = new Point(79, 120);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(565, 60);
            txtNotes.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.ForeColor = Color.FromArgb(89, 85, 84);
            label12.Location = new Point(16, 120);
            label12.Name = "label12";
            label12.Size = new Size(48, 19);
            label12.TabIndex = 19;
            label12.Text = "Notes:";
            // 
            // txtBatchNo
            // 
            txtBatchNo.BackColor = Color.White;
            txtBatchNo.Font = new Font("Segoe UI", 10F);
            txtBatchNo.Location = new Point(484, 47);
            txtBatchNo.Name = "txtBatchNo";
            txtBatchNo.Size = new Size(160, 25);
            txtBatchNo.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.FromArgb(89, 85, 84);
            label11.Location = new Point(364, 50);
            label11.Name = "label11";
            label11.Size = new Size(93, 19);
            label11.TabIndex = 17;
            label11.Text = "Batch/Lot No:";
            // 
            // txtAdministeredBy
            // 
            txtAdministeredBy.BackColor = Color.White;
            txtAdministeredBy.Font = new Font("Segoe UI", 10F);
            txtAdministeredBy.Location = new Point(484, 12);
            txtAdministeredBy.Name = "txtAdministeredBy";
            txtAdministeredBy.Size = new Size(160, 25);
            txtAdministeredBy.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.FromArgb(89, 85, 84);
            label10.Location = new Point(363, 15);
            label10.Name = "label10";
            label10.Size = new Size(112, 19);
            label10.TabIndex = 15;
            label10.Text = "Administered By:";
            // 
            // dtpNextDue
            // 
            dtpNextDue.CalendarMonthBackground = Color.White;
            dtpNextDue.Format = DateTimePickerFormat.Short;
            dtpNextDue.Location = new Point(152, 82);
            dtpNextDue.Name = "dtpNextDue";
            dtpNextDue.Size = new Size(200, 23);
            dtpNextDue.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.FromArgb(89, 85, 84);
            label9.Location = new Point(16, 85);
            label9.Name = "label9";
            label9.Size = new Size(102, 19);
            label9.TabIndex = 13;
            label9.Text = "Next Due Date:";
            // 
            // dtpDateGiven
            // 
            dtpDateGiven.CalendarMonthBackground = Color.White;
            dtpDateGiven.Format = DateTimePickerFormat.Short;
            dtpDateGiven.Location = new Point(152, 47);
            dtpDateGiven.Name = "dtpDateGiven";
            dtpDateGiven.Size = new Size(200, 23);
            dtpDateGiven.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(89, 85, 84);
            label8.Location = new Point(16, 50);
            label8.Name = "label8";
            label8.Size = new Size(126, 19);
            label8.TabIndex = 11;
            label8.Text = "Date Administered:";
            // 
            // cmbVaccineName
            // 
            cmbVaccineName.BackColor = Color.White;
            cmbVaccineName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVaccineName.Font = new Font("Segoe UI", 10F);
            cmbVaccineName.FormattingEnabled = true;
            cmbVaccineName.Items.AddRange(new object[] { "Rabies", "DHPP", "5-in-1", "6-in-1", "Canine Parvovirus", "Canine Distemper", "Canine Hepatitis", "Leptospirosis", "Bordetella", "Canine Influenza", "Lyme Disease", "Coronavirus (CCV)", "FVRCP", "FVR", "Calicivirus", "Panleukopenia", "FeLV (Feline Leukemia)", "FIV (Feline Immunodeficiency Virus)", "Chlamydia", "Myxomatosis (Rabbit)", "RHDV1 (Rabbit)", "RHDV2 (Rabbit)" });
            cmbVaccineName.Location = new Point(152, 12);
            cmbVaccineName.Name = "cmbVaccineName";
            cmbVaccineName.Size = new Size(200, 25);
            cmbVaccineName.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(89, 85, 84);
            label7.Location = new Point(16, 15);
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
            // VaccineRecordsPanelVet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox2);
            Controls.Add(VRDSVaccineDetailsPanel);
            Name = "VaccineRecordsPanelVet";
            Size = new Size(800, 590);
            VRDSVaccineDetailsPanel.ResumeLayout(false);
            VRDSVaccineDetailsPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            VRDSVaccineCard.ResumeLayout(false);
            VRDSVaccineCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtGender;
        private TextBox txtPetName;
        private TextBox txtPetID;
        private TextBox txtBreed;
        private TextBox txtSpecies;
        private Panel panel1;
        private Label label6;
        private ReaLTaiizor.Controls.HopeRoundButton btnAddRecord;
        private ReaLTaiizor.Controls.HopeRoundButton btnClear;
    }
}
