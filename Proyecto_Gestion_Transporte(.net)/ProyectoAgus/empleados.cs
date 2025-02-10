using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAgus
{
    public partial class empleados : Form
    {
        public empleados()
        {
            InitializeComponent();
            DeshabilitarBotones();
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transGlobalDataSet);

        }

        private void empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.transGlobalDataSet.Empleados);
            if (fotoPictureBox.Image != null)
            {
                fotoPictureBox.BackgroundImage = Properties.Resources.vacio;
            }

        }

        private void botonPrincipio_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveFirst();
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MovePrevious();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveNext();
        }

        private void botonFinal_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveLast();
        }

        private void botonAdd_Click(object sender, EventArgs e)
        {
            // Validar aliasTextBox
            if (string.IsNullOrWhiteSpace(aliasTextBox.Text))
            {
                errorProvider1.SetError(aliasTextBox, "El campo Alias no puede estar vacío.");
            }
            else if (aliasTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(aliasTextBox, "El campo Alias no puede tener más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(aliasTextBox, ""); // Limpia el mensaje de error
            }

            // Validar rolComboBox
            if (string.IsNullOrWhiteSpace(rolComboBox.Text))
            {
                errorProvider1.SetError(rolComboBox, "El campo Rol no puede estar vacío.");
            }
            else if (rolComboBox.Text.Length > 40)
            {
                errorProvider1.SetError(rolComboBox, "El campo Rol no puede tener más de 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(rolComboBox, ""); // Limpia el mensaje de error
            }

            // Validar contrasenaTextBox
            if (string.IsNullOrWhiteSpace(contrasenaTextBox.Text))
            {
                errorProvider1.SetError(contrasenaTextBox, "El campo Contraseña no puede estar vacío.");
            }
            else if (contrasenaTextBox.Text.Length > 18 || contrasenaTextBox.Text.Length < 8)
            {
                errorProvider1.SetError(contrasenaTextBox, "La contraseña debe tener entre 8 y 18 caracteres.");
            }
            else
            {
                errorProvider1.SetError(contrasenaTextBox, ""); // Limpia el mensaje de error
            }

            // Validar nombreTextBox
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede estar vacío.");
            }
            else if (nombreTextBox.Text.Length > 150)
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede tener más de 150 caracteres.");
            }
            else
            {
                errorProvider1.SetError(nombreTextBox, ""); // Limpia el mensaje de error
            }

            // Validar dNITextBox
            if (string.IsNullOrWhiteSpace(dNITextBox.Text))
            {
                errorProvider1.SetError(dNITextBox, "El campo DNI no puede estar vacío.");
            }
            else if (!Regex.IsMatch(dNITextBox.Text, @"^\d{8}[a-zA-Z]$"))
            {
                errorProvider1.SetError(dNITextBox, "Formato incorrecto para DNI. Debe ser 8 números seguidos de 1 letra.");
            }
            else
            {
                errorProvider1.SetError(dNITextBox, ""); // Limpia el mensaje de error
            }

            // Validar telefonoTextBox
            if (string.IsNullOrWhiteSpace(telefonoTextBox.Text))
            {
                errorProvider1.SetError(telefonoTextBox, "El campo Teléfono no puede estar vacío.");
            }
            else if (telefonoTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(telefonoTextBox, "El campo Teléfono no puede tener más de 9 caracteres.");
            }
            else
            {
                errorProvider1.SetError(telefonoTextBox, ""); // Limpia el mensaje de error
            }

            // Validar direccionTextBox
            if (string.IsNullOrWhiteSpace(direccionTextBox.Text))
            {
                errorProvider1.SetError(direccionTextBox, "El campo Dirección no puede estar vacío.");
            }
            else if (direccionTextBox.Text.Length > 200)
            {
                errorProvider1.SetError(direccionTextBox, "El campo Dirección no puede tener más de 200 caracteres.");
            }
            else
            {
                errorProvider1.SetError(direccionTextBox, ""); // Limpia el mensaje de error
            }

            // Validar correoTextBox
            if (string.IsNullOrWhiteSpace(correoTextBox.Text))
            {
                errorProvider1.SetError(correoTextBox, "El campo Correo no puede estar vacío.");
            }
            else if (correoTextBox.Text.Length > 100)
            {
                errorProvider1.SetError(correoTextBox, "El campo Correo no puede tener más de 150 caracteres.");
            }
            else if (!Regex.IsMatch(correoTextBox.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                errorProvider1.SetError(correoTextBox, "Formato incorrecto para el correo. Debe ser algo como usuario@email.com.");
            }
            else
            {
                errorProvider1.SetError(correoTextBox, ""); // Limpia el mensaje de error
            }

            // Validar salarioTextBox
            decimal salario;
            if (string.IsNullOrWhiteSpace(salarioTextBox.Text))
            {
                errorProvider1.SetError(salarioTextBox, "El campo Salario no puede estar vacío.");
            }
            else if (!decimal.TryParse(salarioTextBox.Text.Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out salario) ||
                      salarioTextBox.Text.Length > 20 ||
                      !Regex.IsMatch(salarioTextBox.Text, @"^\d{1,15}(\,\d{1,4})?$"))
            {
                errorProvider1.SetError(salarioTextBox, "Formato incorrecto para salario. Debe ser un número con hasta 15 dígitos y 4 decimales, utilizando coma como separador decimal.");
            }
            else
            {
                errorProvider1.SetError(salarioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar cargoTextBox
            if (string.IsNullOrWhiteSpace(cargoTextBox.Text))
            {
                errorProvider1.SetError(cargoTextBox, "El campo Cargo no puede estar vacío.");
            }
            else if (cargoTextBox.Text.Length > 20)
            {
                errorProvider1.SetError(cargoTextBox, "El campo Cargo no puede tener más de 20 caracteres.");
            }
            else
            {
                errorProvider1.SetError(cargoTextBox, ""); // Limpia el mensaje de error
            }

            // Verificar si todos los campos tienen errores vacíos
            if (errorProvider1.GetError(aliasTextBox) == "" &&
                errorProvider1.GetError(rolComboBox) == "" &&
                errorProvider1.GetError(contrasenaTextBox) == "" &&
                errorProvider1.GetError(nombreTextBox) == "" &&
                errorProvider1.GetError(dNITextBox) == "" &&
                errorProvider1.GetError(telefonoTextBox) == "" &&
                errorProvider1.GetError(direccionTextBox) == "" &&
                errorProvider1.GetError(correoTextBox) == "" &&
                errorProvider1.GetError(salarioTextBox) == "" &&
                errorProvider1.GetError(cargoTextBox) == "")
            {
                empleadosBindingSource.AddNew();
                HabilitarBotones();
                fechaContratacionDateTimePicker.Value = DateTime.Today;
                fechaNacimientoDateTimePicker.Value = DateTime.Today;
                botonPrincipio.Enabled = false;
                botonAnterior.Enabled = false;
                botonSiguiente.Enabled = false;
                botonFinal.Enabled = false;
                botonBuscar.Enabled = false;
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Borrar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                empleadosBindingSource.RemoveCurrent();
                DeshabilitarBotones();
                botonGuardar.Enabled = true;
                botonPrincipio.Enabled = true;
                botonSiguiente.Enabled = true;
                botonAnterior.Enabled = true;
                botonFinal.Enabled = true;
                botonBuscar.Enabled = true;
            }
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            HabilitarBotones();
            botonPrincipio.Enabled = false;
            botonAnterior.Enabled = false;
            botonSiguiente.Enabled = false;
            botonFinal.Enabled = false;
            botonBuscar.Enabled = false;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                empleadosBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(transGlobalDataSet);

                // Si la ejecución llega hasta aquí sin lanzar una excepción, entonces se ha guardado con éxito.
                MessageBox.Show("Guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DeshabilitarBotones();
                botonGuardar.Enabled = false;
                botonPrincipio.Enabled = true;
                botonSiguiente.Enabled = true;
                botonAnterior.Enabled = true;
                botonFinal.Enabled = true;
                botonBuscar.Enabled = true;
            }
            catch (Exception ex)
            {
                // Si hay una excepción, muestra un mensaje de error.
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            // Validar aliasTextBox
            if (string.IsNullOrWhiteSpace(aliasTextBox.Text))
            {
                errorProvider1.SetError(aliasTextBox, "El campo Alias no puede estar vacío.");
            }
            else if (aliasTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(aliasTextBox, "El campo Alias no puede tener más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(aliasTextBox, ""); // Limpia el mensaje de error
            }

            // Validar rolComboBox
            if (string.IsNullOrWhiteSpace(rolComboBox.Text))
            {
                errorProvider1.SetError(rolComboBox, "El campo Rol no puede estar vacío.");
            }
            else if (rolComboBox.Text.Length > 40)
            {
                errorProvider1.SetError(rolComboBox, "El campo Rol no puede tener más de 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(rolComboBox, ""); // Limpia el mensaje de error
            }

            // Validar contrasenaTextBox
            if (string.IsNullOrWhiteSpace(contrasenaTextBox.Text))
            {
                errorProvider1.SetError(contrasenaTextBox, "El campo Contraseña no puede estar vacío.");
            }
            else if (contrasenaTextBox.Text.Length > 18 || contrasenaTextBox.Text.Length < 8)
            {
                errorProvider1.SetError(contrasenaTextBox, "La contraseña debe tener entre 8 y 18 caracteres.");
            }
            else
            {
                errorProvider1.SetError(contrasenaTextBox, ""); // Limpia el mensaje de error
            }

            // Validar nombreTextBox
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede estar vacío.");
            }
            else if (nombreTextBox.Text.Length > 150)
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede tener más de 150 caracteres.");
            }
            else
            {
                errorProvider1.SetError(nombreTextBox, ""); // Limpia el mensaje de error
            }

            // Validar dNITextBox
            if (string.IsNullOrWhiteSpace(dNITextBox.Text))
            {
                errorProvider1.SetError(dNITextBox, "El campo DNI no puede estar vacío.");
            }
            else if (!Regex.IsMatch(dNITextBox.Text, @"^\d{8}[a-zA-Z]$"))
            {
                errorProvider1.SetError(dNITextBox, "Formato incorrecto para DNI. Debe ser 8 números seguidos de 1 letra.");
            }
            else
            {
                errorProvider1.SetError(dNITextBox, ""); // Limpia el mensaje de error
            }

            // Validar telefonoClienteTextBox
            if (string.IsNullOrWhiteSpace(telefonoTextBox.Text))
            {
                errorProvider1.SetError(telefonoTextBox, "Teléfono no puede estar vacío.");
            }
            else if (!int.TryParse(telefonoTextBox.Text, out _))
            {
                errorProvider1.SetError(telefonoTextBox, "Teléfono debe ser numérico.");
            }
            else if (telefonoTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(telefonoTextBox, "Teléfono debe tener hasta 9 dígitos.");
            }
            else
            {
                errorProvider1.SetError(telefonoTextBox, ""); // Limpia el mensaje de error
            }

            // Validar direccionTextBox
            if (string.IsNullOrWhiteSpace(direccionTextBox.Text))
            {
                errorProvider1.SetError(direccionTextBox, "El campo Dirección no puede estar vacío.");
            }
            else if (direccionTextBox.Text.Length > 200)
            {
                errorProvider1.SetError(direccionTextBox, "El campo Dirección no puede tener más de 200 caracteres.");
            }
            else
            {
                errorProvider1.SetError(direccionTextBox, ""); // Limpia el mensaje de error
            }

            // Validar correoTextBox
            if (string.IsNullOrWhiteSpace(correoTextBox.Text))
            {
                errorProvider1.SetError(correoTextBox, "El campo Correo no puede estar vacío.");
            }
            else if (correoTextBox.Text.Length > 100)
            {
                errorProvider1.SetError(correoTextBox, "El campo Correo no puede tener más de 150 caracteres.");
            } 
            else if (!Regex.IsMatch(correoTextBox.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                errorProvider1.SetError(correoTextBox, "Formato incorrecto para el correo. Debe ser algo como usuario@email.com.");
            }
            else
            {
                errorProvider1.SetError(correoTextBox, ""); // Limpia el mensaje de error
            }

            // Validar salarioTextBox
            decimal salario;
            if (string.IsNullOrWhiteSpace(salarioTextBox.Text))
            {
                errorProvider1.SetError(salarioTextBox, "El campo Salario no puede estar vacío.");
            }
            else if (!decimal.TryParse(salarioTextBox.Text.Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out salario) ||
                      salarioTextBox.Text.Length > 20 ||
                      !Regex.IsMatch(salarioTextBox.Text, @"^\d{1,15}(\,\d{1,4})?$"))
            {
                errorProvider1.SetError(salarioTextBox, "Formato incorrecto para salario. Debe ser un número con hasta 15 dígitos y 4 decimales, utilizando coma como separador decimal.");
            }
            else
            {
                errorProvider1.SetError(salarioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar cargoTextBox
            if (string.IsNullOrWhiteSpace(cargoTextBox.Text))
            {
                errorProvider1.SetError(cargoTextBox, "El campo Cargo no puede estar vacío.");
            }
            else if (cargoTextBox.Text.Length > 20)
            {
                errorProvider1.SetError(cargoTextBox, "El campo Cargo no puede tener más de 20 caracteres.");
            }
            else
            {
                errorProvider1.SetError(cargoTextBox, ""); // Limpia el mensaje de error
            }

            // Verificar si todos los campos tienen errores vacíos
            if (errorProvider1.GetError(aliasTextBox) == "" &&
                errorProvider1.GetError(rolComboBox) == "" &&
                errorProvider1.GetError(contrasenaTextBox) == "" &&
                errorProvider1.GetError(nombreTextBox) == "" &&
                errorProvider1.GetError(dNITextBox) == "" &&
                errorProvider1.GetError(telefonoTextBox) == "" &&
                errorProvider1.GetError(direccionTextBox) == "" &&
                errorProvider1.GetError(correoTextBox) == "" &&
                errorProvider1.GetError(salarioTextBox) == "" &&
                errorProvider1.GetError(cargoTextBox) == "")
            {
                empleadosBindingSource.EndEdit();
                DeshabilitarBotones();
                botonGuardar.Enabled = true;
                botonPrincipio.Enabled = true;
                botonAnterior.Enabled = true;
                botonSiguiente.Enabled = true;
                botonFinal.Enabled = true;
                botonBuscar.Enabled = true;
            }

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            empleadosBindingSource.CancelEdit();
            DeshabilitarBotones();
            botonGuardar.Enabled = true;
            botonPrincipio.Enabled = true;
            botonAnterior.Enabled = true;
            botonSiguiente.Enabled = true;
            botonFinal.Enabled = true;
            botonBuscar.Enabled = true;
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            if (botonGuardar.Enabled || botonAceptar.Enabled)
            {
                DialogResult result = MessageBox.Show("¿Quieres guardar antes de salir?", "Salir sin guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        empleadosBindingSource.EndEdit();
                        tableAdapterManager.UpdateAll(transGlobalDataSet);

                        // Si la ejecución llega hasta aquí sin lanzar una excepción, entonces se ha guardado con éxito.
                        MessageBox.Show("Guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        menu menu = new menu();
                        menu.Show();
                    }
                    catch (Exception ex)
                    {
                        // Si hay una excepción, muestra un mensaje de error.
                        MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        menu menu = new menu();
                        menu.Show();
                    }
                }
                else if (result == DialogResult.No)
                {
                    this.Hide();
                    menu menu = new menu();
                    menu.Show();
                }
            }
            else
            {
                this.Hide();
                menu menu = new menu();
                menu.Show();
            }
        }
        private void HabilitarBotones()
        {
            botonAceptar.Enabled = true;
            botonCancelar.Enabled = true;
            nombreTextBox.Enabled = true;
            correoTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            fotoPictureBox.Enabled = true;
            aliasTextBox.Enabled = true;
            rolComboBox.Enabled = true;
            contrasenaTextBox.Enabled = true;
            dNITextBox.Enabled = true;
            fechaNacimientoDateTimePicker.Enabled = true;
            fechaContratacionDateTimePicker.Enabled = true;
            salarioTextBox.Enabled = true;
            cargoTextBox.Enabled = true;

        }
        private void DeshabilitarBotones()
        {
            botonAceptar.Enabled = false;
            botonCancelar.Enabled = false;
            empleadosIDTextBox.Enabled = false;
            nombreTextBox.Enabled = false;
            correoTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            fotoPictureBox.Enabled = false;
            aliasTextBox.Enabled = false;
            rolComboBox.Enabled = false;
            contrasenaTextBox.Enabled = false;
            dNITextBox.Enabled = false;
            fechaNacimientoDateTimePicker.Enabled = false;
            fechaContratacionDateTimePicker.Enabled = false;
            salarioTextBox.Enabled = false;
            cargoTextBox.Enabled = false;
        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*|" + "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { fotoPictureBox.Image = Image.FromFile(openFileDialog1.FileName); }
            else
            { fotoPictureBox.Image = null; }
        }

        private void botonImprimir_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.idEmpleado = empleadosIDTextBox.Text;
            Properties.Settings.Default.nombreEmpleado = nombreTextBox.Text;
            Properties.Settings.Default.dniEmpleado = dNITextBox.Text;
            Properties.Settings.Default.telefonoEmpleado = telefonoTextBox.Text;
            Properties.Settings.Default.direccionEmpleado = direccionTextBox.Text;
            Properties.Settings.Default.correoEmpleado = correoTextBox.Text;
            Properties.Settings.Default.fechaContratacion = fechaContratacionDateTimePicker.Text;
            Properties.Settings.Default.fechaNacimiento = fechaNacimientoDateTimePicker.Text;
            Properties.Settings.Default.salarioEmpleado = salarioTextBox.Text;
            Properties.Settings.Default.cargoEmpleado = cargoTextBox.Text;

            informeEmpleados informeempleados = new informeEmpleados();
            informeempleados.Show();
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
                case "Buscar por Id":
                    BuscarPorId(valorBusqueda);
                    break;
                case "Buscar por DNI":
                    BuscarPorDNI(valorBusqueda);
                    break;
                case "Buscar por Correo":
                    BuscarPorCorreo(valorBusqueda);
                    break;
                default:
                    MessageBox.Show("Filtro no válido");
                    break;
            }
        }
        private void BuscarPorCorreo(string correo)
        {
            int index = empleadosBindingSource.Find("Correo", correo);
            MostrarResultadoBusqueda(index, "Correo");
        }
        private void BuscarPorDNI(string DNI)
        {
            int index = empleadosBindingSource.Find("DNI", DNI);
            MostrarResultadoBusqueda(index, "DNI");
        }
        private void BuscarPorId(string id)
        {
            int idBusqueda;
            if (int.TryParse(id, out idBusqueda))
            {
                int index = empleadosBindingSource.Find("EmpleadoID", idBusqueda);
                if (index == -1)
                {
                    MessageBox.Show("No existe un empleado con ese ID.");
                }
                else
                {
                    empleadosBindingSource.Position = index;
                }
            }
            else
            {
                MessageBox.Show("ID no válido. Ingresa un número entero.");
            }
        }
        private void MostrarResultadoBusqueda(int index, string filtro)
        {
            if (index == -1)
            {
                MessageBox.Show($"No existe un empleado con ese {filtro}.");
            }
            else
            {
                empleadosBindingSource.Position = index;
            }
        }

        private void empleadosBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = "Empleado " + (empleadosBindingSource.Position + 1) + " de " + (empleadosBindingSource.Count);
        }

        private void aliasTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                rolComboBox.Focus();
            }
        }

        private void rolComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                rolComboBox.DroppedDown = true;
            }
        }

        private void contrasenaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                nombreTextBox.Focus();
            }
        }

        private void nombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                dNITextBox.Focus();
            }
        }

        private void dNITextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                telefonoTextBox.Focus();
            }
        }

        private void direccionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                correoTextBox.Focus();
            }
        }

        private void correoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                fechaContratacionDateTimePicker.Focus();
            }
        }

        private void fechaContratacionDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                fechaNacimientoDateTimePicker.Focus();
            }
        }

        private void salarioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cargoTextBox.Focus();
            }
        }

        private void cargoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                botonAceptar.PerformClick();
            }
        }
        private void telefonoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                direccionTextBox.Focus();
            }
        }
        private void fechaNacimientoDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                salarioTextBox.Focus();
            }
        }

        private void buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                botonBuscar.PerformClick();
                buscar.Text = "";
            }
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\..\\Crear documentación chm\\TransGlobal.chm", "Empleados.htm");
        }
    }
}
