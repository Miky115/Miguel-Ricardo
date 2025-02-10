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
    public partial class InformeProductos : Form
    {
        public InformeProductos()
        {
            InitializeComponent();
        }

        private void InformeProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.transGlobalDataSet.Producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
