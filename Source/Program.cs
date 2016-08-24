using System;
using System.Windows.Forms;

namespace Ada.Framework.Development.Log4Me.Analyzer.WinForm
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MenuPrincipal vista = new MenuPrincipal();

            try
            {
                Application.Run(vista);
            }
            catch (Exception ex)
            {
                UtilitarioExcepcion.MostrarExcepcion(vista, ex);
            }
        }
    }
}
