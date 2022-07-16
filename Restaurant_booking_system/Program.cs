using Restaurant_booking_system.Admin;
using Restaurant_booking_system.Repositories;

namespace Restaurant_booking_system
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
            Application.Run(new Frm_login());
            //Application.Run(new Frm_AdminDashboard());
        }
    }
}