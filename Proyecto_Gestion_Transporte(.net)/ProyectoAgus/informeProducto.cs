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

namespace ProyectoAgus
{
    public partial class informeProducto : Form
    {
        public informeProducto()
        {
            InitializeComponent();
            // Configurar los valores de los parámetros
            ReportParameter[] parameters = new ReportParameter[6];
            parameters[0] = new ReportParameter("id", Properties.Settings.Default.idProducto);
            parameters[1] = new ReportParameter("nombre", Properties.Settings.Default.nombreProducto);
            parameters[2] = new ReportParameter("precio", Properties.Settings.Default.precioProducto);
            parameters[3] = new ReportParameter("peso", Properties.Settings.Default.pesoProducto);
            parameters[4] = new ReportParameter("stock", Properties.Settings.Default.stockProducto);
            parameters[5] = new ReportParameter("isbn", Properties.Settings.Default.isbnProducto);

            // Configurar el ReportViewer con los parámetros
            this.reportViewer1.LocalReport.SetParameters(parameters);

            // Cargar y mostrar el informe
            this.reportViewer1.RefreshReport();
        }

        private void informeProducto_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
