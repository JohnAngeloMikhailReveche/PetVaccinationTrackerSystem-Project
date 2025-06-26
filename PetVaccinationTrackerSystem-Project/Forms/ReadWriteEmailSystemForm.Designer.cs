namespace PetVaccinationTrackerSystem_Project.Forms
{
    partial class ReadWriteEmailSystemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadWriteEmailSystemForm));
            richtxtContent = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtToUser = new TextBox();
            txtTitle = new TextBox();
            datetimeDateSent = new DateTimePicker();
            panel1 = new Panel();
            mainFormVButtonExit = new Button();
            label4 = new Label();
            btnSend = new ReaLTaiizor.Controls.HopeRoundButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richtxtContent
            // 
            richtxtContent.BackColor = Color.White;
            richtxtContent.Location = new Point(34, 183);
            richtxtContent.Name = "richtxtContent";
            richtxtContent.Size = new Size(730, 269);
            richtxtContent.TabIndex = 11;
            richtxtContent.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(622, 125);
            label3.Name = "label3";
            label3.Size = new Size(134, 19);
            label3.TabIndex = 8;
            label3.Text = "To (Provide User ID):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(416, 125);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 9;
            label2.Text = "Date Sent:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(34, 125);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 10;
            label1.Text = "Subject:";
            // 
            // txtToUser
            // 
            txtToUser.BackColor = Color.White;
            txtToUser.Font = new Font("Segoe UI", 10F);
            txtToUser.Location = new Point(623, 147);
            txtToUser.Name = "txtToUser";
            txtToUser.Size = new Size(142, 25);
            txtToUser.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(34, 147);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(375, 25);
            txtTitle.TabIndex = 5;
            // 
            // datetimeDateSent
            // 
            datetimeDateSent.CalendarFont = new Font("Segoe UI", 10F);
            datetimeDateSent.CalendarMonthBackground = Color.White;
            datetimeDateSent.Location = new Point(416, 147);
            datetimeDateSent.Name = "datetimeDateSent";
            datetimeDateSent.Size = new Size(200, 23);
            datetimeDateSent.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 59, 58);
            panel1.Controls.Add(mainFormVButtonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 14;
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
            mainFormVButtonExit.TabIndex = 17;
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
            label4.Size = new Size(241, 54);
            label4.TabIndex = 15;
            label4.Text = "Write Email";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(63, 59, 58);
            btnSend.BorderColor = Color.FromArgb(220, 223, 230);
            btnSend.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSend.DangerColor = Color.FromArgb(245, 108, 108);
            btnSend.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSend.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.HoverTextColor = Color.White;
            btnSend.InfoColor = Color.FromArgb(144, 147, 153);
            btnSend.Location = new Point(655, 468);
            btnSend.Name = "btnSend";
            btnSend.PrimaryColor = Color.FromArgb(63, 59, 58);
            btnSend.Size = new Size(110, 40);
            btnSend.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSend.TabIndex = 17;
            btnSend.Text = "Send";
            btnSend.TextColor = Color.White;
            btnSend.WarningColor = Color.FromArgb(230, 162, 60);
            btnSend.Click += btnSend_Click;
            // 
            // ReadWriteEmailSystemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 535);
            Controls.Add(btnSend);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(datetimeDateSent);
            Controls.Add(richtxtContent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtToUser);
            Controls.Add(txtTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReadWriteEmailSystemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Write Email";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richtxtContent;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtToUser;
        private TextBox txtTitle;
        private DateTimePicker datetimeDateSent;
        private Panel panel1;
        private Button mainFormVButtonExit;
        private Label label4;
        private ReaLTaiizor.Controls.HopeRoundButton btnSend;
    }
}