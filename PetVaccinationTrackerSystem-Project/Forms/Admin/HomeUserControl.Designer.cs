namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    partial class HomeUserControl
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
            dgvVetList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVetList).BeginInit();
            SuspendLayout();
            // 
            // dgvVetList
            // 
            dgvVetList.AllowUserToAddRows = false;
            dgvVetList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVetList.Location = new Point(26, 29);
            dgvVetList.MultiSelect = false;
            dgvVetList.Name = "dgvVetList";
            dgvVetList.ReadOnly = true;
            dgvVetList.Size = new Size(733, 523);
            dgvVetList.TabIndex = 0;
            dgvVetList.DoubleClick += dgvVetList_DoubleClick;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvVetList);
            Name = "HomeUserControl";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)dgvVetList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvVetList;
    }
}
