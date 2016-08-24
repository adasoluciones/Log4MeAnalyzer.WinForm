using MetroFramework;
using System;
using System.Windows.Forms;

namespace Ada.Framework.Development.Log4Me.Analyzer.WinForm
{
    public static class UtilitarioExcepcion
    {
        public static void MostrarExcepcion(IWin32Window windows, Exception ex)
        {
            #if DEBUG
                throw ex;
            #else
                MetroMessageBox.Show(windows, ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endif
        }

        public static void MostrarExcepcion(IWin32Window windows, Exception ex, bool isDebug)
        {
            if (isDebug)
            {
                throw ex;
            }
            else
            {
                MetroMessageBox.Show(windows, ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
