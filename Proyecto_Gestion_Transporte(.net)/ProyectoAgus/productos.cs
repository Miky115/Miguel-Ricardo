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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
            DeshabilitarBotones();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transGlobalDataSet);

        }

        private void productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.transGlobalDataSet.Producto);
            if (fotoPictureBox.Image != null)
            {
                fotoPictureBox.BackgroundImage = Properties.Resources.vacio;
            }
        }

        private void botonPrincipio_Click(object sender, EventArgs e)
        {
            productoBindingSource.MoveFirst();
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            productoBindingSource.MovePrevious();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            productoBindingSource.MoveNext();
        }

        private void botonFinal_Click(object sender, EventArgs e)
        {
            productoBindingSource.MoveLast();
        }

        private void botonAdd_Click(object sender, EventArgs e)
        {
            // Validar nombreTextBox
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede estar vacío.");
            }
            else if (nombreTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede tener más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(nombreTextBox, ""); // Limpia el mensaje de error
            }

            // Validar precioTextBox
            decimal precio;
            if (string.IsNullOrWhiteSpace(precioTextBox.Text))
            {
                errorProvider1.SetError(precioTextBox, "El campo Precio no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioTextBox.Text, out precio) || precioTextBox.Text.Length > 15)
            {
                errorProvider1.SetError(precioTextBox, "Formato incorrecto para Precio. Debe ser un número con un máximo de 15 dígitos.");
            }
            else
            {
                errorProvider1.SetError(precioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar pesoTextBox
            decimal peso;
            if (string.IsNullOrWhiteSpace(pesoTextBox.Text))
            {
                errorProvider1.SetError(pesoTextBox, "El campo Peso no puede estar vacío.");
            }
            else if (!decimal.TryParse(pesoTextBox.Text, out peso) || pesoTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(pesoTextBox, "Formato incorrecto para Peso. Debe ser un número con un máximo de 9 dígitos.");
            }
            else
            {
                errorProvider1.SetError(pesoTextBox, ""); // Limpia el mensaje de error
            }

            // Validar stockTextBox
            decimal stock;
            if (string.IsNullOrWhiteSpace(stockTextBox.Text))
            {
                errorProvider1.SetError(stockTextBox, "El campo Stock no puede estar vacío.");
            }
            else if (!decimal.TryParse(stockTextBox.Text, out stock) || stockTextBox.Text.Length > 10)
            {
                errorProvider1.SetError(stockTextBox, "Formato incorrecto para Stock. Debe ser un número con un máximo de 10 dígitos.");
            }
            else
            {
                errorProvider1.SetError(stockTextBox, ""); // Limpia el mensaje de error
            }

            // Validar iSBNTextBox
            if (string.IsNullOrWhiteSpace(iSBNTextBox.Text))
            {
                errorProvider1.SetError(iSBNTextBox, "El campo ISBN no puede estar vacío.");
            }
            else if (!Regex.IsMatch(iSBNTextBox.Text, @"^\d{1,13}$"))
            {
                errorProvider1.SetError(iSBNTextBox, "El campo ISBN debe contener hasta 13 números.");
            }
            else
            {
                errorProvider1.SetError(iSBNTextBox, ""); // Limpia el mensaje de error
            }

            if (errorProvider1.GetError(nombreTextBox) == "" &&
    errorProvider1.GetError(precioTextBox) == "" &&
    errorProvider1.GetError(pesoTextBox) == "" &&
    errorProvider1.GetError(stockTextBox) == "" &&
    errorProvider1.GetError(iSBNTextBox) == "")
            {
                botonPrincipio.Enabled = false;
                botonAnterior.Enabled = false;
                botonSiguiente.Enabled = false;
                botonFinal.Enabled = false;
                botonBuscar.Enabled = false;

                productoBindingSource.AddNew();
                HabilitarBotones();
            }

        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Borrar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                productoBindingSource.RemoveCurrent();
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
                productoBindingSource.EndEdit();
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
            // Validar nombreTextBox
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede estar vacío.");
            }
            else if (nombreTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(nombreTextBox, "El campo Nombre no puede tener más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(nombreTextBox, ""); // Limpia el mensaje de error
            }

            // Validar precioTextBox
            decimal precio;
            if (string.IsNullOrWhiteSpace(precioTextBox.Text))
            {
                errorProvider1.SetError(precioTextBox, "El campo Precio no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioTextBox.Text, out precio) || precioTextBox.Text.Length > 15)
            {
                errorProvider1.SetError(precioTextBox, "Formato incorrecto para Precio. Debe ser un número con un máximo de 15 dígitos.");
            }
            else
            {
                errorProvider1.SetError(precioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar pesoTextBox
            decimal peso;
            if (string.IsNullOrWhiteSpace(pesoTextBox.Text))
            {
                errorProvider1.SetError(pesoTextBox, "El campo Peso no puede estar vacío.");
            }
            else if (!decimal.TryParse(pesoTextBox.Text, out peso) || pesoTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(pesoTextBox, "Formato incorrecto para Peso. Debe ser un número con un máximo de 9 dígitos.");
            }
            else
            {
                errorProvider1.SetError(pesoTextBox, ""); // Limpia el mensaje de error
            }

            // Validar stockTextBox
            decimal stock;
            if (string.IsNullOrWhiteSpace(stockTextBox.Text))
            {
                errorProvider1.SetError(stockTextBox, "El campo Stock no puede estar vacío.");
            }
            else if (!decimal.TryParse(stockTextBox.Text, out stock) || stockTextBox.Text.Length > 10)
            {
                errorProvider1.SetError(stockTextBox, "Formato incorrecto para Stock. Debe ser un número con un máximo de 10 dígitos.");
            }
            else
            {
                errorProvider1.SetError(stockTextBox, ""); // Limpia el mensaje de error
            }

            // Validar ISBNTextBox
            if (string.IsNullOrWhiteSpace(iSBNTextBox.Text))
            {
                errorProvider1.SetError(iSBNTextBox, "El campo ISBN no puede estar vacío.");
            }
            else if (!Regex.IsMatch(iSBNTextBox.Text, @"^\d{1,13}$"))
            {
                errorProvider1.SetError(iSBNTextBox, "El campo ISBN debe contener hasta 13 números.");
            }
            else
            {
                errorProvider1.SetError(iSBNTextBox, ""); // Limpia el mensaje de error
            }

            if (errorProvider1.GetError(nombreTextBox) == "" &&
    errorProvider1.GetError(precioTextBox) == "" &&
    errorProvider1.GetError(pesoTextBox) == "" &&
    errorProvider1.GetError(stockTextBox) == "" &&
    errorProvider1.GetError(iSBNTextBox) == "")
            {
                // Todos los ErrorProvider están vacíos, por lo tanto, puedes realizar las acciones deseadas.
                productoBindingSource.EndEdit();
                DeshabilitarBotones();
                botonGuardar.Enabled = true;
                botonPrincipio.Enabled = true;
                botonAnterior.Enabled = true;
                botonSiguiente.Enabled = true;
                botonFinal.Enabled = true;
                botonBorrar.Enabled = true;
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            productoBindingSource.CancelEdit();
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
                        productoBindingSource.EndEdit();
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
                } else if (result == DialogResult.No)
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
            precioTextBox.Enabled = true;
            stockTextBox.Enabled = true;
            pesoTextBox.Enabled = true;
            iSBNTextBox.Enabled = true;
            fotoPictureBox.Enabled = true;
        }
        private void DeshabilitarBotones()
        {
            botonAceptar.Enabled = false;
            botonCancelar.Enabled = false;
            productoIDTextBox.Enabled = false;
            nombreTextBox.Enabled = false;
            precioTextBox.Enabled = false;
            stockTextBox.Enabled = false;
            pesoTextBox.Enabled = false;
            iSBNTextBox.Enabled = false;
            fotoPictureBox.Enabled = false;
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
            Properties.Settings.Default.idProducto = productoIDTextBox.Text;
            Properties.Settings.Default.nombreProducto = nombreTextBox.Text;
            Properties.Settings.Default.precioProducto = precioTextBox.Text;
            Properties.Settings.Default.pesoProducto = pesoTextBox.Text;
            Properties.Settings.Default.stockProducto = stockTextBox.Text;
            Properties.Settings.Default.isbnProducto = iSBNTextBox.Text;

            informeProducto informe = new informeProducto();
            informe.Show();
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
                case "Buscar por Nombre":
                    BuscarPorNombre(valorBusqueda);
                    break;
                case "Buscar por ISBN":
                    BuscarPorISBN(valorBusqueda);
                    break;
                default:
                    MessageBox.Show("Filtro no válido");
                    break;
            }
        }
        private void BuscarPorNombre(string nombre)
        {
            int index = productoBindingSource.Find("Nombre", nombre);
            MostrarResultadoBusqueda(index, "Nombre");
        }
        private void BuscarPorISBN(string ISBN)
        {
            int index = productoBindingSource.Find("ISBN", ISBN);
            MostrarResultadoBusqueda(index, "ISBN");
        }
        private void BuscarPorId(string id)
        {
            int idBusqueda;
            if (int.TryParse(id, out idBusqueda))
            {
                int index = productoBindingSource.Find("ProductoID", idBusqueda);
                if (index == -1)
                {
                    MessageBox.Show("No existe un producto con ese ID.");
                }
                else
                {
                    productoBindingSource.Position = index;
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
                MessageBox.Show($"No existe un producto con ese {filtro}.");
            }
            else
            {
                productoBindingSource.Position = index;
            }
        }

        private void productoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = "Producto " + (productoBindingSource.Position + 1) + " de " + (productoBindingSource.Count);
        }

        private void nombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                precioTextBox.Focus();
            }
        }

        private void precioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                pesoTextBox.Focus();
            }
        }

        private void pesoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                stockTextBox.Focus();
            }
        }

        private void stockTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                iSBNTextBox.Focus();
            }
        }

        private void iSBNTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                botonAceptar.PerformClick();
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
