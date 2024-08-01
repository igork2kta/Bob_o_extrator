using System;
using System.Reflection;
using System.Windows.Forms;


[assembly: AssemblyVersion("1.3.0")]
[assembly: AssemblyMetadata("BuildDate", "2024-06-06")]
namespace Bob_o_extrator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
