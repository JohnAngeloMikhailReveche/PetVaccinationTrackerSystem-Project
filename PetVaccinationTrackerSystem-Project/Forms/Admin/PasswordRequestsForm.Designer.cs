namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class PasswordRequestsForm
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
            dgvUserList = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            SuspendLayout();
            // 
            // dgvUserList
            // 
            dgvUserList.AllowUserToAddRows = false;
            dgvUserList.BackgroundColor = Color.White;
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Location = new Point(23, 123);
            dgvUserList.MultiSelect = false;
            dgvUserList.Name = "dgvUserList";
            dgvUserList.ReadOnly = true;
            dgvUserList.Size = new Size(754, 380);
            dgvUserList.TabIndex = 6;
            dgvUserList.DoubleClick += dgvVetList_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(23, 68);
            label1.Name = "label1";
            label1.Size = new Size(568, 37);
            label1.TabIndex = 7;
            label1.Text = "Veterinarians Requesting Password Default";
            // 
            // PasswordRequestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dgvUserList);
            Name = "PasswordRequestsForm";
            Size = new Size(800, 590);
            Load += PasswordRequestsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUserList;
        private Label label1;
    }
}
