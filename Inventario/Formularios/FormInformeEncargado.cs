﻿using Inventario.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Formularios
{

    public partial class FormInformeEncargado : Form
    {
        private Registro_TiendasEntities3 db = new Registro_TiendasEntities3();
        public FormInformeEncargado()
        {
            InitializeComponent();
            CargarReporte();
        }

        private void FormInformeEncargado_Load(object sender, EventArgs e)
        {
            this.rvEncargado.RefreshReport();
        }
        private void CargarReporte()
        {
            var listaEncargados = (from e in db.Encargado
                               select new
                               {
                                   e.id_encargado,
                                   e.rut,
                                   e.nombre,
                                   e.apellido,
                                   e.telefono
                               }).ToList();
            if (listaEncargados.Count() > 0)
            {
                ReportDataSource report = new ReportDataSource("Encargado", listaEncargados);
                rvEncargado.LocalReport.DataSources.Clear();
                rvEncargado.LocalReport.DataSources.Add(report);
                rvEncargado.RefreshReport();
            }
        }
       // private void CargarReporte()
     //   {
   //         var listaMarcas = (from m in db.Marca
   //                            select new
  //                             {
  //                               m.id_marca,
 //                                m.nombre_marca
  //                            }).ToList();
  //          if (listaMarcas.Count() > 0)
 //           {
 //               ReportDataSource report = new ReportDataSource("Marca", listaMarcas);
 //               rvMarcas.LocalReport.DataSources.Clear();
 //               rvMarcas.LocalReport.DataSources.Add(report);
 //               rvMarcas.RefreshReport();
//            }
 //       }
    }
}
