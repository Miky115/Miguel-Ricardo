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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoAgus
{
    public partial class camiones : Form
    {
        public camiones()
        {
            InitializeComponent();
            DeshabilitarBotones();
        }

        private void camionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.camionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transGlobalDataSet);

        }

        private void camiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Camiones' Puede moverla o quitarla según sea necesario.
            this.camionesTableAdapter.Fill(this.transGlobalDataSet.Camiones);
            if (fotoPictureBox.Image != null)
            {
                fotoPictureBox.BackgroundImage = Properties.Resources.vacio;
            }
        }

        private void botonPrincipio_Click(object sender, EventArgs e)
        {
            camionesBindingSource.MoveFirst();
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            camionesBindingSource.MovePrevious();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            camionesBindingSource.MoveNext();
        }

        private void botonFinal_Click(object sender, EventArgs e)
        {
            camionesBindingSource.MoveLast();
        }

        private void botonAdd_Click(object sender, EventArgs e)
        {
            // Realiza la validación para matriculaTextBox
            if (string.IsNullOrWhiteSpace(matriculaTextBox.Text))
            {
                errorProvider1.SetError(matriculaTextBox, "La matrícula no puede estar vacía.");
            }
            else if (matriculaTextBox.Text.Length > 6)
            {
                errorProvider1.SetError(matriculaTextBox, "La matrícula no puede tener más de 6 caracteres.");
            }
            else if (!Regex.IsMatch(matriculaTextBox.Text, "^[A-Za-z]{3}\\d{3}$"))
            {
                errorProvider1.SetError(matriculaTextBox, "Formato de matrícula incorrecto. Debe ser de la forma ABC123.");
            }
            else
            {
                // La validación es exitosa, limpia el errorProvider
                errorProvider1.SetError(matriculaTextBox, "");

                // Puedes continuar con el resto de tu lógica aquí
            }

            // Realiza la validación para tipoCamionComboBox
            if (string.IsNullOrWhiteSpace(tipoCamionComboBox.Text))
            {
                errorProvider1.SetError(tipoCamionComboBox, "El tipo de camión no puede estar vacío.");
            }
            else if (tipoCamionComboBox.Text.Length > 50)
            {
                errorProvider1.SetError(tipoCamionComboBox, "El tipo de camión no puede tener más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(tipoCamionComboBox, ""); // Limpia el mensaje de error
            }

            // Realiza la validación para marcaTextBox
            if (string.IsNullOrWhiteSpace(marcaTextBox.Text))
            {
                errorProvider1.SetError(marcaTextBox, "La marca no puede estar vacía.");
            }
            else if (marcaTextBox.Text.Length > 30)
            {
                errorProvider1.SetError(marcaTextBox, "La marca no puede tener más de 30 caracteres.");
            }
            else
            {
                errorProvider1.SetError(marcaTextBox, ""); // Limpia el mensaje de error
            }

            // Realiza la validación para modeloTextBox
            if (string.IsNullOrWhiteSpace(modeloTextBox.Text))
            {
                errorProvider1.SetError(modeloTextBox, "El modelo no puede estar vacío.");
            }
            else if (modeloTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(modeloTextBox, "El modelo no puede tener más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(modeloTextBox, ""); // Limpia el mensaje de error
            }

            // Realiza la validación para capacidadCargaTextBox
            if (string.IsNullOrWhiteSpace(capacidadaCargaTextBox.Text))
            {
                errorProvider1.SetError(capacidadaCargaTextBox, "La capacidad de carga no puede estar vacía.");
            }
            else if (capacidadaCargaTextBox.Text.Length > 20)
            {
                errorProvider1.SetError(capacidadaCargaTextBox, "La capacidad de carga no puede tener más de 20 caracteres.");
            }
            else
            {
                errorProvider1.SetError(capacidadaCargaTextBox, ""); // Limpia el mensaje de error
            }

            // Realiza la validación para tipoCombustibleComboBox
            if (string.IsNullOrWhiteSpace(tipoCombustibleComboBox.Text))
            {
                errorProvider1.SetError(tipoCombustibleComboBox, "El tipo de combustible no puede estar vacío.");
            }
            else if (tipoCombustibleComboBox.Text.Length > 50)
            {
                errorProvider1.SetError(tipoCombustibleComboBox, "El tipo de combustible no puede tener más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(tipoCombustibleComboBox, ""); // Limpia el mensaje de error
            }

            // Verifica si hay algún error en alguno de los TextBox
            if (errorProvider1.GetError(matriculaTextBox) == "" &&
                errorProvider1.GetError(tipoCamionComboBox) == "" &&
                errorProvider1.GetError(marcaTextBox) == "" &&
                errorProvider1.GetError(modeloTextBox) == "" &&
                errorProvider1.GetError(capacidadaCargaTextBox) == "" &&
                errorProvider1.GetError(tipoCombustibleComboBox) == "")
            {
                botonPrincipio.Enabled = false;
                botonAnterior.Enabled = false;
                botonSiguiente.Enabled = false;
                botonFinal.Enabled = false;
                botonBuscar.Enabled = false;
                camionesBindingSource.AddNew();
                fechaFabricacionDateTimePicker.Value = DateTime.Now;
                HabilitarBotones();
                // Todos los TextBox están validados correctamente, puedes continuar con el resto de tu lógica aquí
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Borrar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                camionesBindingSource.RemoveCurrent();
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
                camionesBindingSource.EndEdit();
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
                case "Buscar por Matricula":
                    BuscarPorMatricula(valorBusqueda);
                    break;
                default:
                    MessageBox.Show("Filtro no válido");
                    break;
            }
        }

        private void camionesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = "Camión " + (camionesBindingSource.Position + 1) + " de " + (camionesBindingSource.Count);
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            // Realiza la validación para matriculaTextBox
            if (string.IsNullOrWhiteSpace(matriculaTextBox.Text))
            {
                errorProvider1.SetError(matriculaTextBox, "La matrícula no puede estar vacía.");
            }
            else if (matriculaTextBox.Text.Length > 6)
            {
                errorProvider1.SetError(matriculaTextBox, "La matrícula no puede tener más de 6 caracteres.");
            }
            else if (!Regex.IsMatch(matriculaTextBox.Text, "^[A-Za-z]{3}\\d{3}$"))
            {
                errorProvider1.SetError(matriculaTextBox, "Formato de matrícula incorrecto. Debe ser de la forma ABC123.");
            }
            else
            {
                // La validación es exitosa, limpia el errorProvider
                errorProvider1.SetError(matriculaTextBox, "");

                // Puedes continuar con el resto de tu lógica aquí
            }

            // Realiza la validación para tipoCamionComboBox
            if (string.IsNullOrWhiteSpace(tipoCamionComboBox.Text))
            {
                errorProvider1.SetError(tipoCamionComboBox, "El tipo de camión no puede estar vacío.");
            }
            else if (tipoCamionComboBox.Text.Length > 50)
            {
                errorProvider1.SetError(tipoCamionComboBox, "El tipo de camión no puede tener más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(tipoCamionComboBox, ""); // Limpia el mensaje de error
            }

            // Realiza la validación para marcaTextBox
            if (string.IsNullOrWhiteSpace(marcaTextBox.Text))
            {
                errorProvider1.SetError(marcaTextBox, "La marca no puede estar vacía.");
            }
            else if (marcaTextBox.Text.Length > 30)
            {
                errorProvider1.SetError(marcaTextBox, "La marca no puede tener más de 30 caracteres.");
            }
            else
            {
                errorProvider1.SetError(marcaTextBox, ""); // Limpia el mensaje de error
            }

            // Realiza la validación para modeloTextBox
            if (string.IsNullOrWhiteSpace(modeloTextBox.Text))
            {
                errorProvider1.SetError(modeloTextBox, "El modelo no puede estar vacío.");
            }
            else if (modeloTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(modeloTextBox, "El modelo no puede tener más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(modeloTextBox, ""); // Limpia el mensaje de error
            }

            // Realiza la validación para capacidadCargaTextBox
            if (string.IsNullOrWhiteSpace(capacidadaCargaTextBox.Text))
            {
                errorProvider1.SetError(capacidadaCargaTextBox, "La capacidad de carga no puede estar vacía.");
            }
            else if (capacidadaCargaTextBox.Text.Length > 20)
            {
                errorProvider1.SetError(capacidadaCargaTextBox, "La capacidad de carga no puede tener más de 20 caracteres.");
            }
            else
            {
                errorProvider1.SetError(capacidadaCargaTextBox, ""); // Limpia el mensaje de error
            }

            // Realiza la validación para tipoCombustibleComboBox
            if (string.IsNullOrWhiteSpace(tipoCombustibleComboBox.Text))
            {
                errorProvider1.SetError(tipoCombustibleComboBox, "El tipo de combustible no puede estar vacío.");
            }
            else if (tipoCombustibleComboBox.Text.Length > 50)
            {
                errorProvider1.SetError(tipoCombustibleComboBox, "El tipo de combustible no puede tener más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(tipoCombustibleComboBox, ""); // Limpia el mensaje de error
            }

            // Verifica si hay algún error en alguno de los TextBox
            if (errorProvider1.GetError(matriculaTextBox) == "" &&
                errorProvider1.GetError(tipoCamionComboBox) == "" &&
                errorProvider1.GetError(marcaTextBox) == "" &&
                errorProvider1.GetError(modeloTextBox) == "" &&
                errorProvider1.GetError(capacidadaCargaTextBox) == "" &&
                errorProvider1.GetError(tipoCombustibleComboBox) == "")
            {
                camionesBindingSource.EndEdit();
                DeshabilitarBotones();
                botonGuardar.Enabled = true;
                botonPrincipio.Enabled = true;
                botonAnterior.Enabled = true;
                botonSiguiente.Enabled = true;
                botonFinal.Enabled = true;
                botonBorrar.Enabled = true;
                // Todos los TextBox están validados correctamente, puedes continuar con el resto de tu lógica aquí
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            camionesBindingSource.CancelEdit();
            DeshabilitarBotones();
            botonPrincipio.Enabled = true;
            botonAnterior.Enabled = true;
            botonSiguiente.Enabled = true;
            botonFinal.Enabled = true;
            botonBuscar.Enabled = true;
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
        private void HabilitarBotones()
        {
            botonAceptar.Enabled = true;
            botonCancelar.Enabled = true;
            matriculaTextBox.Enabled = true;
            tipoCamionComboBox.Enabled = true;
            marcaTextBox.Enabled = true;
            modeloTextBox.Enabled = true;
            fechaFabricacionDateTimePicker.Enabled = true;
            capacidadaCargaTextBox.Enabled = true;
            fotoPictureBox.Enabled = true;
            tipoCombustibleComboBox.Enabled = true;
        }
        private void DeshabilitarBotones()
        {
            botonAceptar.Enabled = false;
            botonCancelar.Enabled = false;
            camionIDTextBox.Enabled = false;
            matriculaTextBox.Enabled = false;
            tipoCamionComboBox.Enabled = false;
            marcaTextBox.Enabled = false;
            modeloTextBox.Enabled = false;
            fechaFabricacionDateTimePicker.Enabled = false;
            capacidadaCargaTextBox.Enabled = false;
            fotoPictureBox.Enabled = false;
            tipoCombustibleComboBox.Enabled = false;
        }

        private void BuscarPorMatricula(string matricula)
        {
            int index = camionesBindingSource.Find("Matricula", matricula);
            MostrarResultadoBusqueda(index, "Matricula");
        }
        private void BuscarPorId(string id)
        {
            int idBusqueda;
            if (int.TryParse(id, out idBusqueda))
            {
                int index = camionesBindingSource.Find("camionID", idBusqueda);
                if (index == -1)
                {
                    MessageBox.Show("No existe un camion con ese ID.");
                }
                else
                {
                    camionesBindingSource.Position = index;
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
                MessageBox.Show($"No existe un juego con ese {filtro}.");
            }
            else
            {
                camionesBindingSource.Position = index;
            }
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
                        camionesBindingSource.EndEdit();
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

            private void buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                botonBuscar.PerformClick();
                buscar.Text = "";
            }
        }

        private void matriculaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tipoCamionComboBox.DroppedDown = true;  // Desplegar el ComboBox al presionar Enter
            }
        }

        private void tipoCamionComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                marcaTextBox.Focus();
            }
        }

        private void marcaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                modeloTextBox.Focus();
            }
        }

        private void modeloTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                fechaFabricacionDateTimePicker.Focus();
            }
        }

        private void fechaFabricacionDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                capacidadaCargaTextBox.Focus();
            }
        }

        private void capacidadaCargaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tipoCombustibleComboBox.DroppedDown = true;  // Desplegar el ComboBox al presionar Enter
            }
        }

        private void tipoCombustibleComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                botonAceptar.PerformClick();
            }
        }

        private void botonInforme_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.matricula = matriculaTextBox.Text;
            Properties.Settings.Default.tipocamion = tipoCamionComboBox.Text;
            Properties.Settings.Default.marca = marcaTextBox.Text;
            Properties.Settings.Default.modelo = modeloTextBox.Text;
            Properties.Settings.Default.fechafabricacion = fechaFabricacionDateTimePicker.Text;
            Properties.Settings.Default.carga = capacidadaCargaTextBox.Text;
            Properties.Settings.Default.combustible = tipoCombustibleComboBox.Text;

            informeCamion informeCamiones = new informeCamion();
            informeCamiones.Show();
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Alumnodam2\\Documents\\HelpNDoc\\Output\\Crear documentación chm\\TransGlobal.chm", "Camiones.htm");
        }
    }
}
