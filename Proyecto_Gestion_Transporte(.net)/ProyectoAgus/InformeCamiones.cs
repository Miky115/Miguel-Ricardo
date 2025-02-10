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
    public partial class InformeCamiones : Form
    {
        public InformeCamiones()
        {
            InitializeComponent();
        }

        private void InformeCamiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Camiones' Puede moverla o quitarla según sea necesario.
            this.camionesTableAdapter.Fill(this.transGlobalDataSet.Camiones);

            this.reportViewer1.RefreshReport();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            string filtro = buscarComboBox.SelectedItem?.ToString();
            string valorBusqueda = buscar.Text;

            if (string.IsNullOrEmpty(valorBusqueda) || string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Selecciona un filtro y proporciona un valor de búsqueda.");
                return;
            }

            switch (filtro)
            {
                case "Tipo Camion":
                    camionesBindingSource.Filter = "TipoCamion=" + "'" + buscar.Text + "'";
                    reportViewer1.RefreshReport();
                    break;
                case "Marca":
                    camionesBindingSource.Filter = "Marca=" + "'" + buscar.Text + "'";
                    reportViewer1.RefreshReport();
                    break;
                case "Tipo Combustible":
                    camionesBindingSource.Filter = "TipoCombustible=" + "'" + buscar.Text + "'";
                    reportViewer1.RefreshReport();
                    break;
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            camionesBindingSource.Filter = "";
            reportViewer1.RefreshReport();
        }
    }
}
