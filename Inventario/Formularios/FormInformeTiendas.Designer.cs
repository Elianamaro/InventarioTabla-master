﻿
namespace Inventario.Formularios
{
    partial class FormInformeTiendas
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
            this.rvTiendas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.EncargadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EncargadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvTiendas
            // 
            reportDataSource1.Name = "Tienda";
            reportDataSource1.Value = this.EncargadoBindingSource;
            this.rvTiendas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvTiendas.LocalReport.ReportEmbeddedResource = "Inventario.Reports.Tienda.rdlc";
            this.rvTiendas.Location = new System.Drawing.Point(68, 110);
            this.rvTiendas.Name = "rvTiendas";
            this.rvTiendas.ServerReport.BearerToken = null;
            this.rvTiendas.Size = new System.Drawing.Size(665, 322);
            this.rvTiendas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte Tiendas";
            // 
            // EncargadoBindingSource
            // 
            this.EncargadoBindingSource.DataSource = typeof(Inventario.Models.Tienda);
            // 
            // FormInformeTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvTiendas);
            this.Controls.Add(this.label1);
            this.Name = "FormInformeTiendas";
            this.Text = "FormInformeTiendas";
            this.Load += new System.EventHandler(this.FormInformeTiendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EncargadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvTiendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource EncargadoBindingSource;
    }
}