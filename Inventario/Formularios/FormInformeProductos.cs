using Inventario.Models;
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
    public partial class FormInformeProductos : Form
    {
        private Registro_TiendasEntities3 db = new Registro_TiendasEntities3();
        public FormInformeProductos()
        {
            InitializeComponent();
            CargarReporte();
        }
        private void CargarReporte()
        {
            var listaProductos = (from p in db.Producto
                                  select new
                                  {
                                      p.id_producto,
                                      p.id_marca,
                                      p.id_categoria,
                                      p.id_tienda,
                                      p.fecha_recepcion,
                                      p.Marca.nombre_marca,
                                      p.Categorias.nombre,
                                      p.codigo_producto,
                                      p.nombre_producto,
                                      p.precio_compra,
                                      p.precio_venta,
                                      p.descripcion_producto
                                  }).ToList();
            if (listaProductos.Count() > 0)
            {
                ReportDataSource report = new ReportDataSource("Producto", listaProductos);
                rvProductos.LocalReport.DataSources.Clear();
                rvProductos.LocalReport.DataSources.Add(report);
                rvProductos.RefreshReport();
            }
        }

        private void FormInformeProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
