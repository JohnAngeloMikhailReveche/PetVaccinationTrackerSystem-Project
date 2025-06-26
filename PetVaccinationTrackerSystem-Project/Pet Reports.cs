using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Data;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project
{
    public partial class Pet_Reports : UserControl
    {
        public Pet_Reports()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void VRDSVaccineDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pet_Reports_Load(object sender, EventArgs e)
        {
            // Set default date to today
            dateTimePicker1.Value = DateTime.Today;

            

            // Load line chart: shows how many pets got vaccinated today
            LoadLineChart(DateTime.Today);

            // Load pie chart: filtered by species, gender, and vaccine name
            LoadPieChart("Dog", "Male", "Anti-Rabies");
        }

        private void LoadLineChart(DateTime date)
        {
            using (var context = new ModelContext())
            {
                int count = context.PetHealthRecordsList
                    .Where(r => r.DateAdministered.Date == date)
                    .Count();

                cartesianChart1.Series = new ISeries[]
                {
                    new LineSeries<ObservablePoint>
                    {
                        Values = new List<ObservablePoint>

                            {
                              new ObservablePoint(date.ToOADate(), count)
                            },

                                GeometrySize = 10,
                                Stroke = new SolidColorPaint(SKColors.SaddleBrown, 2),
                                Fill = null
                    }
                };

                cartesianChart1.XAxes = new[]

                {
                    new Axis
                    {
                        Labeler = value => DateTime.FromOADate(value).ToString("MM/dd/yyyy"),
                        LabelsRotation = 15,
                        Name = "Date"
                    }
                };

                cartesianChart1.YAxes = new[]
                {
                    new Axis
                    {
                        Name = "Number of Vaccinated Pets",
                        MinLimit = 0
                    }
                };
            }
        }


        private void LoadPieChart(string species, string gender, string vaccine)
        {
            using (var context = new ModelContext())
            {
                var count = context.PetHealthRecordsList
                    .Include(r => r.Pet)
                    .Where(r =>
                        r.Pet.Species.ToLower() == species.Trim().ToLower() &&
                        r.Pet.Gender.ToLower() == gender.Trim().ToLower() &&
                        r.VaccineName.ToLower() == vaccine.Trim().ToLower())
                    .Count();

                pieChart1.Series = new ISeries[]
                {
                    new PieSeries<double>
                    {
                        Name = $"{species}-{gender}-{vaccine}",
                        Values = new double[] { count },
                        DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                        DataLabelsSize = 14,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.ChartCenter
                    }
                };
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // Grab values from the UI
            string selectedSpecies = cmbPettype.SelectedItem?.ToString();
            string selectedGender = cmbPetGender.SelectedItem?.ToString();
            string selectedVaccine = cmbVaccinenName.SelectedItem?.ToString();
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Load both charts
            LoadPieChart(selectedSpecies, selectedGender, selectedVaccine);
            LoadLineChart(selectedDate);

        }
    }
}
