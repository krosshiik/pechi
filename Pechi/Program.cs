using Pechi.Forms;

namespace Pechi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static FormLogin formLogin;
        public static FormProstoi formProstoi;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            formLogin = new FormLogin();
            formProstoi = new FormProstoi();

            Application.Run(formLogin);
        }
    }
}