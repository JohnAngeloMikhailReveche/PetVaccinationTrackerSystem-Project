namespace PetVaccinationTrackerSystem_Project.Forms
{
    partial class InboxForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InboxForm));
            dgvEmails = new DataGridView();
            cmbFilters = new ComboBox();
            txtSearchBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            mainFormVButtonExit = new Button();
            btnWriteEmail = new ReaLTaiizor.Controls.HopeRoundButton();
            btnSearch = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)dgvEmails).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmails
            // 
            dgvEmails.AllowUserToAddRows = false;
            dgvEmails.BackgroundColor = Color.White;
            dgvEmails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmails.Location = new Point(25, 110);
            dgvEmails.MultiSelect = false;
            dgvEmails.Name = "dgvEmails";
            dgvEmails.ReadOnly = true;
            dgvEmails.Size = new Size(754, 360);
            dgvEmails.TabIndex = 6;
            dgvEmails.DoubleClick += dgvEmails_DoubleClick;
            // 
            // cmbFilters
            // 
            cmbFilters.BackColor = Color.White;
            cmbFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilters.Font = new Font("Segoe UI", 10F);
            cmbFilters.FormattingEnabled = true;
            cmbFilters.Location = new Point(451, 66);
            cmbFilters.Name = "cmbFilters";
            cmbFilters.Size = new Size(225, 25);
            cmbFilters.TabIndex = 7;
            // 
            // txtSearchBox
            // 
            txtSearchBox.BackColor = Color.White;
            txtSearchBox.Font = new Font("Segoe UI", 10F);
            txtSearchBox.Location = new Point(146, 66);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(295, 25);
            txtSearchBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(130, 54);
            label1.TabIndex = 10;
            label1.Text = "Inbox";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 59, 58);
            panel1.Controls.Add(mainFormVButtonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 30);
            panel1.TabIndex = 11;
            // 
            // mainFormVButtonExit
            // 
            mainFormVButtonExit.BackColor = Color.FromArgb(63, 59, 58);
            mainFormVButtonExit.BackgroundImage = (Image)resources.GetObject("mainFormVButtonExit.BackgroundImage");
            mainFormVButtonExit.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormVButtonExit.FlatAppearance.BorderSize = 0;
            mainFormVButtonExit.FlatStyle = FlatStyle.Flat;
            mainFormVButtonExit.Location = new Point(775, 7);
            mainFormVButtonExit.Name = "mainFormVButtonExit";
            mainFormVButtonExit.Size = new Size(15, 15);
            mainFormVButtonExit.TabIndex = 16;
            mainFormVButtonExit.UseVisualStyleBackColor = false;
            mainFormVButtonExit.Click += mainFormVButtonExit_Click;
            // 
            // btnWriteEmail
            // 
            btnWriteEmail.BackColor = Color.FromArgb(63, 59, 58);
            btnWriteEmail.BorderColor = Color.FromArgb(220, 223, 230);
            btnWriteEmail.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnWriteEmail.DangerColor = Color.FromArgb(245, 108, 108);
            btnWriteEmail.DefaultColor = Color.FromArgb(255, 255, 255);
            btnWriteEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWriteEmail.ForeColor = Color.White;
            btnWriteEmail.HoverTextColor = Color.White;
            btnWriteEmail.InfoColor = Color.FromArgb(144, 147, 153);
            btnWriteEmail.Location = new Point(646, 487);
            btnWriteEmail.Name = "btnWriteEmail";
            btnWriteEmail.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnWriteEmail.Size = new Size(130, 35);
            btnWriteEmail.SuccessColor = Color.FromArgb(103, 194, 58);
            btnWriteEmail.TabIndex = 12;
            btnWriteEmail.Text = "Write Email";
            btnWriteEmail.TextColor = Color.White;
            btnWriteEmail.WarningColor = Color.FromArgb(230, 162, 60);
            btnWriteEmail.Click += btnWriteEmail_Click;
            // 
            // btnSearch
            // 
            btnSearch.BorderColor = Color.FromArgb(220, 223, 230);
            btnSearch.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSearch.DangerColor = Color.FromArgb(245, 108, 108);
            btnSearch.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.HoverTextColor = Color.White;
            btnSearch.InfoColor = Color.FromArgb(144, 147, 153);
            btnSearch.Location = new Point(689, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnSearch.Size = new Size(90, 30);
            btnSearch.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.TextColor = Color.White;
            btnSearch.WarningColor = Color.FromArgb(230, 162, 60);
            btnSearch.Click += btnSearch_Click;
            // 
            // InboxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(802, 545);
            Controls.Add(btnSearch);
            Controls.Add(btnWriteEmail);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txtSearchBox);
            Controls.Add(cmbFilters);
            Controls.Add(dgvEmails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InboxForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inbox";
            Load += InboxForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmails).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmails;
        private ComboBox cmbFilters;
        private TextBox txtSearchBox;
        private Label label1;
        private Panel panel1;
        private Button mainFormVButtonExit;
        private ReaLTaiizor.Controls.HopeRoundButton btnWriteEmail;
        private ReaLTaiizor.Controls.HopeRoundButton btnSearch;
    }
}