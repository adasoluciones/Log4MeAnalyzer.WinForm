
namespace Ada.Framework.Development.Log4Me.Analyzer.WinForm
{
    partial class VistaDiagramaSecuencia
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
            this.panelDiagrama = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lb_Escala = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // panelDiagrama
            // 
            this.panelDiagrama.AutoScroll = true;
            this.panelDiagrama.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDiagrama.BackColor = System.Drawing.Color.Transparent;
            this.panelDiagrama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDiagrama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiagrama.Location = new System.Drawing.Point(20, 60);
            this.panelDiagrama.Name = "panelDiagrama";
            this.panelDiagrama.Size = new System.Drawing.Size(1125, 639);
            this.panelDiagrama.TabIndex = 0;
            this.panelDiagrama.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panelDiagrama_Scroll);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // lb_Escala
            // 
            this.lb_Escala.AutoSize = true;
            this.lb_Escala.BackColor = System.Drawing.Color.Transparent;
            this.lb_Escala.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_Escala.Location = new System.Drawing.Point(1097, 60);
            this.lb_Escala.Name = "lb_Escala";
            this.lb_Escala.Size = new System.Drawing.Size(48, 13);
            this.lb_Escala.TabIndex = 1;
            this.lb_Escala.Text = "Escala 1";
            // 
            // VistaDiagramaSecuencia
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackImage = global::Ada.Framework.Development.Log4Me.Analyzer.WinForm.Properties.Resources.Log4Me_icon;
            this.BackImagePadding = new System.Windows.Forms.Padding(210, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(1165, 719);
            this.Controls.Add(this.lb_Escala);
            this.Controls.Add(this.panelDiagrama);
            this.Name = "VistaDiagramaSecuencia";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StyleManager = this.metroStyleManager;
            this.Text = "Log4MeAnalyzer";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private System.Windows.Forms.Panel panelDiagrama;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lb_Escala;

    }
}

