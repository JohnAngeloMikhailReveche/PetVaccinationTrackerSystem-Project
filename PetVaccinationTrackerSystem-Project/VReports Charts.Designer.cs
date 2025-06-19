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
            pictureBox1 = new PictureBox();
            VRDSVaccineCard = new Panel();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            VRDSVaccineCard.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.vaccination_reports_banner1;
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
            VRDSVaccineCard.Controls.Add(pieChart1);
            VRDSVaccineCard.Controls.Add(button2);
            VRDSVaccineCard.Controls.Add(dateTimePicker1);
            VRDSVaccineCard.Controls.Add(button1);
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
            cartesianChart1.BackColor = Color.FromArgb(249, 249, 249);
            cartesianChart1.Location = new Point(400, 90);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(367, 333);
            cartesianChart1.TabIndex = 41;
            // 
            // pieChart1
            // 
            pieChart1.BackColor = Color.FromArgb(249, 249, 249);
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(14, 90);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = double.NaN;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(358, 333);
            pieChart1.TabIndex = 40;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(89, 85, 84);
            button2.Location = new Point(34, 452);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 39;
            button2.Text = "Go Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(535, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 29);
            dateTimePicker1.TabIndex = 34;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(89, 85, 84);
            button1.Location = new Point(667, 15);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 33;
            button1.Text = "Filters";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(249, 249, 249);
            comboBox1.ForeColor = Color.FromArgb(249, 249, 249);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dog", "Cat" });
            comboBox1.Location = new Point(132, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(14, 37);
            label7.Name = "label7";
            label7.Size = new Size(112, 19);
            label7.TabIndex = 1;
            label7.Text = "Filters by Species";
            label7.Click += label7_Click;
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
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label7;
        private Button button2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}
