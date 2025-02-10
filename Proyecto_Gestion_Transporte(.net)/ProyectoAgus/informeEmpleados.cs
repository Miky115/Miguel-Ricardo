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
    public partial class informeEmpleados : Form
    {
        public informeEmpleados()
        {
            InitializeComponent();
            // Configurar los valores de los parámetros
            ReportParameter[] parameters = new ReportParameter[10];
            parameters[0] = new ReportParameter("id", Properties.Settings.Default.idEmpleado);
            parameters[1] = new ReportParameter("nombre", Properties.Settings.Default.nombreEmpleado);
            parameters[2] = new ReportParameter("dni", Properties.Settings.Default.dniEmpleado);
            parameters[3] = new ReportParameter("telefono", Properties.Settings.Default.telefonoEmpleado);
            parameters[4] = new ReportParameter("direccion", Properties.Settings.Default.direccionEmpleado);
            parameters[5] = new ReportParameter("correo", Properties.Settings.Default.correoEmpleado);
            parameters[6] = new ReportParameter("fechacontratacion", Properties.Settings.Default.fechaContratacion);
            parameters[7] = new ReportParameter("fechanacimiento", Properties.Settings.Default.fechaNacimiento);
            parameters[8] = new ReportParameter("salario", Properties.Settings.Default.salarioEmpleado);
            parameters[9] = new ReportParameter("cargo", Properties.Settings.Default.cargoEmpleado);

            // Configurar el ReportViewer con los parámetros
            this.reportViewer1.LocalReport.SetParameters(parameters);

            // Cargar y mostrar el informe
            this.reportViewer1.RefreshReport();
        }

        private void informeEmpleados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
