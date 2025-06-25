namespace PetVaccinationTrackerSystem_Project
{
    partial class Pet_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pet_Reports));
            pictureBox1 = new PictureBox();
            VRDSVaccineCard = new Panel();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label1 = new Label();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            VRDSVaccineCard.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // VRDSVaccineCard
            // 
            VRDSVaccineCard.BackColor = Color.White;
            VRDSVaccineCard.BorderStyle = BorderStyle.FixedSingle;
            VRDSVaccineCard.Controls.Add(cartesianChart1);
            VRDSVaccineCard.Controls.Add(label1);
            VRDSVaccineCard.Controls.Add(pieChart1);
            VRDSVaccineCard.Controls.Add(dateTimePicker1);
            VRDSVaccineCard.Controls.Add(button1);
            VRDSVaccineCard.Controls.Add(comboBox3);
            VRDSVaccineCard.Controls.Add(comboBox2);
            VRDSVaccineCard.Controls.Add(comboBox1);
            VRDSVaccineCard.Controls.Add(label7);
            VRDSVaccineCard.Location = new Point(9, 78);
            VRDSVaccineCard.Margin = new Padding(20, 5, 0, 0);
            VRDSVaccineCard.Name = "VRDSVaccineCard";
            VRDSVaccineCard.Size = new Size(782, 500);
            VRDSVaccineCard.TabIndex = 1;
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.FromArgb(250, 250, 250);
            cartesianChart1.Location = new Point(425, 92);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(342, 390);
            cartesianChart1.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(13, 70);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 37;
            label1.Text = "Charts Overview:";
            // 
            // pieChart1
            // 
            pieChart1.BackColor = Color.FromArgb(250, 250, 250);
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(14, 93);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = double.NaN;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(356, 389);
            pieChart1.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F);
            dateTimePicker1.Font = new Font("Segoe UI", 9F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(425, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 23);
            dateTimePicker1.TabIndex = 34;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(89, 85, 84);
            button1.Location = new Point(557, 30);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 33;
            button1.Text = "Filters";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.White;
            comboBox3.ForeColor = Color.White;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(141, 36);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(115, 23);
            comboBox3.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(263, 36);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(107, 23);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(89, 85, 84);
            label7.Location = new Point(13, 11);
            label7.Name = "label7";
            label7.Size = new Size(53, 19);
            label7.TabIndex = 1;
            label7.Text = "Filters:";
            // 
            // Pet_Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(VRDSVaccineCard);
            Controls.Add(pictureBox1);
            Name = "Pet_Reports";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            VRDSVaccineCard.ResumeLayout(false);
            VRDSVaccineCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel VRDSVaccineCard;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label7;
    }
}
