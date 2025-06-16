using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petvax_report
{
    public partial class Admin_ReportPage : Form
    {
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        public Admin_ReportPage()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            ApplyCustomColors();
        }

        private void ApplyCustomColors()
        {
            panelSidebar.BackColor = Color.FromArgb(215, 210, 191);
            groupPetInfo.BackColor = Color.FromArgb(255, 247, 244);
            dgvRecords.BackgroundColor = Color.FromArgb(255, 247, 244);
            dgvRecords.DefaultCellStyle.BackColor = Color.FromArgb(255, 247, 244);
            dgvRecords.DefaultCellStyle.SelectionBackColor = Color.FromArgb(203, 168, 128);

            btnBack.BackColor = Color.FromArgb(89, 85, 84);
            btnPrint.BackColor = Color.FromArgb(203, 168, 128);
        }

        private void ReportPage_Load(object sender, EventArgs e)
        {

        }
       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printPreviewDialog.Document = printDocument;

            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing error: " + ex.Message);
            }
        }

        private void banner_Click(object sender, EventArgs e)
        {
            
        }  

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 50;
            int y = 100;
            int rowHeight = 30;

            Font headerFont = new Font("Segoe UI", 10, FontStyle.Bold);
            Font rowFont = new Font("Segoe UI", 10);
            Brush brush = Brushes.Black;

        
            if (banner.BackgroundImage != null)
            {
                // Scale and draw the banner at the top of the page
                int bannerWidth = e.MarginBounds.Width;
                int bannerHeight = 100; // Adjust as needed
                e.Graphics.DrawImage(banner.BackgroundImage, e.MarginBounds.Left, e.MarginBounds.Top - 80, bannerWidth, bannerHeight);

                y = e.MarginBounds.Top + bannerHeight - 20; 
            }

        
            e.Graphics.DrawString("Vaccine Name", headerFont, brush, x, y);
            e.Graphics.DrawString("Date", headerFont, brush, x + 150, y);
            e.Graphics.DrawString("Next Due", headerFont, brush, x + 300, y);
            e.Graphics.DrawString("By", headerFont, brush, x + 450, y);
            e.Graphics.DrawString("Notes", headerFont, brush, x + 550, y);
            y += rowHeight;

     
            foreach (DataGridViewRow row in dgvRecords.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawString(row.Cells[0].Value?.ToString(), rowFont, brush, x, y);
                e.Graphics.DrawString(row.Cells[1].Value?.ToString(), rowFont, brush, x + 150, y);
                e.Graphics.DrawString(row.Cells[2].Value?.ToString(), rowFont, brush, x + 300, y);
                e.Graphics.DrawString(row.Cells[3].Value?.ToString(), rowFont, brush, x + 450, y);
                e.Graphics.DrawString(row.Cells[4].Value?.ToString(), rowFont, brush, x + 550, y);
                y += rowHeight;

                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }
    }
}

