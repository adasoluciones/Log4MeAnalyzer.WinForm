using Ada.Framework.Development.Log4Me.Analyzer.Models;
using Ada.Framework.Development.Log4Me.Analyzer.WinForm.Model;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ada.Framework.Development.Log4Me.Analyzer.WinForm
{
    public partial class MenuPrincipal : MetroForm
    {
        private static string FORMATO_FECHA_HORA = "dd/MM/yyyy HH:mm:ss";
        private static string FECHA_HORA_DEFECTO = "00/00/0000 00:00:00";
        private static string HORA_DEFECTO = "00:00:00,0000";
        private ResumenLog4MeModel modelo;

        public MenuPrincipal()
        {
            InitializeComponent();
            dialogoAbrir.Filter = "Archivo de Log4Me| *.log";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modelo = new ResumenLog4MeModel();
            MostrarModelo(modelo);

            if (dialogoAbrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Sesion.RutaArchivo = dialogoAbrir.FileName;

                Sesion.DialogoCarga.IniciarCarga(new DoWorkEventHandler((a, b) =>
                {
                    try
                    {
                        modelo = Sesion.Analyzer.ObtenerResumen(Sesion.RutaArchivo);
                        Sesion.Excepciones = modelo.Excepciones;
                        MostrarModelo(modelo);

                        if (Sesion.Excepciones != null)
                        {
                            Invoke(new Action(() =>
                            {
                                if (Sesion.Excepciones != null)
                                {
                                    grid_Excepciones.DataSource = Sesion.Excepciones.Select(excepcion => new ExcepcionModel()
                                    {
                                        ThreadGUID = excepcion.Metodo.Hilo.ThreadGUID,
                                        Clase = excepcion.Metodo.Clase,
                                        MethodGUID = excepcion.Metodo.MethodGUID,
                                        Metodo = excepcion.Metodo.Nombre,
                                        Tipo = excepcion.Tipo,
                                        Mensaje = excepcion.Mensaje,
                                        StackTrace = excepcion.StackTrace,
                                        Data = excepcion.Data
                                    }).ToList();
                                }
                            }));
                        }
                    }
                    catch (Exception ex)
                    {
                        Sesion.DialogoCarga.PermiteCerrar = true;
                        Sesion.DialogoCarga.Close();
                        MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }));
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void MostrarModelo(ResumenLog4MeModel model)
        {
            Invoke(new Action(() =>
            {
                #region Tiempo Análisis
                lb_FechaInicioTiempoAnalisis.Text = model.Analisis.Inicio.HasValue ? model.Analisis.Inicio.Value.ToString(FORMATO_FECHA_HORA, CultureInfo.InvariantCulture) : FECHA_HORA_DEFECTO;
                lb_FechaTerminoTiempoAnalisis.Text = model.Analisis.Termino.HasValue ? model.Analisis.Inicio.Value.ToString(FORMATO_FECHA_HORA, CultureInfo.InvariantCulture) : FECHA_HORA_DEFECTO;
                lb_TotalTiempoAnalisis.Text = model.Analisis.Total.HasValue ? model.Analisis.Total.Value.ToString() : HORA_DEFECTO;
                #endregion Tiempo Análisis

                #region Tiempo Log
                lb_FechaInicioLog.Text = model.Log.Inicio.HasValue ? model.Analisis.Inicio.Value.ToString(FORMATO_FECHA_HORA, CultureInfo.InvariantCulture) : FECHA_HORA_DEFECTO;
                lb_FechaTerminoLog.Text = model.Log.Termino.HasValue ? model.Analisis.Inicio.Value.ToString(FORMATO_FECHA_HORA, CultureInfo.InvariantCulture) : FECHA_HORA_DEFECTO;
                lb_TotalTiempoLog.Text = model.Log.Total.HasValue ? model.Analisis.Total.Value.ToString() : HORA_DEFECTO;
                #endregion Tiempo Log

                #region Cuentas
                if (model.MetodosEjecutados > 0)
                {
                    int valor = model.MetodosEjecutados - model.ExcepcionesLanzadas;

                    this.chart1.Palette = ChartColorPalette.Pastel;
                    chart1.Series.Clear();

                    chart1.Legends.Add("");

                    Series serie = new Series()
                    {
                        ChartType = SeriesChartType.Doughnut
                    };

                    serie.Points.Add(new DataPoint(valor, valor)
                    {
                        LegendText = string.Format("{0} Correcto", valor),
                        Color = Color.FromArgb(154, 205, 50)
                    });

                    serie.Points.Add(new DataPoint(model.ExcepcionesLanzadas, model.ExcepcionesLanzadas)
                    {
                        LegendText = string.Format("{0} Excepciones", model.ExcepcionesLanzadas),
                        Color = Color.Red
                    });

                    chart1.Series.Add(serie);
                }
                #endregion Cuentas

                #region Flujo mas demoroso
                btn_ThreadGUIDFlujoMasDemoroso.Text = model.FlujoMasDemoroso.ID;
                lb_FechaInicioFlujoMasDemoroso.Text = model.FlujoMasDemoroso.Inicio.HasValue ? model.FlujoMasDemoroso.Inicio.Value.ToString(FORMATO_FECHA_HORA, CultureInfo.InvariantCulture) : FECHA_HORA_DEFECTO;
                lb_FechaTerminoFlujoMasDemoroso.Text = model.FlujoMasDemoroso.Termino.HasValue ? model.FlujoMasDemoroso.Termino.Value.ToString(FORMATO_FECHA_HORA, CultureInfo.InvariantCulture) : FECHA_HORA_DEFECTO;
                lb_TotalFechaFlujoMasDemoroso.Text = model.FlujoMasDemoroso.Total.HasValue ? model.FlujoMasDemoroso.Total.Value.ToString() : HORA_DEFECTO;
                #endregion Flujo mas demoroso

                #region Método mas demoroso
                lb_MethodGUIDMetodoMasDemoroso.Text = model.MetodoMasDemoroso.ID;
                lb_NomreMetodoMasDemoroso.Text = model.MetodoMasDemoroso.Nombre;
                lb_FechaInicioMetodoMasDemoroso.Text = model.MetodoMasDemoroso.Inicio.HasValue ? model.MetodoMasDemoroso.Inicio.Value.ToString(FORMATO_FECHA_HORA, CultureInfo.InvariantCulture) : FECHA_HORA_DEFECTO;
                lb_FechaTerminoMetodoMasDemoroso.Text = model.MetodoMasDemoroso.Termino.HasValue ? model.MetodoMasDemoroso.Termino.Value.ToString(FORMATO_FECHA_HORA, CultureInfo.InvariantCulture) : FECHA_HORA_DEFECTO;
                lb_TotalFechaMetodoMasDemoroso.Text = model.MetodoMasDemoroso.Total.HasValue ? model.MetodoMasDemoroso.Total.Value.ToString() : HORA_DEFECTO;
                #endregion Método mas demoroso
            }));
        }

        private void btn_ThreadGUIDFlujoMasDemoroso_Click(object sender, EventArgs e)
        {
            VistaDiagramaSecuencia detalle = new VistaDiagramaSecuencia();

            Sesion.DialogoCarga.IniciarCarga(new DoWorkEventHandler((a, b) =>
            {
                if (Sesion.RutaArchivo != null)
                {
                    Sesion.HiloActual = Sesion.Mapper.Convertir(Sesion.Analyzer.ObtenerFlujo(Sesion.RutaArchivo, btn_ThreadGUIDFlujoMasDemoroso.Text));
                    detalle.CrearDiagrama();
                }
            }),
                new DoWorkEventHandler((a, b) =>
                {
                    Invoke(new Action(() =>
                    {
                        if (Sesion.HiloActual != null)
                        {
                            detalle.ShowDialog();
                        }
                    }));
                }));
        }

        private void grid_Excepciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ThreadGUID = grid_Excepciones.CurrentRow.Cells[0].Value.ToString();

            VistaDiagramaSecuencia detalle = new VistaDiagramaSecuencia();

            if (!string.IsNullOrWhiteSpace(ThreadGUID))
            {
                Sesion.DialogoCarga.IniciarCarga(new DoWorkEventHandler((a, b) =>
                {
                    Sesion.HiloActual = Sesion.Mapper.Convertir(Sesion.Analyzer.ObtenerFlujo(Sesion.RutaArchivo, ThreadGUID));
                    detalle.CrearDiagrama();
                }),
                new DoWorkEventHandler((a, b) =>
                {
                    Invoke(new Action(() =>
                    {
                        detalle.ShowDialog();
                    }));
                }));
            }
        }
    }
}
