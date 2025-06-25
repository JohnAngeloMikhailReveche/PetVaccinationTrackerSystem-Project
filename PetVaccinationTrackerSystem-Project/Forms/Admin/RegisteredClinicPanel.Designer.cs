namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class RegisteredClinicPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisteredClinicPanel));
            cmbboxFilterClinic = new ComboBox();
            txtboxSearchClinic = new TextBox();
            label2 = new Label();
            dgvClinicList = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSearchClinic = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)dgvClinicList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbboxFilterClinic
            // 
            cmbboxFilterClinic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxFilterClinic.Font = new Font("Segoe UI", 10F);
            cmbboxFilterClinic.FormattingEnabled = true;
            cmbboxFilterClinic.Location = new Point(537, 157);
            cmbboxFilterClinic.Name = "cmbboxFilterClinic";
            cmbboxFilterClinic.Size = new Size(140, 25);
            cmbboxFilterClinic.TabIndex = 8;
            // 
            // txtboxSearchClinic
            // 
            txtboxSearchClinic.Font = new Font("Segoe UI", 10F);
            txtboxSearchClinic.Location = new Point(156, 157);
            txtboxSearchClinic.Name = "txtboxSearchClinic";
            txtboxSearchClinic.Size = new Size(367, 25);
            txtboxSearchClinic.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(24, 158);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 6;
            label2.Text = "Filter and Search:";
            // 
            // dgvClinicList
            // 
            dgvClinicList.AllowUserToAddRows = false;
            dgvClinicList.BackgroundColor = Color.White;
            dgvClinicList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClinicList.Location = new Point(24, 195);
            dgvClinicList.MultiSelect = false;
            dgvClinicList.Name = "dgvClinicList";
            dgvClinicList.ReadOnly = true;
            dgvClinicList.Size = new Size(754, 380);
            dgvClinicList.TabIndex = 5;
            dgvClinicList.DoubleClick += dgvClinicList_DoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 150);
            panel1.TabIndex = 10;
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
            // btnSearchClinic
            // 
            btnSearchClinic.BackColor = Color.FromArgb(63, 59, 58);
            btnSearchClinic.BorderColor = Color.FromArgb(220, 223, 230);
            btnSearchClinic.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSearchClinic.DangerColor = Color.FromArgb(245, 108, 108);
            btnSearchClinic.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSearchClinic.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchClinic.HoverTextColor = Color.White;
            btnSearchClinic.InfoColor = Color.FromArgb(144, 147, 153);
            btnSearchClinic.Location = new Point(688, 153);
            btnSearchClinic.Name = "btnSearchClinic";
            btnSearchClinic.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnSearchClinic.Size = new Size(90, 30);
            btnSearchClinic.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSearchClinic.TabIndex = 11;
            btnSearchClinic.Text = "Search";
            btnSearchClinic.TextColor = Color.White;
            btnSearchClinic.WarningColor = Color.FromArgb(230, 162, 60);
            btnSearchClinic.Click += btnSearchClinic_Click;
            // 
            // RegisteredClinicPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSearchClinic);
            Controls.Add(panel1);
            Controls.Add(cmbboxFilterClinic);
            Controls.Add(txtboxSearchClinic);
            Controls.Add(label2);
            Controls.Add(dgvClinicList);
            Name = "RegisteredClinicPanel";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)dgvClinicList).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbboxFilterClinic;
        private TextBox txtboxSearchClinic;
        private Label label2;
        private DataGridView dgvClinicList;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeRoundButton btnSearchClinic;
    }
}
