using Ada.Framework.Data.Json;
using Ada.Framework.Development.Log4Me.Analyzer.Entities;
using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Ada.Framework.Development.Log4Me.Analyzer.WinForm
{
    public partial class VerParametros : MetroForm
    {
        public VerParametros()
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
            arbol_JSON.Nodes.Clear();
            JavaScriptSerializer js = new JavaScriptSerializer();

            try
            {
                TreeNode rootNode = new TreeNode("Parametros");
                arbol_JSON.Nodes.Add(rootNode);

                foreach (ParametroTO parametro in Sesion.MetodoActual.Parametros)
                {
                    TreeNode nodoParametro = new TreeNode(string.Format("[{0}]", parametro.Nombre));
                    rootNode.Nodes.Add(nodoParametro);
                    IJsonConverter converter = JsonConverterFactory.ObtenerJsonConverter();
                    try
                    {
                        parametro.Valor = converter.ToObject(parametro.Valor.ToString(), true);
                    }
                    catch { }

                    Dictionary<string, object> dic = js.Deserialize<Dictionary<string, object>>(converter.ToJson(parametro));
                    BuildTree(dic, nodoParametro);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("JSON data is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
