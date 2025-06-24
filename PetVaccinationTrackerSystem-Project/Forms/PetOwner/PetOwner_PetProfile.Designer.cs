namespace PetVaccinationTrackerSystem_Project.Forms.PetOwner
{
    partial class PetOwner_PetProfile
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
            label1 = new Label();
            dgvRegisteredPet = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredPet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 1;
            label1.Text = "Pet Registered";
            // 
            // dgvRegisteredPet
            // 
            dgvRegisteredPet.AllowUserToAddRows = false;
            dgvRegisteredPet.BackgroundColor = Color.White;
            dgvRegisteredPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegisteredPet.Location = new Point(34, 78);
            dgvRegisteredPet.MultiSelect = false;
            dgvRegisteredPet.Name = "dgvRegisteredPet";
            dgvRegisteredPet.ReadOnly = true;
            dgvRegisteredPet.Size = new Size(733, 233);
            dgvRegisteredPet.TabIndex = 6;
            dgvRegisteredPet.DoubleClick += dgvRegisteredPet_DoubleClick;
            // 
            // PetOwner_PetProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvRegisteredPet);
            Controls.Add(label1);
            Name = "PetOwner_PetProfile";
            Size = new Size(800, 590);
            Load += PetOwner_PetProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredPet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvRegisteredPet;
    }
}
