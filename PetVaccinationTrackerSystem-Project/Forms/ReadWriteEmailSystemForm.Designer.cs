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
            btnSend = new Button();
            richtxtContent = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtToUser = new TextBox();
            txtTitle = new TextBox();
            datetimeDateSent = new DateTimePicker();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(604, 397);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(160, 41);
            btnSend.TabIndex = 12;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // richtxtContent
            // 
            richtxtContent.Location = new Point(36, 122);
            richtxtContent.Name = "richtxtContent";
            richtxtContent.Size = new Size(728, 257);
            richtxtContent.TabIndex = 11;
            richtxtContent.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 65);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 8;
            label3.Text = "To ( Provide the User ID ) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 65);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Date Sent:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 10;
            label1.Text = "Subject:";
            // 
            // txtToUser
            // 
            txtToUser.Location = new Point(274, 83);
            txtToUser.Name = "txtToUser";
            txtToUser.Size = new Size(142, 23);
            txtToUser.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(36, 30);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(418, 23);
            txtTitle.TabIndex = 5;
            // 
            // datetimeDateSent
            // 
            datetimeDateSent.Location = new Point(36, 83);
            datetimeDateSent.Name = "datetimeDateSent";
            datetimeDateSent.Size = new Size(200, 23);
            datetimeDateSent.TabIndex = 13;
            // 
            // ReadWriteEmailSystemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datetimeDateSent);
            Controls.Add(btnSend);
            Controls.Add(richtxtContent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtToUser);
            Controls.Add(txtTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReadWriteEmailSystemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Write Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private RichTextBox richtxtContent;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtToUser;
        private TextBox txtTitle;
        private DateTimePicker datetimeDateSent;
    }
}