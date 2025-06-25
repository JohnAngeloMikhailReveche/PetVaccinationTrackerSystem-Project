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
            dgvEmails = new DataGridView();
            cmbFilters = new ComboBox();
            btnSearch = new Button();
            txtSearchBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmails).BeginInit();
            SuspendLayout();
            // 
            // dgvEmails
            // 
            dgvEmails.AllowUserToAddRows = false;
            dgvEmails.BackgroundColor = Color.White;
            dgvEmails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmails.Location = new Point(23, 109);
            dgvEmails.MultiSelect = false;
            dgvEmails.Name = "dgvEmails";
            dgvEmails.ReadOnly = true;
            dgvEmails.Size = new Size(754, 360);
            dgvEmails.TabIndex = 6;
            dgvEmails.DoubleClick += dgvEmails_DoubleClick;
            // 
            // cmbFilters
            // 
            cmbFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilters.FormattingEnabled = true;
            cmbFilters.Location = new Point(452, 69);
            cmbFilters.Name = "cmbFilters";
            cmbFilters.Size = new Size(202, 23);
            cmbFilters.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(660, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(149, 69);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(297, 23);
            txtSearchBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(23, 13);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 10;
            label1.Text = "Inbox";
            // 
            // InboxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 497);
            Controls.Add(label1);
            Controls.Add(txtSearchBox);
            Controls.Add(btnSearch);
            Controls.Add(cmbFilters);
            Controls.Add(dgvEmails);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InboxForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inbox";
            ((System.ComponentModel.ISupportInitialize)dgvEmails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmails;
        private ComboBox cmbFilters;
        private Button btnSearch;
        private TextBox txtSearchBox;
        private Label label1;
    }
}