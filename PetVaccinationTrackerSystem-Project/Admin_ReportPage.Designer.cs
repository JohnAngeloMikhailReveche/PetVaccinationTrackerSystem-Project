namespace petvax_report
{
    partial class Admin_ReportPage
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelSidebar = new Panel();
            txtSearch = new TextBox();
            btnBack = new Button();
            btnPrint = new Button();
            groupPetInfo = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6_OwnersName = new Label();
            label5_Color = new Label();
            label4_Breed = new Label();
            label3_Species = new Label();
            label2_Gender = new Label();
            label_PetName = new Label();
            dgvRecords = new DataGridView();
            colVaccineName = new DataGridViewTextBoxColumn();
            colDateAdmin = new DataGridViewTextBoxColumn();
            colNextDue = new DataGridViewTextBoxColumn();
            colAdministeredBy = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            banner = new PictureBox();
            groupPetInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)banner).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(215, 210, 191);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(234, 684);
            panelSidebar.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(719, 120);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(176, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(89, 85, 84);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(239, 648);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 32);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(203, 168, 128);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(371, 648);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(127, 32);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // groupPetInfo
            // 
            groupPetInfo.BackColor = Color.FromArgb(255, 247, 244);
            groupPetInfo.Controls.Add(textBox7);
            groupPetInfo.Controls.Add(textBox6);
            groupPetInfo.Controls.Add(textBox4);
            groupPetInfo.Controls.Add(textBox3);
            groupPetInfo.Controls.Add(textBox2);
            groupPetInfo.Controls.Add(textBox1);
            groupPetInfo.Controls.Add(label6_OwnersName);
            groupPetInfo.Controls.Add(label5_Color);
            groupPetInfo.Controls.Add(label4_Breed);
            groupPetInfo.Controls.Add(label3_Species);
            groupPetInfo.Controls.Add(label2_Gender);
            groupPetInfo.Controls.Add(label_PetName);
            groupPetInfo.Font = new Font("Calibri", 14F, FontStyle.Bold);
            groupPetInfo.Location = new Point(239, 151);
            groupPetInfo.Margin = new Padding(2);
            groupPetInfo.Name = "groupPetInfo";
            groupPetInfo.Padding = new Padding(2);
            groupPetInfo.Size = new Size(656, 220);
            groupPetInfo.TabIndex = 5;
            groupPetInfo.TabStop = false;
            groupPetInfo.Text = "Pet Information";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(418, 93);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(198, 23);
            textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(418, 58);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(198, 23);
            textBox6.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(85, 175);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(198, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(85, 137);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(85, 99);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(85, 58);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 6;
            // 
            // label6_OwnersName
            // 
            label6_OwnersName.AutoSize = true;
            label6_OwnersName.Font = new Font("Segoe UI", 9F);
            label6_OwnersName.Location = new Point(308, 103);
            label6_OwnersName.Margin = new Padding(4, 0, 4, 0);
            label6_OwnersName.Name = "label6_OwnersName";
            label6_OwnersName.Size = new Size(88, 15);
            label6_OwnersName.TabIndex = 5;
            label6_OwnersName.Text = "Owner's Name:";
            // 
            // label5_Color
            // 
            label5_Color.AutoSize = true;
            label5_Color.Font = new Font("Segoe UI", 9F);
            label5_Color.Location = new Point(308, 65);
            label5_Color.Margin = new Padding(4, 0, 4, 0);
            label5_Color.Name = "label5_Color";
            label5_Color.Size = new Size(39, 15);
            label5_Color.TabIndex = 4;
            label5_Color.Text = "Color:";
            // 
            // label4_Breed
            // 
            label4_Breed.AutoSize = true;
            label4_Breed.Font = new Font("Segoe UI", 9F);
            label4_Breed.Location = new Point(6, 179);
            label4_Breed.Margin = new Padding(4, 0, 4, 0);
            label4_Breed.Name = "label4_Breed";
            label4_Breed.Size = new Size(40, 15);
            label4_Breed.TabIndex = 3;
            label4_Breed.Text = "Breed:";
            // 
            // label3_Species
            // 
            label3_Species.AutoSize = true;
            label3_Species.Font = new Font("Segoe UI", 9F);
            label3_Species.Location = new Point(5, 141);
            label3_Species.Margin = new Padding(4, 0, 4, 0);
            label3_Species.Name = "label3_Species";
            label3_Species.Size = new Size(49, 15);
            label3_Species.TabIndex = 2;
            label3_Species.Text = "Species:";
            // 
            // label2_Gender
            // 
            label2_Gender.AutoSize = true;
            label2_Gender.Font = new Font("Segoe UI", 9F);
            label2_Gender.Location = new Point(6, 103);
            label2_Gender.Margin = new Padding(4, 0, 4, 0);
            label2_Gender.Name = "label2_Gender";
            label2_Gender.Size = new Size(48, 15);
            label2_Gender.TabIndex = 1;
            label2_Gender.Text = "Gender:";
            // 
            // label_PetName
            // 
            label_PetName.AutoSize = true;
            label_PetName.Font = new Font("Segoe UI", 9F);
            label_PetName.Location = new Point(6, 65);
            label_PetName.Margin = new Padding(4, 0, 4, 0);
            label_PetName.Name = "label_PetName";
            label_PetName.Size = new Size(62, 15);
            label_PetName.TabIndex = 0;
            label_PetName.Text = "Pet Name:";
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.BackgroundColor = Color.FromArgb(255, 247, 244);
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Columns.AddRange(new DataGridViewColumn[] { colVaccineName, colDateAdmin, colNextDue, colAdministeredBy, colNotes });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 247, 244);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(203, 168, 128);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvRecords.DefaultCellStyle = dataGridViewCellStyle1;
            dgvRecords.Location = new Point(239, 392);
            dgvRecords.Margin = new Padding(2);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.Size = new Size(656, 241);
            dgvRecords.TabIndex = 6;
            // 
            // colVaccineName
            // 
            colVaccineName.HeaderText = "Vaccine Name";
            colVaccineName.Name = "colVaccineName";
            colVaccineName.ReadOnly = true;
            // 
            // colDateAdmin
            // 
            colDateAdmin.HeaderText = "Date Administered";
            colDateAdmin.Name = "colDateAdmin";
            colDateAdmin.ReadOnly = true;
            // 
            // colNextDue
            // 
            colNextDue.HeaderText = "Next Due Date";
            colNextDue.Name = "colNextDue";
            colNextDue.ReadOnly = true;
            // 
            // colAdministeredBy
            // 
            colAdministeredBy.HeaderText = "Administered By";
            colAdministeredBy.Name = "colAdministeredBy";
            colAdministeredBy.ReadOnly = true;
            // 
            // colNotes
            // 
            colNotes.HeaderText = "Notes";
            colNotes.Name = "colNotes";
            colNotes.ReadOnly = true;
            // 
            // banner
            // 
            banner.BackgroundImageLayout = ImageLayout.Zoom;
            banner.Dock = DockStyle.Top;
            banner.Image = PetVaccinationTrackerSystem_Project.Properties.Resources.vaccination_reports_banner;
            banner.Location = new Point(0, 0);
            banner.Margin = new Padding(4, 3, 4, 3);
            banner.Name = "banner";
            banner.Size = new Size(910, 107);
            banner.SizeMode = PictureBoxSizeMode.Zoom;
            banner.TabIndex = 1;
            banner.TabStop = false;
            // 
            // Admin_ReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(910, 684);
            Controls.Add(banner);
            Controls.Add(panelSidebar);
            Controls.Add(txtSearch);
            Controls.Add(btnBack);
            Controls.Add(btnPrint);
            Controls.Add(groupPetInfo);
            Controls.Add(dgvRecords);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Admin_ReportPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetVax - Report Page";
            groupPetInfo.ResumeLayout(false);
            groupPetInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)banner).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupPetInfo;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaccineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdministeredBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.Label label6_OwnersName;
        private System.Windows.Forms.Label label5_Color;
        private System.Windows.Forms.Label label4_Breed;
        private System.Windows.Forms.Label label3_Species;
        private System.Windows.Forms.Label label2_Gender;
        private System.Windows.Forms.Label label_PetName;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}



