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
    public partial class informeCliente : Form
    {
        public informeCliente()
        {
            InitializeComponent();
            // Configurar los valores de los parámetros
            ReportParameter[] parameters = new ReportParameter[10];
            parameters[0] = new ReportParameter("id", Properties.Settings.Default.idCliente);
            parameters[1] = new ReportParameter("nombre", Properties.Settings.Default.nombreCliente);
            parameters[2] = new ReportParameter("tipocliente", Properties.Settings.Default.tipoCliente);
            parameters[3] = new ReportParameter("dni", Properties.Settings.Default.dniCliente);
            parameters[4] = new ReportParameter("telefono", Properties.Settings.Default.telefonoCliente);
            parameters[5] = new ReportParameter("email", Properties.Settings.Default.emailCliente);
            parameters[6] = new ReportParameter("provincia", Properties.Settings.Default.provinciaCliente);
            parameters[7] = new ReportParameter("localidad", Properties.Settings.Default.localidadCliente);
            parameters[8] = new ReportParameter("codigopostal", Properties.Settings.Default.codigoPostalCliente);
            parameters[9] = new ReportParameter("direccion", Properties.Settings.Default.direcciónCliente);

            // Configurar el ReportViewer con los parámetros
            this.reportViewer1.LocalReport.SetParameters(parameters);

            // Cargar y mostrar el informe
            this.reportViewer1.RefreshReport();
        }

        private void informeCliente_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
