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
            txtTitle = new TextBox();
            txtDate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            richtxtContent = new RichTextBox();
            btnDelete = new Button();
            btnRead = new Button();
            label3 = new Label();
            txtFromUser = new TextBox();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(30, 30);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(418, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(30, 83);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(138, 23);
            txtDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 65);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Date Sent:";
            // 
            // richtxtContent
            // 
            richtxtContent.Location = new Point(30, 122);
            richtxtContent.Name = "richtxtContent";
            richtxtContent.ReadOnly = true;
            richtxtContent.Size = new Size(728, 257);
            richtxtContent.TabIndex = 3;
            richtxtContent.Text = "";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(598, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 41);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(432, 397);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(160, 41);
            btnRead.TabIndex = 4;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 65);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "From:";
            // 
            // txtFromUser
            // 
            txtFromUser.Location = new Point(205, 83);
            txtFromUser.Name = "txtFromUser";
            txtFromUser.ReadOnly = true;
            txtFromUser.Size = new Size(243, 23);
            txtFromUser.TabIndex = 1;
            // 
            // EmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRead);
            Controls.Add(btnDelete);
            Controls.Add(richtxtContent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFromUser);
            Controls.Add(txtDate);
            Controls.Add(txtTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmailTitle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDate;
        private Label label1;
        private Label label2;
        private RichTextBox richtxtContent;
        private Button btnDelete;
        private Button btnRead;
        private Label label3;
        private TextBox txtFromUser;
    }
}