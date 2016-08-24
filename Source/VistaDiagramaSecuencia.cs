using Ada.Framework.Development.Log4Me.Analyzer.Entities;
using Ada.Framework.UI.WinForms.Diagram.API;
using Ada.Framework.UI.WinForms.Diagram.Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ada.Framework.Development.Log4Me.Analyzer.WinForm
{
    public partial class VistaDiagramaSecuencia : MetroForm
    {
        public DiagramaSecuencia diagramaSecuencia { get; set; }
        private IDictionary<string, Clase> ClasesCreadas = new Dictionary<string, Clase>();

        private volatile Graphics graphics = null;
        private volatile Graphics graphicsTooltip = null;
        private GraphicsState estadoVacio = null;

        public bool ActualizarDiagrama { get; set; }

        public VistaDiagramaSecuencia()
        {
            diagramaSecuencia = new DiagramaSecuencia();
            diagramaSecuencia.AlHacerClickForma += AlHacerClickForma;
            InitializeComponent();
            panelDiagrama.MouseDown += diagramaSecuencia.OnMouseDown;
        }

        public void CrearDiagrama()
        {
            MetodoTO metodoInicial = Sesion.HiloActual.Ejecuciones[0];

            Clase usuario = diagramaSecuencia.AgregarClase("Usuario", true);
            ClasesCreadas.Add(metodoInicial.Clase, diagramaSecuencia.AgregarClase(metodoInicial.Clase));

            diagramaSecuencia.AgregarInicioLlamada(metodoInicial.Nombre, usuario.Linea, ClasesCreadas[metodoInicial.Clase].Linea, metodoInicial.MethodGUID);

            for (int i = 0; i < Sesion.HiloActual.Ejecuciones.Count; i++)
            {
                MostrarMetodo(Sesion.HiloActual.Ejecuciones[i], diagramaSecuencia, true);
            }
            diagramaSecuencia.AgregarRetornoLlamada(ClasesCreadas[metodoInicial.Clase].Linea, usuario.Linea, metodoInicial.Excepcion != null, metodoInicial.Retorno.Valor.ToString() == "<Void>", metodoInicial.MethodGUID);
        }

        public void MostrarMetodo(MetodoTO metodo, DiagramaSecuencia diagramaSecuencia, bool agregarDefinicion)
        {
            if (agregarDefinicion)
            {
                if (!ClasesCreadas.ContainsKey(metodo.Clase))
                {
                    ClasesCreadas.Add(metodo.Clase, diagramaSecuencia.AgregarClase(metodo.Clase));
                }
            }

            foreach (MetodoTO llamada in metodo.Llamadas)
            {
                if (!ClasesCreadas.ContainsKey(llamada.Clase))
                {
                    ClasesCreadas.Add(llamada.Clase, diagramaSecuencia.AgregarClase(llamada.Clase));
                }
                diagramaSecuencia.AgregarInicioLlamada(llamada.Nombre, ClasesCreadas[metodo.Clase].Linea, ClasesCreadas[llamada.Clase].Linea, llamada.MethodGUID);
                MostrarMetodo(llamada, diagramaSecuencia, false);
                diagramaSecuencia.AgregarRetornoLlamada(ClasesCreadas[llamada.Clase].Linea, ClasesCreadas[metodo.Clase].Linea, llamada.Excepcion != null, (llamada.Retorno.Valor.ToString() == "<Void>" || string.IsNullOrWhiteSpace(llamada.Retorno.Valor.ToString())), llamada.MethodGUID);
            }
        }

        private void DibujarDiagrama()
        {
            try
            {
                if (graphics == null)
                {
                    graphics = panelDiagrama.CreateGraphics();
                }

                if (graphicsTooltip == null)
                {
                    graphicsTooltip = panelDiagrama.CreateGraphics();
                    estadoVacio = graphicsTooltip.Save();
                }

                Point punto = new Point(-panelDiagrama.HorizontalScroll.Value, -panelDiagrama.VerticalScroll.Value);

                if (panelDiagrama.Controls.Count == 0)
                {
                    Panel panel = new Panel()
                    {
                        AutoSize = false,
                        Location = diagramaSecuencia.EndPoint,
                        Width = 100,
                        Height = 100
                    };
                    panel.BackColor = Color.Transparent;
                    panelDiagrama.Controls.Add(panel);
                }

                graphics.Clear(Color.White);
                diagramaSecuencia.Dibujar(graphics, punto);
            }
            catch (Exception ex)
            {
                UtilitarioExcepcion.MostrarExcepcion(this, ex);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (e != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                base.OnPaint(e);
            }
            DibujarDiagrama();            
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            bool actualizar = false;

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Add)
            {
                if (diagramaSecuencia.EscalaZoom < 1.5)
                {
                    diagramaSecuencia.EscalaZoom += (float)0.1;
                }
                actualizar = true;
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Subtract)
            {
                if (diagramaSecuencia.EscalaZoom > 0.3)
                {
                    diagramaSecuencia.EscalaZoom -= (float)0.1;
                }
                actualizar = true;
            }

            if (actualizar)
            {
                lb_Escala.Text = string.Format("Escala {0}", Math.Round(diagramaSecuencia.EscalaZoom, 1));
                panelDiagrama.Controls[0].Location = diagramaSecuencia.EndPoint;
                DibujarDiagrama();
            }
        }

        public void AlHacerClickForma(object sender, EventArgs e)
        {
            if (sender is Linea && !(sender as Linea).Transparente)
            {
                Linea linea = (sender as Linea);

                string MethodGUID = linea.Data.ToString();

                Form dialogo = null;
                Sesion.DialogoCarga.IniciarCarga(new DoWorkEventHandler((a, b) =>
                {
                    Invoke(new Action(() =>
                    {
                        Sesion.MetodoActual = Sesion.Mapper.ConvertirMetodo(Sesion.Analyzer.ObtenerMetodo(Sesion.RutaArchivo, MethodGUID));

                        if (linea.StartPoint.X < linea.EndPoint.X)
                        {
                            dialogo = new VerParametros();
                        }
                        else
                        {
                            dialogo = new VerRetorno();
                        }
                    }));
                }),
                     new DoWorkEventHandler((a, b) =>
                     {
                         if (dialogo != null)
                         {
                             Invoke(new Action(() =>
                             {
                                 dialogo.ShowDialog();
                             }));
                         }
                     }));
            }
        }

        private void panelDiagrama_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                diagramaSecuencia.XScrollMargin = e.NewValue;
            }
            else
            {
                diagramaSecuencia.YScrollMargin = e.NewValue;
            }
        }
    }
}
