namespace PetVaccinationTrackerSystem_Project
{
    partial class MainForm
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
            panel1 = new Panel();
            panel6 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            userControl11 = new UserControl1();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 640);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Maroon;
            panel6.Location = new Point(0, 200);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 50);
            panel6.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 350);
            button4.Name = "button4";
            button4.Size = new Size(200, 50);
            button4.TabIndex = 6;
            button4.Text = "Vaccine Reports";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 300);
            button3.Name = "button3";
            button3.Size = new Size(200, 50);
            button3.TabIndex = 5;
            button3.Text = "Vaccine Records";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 250);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.TabIndex = 4;
            button2.Text = "Pet Profile";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 200);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 3;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 150);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 50);
            panel4.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 50);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(206, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(50, 50);
            panel3.TabIndex = 2;
            // 
            // userControl11
            // 
            userControl11.Dock = DockStyle.Bottom;
            userControl11.Location = new Point(200, 112);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(800, 528);
            userControl11.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 640);
            Controls.Add(userControl11);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Panel panel3;
        private UserControl1 userControl11;
    }
}