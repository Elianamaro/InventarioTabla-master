
namespace Inventario.Formularios
{
    partial class FormInformeProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvProductos
            // 
            reportDataSource1.Name = "Producto";
            this.rvProductos.LocalReport.DataSources.Add(reportDataSource1);
            this.rvProductos.LocalReport.ReportEmbeddedResource = "Inventario.Reports.Producto.rdlc";
            this.rvProductos.Location = new System.Drawing.Point(68, 110);
            this.rvProductos.Name = "rvProductos";
            this.rvProductos.ServerReport.BearerToken = null;
            this.rvProductos.Size = new System.Drawing.Size(665, 322);
            this.rvProductos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte Productos";
            // 
            // CategoriasBindingSource
            // 
            this.CategoriasBindingSource.DataSource = typeof(Inventario.Models.Producto);
            // 
            // FormInformeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvProductos);
            this.Controls.Add(this.label1);
            this.Name = "FormInformeProductos";
            this.Text = "FormInformeProductos";
            this.Load += new System.EventHandler(this.FormInformeProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource CategoriasBindingSource;
    }
}