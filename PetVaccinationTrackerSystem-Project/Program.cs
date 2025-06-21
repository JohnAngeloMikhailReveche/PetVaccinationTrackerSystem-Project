using PetVaccinationTrackerSystem_Project.Forms;
using PetVaccinationTrackerSystem_Project.Forms.Auth;

namespace PetVaccinationTrackerSystem_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new MainFormVet());
            Application.Run(new AuthForm());
        }
    }
}