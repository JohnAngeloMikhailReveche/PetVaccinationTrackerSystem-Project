namespace VaccinationForm
{
    partial class VaccinationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pctBanner = new PictureBox();
            pctPetImage = new PictureBox();
            errFields = new ErrorProvider(components);
            tipFields = new ToolTip(components);
            textBox1 = new TextBox();
            dtpNextDue = new DateTimePicker();
            txtAdministeredBy = new TextBox();
            txtBatchNo = new TextBox();
            txtNotes = new TextBox();
            pnlPetInfo = new TableLayoutPanel();
            label13 = new Label();
            txtBreed = new TextBox();
            label1 = new Label();
            txtMicrochip = new TextBox();
            txtSpecies = new ComboBox();
            comboBox1 = new ComboBox();
            dtpDOB = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            pnlVaccineCard = new Panel();
            lnkRemove = new LinkLabel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            dtpDateGiven = new DateTimePicker();
            label8 = new Label();
            cmbVaccineName = new ComboBox();
            label7 = new Label();
            label14 = new Label();
            flpVaccines = new FlowLayoutPanel();
            hopeRoundButton1 = new ReaLTaiizor.Controls.HopeRoundButton();
            hopeRoundButton2 = new ReaLTaiizor.Controls.HopeRoundButton();
            hopeRoundButton3 = new ReaLTaiizor.Controls.HopeRoundButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pctBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPetImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errFields).BeginInit();
            pnlPetInfo.SuspendLayout();
            pnlVaccineCard.SuspendLayout();
            flpVaccines.SuspendLayout();
            SuspendLayout();
            // 
            // pctBanner
            // 
            pctBanner.Dock = DockStyle.Top;
            pctBanner.Image = Properties.Resources.vaccination_records_banner;
            pctBanner.Location = new Point(0, 0);
            pctBanner.Margin = new Padding(0);
            pctBanner.Name = "pctBanner";
            pctBanner.Size = new Size(780, 93);
            pctBanner.SizeMode = PictureBoxSizeMode.Zoom;
            pctBanner.TabIndex = 0;
            pctBanner.TabStop = false;
            // 
            // pctPetImage
            // 
            pctPetImage.BorderStyle = BorderStyle.Fixed3D;
            pctPetImage.Location = new Point(12, 105);
            pctPetImage.Name = "pctPetImage";
            pctPetImage.Size = new Size(150, 150);
            pctPetImage.SizeMode = PictureBoxSizeMode.Zoom;
            pctPetImage.TabIndex = 1;
            pctPetImage.TabStop = false;
            pctPetImage.Click += pctPetImage_Click;
            // 
            // errFields
            // 
            errFields.ContainerControl = this;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(249, 249, 249);
            textBox1.Location = new Point(297, 138);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(288, 23);
            textBox1.TabIndex = 15;
            tipFields.SetToolTip(textBox1, "Select the vaccine given to the pet");
            // 
            // dtpNextDue
            // 
            dtpNextDue.Format = DateTimePickerFormat.Short;
            dtpNextDue.Location = new Point(130, 82);
            dtpNextDue.Name = "dtpNextDue";
            dtpNextDue.Size = new Size(200, 23);
            dtpNextDue.TabIndex = 14;
            tipFields.SetToolTip(dtpNextDue, "Enter the date for the next dose");
            // 
            // txtAdministeredBy
            // 
            txtAdministeredBy.BackColor = Color.FromArgb(249, 249, 249);
            txtAdministeredBy.Location = new Point(460, 12);
            txtAdministeredBy.Name = "txtAdministeredBy";
            txtAdministeredBy.Size = new Size(170, 23);
            txtAdministeredBy.TabIndex = 16;
            tipFields.SetToolTip(txtAdministeredBy, "Enter name of vet or provider");
            // 
            // txtBatchNo
            // 
            txtBatchNo.BackColor = Color.FromArgb(249, 249, 249);
            txtBatchNo.Location = new Point(460, 47);
            txtBatchNo.Name = "txtBatchNo";
            txtBatchNo.Size = new Size(170, 23);
            txtBatchNo.TabIndex = 18;
            tipFields.SetToolTip(txtBatchNo, "Enter the vaccine's batch or lot number");
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(249, 249, 249);
            txtNotes.Location = new Point(130, 120);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(500, 60);
            txtNotes.TabIndex = 20;
            tipFields.SetToolTip(txtNotes, "Add optional notes or reactions observed");
            // 
            // pnlPetInfo
            // 
            pnlPetInfo.ColumnCount = 2;
            pnlPetInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlPetInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlPetInfo.Controls.Add(label13, 0, 0);
            pnlPetInfo.Controls.Add(txtBreed, 1, 2);
            pnlPetInfo.Controls.Add(label1, 0, 6);
            pnlPetInfo.Controls.Add(txtMicrochip, 1, 0);
            pnlPetInfo.Controls.Add(txtSpecies, 1, 1);
            pnlPetInfo.Controls.Add(comboBox1, 1, 3);
            pnlPetInfo.Controls.Add(dtpDOB, 1, 4);
            pnlPetInfo.Controls.Add(textBox1, 1, 5);
            pnlPetInfo.Controls.Add(label3, 0, 1);
            pnlPetInfo.Controls.Add(label5, 0, 4);
            pnlPetInfo.Controls.Add(label6, 0, 5);
            pnlPetInfo.Controls.Add(label4, 0, 3);
            pnlPetInfo.Controls.Add(label2, 0, 2);
            pnlPetInfo.Location = new Point(171, 105);
            pnlPetInfo.Name = "pnlPetInfo";
            pnlPetInfo.RowCount = 7;
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            pnlPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlPetInfo.Size = new Size(588, 162);
            pnlPetInfo.TabIndex = 14;
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
            txtBreed.Location = new Point(297, 57);
            txtBreed.Name = "txtBreed";
            txtBreed.ReadOnly = true;
            txtBreed.Size = new Size(288, 23);
            txtBreed.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(3, 162);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 14;
            label1.Text = "Pet Name:";
            // 
            // txtMicrochip
            // 
            txtMicrochip.BackColor = Color.FromArgb(249, 249, 249);
            txtMicrochip.Location = new Point(297, 3);
            txtMicrochip.Name = "txtMicrochip";
            txtMicrochip.ReadOnly = true;
            txtMicrochip.Size = new Size(288, 23);
            txtMicrochip.TabIndex = 26;
            // 
            // txtSpecies
            // 
            txtSpecies.BackColor = Color.FromArgb(249, 249, 249);
            txtSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSpecies.Enabled = false;
            txtSpecies.FormattingEnabled = true;
            txtSpecies.Items.AddRange(new object[] { "Dog", "Cat", "etc." });
            txtSpecies.Location = new Point(297, 30);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(288, 23);
            txtSpecies.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(249, 249, 249);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(297, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(288, 23);
            comboBox1.TabIndex = 27;
            // 
            // dtpDOB
            // 
            dtpDOB.Enabled = false;
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(297, 111);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(288, 23);
            dtpDOB.TabIndex = 25;
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
            label3.Click += label3_Click_1;
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
            label6.Size = new Size(90, 15);
            label6.TabIndex = 20;
            label6.Text = "Color/Markings";
            label6.Click += label6_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(3, 54);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 16;
            label2.Text = "Breed:";
            label2.Click += label2_Click;
            // 
            // pnlVaccineCard
            // 
            pnlVaccineCard.BackColor = Color.White;
            pnlVaccineCard.BorderStyle = BorderStyle.FixedSingle;
            pnlVaccineCard.Controls.Add(lnkRemove);
            pnlVaccineCard.Controls.Add(txtNotes);
            pnlVaccineCard.Controls.Add(label12);
            pnlVaccineCard.Controls.Add(txtBatchNo);
            pnlVaccineCard.Controls.Add(label11);
            pnlVaccineCard.Controls.Add(txtAdministeredBy);
            pnlVaccineCard.Controls.Add(label10);
            pnlVaccineCard.Controls.Add(dtpNextDue);
            pnlVaccineCard.Controls.Add(label9);
            pnlVaccineCard.Controls.Add(dtpDateGiven);
            pnlVaccineCard.Controls.Add(label8);
            pnlVaccineCard.Controls.Add(cmbVaccineName);
            pnlVaccineCard.Controls.Add(label7);
            pnlVaccineCard.Location = new Point(10, 29);
            pnlVaccineCard.Margin = new Padding(0, 5, 0, 0);
            pnlVaccineCard.Name = "pnlVaccineCard";
            pnlVaccineCard.Size = new Size(660, 191);
            pnlVaccineCard.TabIndex = 0;
            // 
            // lnkRemove
            // 
            lnkRemove.AutoSize = true;
            lnkRemove.LinkColor = Color.Gray;
            lnkRemove.Location = new Point(590, 5);
            lnkRemove.Name = "lnkRemove";
            lnkRemove.Size = new Size(50, 15);
            lnkRemove.TabIndex = 21;
            lnkRemove.TabStop = true;
            lnkRemove.Text = "Remove";
            lnkRemove.VisitedLinkColor = Color.Red;
            lnkRemove.LinkClicked += lnkRemove_LinkClicked;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(89, 85, 84);
            label12.Location = new Point(15, 120);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 19;
            label12.Text = "Notes:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(89, 85, 84);
            label11.Location = new Point(350, 50);
            label11.Name = "label11";
            label11.Size = new Size(81, 15);
            label11.TabIndex = 17;
            label11.Text = "Batch/Lot No:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(89, 85, 84);
            label10.Location = new Point(350, 15);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 15;
            label10.Text = "Administered By:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(89, 85, 84);
            label9.Location = new Point(15, 85);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 13;
            label9.Text = "Next Due Date:";
            // 
            // dtpDateGiven
            // 
            dtpDateGiven.Format = DateTimePickerFormat.Short;
            dtpDateGiven.Location = new Point(130, 47);
            dtpDateGiven.Name = "dtpDateGiven";
            dtpDateGiven.Size = new Size(200, 23);
            dtpDateGiven.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(89, 85, 84);
            label8.Location = new Point(15, 50);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 11;
            label8.Text = "Date Administered:";
            // 
            // cmbVaccineName
            // 
            cmbVaccineName.BackColor = Color.FromArgb(249, 249, 249);
            cmbVaccineName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVaccineName.FormattingEnabled = true;
            cmbVaccineName.Items.AddRange(new object[] { "Rabies", "DHPP", "5-in-1", "6-in-1", "Canine Parvovirus", "Canine Distemper", "Canine Hepatitis", "Leptospirosis", "Bordetella", "Canine Influenza", "Lyme Disease", "Coronavirus (CCV)", "FVRCP", "FVR", "Calicivirus", "Panleukopenia", "FeLV (Feline Leukemia)", "FIV (Feline Immunodeficiency Virus)", "Chlamydia", "Myxomatosis (Rabbit)", "RHDV1 (Rabbit)", "RHDV2 (Rabbit)" });
            cmbVaccineName.Location = new Point(130, 12);
            cmbVaccineName.Name = "cmbVaccineName";
            cmbVaccineName.Size = new Size(200, 23);
            cmbVaccineName.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(89, 85, 84);
            label7.Location = new Point(15, 15);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 0;
            label7.Text = "Vaccine Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(89, 85, 84);
            label14.Location = new Point(13, 5);
            label14.Margin = new Padding(3, 5, 3, 0);
            label14.Name = "label14";
            label14.Size = new Size(137, 19);
            label14.TabIndex = 22;
            label14.Text = "Vaccination Details";
            // 
            // flpVaccines
            // 
            flpVaccines.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpVaccines.AutoScroll = true;
            flpVaccines.BackColor = Color.FromArgb(249, 249, 249);
            flpVaccines.Controls.Add(label14);
            flpVaccines.Controls.Add(pnlVaccineCard);
            flpVaccines.Controls.Add(hopeRoundButton1);
            flpVaccines.FlowDirection = FlowDirection.TopDown;
            flpVaccines.Location = new Point(30, 275);
            flpVaccines.Margin = new Padding(0);
            flpVaccines.Name = "flpVaccines";
            flpVaccines.Padding = new Padding(10, 0, 10, 10);
            flpVaccines.Size = new Size(720, 268);
            flpVaccines.TabIndex = 3;
            flpVaccines.WrapContents = false;
            // 
            // hopeRoundButton1
            // 
            hopeRoundButton1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButton1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButton1.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButton1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopeRoundButton1.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButton1.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButton1.Location = new Point(13, 223);
            hopeRoundButton1.Name = "hopeRoundButton1";
            hopeRoundButton1.PrimaryColor = Color.FromArgb(89, 85, 84);
            hopeRoundButton1.Size = new Size(140, 40);
            hopeRoundButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButton1.TabIndex = 23;
            hopeRoundButton1.Text = "+ Add Record";
            hopeRoundButton1.TextColor = Color.White;
            hopeRoundButton1.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // hopeRoundButton2
            // 
            hopeRoundButton2.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButton2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButton2.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButton2.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopeRoundButton2.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButton2.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButton2.Location = new Point(435, 548);
            hopeRoundButton2.Name = "hopeRoundButton2";
            hopeRoundButton2.PrimaryColor = Color.FromArgb(168, 130, 95);
            hopeRoundButton2.Size = new Size(140, 40);
            hopeRoundButton2.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButton2.TabIndex = 24;
            hopeRoundButton2.Text = "Clear";
            hopeRoundButton2.TextColor = Color.White;
            hopeRoundButton2.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // hopeRoundButton3
            // 
            hopeRoundButton3.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButton3.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButton3.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButton3.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopeRoundButton3.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButton3.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButton3.Location = new Point(605, 548);
            hopeRoundButton3.Name = "hopeRoundButton3";
            hopeRoundButton3.PrimaryColor = Color.FromArgb(89, 85, 84);
            hopeRoundButton3.Size = new Size(140, 40);
            hopeRoundButton3.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButton3.TabIndex = 25;
            hopeRoundButton3.Text = "Save";
            hopeRoundButton3.TextColor = Color.White;
            hopeRoundButton3.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButton3.Click += hopeRoundButton3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(89, 85, 84);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 2);
            panel1.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 593);
            Controls.Add(panel1);
            Controls.Add(hopeRoundButton3);
            Controls.Add(hopeRoundButton2);
            Controls.Add(flpVaccines);
            Controls.Add(pctPetImage);
            Controls.Add(pctBanner);
            Controls.Add(pnlPetInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPetImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errFields).EndInit();
            pnlPetInfo.ResumeLayout(false);
            pnlPetInfo.PerformLayout();
            pnlVaccineCard.ResumeLayout(false);
            pnlVaccineCard.PerformLayout();
            flpVaccines.ResumeLayout(false);
            flpVaccines.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctBanner;
        private PictureBox pctPetImage;
        private ToolTip tipFields;
        private ErrorProvider errFields;
        private TableLayoutPanel pnlPetInfo;
        private TextBox txtBreed;
        private Label label6;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtMicrochip;
        private ComboBox txtSpecies;
        private Label label5;
        private ComboBox comboBox1;
        private DateTimePicker dtpDOB;
        private Label label3;
        private TextBox textBox1;
        private Label label13;
        private FlowLayoutPanel flpVaccines;
        private Label label14;
        private Panel pnlVaccineCard;
        private LinkLabel lnkRemove;
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
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton3;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton2;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton1;
        private Panel panel1;
    }
}
