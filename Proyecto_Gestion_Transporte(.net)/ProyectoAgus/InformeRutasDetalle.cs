﻿using System;
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
    public partial class InformeRutasDetalle : Form
    {
        public InformeRutasDetalle()
        {
            InitializeComponent();
        }

        private void InformeRutasDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Ruta_Detalle' Puede moverla o quitarla según sea necesario.
            this.ruta_DetalleTableAdapter.Fill(this.transGlobalDataSet.Ruta_Detalle);

            this.reportViewer1.RefreshReport();
        }
    }
}
