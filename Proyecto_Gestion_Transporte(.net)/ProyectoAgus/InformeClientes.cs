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
    public partial class InformeClientes : Form
    {
        public InformeClientes()
        {
            InitializeComponent();
        }

        private void InformeClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.transGlobalDataSet.Clientes);

            this.reportViewer1.RefreshReport();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transGlobalDataSet);

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
                case "Tipo cliente":
                    clientesBindingSource.Filter = "TipoCliente=" + "'" + buscar.Text + "'";
                    reportViewer1.RefreshReport();
                    break;
                case "Ciudad":
                    clientesBindingSource.Filter = "Ciudad=" + "'" + buscar.Text + "'";
                    reportViewer1.RefreshReport();
                    break;
                case "Localidad":
                    clientesBindingSource.Filter = "Localidad=" + "'" + buscar.Text + "'";
                    reportViewer1.RefreshReport();
                    break;
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.Filter = "";
            reportViewer1.RefreshReport();
        }
    }
}
