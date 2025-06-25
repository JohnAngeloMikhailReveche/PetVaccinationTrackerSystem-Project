namespace PetVaccinationTrackerSystem_Project
{
    partial class registerPetOwnerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerPetOwnerPanel));
            registerPORegisterPanel = new Panel();
            label1 = new Label();
            label14 = new Label();
            registerPOAccountDetsCard = new Panel();
            registerPOPanelButton = new ReaLTaiizor.Controls.HopeRoundButton();
            txtboxPassword = new TextBox();
            txtboxLastName = new TextBox();
            txtboxFirstName = new TextBox();
            txtboxUsername = new TextBox();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            registerPOPanelBanner = new PictureBox();
            registerPORegisterPanel.SuspendLayout();
            registerPOAccountDetsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registerPOPanelBanner).BeginInit();
            SuspendLayout();
            // 
            // registerPORegisterPanel
            // 
            registerPORegisterPanel.BackColor = Color.FromArgb(249, 249, 249);
            registerPORegisterPanel.Controls.Add(label1);
            registerPORegisterPanel.Controls.Add(label14);
            registerPORegisterPanel.Controls.Add(registerPOAccountDetsCard);
            registerPORegisterPanel.Location = new Point(190, 210);
            registerPORegisterPanel.Name = "registerPORegisterPanel";
            registerPORegisterPanel.Size = new Size(406, 345);
            registerPORegisterPanel.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(216, 15);
            label1.TabIndex = 25;
            label1.Text = "Please provide valid owner information.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(89, 85, 84);
            label14.Location = new Point(22, 12);
            label14.Name = "label14";
            label14.Size = new Size(130, 21);
            label14.TabIndex = 2;
            label14.Text = "Account Details";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // registerPOAccountDetsCard
            // 
            registerPOAccountDetsCard.BackColor = Color.White;
            registerPOAccountDetsCard.BorderStyle = BorderStyle.FixedSingle;
            registerPOAccountDetsCard.Controls.Add(registerPOPanelButton);
            registerPOAccountDetsCard.Controls.Add(txtboxPassword);
            registerPOAccountDetsCard.Controls.Add(txtboxLastName);
            registerPOAccountDetsCard.Controls.Add(txtboxFirstName);
            registerPOAccountDetsCard.Controls.Add(txtboxUsername);
            registerPOAccountDetsCard.Controls.Add(label3);
            registerPOAccountDetsCard.Controls.Add(label8);
            registerPOAccountDetsCard.Controls.Add(label2);
            registerPOAccountDetsCard.Controls.Add(label4);
            registerPOAccountDetsCard.Controls.Add(label7);
            registerPOAccountDetsCard.Location = new Point(22, 55);
            registerPOAccountDetsCard.Margin = new Padding(20, 5, 0, 0);
            registerPOAccountDetsCard.Name = "registerPOAccountDetsCard";
            registerPOAccountDetsCard.Size = new Size(361, 271);
            registerPOAccountDetsCard.TabIndex = 1;
            // 
            // registerPOPanelButton
            // 
            registerPOPanelButton.BorderColor = Color.FromArgb(220, 223, 230);
            registerPOPanelButton.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            registerPOPanelButton.DangerColor = Color.FromArgb(245, 108, 108);
            registerPOPanelButton.DefaultColor = Color.FromArgb(255, 255, 255);
            registerPOPanelButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerPOPanelButton.HoverTextColor = Color.White;
            registerPOPanelButton.InfoColor = Color.FromArgb(144, 147, 153);
            registerPOPanelButton.Location = new Point(116, 213);
            registerPOPanelButton.Name = "registerPOPanelButton";
            registerPOPanelButton.PrimaryColor = Color.FromArgb(89, 85, 84);
            registerPOPanelButton.Size = new Size(130, 40);
            registerPOPanelButton.SuccessColor = Color.FromArgb(103, 194, 58);
            registerPOPanelButton.TabIndex = 20;
            registerPOPanelButton.Text = "Register";
            registerPOPanelButton.TextColor = Color.White;
            registerPOPanelButton.WarningColor = Color.FromArgb(230, 162, 60);
            registerPOPanelButton.Click += registerPOPanelButton_Click;
            // 
            // txtboxPassword
            // 
            txtboxPassword.BackColor = Color.White;
            txtboxPassword.Font = new Font("Segoe UI", 10F);
            txtboxPassword.Location = new Point(14, 159);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(333, 25);
            txtboxPassword.TabIndex = 23;
            // 
            // txtboxLastName
            // 
            txtboxLastName.BackColor = Color.White;
            txtboxLastName.Font = new Font("Segoe UI", 10F);
            txtboxLastName.Location = new Point(181, 35);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(166, 25);
            txtboxLastName.TabIndex = 22;
            txtboxLastName.TextChanged += txtboxLastName_TextChanged;
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.BackColor = Color.White;
            txtboxFirstName.Font = new Font("Segoe UI", 10F);
            txtboxFirstName.Location = new Point(14, 35);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(155, 25);
            txtboxFirstName.TabIndex = 22;
            txtboxFirstName.TextChanged += txtboxFirstName_TextChanged;
            // 
            // txtboxUsername
            // 
            txtboxUsername.BackColor = Color.White;
            txtboxUsername.Font = new Font("Segoe UI", 10F);
            txtboxUsername.Location = new Point(14, 98);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(187, 25);
            txtboxUsername.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(89, 85, 84);
            label3.Location = new Point(181, 13);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 0;
            label3.Text = "Last Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(89, 85, 84);
            label8.Location = new Point(14, 137);
            label8.Name = "label8";
            label8.Size = new Size(70, 19);
            label8.TabIndex = 11;
            label8.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(89, 85, 84);
            label2.Location = new Point(14, 13);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 0;
            label2.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(89, 85, 84);
            label4.Location = new Point(203, 100);
            label4.Name = "label4";
            label4.Size = new Size(138, 19);
            label4.TabIndex = 0;
            label4.Text = "@petownerclinic.com";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(89, 85, 84);
            label7.Location = new Point(14, 74);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 0;
            label7.Text = "Username:";
            // 
            // registerPOPanelBanner
            // 
            registerPOPanelBanner.Image = (Image)resources.GetObject("registerPOPanelBanner.Image");
            registerPOPanelBanner.Location = new Point(218, 0);
            registerPOPanelBanner.Name = "registerPOPanelBanner";
            registerPOPanelBanner.Size = new Size(350, 250);
            registerPOPanelBanner.SizeMode = PictureBoxSizeMode.Zoom;
            registerPOPanelBanner.TabIndex = 19;
            registerPOPanelBanner.TabStop = false;
            // 
            // registerPetOwnerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(registerPORegisterPanel);
            Controls.Add(registerPOPanelBanner);
            Name = "registerPetOwnerPanel";
            Size = new Size(800, 590);
            registerPORegisterPanel.ResumeLayout(false);
            registerPORegisterPanel.PerformLayout();
            registerPOAccountDetsCard.ResumeLayout(false);
            registerPOAccountDetsCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registerPOPanelBanner).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel registerPORegisterPanel;
        private Label label14;
        private Panel registerPOAccountDetsCard;
        private TextBox txtboxPassword;
        private TextBox txtboxUsername;
        private Label label8;
        private Label label7;
        private PictureBox registerPOPanelBanner;
        private Label label1;
        private TextBox txtboxLastName;
        private TextBox txtboxFirstName;
        private Label label3;
        private Label label2;
        private Label label4;
        private ReaLTaiizor.Controls.HopeRoundButton registerPOPanelButton;
    }
}
