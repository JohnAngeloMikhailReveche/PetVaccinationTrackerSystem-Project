namespace PetVaccinationTrackerSystem_Project
{
    partial class TablePetProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablePetProfile));
            label2 = new Label();
            dgvPetProfile = new DataGridView();
            txtboxSearchPet = new TextBox();
            cmbFilterSpecies = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSearchPetProfile = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)dgvPetProfile).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(24, 158);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 7;
            label2.Text = "Filter and Search:";
            // 
            // dgvPetProfile
            // 
            dgvPetProfile.AllowUserToAddRows = false;
            dgvPetProfile.BackgroundColor = Color.White;
            dgvPetProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetProfile.Location = new Point(24, 195);
            dgvPetProfile.MultiSelect = false;
            dgvPetProfile.Name = "dgvPetProfile";
            dgvPetProfile.ReadOnly = true;
            dgvPetProfile.Size = new Size(754, 380);
            dgvPetProfile.TabIndex = 8;
            // 
            // txtboxSearchPet
            // 
            txtboxSearchPet.Font = new Font("Segoe UI", 10F);
            txtboxSearchPet.Location = new Point(156, 157);
            txtboxSearchPet.Name = "txtboxSearchPet";
            txtboxSearchPet.Size = new Size(270, 25);
            txtboxSearchPet.TabIndex = 9;
            // 
            // cmbFilterSpecies
            // 
            cmbFilterSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterSpecies.Font = new Font("Segoe UI", 10F);
            cmbFilterSpecies.FormattingEnabled = true;
            cmbFilterSpecies.Items.AddRange(new object[] { "Dog", "Cat" });
            cmbFilterSpecies.Location = new Point(561, 157);
            cmbFilterSpecies.Name = "cmbFilterSpecies";
            cmbFilterSpecies.Size = new Size(121, 25);
            cmbFilterSpecies.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 150);
            panel1.TabIndex = 13;
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
            // btnSearchPetProfile
            // 
            btnSearchPetProfile.BorderColor = Color.FromArgb(220, 223, 230);
            btnSearchPetProfile.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSearchPetProfile.DangerColor = Color.FromArgb(245, 108, 108);
            btnSearchPetProfile.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSearchPetProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchPetProfile.HoverTextColor = Color.White;
            btnSearchPetProfile.InfoColor = Color.FromArgb(144, 147, 153);
            btnSearchPetProfile.Location = new Point(688, 153);
            btnSearchPetProfile.Name = "btnSearchPetProfile";
            btnSearchPetProfile.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnSearchPetProfile.Size = new Size(90, 30);
            btnSearchPetProfile.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSearchPetProfile.TabIndex = 15;
            btnSearchPetProfile.Text = "Search";
            btnSearchPetProfile.TextColor = Color.White;
            btnSearchPetProfile.WarningColor = Color.FromArgb(230, 162, 60);
            btnSearchPetProfile.Click += btnSearchPetProfile_Click;
            // 
            // TablePetProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSearchPetProfile);
            Controls.Add(panel1);
            Controls.Add(cmbFilterSpecies);
            Controls.Add(txtboxSearchPet);
            Controls.Add(dgvPetProfile);
            Controls.Add(label2);
            Name = "TablePetProfile";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)dgvPetProfile).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvPetProfile;
        private TextBox txtboxSearchPet;
        private ComboBox cmbFilterSpecies;
        private Panel panel1;
        private ReaLTaiizor.Controls.HopeRoundButton btnSearchPetProfile;
        private PictureBox pictureBox1;
    }
}
