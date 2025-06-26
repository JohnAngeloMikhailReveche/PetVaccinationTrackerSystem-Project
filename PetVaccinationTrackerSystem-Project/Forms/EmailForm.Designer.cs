namespace PetVaccinationTrackerSystem_Project.Forms
{
    partial class EmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailForm));
            txtTitle = new TextBox();
            txtDate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            richtxtContent = new RichTextBox();
            label3 = new Label();
            txtFromUser = new TextBox();
            panel1 = new Panel();
            mainFormVButtonExit = new Button();
            label4 = new Label();
            btnRead = new ReaLTaiizor.Controls.HopeRoundButton();
            btnDelete = new ReaLTaiizor.Controls.HopeRoundButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(34, 147);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(375, 25);
            txtTitle.TabIndex = 0;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.White;
            txtDate.Font = new Font("Segoe UI", 10F);
            txtDate.Location = new Point(623, 147);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(142, 25);
            txtDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(34, 125);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 2;
            label1.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(622, 125);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 2;
            label2.Text = "Date Sent:";
            // 
            // richtxtContent
            // 
            richtxtContent.BackColor = Color.White;
            richtxtContent.Location = new Point(34, 183);
            richtxtContent.Name = "richtxtContent";
            richtxtContent.ReadOnly = true;
            richtxtContent.Size = new Size(730, 269);
            richtxtContent.TabIndex = 3;
            richtxtContent.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(416, 125);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 2;
            label3.Text = "From:";
            // 
            // txtFromUser
            // 
            txtFromUser.BackColor = Color.White;
            txtFromUser.Font = new Font("Segoe UI", 10F);
            txtFromUser.Location = new Point(416, 147);
            txtFromUser.Name = "txtFromUser";
            txtFromUser.ReadOnly = true;
            txtFromUser.Size = new Size(200, 25);
            txtFromUser.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 59, 58);
            panel1.Controls.Add(mainFormVButtonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 5;
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
            mainFormVButtonExit.TabIndex = 15;
            mainFormVButtonExit.UseVisualStyleBackColor = false;
            mainFormVButtonExit.Click += mainFormVButtonExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(89, 85, 84);
            label4.Location = new Point(25, 50);
            label4.Name = "label4";
            label4.Size = new Size(230, 54);
            label4.TabIndex = 16;
            label4.Text = "Read Email";
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.FromArgb(63, 59, 58);
            btnRead.BorderColor = Color.FromArgb(220, 223, 230);
            btnRead.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnRead.DangerColor = Color.FromArgb(245, 108, 108);
            btnRead.DefaultColor = Color.FromArgb(255, 255, 255);
            btnRead.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.HoverTextColor = Color.White;
            btnRead.InfoColor = Color.FromArgb(144, 147, 153);
            btnRead.Location = new Point(535, 468);
            btnRead.Name = "btnRead";
            btnRead.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnRead.Size = new Size(110, 40);
            btnRead.SuccessColor = Color.FromArgb(103, 194, 58);
            btnRead.TabIndex = 18;
            btnRead.Text = "Read";
            btnRead.TextColor = Color.White;
            btnRead.WarningColor = Color.FromArgb(230, 162, 60);
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(63, 59, 58);
            btnDelete.BorderColor = Color.FromArgb(220, 223, 230);
            btnDelete.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDelete.DangerColor = Color.FromArgb(245, 108, 108);
            btnDelete.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.HoverTextColor = Color.White;
            btnDelete.InfoColor = Color.FromArgb(144, 147, 153);
            btnDelete.Location = new Point(655, 468);
            btnDelete.Name = "btnDelete";
            btnDelete.PrimaryColor = Color.FromArgb(69, 0, 0);
            btnDelete.Size = new Size(110, 40);
            btnDelete.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.White;
            btnDelete.WarningColor = Color.FromArgb(230, 162, 60);
            btnDelete.Click += btnDelete_Click;
            // 
            // EmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 535);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(richtxtContent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFromUser);
            Controls.Add(txtDate);
            Controls.Add(txtTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmailTitle";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDate;
        private Label label1;
        private Label label2;
        private RichTextBox richtxtContent;
        private Label label3;
        private TextBox txtFromUser;
        private Panel panel1;
        private Button mainFormVButtonExit;
        private Label label4;
        private ReaLTaiizor.Controls.HopeRoundButton btnRead;
        private ReaLTaiizor.Controls.HopeRoundButton btnDelete;
    }
}