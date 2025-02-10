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
    public partial class InformeVentasDetalle : Form
    {
        public InformeVentasDetalle()
        {
            InitializeComponent();
        }

        private void InformeVentasDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Ventas_Detalle' Puede moverla o quitarla según sea necesario.
            this.ventas_DetalleTableAdapter.Fill(this.transGlobalDataSet.Ventas_Detalle);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.transGlobalDataSet.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.transGlobalDataSet.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Ventas_Detalle' Puede moverla o quitarla según sea necesario.
            this.ventas_DetalleTableAdapter.Fill(this.transGlobalDataSet.Ventas_Detalle);

            this.reportViewer1.RefreshReport();
        }

        private void ventas_DetalleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }
    }
}
