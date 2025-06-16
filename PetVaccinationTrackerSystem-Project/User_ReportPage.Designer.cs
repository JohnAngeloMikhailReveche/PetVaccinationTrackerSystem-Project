namespace petvax_report
{
    partial class User_ReportPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupPetInfo = new System.Windows.Forms.GroupBox();
            this.label6_OwnersName = new System.Windows.Forms.Label();
            this.label5_Color = new System.Windows.Forms.Label();
            this.label4_Breed = new System.Windows.Forms.Label();
            this.label3_Species = new System.Windows.Forms.Label();
            this.label2_Gender = new System.Windows.Forms.Label();
            this.label_PetName = new System.Windows.Forms.Label();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.colVaccineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdministeredBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banner = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupPetInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(616, 104);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 23);
            this.txtSearch.TabIndex = 2;
            //this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(11, 554);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(128)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(124, 554);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 28);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupPetInfo
            // 
            this.groupPetInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.groupPetInfo.Controls.Add(this.textBox5);
            this.groupPetInfo.Controls.Add(this.textBox4);
            this.groupPetInfo.Controls.Add(this.textBox3);
            this.groupPetInfo.Controls.Add(this.textBox2);
            this.groupPetInfo.Controls.Add(this.textBox1);
            this.groupPetInfo.Controls.Add(this.textBox6);
            this.groupPetInfo.Controls.Add(this.label6_OwnersName);
            this.groupPetInfo.Controls.Add(this.label5_Color);
            this.groupPetInfo.Controls.Add(this.label4_Breed);
            this.groupPetInfo.Controls.Add(this.label3_Species);
            this.groupPetInfo.Controls.Add(this.label2_Gender);
            this.groupPetInfo.Controls.Add(this.label_PetName);
            this.groupPetInfo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.groupPetInfo.Location = new System.Drawing.Point(11, 133);
            this.groupPetInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupPetInfo.Name = "groupPetInfo";
            this.groupPetInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupPetInfo.Size = new System.Drawing.Size(758, 191);
            this.groupPetInfo.TabIndex = 5;
            this.groupPetInfo.TabStop = false;
            this.groupPetInfo.Text = "Pet Information";
            //this.groupPetInfo.Enter += new System.EventHandler(this.groupPetInfo_Enter);
            // 
            // label6_OwnersName
            // 
            this.label6_OwnersName.AutoSize = true;
            this.label6_OwnersName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6_OwnersName.Location = new System.Drawing.Point(264, 89);
            this.label6_OwnersName.Name = "label6_OwnersName";
            this.label6_OwnersName.Size = new System.Drawing.Size(88, 15);
            this.label6_OwnersName.TabIndex = 5;
            this.label6_OwnersName.Text = "Owner\'s Name:";
            // 
            // label5_Color
            // 
            this.label5_Color.AutoSize = true;
            this.label5_Color.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5_Color.Location = new System.Drawing.Point(264, 56);
            this.label5_Color.Name = "label5_Color";
            this.label5_Color.Size = new System.Drawing.Size(39, 15);
            this.label5_Color.TabIndex = 4;
            this.label5_Color.Text = "Color:";
            // 
            // label4_Breed
            // 
            this.label4_Breed.AutoSize = true;
            this.label4_Breed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4_Breed.Location = new System.Drawing.Point(5, 155);
            this.label4_Breed.Name = "label4_Breed";
            this.label4_Breed.Size = new System.Drawing.Size(40, 15);
            this.label4_Breed.TabIndex = 3;
            this.label4_Breed.Text = "Breed:";
            //this.label4_Breed.Click += new System.EventHandler(this.label4_Breed_Click);
            // 
            // label3_Species
            // 
            this.label3_Species.AutoSize = true;
            this.label3_Species.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3_Species.Location = new System.Drawing.Point(4, 122);
            this.label3_Species.Name = "label3_Species";
            this.label3_Species.Size = new System.Drawing.Size(49, 15);
            this.label3_Species.TabIndex = 2;
            this.label3_Species.Text = "Species:";
            //this.label3_Species.Click += new System.EventHandler(this.label3_Species_Click);
            // 
            // label2_Gender
            // 
            this.label2_Gender.AutoSize = true;
            this.label2_Gender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2_Gender.Location = new System.Drawing.Point(5, 89);
            this.label2_Gender.Name = "label2_Gender";
            this.label2_Gender.Size = new System.Drawing.Size(48, 15);
            this.label2_Gender.TabIndex = 1;
            this.label2_Gender.Text = "Gender:";
            //this.label2_Gender.Click += new System.EventHandler(this.label2_Gender_Click);
            // 
            // label_PetName
            // 
            this.label_PetName.AutoSize = true;
            this.label_PetName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_PetName.Location = new System.Drawing.Point(5, 56);
            this.label_PetName.Name = "label_PetName";
            this.label_PetName.Size = new System.Drawing.Size(62, 15);
            this.label_PetName.TabIndex = 0;
            this.label_PetName.Text = "Pet Name:";
            //this.label_PetName.Click += new System.EventHandler(this.label_PetName_Click);
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVaccineName,
            this.colDateAdmin,
            this.colNextDue,
            this.colAdministeredBy,
            this.colNotes});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(168)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecords.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecords.Location = new System.Drawing.Point(11, 339);
            this.dgvRecords.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.Size = new System.Drawing.Size(758, 209);
            this.dgvRecords.TabIndex = 6;
            //this.dgvRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecords_CellContentClick);
            // 
            // colVaccineName
            // 
            this.colVaccineName.HeaderText = "Vaccine Name";
            this.colVaccineName.Name = "colVaccineName";
            this.colVaccineName.ReadOnly = true;
            // 
            // colDateAdmin
            // 
            this.colDateAdmin.HeaderText = "Date Administered";
            this.colDateAdmin.Name = "colDateAdmin";
            this.colDateAdmin.ReadOnly = true;
            // 
            // colNextDue
            // 
            this.colNextDue.HeaderText = "Next Due Date";
            this.colNextDue.Name = "colNextDue";
            this.colNextDue.ReadOnly = true;
            // 
            // colAdministeredBy
            // 
            this.colAdministeredBy.HeaderText = "Administered By";
            this.colAdministeredBy.Name = "colAdministeredBy";
            this.colAdministeredBy.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // banner
            // 
            this.banner.BackgroundImage = global::PetVaccinationTrackerSystem_Project.Properties.Resources.vaccination_reports_banner;
            this.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(780, 93);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.banner.TabIndex = 1;
            this.banner.TabStop = false;
            //this.banner.Click += new System.EventHandler(this.banner_Click_1);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(73, 53);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(170, 23);
            this.textBox6.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(73, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 23);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(73, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 23);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(73, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 23);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(358, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 23);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(358, 86);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 23);
            this.textBox5.TabIndex = 16;
            // 
            // User_ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 593);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupPetInfo);
            this.Controls.Add(this.dgvRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "User_ReportPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetVax - Report Page";
            this.groupPetInfo.ResumeLayout(false);
            this.groupPetInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
    }
}



