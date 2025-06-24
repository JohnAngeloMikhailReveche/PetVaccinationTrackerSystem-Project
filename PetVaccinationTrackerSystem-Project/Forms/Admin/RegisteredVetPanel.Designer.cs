namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class RegisteredVetPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisteredVetPanel));
            dgvVetList = new DataGridView();
            cmbboxFilterVet = new ComboBox();
            txtboxSearchVet = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSearchVet = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)dgvVetList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvVetList
            // 
            dgvVetList.AllowUserToAddRows = false;
            dgvVetList.BackgroundColor = Color.White;
            dgvVetList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVetList.Location = new Point(24, 195);
            dgvVetList.MultiSelect = false;
            dgvVetList.Name = "dgvVetList";
            dgvVetList.ReadOnly = true;
            dgvVetList.Size = new Size(754, 380);
            dgvVetList.TabIndex = 5;
            dgvVetList.DoubleClick += dgvVetList_DoubleClick;
            // 
            // cmbboxFilterVet
            // 
            cmbboxFilterVet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxFilterVet.Font = new Font("Segoe UI", 10F);
            cmbboxFilterVet.FormattingEnabled = true;
            cmbboxFilterVet.Location = new Point(537, 157);
            cmbboxFilterVet.Name = "cmbboxFilterVet";
            cmbboxFilterVet.Size = new Size(140, 25);
            cmbboxFilterVet.TabIndex = 8;
            // 
            // txtboxSearchVet
            // 
            txtboxSearchVet.Font = new Font("Segoe UI", 10F);
            txtboxSearchVet.Location = new Point(156, 157);
            txtboxSearchVet.Name = "txtboxSearchVet";
            txtboxSearchVet.Size = new Size(367, 25);
            txtboxSearchVet.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(24, 158);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 6;
            label1.Text = "Filter and Search:";
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
            // btnSearchVet
            // 
            btnSearchVet.BorderColor = Color.FromArgb(220, 223, 230);
            btnSearchVet.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSearchVet.DangerColor = Color.FromArgb(245, 108, 108);
            btnSearchVet.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSearchVet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchVet.HoverTextColor = Color.White;
            btnSearchVet.InfoColor = Color.FromArgb(144, 147, 153);
            btnSearchVet.Location = new Point(688, 153);
            btnSearchVet.Name = "btnSearchVet";
            btnSearchVet.PrimaryColor = Color.FromArgb(89, 85, 84);
            btnSearchVet.Size = new Size(90, 30);
            btnSearchVet.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSearchVet.TabIndex = 11;
            btnSearchVet.Text = "Search";
            btnSearchVet.TextColor = Color.White;
            btnSearchVet.WarningColor = Color.FromArgb(230, 162, 60);
            btnSearchVet.Click += btnSearchVet_Click;
            // 
            // RegisteredVetPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSearchVet);
            Controls.Add(panel1);
            Controls.Add(dgvVetList);
            Controls.Add(cmbboxFilterVet);
            Controls.Add(txtboxSearchVet);
            Controls.Add(label1);
            Name = "RegisteredVetPanel";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)dgvVetList).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVetList;
        private ComboBox cmbboxFilterVet;
        private TextBox txtboxSearchVet;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeRoundButton btnSearchVet;
    }
}
