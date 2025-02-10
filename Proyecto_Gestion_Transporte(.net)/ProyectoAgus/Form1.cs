using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoAgus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transGlobalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.transGlobalDataSet.Empleados);

        }

        private string VerificarCredenciales(string alias, string contrasena)
        {
            // Obtiene la vista de la tabla Empleados desde el BindingSource
            DataView empleadosView = ((DataView)empleadosBindingSource.List);

            // Filtra las filas con el alias y contraseña proporcionados
            var empleadoFiltrado = empleadosView
                .Cast<DataRowView>()
                .FirstOrDefault(fila =>
                    fila.Row["Alias"].ToString() == alias &&
                    fila.Row["Contrasena"].ToString() == contrasena
                );

            // Devuelve el rol del empleado encontrado (o null si no se encuentra)
            return empleadoFiltrado?.Row["Rol"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aliasIngresado = alias.Text;
            string contrasenaIngresada = contrasena.Text;

            // Consulta la base de datos para verificar las credenciales
            string rolEmpleado = VerificarCredenciales(aliasIngresado, contrasenaIngresada);

            // Verifica si se encontró un empleado con las credenciales proporcionadas
            if (!string.IsNullOrEmpty(rolEmpleado))
            {
                // Guarda el rol del empleado en las propiedades del proyecto
                Properties.Settings.Default.rolEmpleado = rolEmpleado;
                Properties.Settings.Default.Save();  // Guardar cambios

                // Abre el formulario correspondiente según el rol
                if (rolEmpleado == "Empleado")
                {
                    // Realiza acciones específicas si es necesario para el rol "Empleado"
                    // En este ejemplo, simplemente muestra el formulario llamado "menu"
                    menu menuForm = new menu();
                    menuForm.Show();
                }
                else
                {
                    // Si el rol no es "Empleado", abre el formulario del menú
                    menu menuForm = new menu();
                    menuForm.Show();
                }

                // Oculta el formulario actual después de abrir el formulario correspondiente
                this.Hide();
            }
            else
            {
                // Credenciales incorrectas
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void botonVer_Click(object sender, EventArgs e)
        {
            // Cambiar el carácter de contraseña entre texto normal y asteriscos
            if (contrasena.PasswordChar == '*')
            {
                contrasena.PasswordChar = '\0'; // Mostrar texto normal
            }
            else
            {
                contrasena.PasswordChar = '*'; // Mostrar asteriscos
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menu menuForm = new menu();
            menuForm.Show();
        }

        private void alias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                contrasena.Focus();
            }
        }

        private void contrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                botonLogin.PerformClick();
            }
        }

        private void bienvenido_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\..\\Crear documentación chm\\TransGlobal.chm", "Bienvenidos.htm");
        }

        private void ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\..\\Crear documentación chm\\TransGlobal.chm", "Guiarapida.htm");
        }
    }
}
