using BlazorWinForms5;

namespace WinFormsApp1
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
            Startup.Init();
            ApplicationConfiguration.Initialize();
            Application.Run(new BlazorWinForms5.Form1());
        }
    }
}