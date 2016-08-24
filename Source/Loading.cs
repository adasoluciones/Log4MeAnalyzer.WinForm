using MetroFramework.Forms;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ada.Framework.Development.Log4Me.Analyzer.WinForm
{
    public partial class Loading : MetroForm
    {
        public bool PermiteCerrar { get; set; }

        public Loading()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            if (PermiteCerrar) e.Cancel = false;

            base.OnFormClosing(e);
        }

        public void IniciarCarga(DoWorkEventHandler DoWork)
        {
            IniciarCarga(DoWork, null);
        }

        public void IniciarCarga(DoWorkEventHandler DoWork, DoWorkEventHandler DoOnCompletedWork)
        {
            Loading dialogo = new Loading();

            BackgroundWorker tareaSegundoPlano = new BackgroundWorker();
            tareaSegundoPlano.DoWork += DoWork;
            tareaSegundoPlano.RunWorkerCompleted += (a, b) =>
            {
                dialogo.PermiteCerrar = true;
                dialogo.Close();
                if (DoOnCompletedWork != null)
                {
                    BackgroundWorker tarea = new BackgroundWorker();
                    tarea.DoWork += DoOnCompletedWork;
                    tarea.RunWorkerAsync();
                }
            };
            tareaSegundoPlano.RunWorkerAsync();
            dialogo.ShowDialog();
        }
    }
}
