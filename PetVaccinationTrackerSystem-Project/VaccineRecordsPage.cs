using System.Drawing.Drawing2D;

namespace VaccinationForm
{
    public partial class VaccineRecordsPage : Form
    {
        public VaccineRecordsPage()
        {
            InitializeComponent();
        }

        private void pctPetImage_Click(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pctPetImage.Width, pctPetImage.Height);
            pctPetImage.Region = new Region(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pctPetImage.Width - 3, pctPetImage.Height - 3);
            pctPetImage.Region = new Region(gp);
        }

        private void pnlPetInfo_Paint(object sender, PaintEventArgs e)
        {
            int radius = 8;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pnlPetInfo.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pnlPetInfo.Width - radius, pnlPetInfo.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pnlPetInfo.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnlPetInfo.Region = new Region(path);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hopeRoundButton3_Click(object sender, EventArgs e)
        { 

        }
     
    }
}
