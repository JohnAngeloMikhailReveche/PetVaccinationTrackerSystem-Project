namespace PetVaccinationTrackerSystem_Project
{
    partial class Pet_Profile
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
            pictureBox1 = new PictureBox();
            VRDSVaccineDetailsPanel = new Panel();
            label14 = new Label();
            VRDSVaccineCard = new Panel();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            textBox11 = new TextBox();
            label5 = new Label();
            textBox10 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            VRDSButtonSave = new Button();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            VRDSVaccineDetailsPanel.SuspendLayout();
            VRDSVaccineCard.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.vaccination_reports_banner;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // VRDSVaccineDetailsPanel
            // 
            VRDSVaccineDetailsPanel.BackColor = Color.FromArgb(249, 249, 249);
            VRDSVaccineDetailsPanel.Controls.Add(label14);
            VRDSVaccineDetailsPanel.Controls.Add(VRDSVaccineCard);
            VRDSVaccineDetailsPanel.Location = new Point(16, 89);
            VRDSVaccineDetailsPanel.Name = "VRDSVaccineDetailsPanel";
            VRDSVaccineDetailsPanel.Size = new Size(471, 482);
            VRDSVaccineDetailsPanel.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(89, 85, 84);
            label14.Location = new Point(23, 4);
            label14.Name = "label14";
            label14.Size = new Size(186, 21);
            label14.TabIndex = 2;
            label14.Text = "Pet Profile Information";
            // 
            // VRDSVaccineCard
            // 
            VRDSVaccineCard.BackColor = Color.White;
            VRDSVaccineCard.BorderStyle = BorderStyle.FixedSingle;
            VRDSVaccineCard.Controls.Add(panel2);
            VRDSVaccineCard.Controls.Add(textBox4);
            VRDSVaccineCard.Controls.Add(textBox3);
            VRDSVaccineCard.Controls.Add(textBox2);
            VRDSVaccineCard.Controls.Add(label7);
            VRDSVaccineCard.Location = new Point(20, 28);
            VRDSVaccineCard.Margin = new Padding(20, 5, 0, 0);
            VRDSVaccineCard.Name = "VRDSVaccineCard";
            VRDSVaccineCard.Size = new Size(427, 430);
            VRDSVaccineCard.TabIndex = 1;
            VRDSVaccineCard.Paint += VRDSVaccineCard_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-1, -1);
            panel2.Margin = new Padding(20, 5, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 430);
            panel2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(216, 186);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 29);
            dateTimePicker1.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.ForeColor = Color.FromArgb(89, 85, 84);
            label10.Location = new Point(216, 160);
            label10.Name = "label10";
            label10.Size = new Size(93, 19);
            label10.TabIndex = 15;
            label10.Text = "Date Of Birth:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.ForeColor = Color.FromArgb(89, 85, 84);
            label9.Location = new Point(18, 356);
            label9.Name = "label9";
            label9.Size = new Size(178, 19);
            label9.TabIndex = 14;
            label9.Text = "Owner Contact Information";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.ForeColor = Color.FromArgb(89, 85, 84);
            label8.Location = new Point(18, 293);
            label8.Name = "label8";
            label8.Size = new Size(99, 19);
            label8.TabIndex = 13;
            label8.Text = "Owner's Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.ForeColor = Color.FromArgb(89, 85, 84);
            label6.Location = new Point(18, 221);
            label6.Name = "label6";
            label6.Size = new Size(125, 19);
            label6.TabIndex = 12;
            label6.Text = "Colors / Markings: ";
            label6.Click += label6_Click;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(249, 249, 249);
            textBox11.Font = new Font("Segoe UI", 10F);
            textBox11.Location = new Point(18, 180);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(178, 38);
            textBox11.TabIndex = 11;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.ForeColor = Color.FromArgb(89, 85, 84);
            label5.Location = new Point(18, 158);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 10;
            label5.Text = "Gender:";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(249, 249, 249);
            textBox10.Font = new Font("Segoe UI", 10F);
            textBox10.Location = new Point(216, 109);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(190, 38);
            textBox10.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.FromArgb(89, 85, 84);
            label4.Location = new Point(216, 76);
            label4.Name = "label4";
            label4.Size = new Size(47, 19);
            label4.TabIndex = 8;
            label4.Text = "Breed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(19, 76);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 7;
            label3.Text = "Species:";
            label3.Click += label3_Click;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(249, 249, 249);
            textBox9.Font = new Font("Segoe UI", 10F);
            textBox9.Location = new Point(19, 109);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(177, 38);
            textBox9.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(249, 249, 249);
            textBox8.Font = new Font("Segoe UI", 10F);
            textBox8.Location = new Point(18, 252);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(388, 38);
            textBox8.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(249, 249, 249);
            textBox5.Font = new Font("Segoe UI", 10F);
            textBox5.Location = new Point(18, 315);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(388, 38);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(249, 249, 249);
            textBox6.Font = new Font("Segoe UI", 10F);
            textBox6.Location = new Point(18, 378);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(388, 38);
            textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(249, 249, 249);
            textBox7.Font = new Font("Segoe UI", 10F);
            textBox7.Location = new Point(18, 35);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(388, 38);
            textBox7.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(18, 13);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 1;
            label2.Text = "Pet Name:";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(95, 307);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(311, 38);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(95, 369);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(311, 38);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 13);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 38);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(89, 85, 84);
            label7.Location = new Point(18, 24);
            label7.Name = "label7";
            label7.Size = new Size(71, 19);
            label7.TabIndex = 1;
            label7.Text = "Pet Name:";
            label7.Click += label7_Click;
            // 
            // VRDSButtonSave
            // 
            VRDSButtonSave.FlatStyle = FlatStyle.Flat;
            VRDSButtonSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VRDSButtonSave.ForeColor = Color.FromArgb(89, 85, 84);
            VRDSButtonSave.Location = new Point(536, 531);
            VRDSButtonSave.Name = "VRDSButtonSave";
            VRDSButtonSave.Size = new Size(100, 40);
            VRDSButtonSave.TabIndex = 31;
            VRDSButtonSave.Text = "Save";
            VRDSButtonSave.UseVisualStyleBackColor = true;
            VRDSButtonSave.Click += VRDSButtonSave_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(89, 85, 84);
            button1.Location = new Point(658, 531);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 32;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(562, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 160);
            panel1.TabIndex = 33;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(89, 85, 84);
            button2.Location = new Point(581, 255);
            button2.Name = "button2";
            button2.Size = new Size(128, 40);
            button2.TabIndex = 34;
            button2.Text = "Update Profile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(515, 339);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 186);
            textBox1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(515, 315);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 36;
            label1.Text = "Notes:";
            label1.Click += label1_Click;
            // 
            // Pet_Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(VRDSButtonSave);
            Controls.Add(VRDSVaccineDetailsPanel);
            Controls.Add(pictureBox1);
            Name = "Pet_Profile";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            VRDSVaccineDetailsPanel.ResumeLayout(false);
            VRDSVaccineDetailsPanel.PerformLayout();
            VRDSVaccineCard.ResumeLayout(false);
            VRDSVaccineCard.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel VRDSVaccineDetailsPanel;
        private Label label14;
        private Panel VRDSVaccineCard;
        private Button VRDSButtonSave;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private TextBox textBox1;
        private Label label7;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel2;
        private TextBox textBox11;
        private Label label5;
        private TextBox textBox10;
        private Label label4;
        private Label label3;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label2;
        private TextBox textBox4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}
