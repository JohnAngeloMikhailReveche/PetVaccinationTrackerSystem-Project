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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetOwner_PetProfile));
            dgvRegisteredPet = new DataGridView();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredPet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvRegisteredPet
            // 
            dgvRegisteredPet.AllowUserToAddRows = false;
            dgvRegisteredPet.BackgroundColor = Color.White;
            dgvRegisteredPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegisteredPet.Location = new Point(24, 195);
            dgvRegisteredPet.MultiSelect = false;
            dgvRegisteredPet.Name = "dgvRegisteredPet";
            dgvRegisteredPet.ReadOnly = true;
            dgvRegisteredPet.Size = new Size(754, 350);
            dgvRegisteredPet.TabIndex = 6;
            dgvRegisteredPet.DoubleClick += dgvRegisteredPet_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(24, 168);
            label2.Name = "label2";
            label2.Size = new Size(327, 19);
            label2.TabIndex = 8;
            label2.Text = "Double-click any pet to view more information:";
            // 
            // PetOwner_PetProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dgvRegisteredPet);
            Name = "PetOwner_PetProfile";
            Size = new Size(800, 590);
            Load += PetOwner_PetProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredPet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvRegisteredPet;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
