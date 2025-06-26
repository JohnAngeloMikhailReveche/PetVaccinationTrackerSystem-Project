namespace PetVaccinationTrackerSystem_Project
{
    partial class HomePanelAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanelAdmin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            descriptionTitle = new Label();
            descriptionContent = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 340);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // descriptionTitle
            // 
            descriptionTitle.AutoSize = true;
            descriptionTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            descriptionTitle.ForeColor = Color.FromArgb(85, 82, 81);
            descriptionTitle.Location = new Point(30, 345);
            descriptionTitle.Name = "descriptionTitle";
            descriptionTitle.Size = new Size(469, 32);
            descriptionTitle.TabIndex = 4;
            descriptionTitle.Text = "What is Pet Vaccination Tracker System?";
            // 
            // descriptionContent
            // 
            descriptionContent.AutoSize = true;
            descriptionContent.Font = new Font("Segoe UI", 10F);
            descriptionContent.ForeColor = Color.FromArgb(85, 82, 81);
            descriptionContent.Location = new Point(33, 385);
            descriptionContent.MaximumSize = new Size(740, 0);
            descriptionContent.Name = "descriptionContent";
            descriptionContent.Size = new Size(661, 57);
            descriptionContent.TabIndex = 5;
            descriptionContent.Text = resources.GetString("descriptionContent.Text");
            // 
            // panel2
            // 
            panel2.Location = new Point(37, 471);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 75);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Location = new Point(378, 471);
            panel3.Name = "panel3";
            panel3.Size = new Size(75, 75);
            panel3.TabIndex = 7;
            // 
            // HomePanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(descriptionContent);
            Controls.Add(descriptionTitle);
            Controls.Add(panel1);
            Name = "HomePanelAdmin";
            Size = new Size(800, 590);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label descriptionTitle;
        private Label descriptionContent;
        private Panel panel2;
        private Panel panel3;
    }
}
