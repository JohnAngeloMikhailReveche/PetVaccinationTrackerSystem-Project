using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Classes.Abstract;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project.Forms.Admin
{
    public partial class AdminRegisterClinicUsCo : UserControl
    {

    
        public AdminRegisterClinicUsCo()
        {
            InitializeComponent();

        }

        private void btnRegisterClinic_Click(object sender, EventArgs e)
        {

            EntityRegistrar clinicRegistrar = new ClinicRegistrar(
                txtboxClinicName.Text.Trim(), 
                txtboxStreet.Text.Trim(), 
                txtboxCity.Text.Trim(), 
                txtboxState.Text.Trim(), 
                txtboxZipCode.Text.Trim());

            if(clinicRegistrar.ValidateFields())
            {
                clinicRegistrar.Register();
                MessageBox.Show("Clinic registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var fieldHelper = new TextFieldHelper();

            fieldHelper.ClearFields(
                new List<TextBox>
                {
                    txtboxClinicName,
                    txtboxCity,
                    txtboxState,
                    txtboxZipCode,
                    txtboxStreet
                });

        }
    }
}
