﻿
namespace Inventario.Formularios
{
    partial class FormInformeEncargado
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
            this.label1 = new System.Windows.Forms.Label();
            this.rvEncargado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EncargadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EncargadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Encargados";
            // 
            // rvEncargado
            // 
            this.rvEncargado.LocalReport.ReportEmbeddedResource = "Inventario.Reports.Encargado.rdlc";
            this.rvEncargado.Location = new System.Drawing.Point(67, 100);
            this.rvEncargado.Name = "rvEncargado";
            this.rvEncargado.ServerReport.BearerToken = null;
            this.rvEncargado.Size = new System.Drawing.Size(665, 322);
            this.rvEncargado.TabIndex = 1;
            // 
            // EncargadoBindingSource
            // 
            this.EncargadoBindingSource.DataSource = typeof(Inventario.Models.Encargado);
            // 
            // FormInformeEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvEncargado);
            this.Controls.Add(this.label1);
            this.Name = "FormInformeEncargado";
            this.Text = "FormInformeEncargado";
            this.Load += new System.EventHandler(this.FormInformeEncargado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EncargadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rvEncargado;
        private System.Windows.Forms.BindingSource EncargadoBindingSource;
    }
}