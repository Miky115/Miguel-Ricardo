using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAgus
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
            DeshabilitarBotones();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transGlobalDataSet);

        }

        private void clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.transGlobalDataSet.Clientes);
            if (fotoPictureBox.Image != null)
            {
                fotoPictureBox.BackgroundImage = Properties.Resources.vacio;
            }

        }

        private void botonPrincipio_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveFirst();
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MovePrevious();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveNext();
        }

        private void botonFinal_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveLast();
        }

        private void botonAdd_Click(object sender, EventArgs e)
        {
            botonPrincipio.Enabled = false;
            botonAnterior.Enabled = false;
            botonSiguiente.Enabled = false;
            botonFinal.Enabled = false;
            botonBuscar.Enabled = false;
            errorProvider1.Clear();

            // Validar nombreTextBox
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede estar vacío.");
            }
            else if (nombreTextBox.Text.Length > 150)
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede tener más de 150 caracteres.");
            }

            // Validar tipoClienteTextBox
            if (string.IsNullOrWhiteSpace(tipoClienteComboBox.Text))
            {
                errorProvider1.SetError(tipoClienteComboBox, "El campo Tipo de Cliente no puede estar vacío.");
            }
            else if (tipoClienteComboBox.Text.Length > 20)
            {
                errorProvider1.SetError(tipoClienteComboBox, "El campo Tipo de Cliente no puede tener más de 20 caracteres.");
            }

            // Validar el formato del DNI o CIF según el tipo de cliente
            string tipoCliente = tipoClienteComboBox.Text.ToUpper();
            string dniCif = dniTextBox.Text.Trim();

            if (tipoCliente == "PARTICULAR" && !Regex.IsMatch(dniCif, @"^\d{8}[a-zA-Z]$"))
            {
                errorProvider1.SetError(dniTextBox, "Formato incorrecto para Particular. Debe ser 8 números seguidos de 1 letra.");
            }
            else if (tipoCliente == "EMPRESA" && !Regex.IsMatch(dniCif, @"^[a-zA-Z]\d{8}$"))
            {
                errorProvider1.SetError(dniTextBox, "Formato incorrecto para Empresa. Debe ser 1 letra seguida de 8 números.");
            }

            // Validar provinciaTextBox
            if (string.IsNullOrWhiteSpace(provinciaTextBox.Text))
            {
                errorProvider1.SetError(provinciaTextBox, "El campo Provincia no puede estar vacío.");
            }
            else if (provinciaTextBox.Text.Length > 100)
            {
                errorProvider1.SetError(provinciaTextBox, "El campo Provincia no puede tener más de 100 caracteres.");
            }

            // Validar localidadTextBox
            if (string.IsNullOrWhiteSpace(localidadTextBox.Text))
            {
                errorProvider1.SetError(localidadTextBox, "El campo Localidad no puede estar vacío.");
            }
            else if (localidadTextBox.Text.Length > 100)
            {
                errorProvider1.SetError(localidadTextBox, "El campo Localidad no puede tener más de 100 caracteres.");
            }

            // Validar codigoPostalTextBox
            int codigoPostal;
            if (!int.TryParse(codigoPostalTextBox.Text, out codigoPostal) || codigoPostalTextBox.Text.Length > 5)
            {
                errorProvider1.SetError(codigoPostalTextBox, "El campo Código Postal debe ser un número entero con un máximo de 5 dígitos.");
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

            // Validar telefonoTextBox
            int telefono;
            if (!int.TryParse(telefonoTextBox.Text, out telefono) || telefonoTextBox.Text.Length != 9)
            {
                errorProvider1.SetError(telefonoTextBox, "El campo Teléfono debe ser un número entero de 9 dígitos.");
            }

            // Validar correoTextBox
            if (string.IsNullOrWhiteSpace(correoTextBox.Text))
            {
                errorProvider1.SetError(correoTextBox, "El campo Correo no puede estar vacío.");
            }
            else if (correoTextBox.Text.Length > 150)
            {
                errorProvider1.SetError(correoTextBox, "El campo Correo no puede tener más de 150 caracteres.");
            }
            else if (!Regex.IsMatch(correoTextBox.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                errorProvider1.SetError(correoTextBox, "Formato incorrecto para el correo. Debe ser algo como usuario@email.com.");
            }

            // Verificar si hay algún error en los campos
            if (errorProvider1.GetError(nombreTextBox) == "" &&
                errorProvider1.GetError(tipoClienteComboBox) == "" &&
                errorProvider1.GetError(provinciaTextBox) == "" &&
                errorProvider1.GetError(localidadTextBox) == "" &&
                errorProvider1.GetError(codigoPostalTextBox) == "" &&
                errorProvider1.GetError(direccionTextBox) == "" &&
                errorProvider1.GetError(telefonoTextBox) == "" &&
                errorProvider1.GetError(correoTextBox) == "")
            {
                clientesBindingSource.AddNew();
                HabilitarBotones();
                // Todos los campos están validados correctamente, puedes continuar con el resto de tu lógica aquí
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Borrar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clientesBindingSource.RemoveCurrent();
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
                clientesBindingSource.EndEdit();
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

            // Limpiar errores existentes
            errorProvider1.Clear();

            // Validar nombreTextBox
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede estar vacío.");
            }
            else if (nombreTextBox.Text.Length > 150)
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede tener más de 150 caracteres.");
            }

            // Validar tipoClienteComboBox
            if (string.IsNullOrWhiteSpace(tipoClienteComboBox.Text))
            {
                errorProvider1.SetError(tipoClienteComboBox, "El campo Tipo de Cliente no puede estar vacío.");
            }
            else if (tipoClienteComboBox.Text.Length > 20)
            {
                errorProvider1.SetError(tipoClienteComboBox, "El campo Tipo de Cliente no puede tener más de 20 caracteres.");
            }

            // Validar el formato del DNI o CIF según el tipo de cliente
            string tipoCliente = tipoClienteComboBox.Text.ToUpper();
            string dniCif = dniTextBox.Text.Trim();

            if (tipoCliente == "PARTICULAR" && !Regex.IsMatch(dniCif, @"^\d{8}[a-zA-Z]$"))
            {
                errorProvider1.SetError(dniTextBox, "Formato incorrecto para Particular. Debe ser 8 números seguidos de 1 letra.");
            }
            else if (tipoCliente == "EMPRESA" && !Regex.IsMatch(dniCif, @"^[a-zA-Z]\d{8}$"))
            {
                errorProvider1.SetError(dniTextBox, "Formato incorrecto para Empresa. Debe ser 1 letra seguida de 8 números.");
            }

            // Validar provinciaTextBox
            if (string.IsNullOrWhiteSpace(provinciaTextBox.Text))
            {
                errorProvider1.SetError(provinciaTextBox, "El campo Provincia no puede estar vacío.");
            }
            else if (provinciaTextBox.Text.Length > 100)
            {
                errorProvider1.SetError(provinciaTextBox, "El campo Provincia no puede tener más de 100 caracteres.");
            }

            // Validar localidadTextBox
            if (string.IsNullOrWhiteSpace(localidadTextBox.Text))
            {
                errorProvider1.SetError(localidadTextBox, "El campo Localidad no puede estar vacío.");
            }
            else if (localidadTextBox.Text.Length > 100)
            {
                errorProvider1.SetError(localidadTextBox, "El campo Localidad no puede tener más de 100 caracteres.");
            }

            // Validar codigoPostalTextBox
            int codigoPostal;
            if (!int.TryParse(codigoPostalTextBox.Text, out codigoPostal) || codigoPostalTextBox.Text.Length > 5)
            {
                errorProvider1.SetError(codigoPostalTextBox, "El campo Código Postal debe ser un número entero con un máximo de 5 dígitos.");
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

            // Validar correoTextBox
            if (string.IsNullOrWhiteSpace(correoTextBox.Text))
            {
                errorProvider1.SetError(correoTextBox, "El campo Correo no puede estar vacío.");
            }
            else if (correoTextBox.Text.Length > 150)
            {
                errorProvider1.SetError(correoTextBox, "El campo Correo no puede tener más de 150 caracteres.");
            }
            else if (!Regex.IsMatch(correoTextBox.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                errorProvider1.SetError(correoTextBox, "Formato incorrecto para el correo. Debe ser algo como usuario@email.com.");
            }

            // Verificar si hay algún error en los campos
            if (errorProvider1.GetError(nombreTextBox) == "" &&
                errorProvider1.GetError(tipoClienteComboBox) == "" &&
                errorProvider1.GetError(provinciaTextBox) == "" &&
                errorProvider1.GetError(localidadTextBox) == "" &&
                errorProvider1.GetError(codigoPostalTextBox) == "" &&
                errorProvider1.GetError(direccionTextBox) == "" &&
                errorProvider1.GetError(telefonoTextBox) == "" &&
                errorProvider1.GetError(correoTextBox) == "")
            {
                clientesBindingSource.EndEdit();
                DeshabilitarBotones();
                botonGuardar.Enabled = true;
                botonPrincipio.Enabled = true;
                botonAnterior.Enabled = true;
                botonSiguiente.Enabled = true;
                botonFinal.Enabled = true;
                botonBorrar.Enabled = true;
                botonBuscar.Enabled = true;
                // Todos los campos están validados correctamente, puedes continuar con el resto de tu lógica aquí
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            clientesBindingSource.CancelEdit();
            DeshabilitarBotones();
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
                        clientesBindingSource.EndEdit();
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
            tipoClienteComboBox.Enabled = true;
            dniTextBox.Enabled = true;
            provinciaTextBox.Enabled = true;
            localidadTextBox.Enabled = true;
            codigoPostalTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            correoTextBox.Enabled = true;
            fotoPictureBox.Enabled = true;

        }
        private void DeshabilitarBotones()
        {
            botonAceptar.Enabled = false;
            botonCancelar.Enabled = false;
            clienteIDTextBox.Enabled = false;
            nombreTextBox.Enabled = false;
            tipoClienteComboBox.Enabled = false;
            dniTextBox.Enabled = false;
            provinciaTextBox.Enabled = false;
            localidadTextBox.Enabled = false;
            codigoPostalTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            correoTextBox.Enabled = false;
            fotoPictureBox.Enabled = false;
        }

      

        private void botonImprimir_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.idCliente = clienteIDTextBox.Text;
            Properties.Settings.Default.nombreCliente = nombreTextBox.Text;
            Properties.Settings.Default.tipoCliente = tipoClienteComboBox.Text;
            Properties.Settings.Default.dniCliente = dniTextBox.Text;
            Properties.Settings.Default.telefonoCliente = telefonoTextBox.Text;
            Properties.Settings.Default.emailCliente = correoTextBox.Text;
            Properties.Settings.Default.provinciaCliente = provinciaTextBox.Text;
            Properties.Settings.Default.localidadCliente = localidadTextBox.Text;
            Properties.Settings.Default.codigoPostalCliente = codigoPostalTextBox.Text;
            Properties.Settings.Default.direcciónCliente = direccionTextBox.Text;

            informeCliente informe = new informeCliente();
            informe.Show();
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
                case "Buscar por DNI/CIF":
                    BuscarPorDNI(valorBusqueda);
                    break;
                case "Buscar por Correo":
                    BuscarPorCorreo(valorBusqueda);
                    break;
                case "Buscar por Nombre":
                    BuscarPorNombre(valorBusqueda);
                    break;
                default:
                    MessageBox.Show("Filtro no válido");
                    break;
            }
        }
        private void BuscarPorCorreo(string correo)
        {
            int index = clientesBindingSource.Find("Correo", correo);
            MostrarResultadoBusqueda(index, "Correo");
        }
        private void BuscarPorNombre(string nombre)
        {
            int index = clientesBindingSource.Find("Nombre", nombre);
            MostrarResultadoBusqueda(index, "Nombre");
        }
        private void BuscarPorDNI(string DNI)
        {
            int index = clientesBindingSource.Find("dni", DNI);
            MostrarResultadoBusqueda(index, "dni");
        }
        private void BuscarPorId(string id)
        {
            int idBusqueda;
            if (int.TryParse(id, out idBusqueda))
            {
                int index = clientesBindingSource.Find("ClienteID", idBusqueda);
                if (index == -1)
                {
                    MessageBox.Show("No existe un cliente con ese ID.");
                }
                else
                {
                    clientesBindingSource.Position = index;
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
                MessageBox.Show($"No existe un cliente con ese {filtro}.");
            }
            else
            {
                clientesBindingSource.Position = index;
            }
        }

        private void clientesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = "Cliente " + (clientesBindingSource.Position + 1) + " de " + (clientesBindingSource.Count);
        }

        private void buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                botonBuscar.PerformClick();
                buscar.Text = "";
            }
        }

        private void nombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tipoClienteComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tipoClienteComboBox.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dniTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void provinciaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void localidadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void codigoPostalTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void direccionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void telefonoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void correoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botonAceptar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\..\\Crear documentación chm\\TransGlobal.chm", "Clientes.htm");
        }
    }
}
