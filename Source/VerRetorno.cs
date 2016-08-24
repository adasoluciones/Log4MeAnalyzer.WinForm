using Ada.Framework.Data.Json;
using Ada.Framework.Development.Log4Me.Analyzer.WinForm.Model;
using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Ada.Framework.Development.Log4Me.Analyzer.WinForm
{
    public partial class VerRetorno : MetroForm
    {
        public VerRetorno()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            lb_Clase.Text = Sesion.MetodoActual.Clase;
            lb_Nombre.Text = Sesion.MetodoActual.Nombre;
            lb_ThreadGUID.Text = Sesion.MetodoActual.Hilo.ThreadGUID;
            lb_MethodGUID.Text = Sesion.MetodoActual.MethodGUID;
            lb_FechaInicio.Text = Sesion.MetodoActual.Fecha.ToString("dd/MM/yyyy");
            lb_FechaRetorno.Text = Sesion.MetodoActual.Retorno.Fecha.ToString("dd/MM/yyyy");
            lb_TiempoEstimado.Text = (Sesion.MetodoActual.Retorno.Fecha - Sesion.MetodoActual.Fecha).ToString();

            Deserialize();
        }

        public void BuildTree(Dictionary<string, object> dictionary, TreeNode node)
        {
            foreach (KeyValuePair<string, object> item in dictionary)
            {
                if (item.Key == "$type") continue;
                TreeNode parentNode = new TreeNode(item.Key);
                node.Nodes.Add(parentNode);

                try
                {
                    dictionary = (Dictionary<string, object>)item.Value;
                    BuildTree(dictionary, parentNode);
                }
                catch (InvalidCastException)
                {
                    try
                    {
                        ArrayList list = (ArrayList)item.Value;
                        foreach (string value in list)
                        {
                            TreeNode finalNode = new TreeNode(value);
                            finalNode.ForeColor = Color.Blue;
                            parentNode.Nodes.Add(finalNode);
                        }
                    }
                    catch (InvalidCastException)
                    {
                        TreeNode finalNode = new TreeNode(item.Value.ToString());
                        finalNode.ForeColor = Color.Blue;
                        parentNode.Nodes.Add(finalNode);
                    }
                }
            }
        }

        private void Deserialize()
        {
            Sesion.ExcepcionActual = Sesion.MetodoActual.Excepcion;

            if (Sesion.ExcepcionActual != null)
            {
                MostrarModelo(new ExcepcionModel()
                {
                    ThreadGUID = Sesion.ExcepcionActual.Metodo.Hilo.ThreadGUID,
                    Clase = Sesion.ExcepcionActual.Metodo.Clase,
                    MethodGUID = Sesion.ExcepcionActual.Metodo.MethodGUID,
                    Metodo = Sesion.ExcepcionActual.Metodo.Nombre,
                    Tipo = Sesion.ExcepcionActual.Tipo,
                    Mensaje = Sesion.ExcepcionActual.Mensaje,
                    StackTrace = Sesion.ExcepcionActual.StackTrace,
                    Data = Sesion.ExcepcionActual.Data
                });
            }

            arbol_JSON.Nodes.Clear();
            JavaScriptSerializer js = new JavaScriptSerializer();

            try
            {
                TreeNode rootNode = new TreeNode(Sesion.MetodoActual.Retorno.Tipo);
                arbol_JSON.Nodes.Add(rootNode);

                IJsonConverter converter = JsonConverterFactory.ObtenerJsonConverter();
                try
                {
                    Sesion.MetodoActual.Retorno.Valor = converter.ToObject(Sesion.MetodoActual.Retorno.Valor.ToString(), true);
                }
                catch { }
                Dictionary<string, object> dic = js.Deserialize<Dictionary<string, object>>(converter.ToJson(Sesion.MetodoActual.Retorno));
                BuildTree(dic, rootNode);
            }
            catch
            {
            }
        }

        public void MostrarModelo(ExcepcionModel model)
        {
            lb_Tipo.Text = model.Tipo;
            lb_Mensaje.Text = model.Mensaje;
            lb_StackTrace.Text = model.StackTrace.Replace("\t", "\n");
            lb_Data.Text = "\n" + model.Data;
        }
    }
}
