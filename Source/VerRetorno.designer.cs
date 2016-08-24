
namespace Ada.Framework.Development.Log4Me.Analyzer.WinForm
{
    partial class VerRetorno
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.arbol_JSON = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Tipo = new System.Windows.Forms.Label();
            this.lb_Mensaje = new System.Windows.Forms.Label();
            this.lb_Data = new System.Windows.Forms.Label();
            this.lb_StackTrace = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_Clase = new System.Windows.Forms.Label();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_ThreadGUID = new System.Windows.Forms.Label();
            this.lb_MethodGUID = new System.Windows.Forms.Label();
            this.lb_FechaInicio = new System.Windows.Forms.Label();
            this.lb_FechaRetorno = new System.Windows.Forms.Label();
            this.lb_TiempoEstimado = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // arbol_JSON
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.arbol_JSON, true);
            this.arbol_JSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arbol_JSON.Location = new System.Drawing.Point(0, 0);
            this.arbol_JSON.Name = "arbol_JSON";
            this.arbol_JSON.Size = new System.Drawing.Size(421, 276);
            this.arbol_JSON.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.tableLayoutPanel3, true);
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.91003F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.08997F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_Tipo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lb_Mensaje, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_Data, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lb_StackTrace, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(350, 242);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "StackTrace";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mensaje";
            // 
            // lb_Tipo
            // 
            this.lb_Tipo.AutoSize = true;
            this.lb_Tipo.Location = new System.Drawing.Point(121, 8);
            this.lb_Tipo.Name = "lb_Tipo";
            this.lb_Tipo.Size = new System.Drawing.Size(0, 13);
            this.lb_Tipo.TabIndex = 12;
            // 
            // lb_Mensaje
            // 
            this.lb_Mensaje.AutoSize = true;
            this.lb_Mensaje.Location = new System.Drawing.Point(121, 42);
            this.lb_Mensaje.Name = "lb_Mensaje";
            this.lb_Mensaje.Size = new System.Drawing.Size(0, 13);
            this.lb_Mensaje.TabIndex = 13;
            // 
            // lb_Data
            // 
            this.lb_Data.AutoSize = true;
            this.lb_Data.Location = new System.Drawing.Point(121, 195);
            this.lb_Data.Name = "lb_Data";
            this.lb_Data.Size = new System.Drawing.Size(0, 13);
            this.lb_Data.TabIndex = 15;
            // 
            // lb_StackTrace
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.lb_StackTrace, true);
            this.lb_StackTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_StackTrace.Location = new System.Drawing.Point(121, 102);
            this.lb_StackTrace.Name = "lb_StackTrace";
            this.lb_StackTrace.ReadOnly = true;
            this.lb_StackTrace.Size = new System.Drawing.Size(226, 90);
            this.lb_StackTrace.TabIndex = 16;
            this.lb_StackTrace.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.tableLayoutPanel2, true);
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.315204F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.6848F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.854839F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.14516F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 276);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.tableLayoutPanel1, true);
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.91003F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.08997F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lb_Clase, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Nombre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_ThreadGUID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_MethodGUID, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_FechaInicio, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_FechaRetorno, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_TiempoEstimado, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 276);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Clase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ThreadGUID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MethodGUID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fecha Inicio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Fecha Retorno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tiempo estimado";
            // 
            // lb_Clase
            // 
            this.lb_Clase.AutoSize = true;
            this.lb_Clase.Location = new System.Drawing.Point(145, 30);
            this.lb_Clase.Name = "lb_Clase";
            this.lb_Clase.Size = new System.Drawing.Size(0, 13);
            this.lb_Clase.TabIndex = 18;
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(145, 60);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(0, 13);
            this.lb_Nombre.TabIndex = 10;
            // 
            // lb_ThreadGUID
            // 
            this.lb_ThreadGUID.AutoSize = true;
            this.lb_ThreadGUID.Location = new System.Drawing.Point(145, 90);
            this.lb_ThreadGUID.Name = "lb_ThreadGUID";
            this.lb_ThreadGUID.Size = new System.Drawing.Size(0, 13);
            this.lb_ThreadGUID.TabIndex = 11;
            // 
            // lb_MethodGUID
            // 
            this.lb_MethodGUID.AutoSize = true;
            this.lb_MethodGUID.Location = new System.Drawing.Point(145, 120);
            this.lb_MethodGUID.Name = "lb_MethodGUID";
            this.lb_MethodGUID.Size = new System.Drawing.Size(0, 13);
            this.lb_MethodGUID.TabIndex = 12;
            // 
            // lb_FechaInicio
            // 
            this.lb_FechaInicio.AutoSize = true;
            this.lb_FechaInicio.Location = new System.Drawing.Point(145, 150);
            this.lb_FechaInicio.Name = "lb_FechaInicio";
            this.lb_FechaInicio.Size = new System.Drawing.Size(0, 13);
            this.lb_FechaInicio.TabIndex = 13;
            // 
            // lb_FechaRetorno
            // 
            this.lb_FechaRetorno.AutoSize = true;
            this.lb_FechaRetorno.Location = new System.Drawing.Point(145, 180);
            this.lb_FechaRetorno.Name = "lb_FechaRetorno";
            this.lb_FechaRetorno.Size = new System.Drawing.Size(0, 13);
            this.lb_FechaRetorno.TabIndex = 14;
            // 
            // lb_TiempoEstimado
            // 
            this.lb_TiempoEstimado.AutoSize = true;
            this.lb_TiempoEstimado.Location = new System.Drawing.Point(145, 210);
            this.lb_TiempoEstimado.Name = "lb_TiempoEstimado";
            this.lb_TiempoEstimado.Size = new System.Drawing.Size(0, 13);
            this.lb_TiempoEstimado.TabIndex = 15;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage4);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(429, 318);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(421, 276);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Detalle";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(421, 276);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Excepción";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.arbol_JSON);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(421, 276);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Valor";
            // 
            // VerRetorno
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Ada.Framework.Development.Log4Me.Analyzer.WinForm.Properties.Resources.Log4Me_icon;
            this.BackImagePadding = new System.Windows.Forms.Padding(210, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(469, 398);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "VerRetorno";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StyleManager = this.metroStyleManager;
            this.Text = "Log4MeAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TreeView arbol_JSON;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lb_Tipo;
        private System.Windows.Forms.Label lb_Mensaje;
        private System.Windows.Forms.Label lb_Data;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_Clase;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Label lb_ThreadGUID;
        private System.Windows.Forms.Label lb_MethodGUID;
        private System.Windows.Forms.Label lb_FechaInicio;
        private System.Windows.Forms.Label lb_FechaRetorno;
        private System.Windows.Forms.Label lb_TiempoEstimado;
        private System.Windows.Forms.RichTextBox lb_StackTrace;

    }
}

