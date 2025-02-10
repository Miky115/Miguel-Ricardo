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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            // Verifica el rol del empleado y oculta el botón de empleados si es "Empleado"
            if (Properties.Settings.Default.rolEmpleado == "Empleado")
            {
                empleados.Visible = false;
                ventas.Location = new Point(90, 190);
                rutas.Location = new Point(294, 190);
            }
        }

        private void camiones_Click(object sender, EventArgs e)
        {
            this.Hide();
            camiones camionesForm = new camiones();
            camionesForm.Show();
        }

        private void empleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            empleados empleadosForm = new empleados();
            empleadosForm.Show();
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes clientesForm = new clientes();
            clientesForm.Show();
        }

        private void productos_Click(object sender, EventArgs e)
        {
            this.Hide();
            productos productosForm = new productos();
            productosForm.Show();
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas ventasForm = new Ventas();
            ventasForm.Show();
        }

        private void rutas_Click(object sender, EventArgs e)
        {
            this.Hide();
            rutas rutasForm = new rutas();
            rutasForm.Show();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\..\\Crear documentación chm\\TransGlobal.chm", "Guiarapida.htm");
        }
    }
}
