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
    public partial class informeCamion : Form
    {
        public informeCamion()
        {
            InitializeComponent();
            // Configurar los valores de los parámetros
            ReportParameter[] parameters = new ReportParameter[7];
            parameters[0] = new ReportParameter("matricula", Properties.Settings.Default.matricula);
            parameters[1] = new ReportParameter("tipocamion", Properties.Settings.Default.tipocamion);
            parameters[2] = new ReportParameter("marca", Properties.Settings.Default.marca);
            parameters[3] = new ReportParameter("modelo", Properties.Settings.Default.modelo);
            parameters[4] = new ReportParameter("fechafabricacion", Properties.Settings.Default.fechafabricacion);
            parameters[5] = new ReportParameter("capacidad", Properties.Settings.Default.carga);
            parameters[6] = new ReportParameter("combustible", Properties.Settings.Default.combustible);

            // Configurar el ReportViewer con los parámetros
            this.reportViewer1.LocalReport.SetParameters(parameters);

            // Cargar y mostrar el informe
            this.reportViewer1.RefreshReport();
        }

        private void informeCamion_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
