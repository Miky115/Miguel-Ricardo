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
    public partial class rutas : Form
    {
        public rutas()
        {
            InitializeComponent();
            DeshabilitarBotones();
        }

        private void rutasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rutasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transGlobalDataSet);

        }

        private void rutas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.transGlobalDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Camiones' Puede moverla o quitarla según sea necesario.
            this.camionesTableAdapter.Fill(this.transGlobalDataSet.Camiones);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Ruta_Detalle' Puede moverla o quitarla según sea necesario.
            this.ruta_DetalleTableAdapter.Fill(this.transGlobalDataSet.Ruta_Detalle);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter.Fill(this.transGlobalDataSet.Rutas);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter.Fill(this.transGlobalDataSet.Rutas);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter.Fill(this.transGlobalDataSet.Rutas);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter.Fill(this.transGlobalDataSet.Rutas);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Ruta_Detalle' Puede moverla o quitarla según sea necesario.
            this.ruta_DetalleTableAdapter.Fill(this.transGlobalDataSet.Ruta_Detalle);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter.Fill(this.transGlobalDataSet.Rutas);
            if (mapaPictureBox.Image != null)
            {
                mapaPictureBox.BackgroundImage = Properties.Resources.vacio;
            }
        }

        private void botonPrincipio_Click(object sender, EventArgs e)
        {
            rutasBindingSource.MoveFirst();
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            rutasBindingSource.MovePrevious();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            rutasBindingSource.MoveNext();
        }

        private void botonFinal_Click(object sender, EventArgs e)
        {
            rutasBindingSource.MoveLast();
        }

        private void botonAdd_Click(object sender, EventArgs e)
        {
            // Validar origenTextBox
            if (string.IsNullOrWhiteSpace(origenTextBox.Text))
            {
                errorProvider1.SetError(origenTextBox, "El campo Origen no puede estar vacío.");
            }
            else if (origenTextBox.Text.Length > 32767)
            {
                errorProvider1.SetError(origenTextBox, "El campo Origen no puede tener más de 32767 caracteres.");
            }
            else
            {
                errorProvider1.SetError(origenTextBox, ""); // Limpia el mensaje de error
            }

            // Validar destinoTextBox
            if (string.IsNullOrWhiteSpace(destinoTextBox.Text))
            {
                errorProvider1.SetError(destinoTextBox, "El campo Destino no puede estar vacío.");
            }
            else if (destinoTextBox.Text.Length > 32767)
            {
                errorProvider1.SetError(destinoTextBox, "El campo Destino no puede tener más de 32767 caracteres.");
            }
            else
            {
                errorProvider1.SetError(destinoTextBox, ""); // Limpia el mensaje de error
            }

            // Validar distanciaKMTextBox
            decimal distancia;
            if (string.IsNullOrWhiteSpace(distanciaKMTextBox.Text))
            {
                errorProvider1.SetError(distanciaKMTextBox, "El campo Distancia no puede estar vacío.");
            }
            else if (!decimal.TryParse(distanciaKMTextBox.Text, out distancia) ||
                     distanciaKMTextBox.Text.Length > 18 ||
                     !Regex.IsMatch(distanciaKMTextBox.Text, @"^\d{1,15}(\.\d{1,4})?$"))
            {
                errorProvider1.SetError(distanciaKMTextBox, "Formato incorrecto para Distancia. Debe ser un número con hasta 18 dígitos y 2 decimales.");
            }
            else
            {
                errorProvider1.SetError(distanciaKMTextBox, ""); // Limpia el mensaje de error
            }

            // Validar empleadoIDComboBox
            if (empleadoIDComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(empleadoIDComboBox, "Seleccione un empleado.");
            }
            else
            {
                errorProvider1.SetError(empleadoIDComboBox, ""); // Limpia el mensaje de error
            }

            // Validar camionIDComboBox
            if (camionIDComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(camionIDComboBox, "Seleccione un camión.");
            }
            else
            {
                errorProvider1.SetError(camionIDComboBox, ""); // Limpia el mensaje de error
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

            // Validar codigoPostalTextBox
            if (string.IsNullOrWhiteSpace(codigoPostalTextBox.Text))
            {
                errorProvider1.SetError(codigoPostalTextBox, "El campo Código Postal no puede estar vacío.");
            }
            else if (!Regex.IsMatch(codigoPostalTextBox.Text, @"^\d+$") || codigoPostalTextBox.Text.Length > 5)
            {
                errorProvider1.SetError(codigoPostalTextBox, "El campo Código Postal debe ser numérico y tener un máximo de 5 caracteres.");
            }
            else
            {
                errorProvider1.SetError(codigoPostalTextBox, ""); // Limpia el mensaje de error
            }

            // Validar horaInicioTextBox
            TimeSpan horaInicio;
            if (string.IsNullOrWhiteSpace(horaInicioTextBox.Text) ||
                !TimeSpan.TryParseExact(horaInicioTextBox.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out horaInicio))
            {
                errorProvider1.SetError(horaInicioTextBox, "Formato incorrecto para Hora de Inicio. Debe ser en el formato 01:00:00.");
            }
            else
            {
                errorProvider1.SetError(horaInicioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar horaFinTextBox
            TimeSpan horaFin;
            if (string.IsNullOrWhiteSpace(horaFinTextBox.Text) ||
                !TimeSpan.TryParseExact(horaFinTextBox.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out horaFin))
            {
                errorProvider1.SetError(horaFinTextBox, "Formato incorrecto para Hora de Fin. Debe ser en el formato 01:00:00.");
            }
            else
            {
                errorProvider1.SetError(horaFinTextBox, ""); // Limpia el mensaje de error
            }

            // Validar costoRutaTextBox
            decimal costoRuta;
            if (string.IsNullOrWhiteSpace(costoRutaTextBox.Text))
            {
                errorProvider1.SetError(costoRutaTextBox, "El campo Costo Ruta no puede estar vacío.");
            }
            else if (!decimal.TryParse(costoRutaTextBox.Text.Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out costoRuta) ||
                     costoRutaTextBox.Text.Length > 20 ||
                     !Regex.IsMatch(costoRutaTextBox.Text, @"^\d{1,15}(\,\d{1,4})?$"))
            {
                errorProvider1.SetError(costoRutaTextBox, "Formato incorrecto para Costo Ruta. Debe ser un número con hasta 15 dígitos y 4 decimales, utilizando coma como separador decimal.");
            }
            else
            {
                errorProvider1.SetError(costoRutaTextBox, ""); // Limpia el mensaje de error
            }

            // Verificar si todos los campos tienen errores vacíos
            if (errorProvider1.GetError(origenTextBox) == "" &&
                errorProvider1.GetError(destinoTextBox) == "" &&
                errorProvider1.GetError(distanciaKMTextBox) == "" &&
                errorProvider1.GetError(empleadoIDComboBox) == "" &&
                errorProvider1.GetError(camionIDComboBox) == "" &&
                errorProvider1.GetError(direccionTextBox) == "" &&
                errorProvider1.GetError(codigoPostalTextBox) == "" &&
                errorProvider1.GetError(horaInicioTextBox) == "" &&
                errorProvider1.GetError(horaFinTextBox) == "" &&
                errorProvider1.GetError(costoRutaTextBox) == "")
            {
                rutasBindingSource.AddNew();
                ruta_DetalleBindingSource.AddNew();
                HabilitarBotones();
                botonPrincipio.Enabled = false;
                botonSiguiente.Enabled = false;
                botonAnterior.Enabled = false;
                botonFinal.Enabled = false;
                botonBuscar.Enabled = false;
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Borrar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                rutasBindingSource.RemoveCurrent();
                DeshabilitarBotones();
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
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                rutasBindingSource.EndEdit();
                ruta_DetalleBindingSource.EndEdit();
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
            string valorBusqueda = buscar.Text;

            if (string.IsNullOrEmpty(valorBusqueda))
            {
                MessageBox.Show("Selecciona un filtro y proporciona un valor de búsqueda.");
                return;
            }
            int idBusqueda;
            if (int.TryParse(valorBusqueda, out idBusqueda))
            {
                int index = rutasBindingSource.Find("rutaID", idBusqueda);
                if (index == -1)
                {
                    MessageBox.Show("No existe una ruta con ese ID.");
                }
                else
                {
                    rutasBindingSource.Position = index;
                }
            }
            else
            {
                MessageBox.Show("ID no válido. Ingresa un número entero.");
            }
        }
        private void rutasBindingSource_PositionChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Ruta " + (rutasBindingSource.Position + 1) + " de " + (rutasBindingSource.Count);
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            // Validar origenTextBox
            if (string.IsNullOrWhiteSpace(origenTextBox.Text))
            {
                errorProvider1.SetError(origenTextBox, "El campo Origen no puede estar vacío.");
            }
            else if (origenTextBox.Text.Length > 32767)
            {
                errorProvider1.SetError(origenTextBox, "El campo Origen no puede tener más de 32767 caracteres.");
            }
            else
            {
                errorProvider1.SetError(origenTextBox, ""); // Limpia el mensaje de error
            }

            // Validar destinoTextBox
            if (string.IsNullOrWhiteSpace(destinoTextBox.Text))
            {
                errorProvider1.SetError(destinoTextBox, "El campo Destino no puede estar vacío.");
            }
            else if (destinoTextBox.Text.Length > 32767)
            {
                errorProvider1.SetError(destinoTextBox, "El campo Destino no puede tener más de 32767 caracteres.");
            }
            else
            {
                errorProvider1.SetError(destinoTextBox, ""); // Limpia el mensaje de error
            }

            // Validar distanciaKMTextBox
            decimal distancia;
            if (string.IsNullOrWhiteSpace(distanciaKMTextBox.Text))
            {
                errorProvider1.SetError(distanciaKMTextBox, "El campo Distancia no puede estar vacío.");
            }
            else if (!decimal.TryParse(distanciaKMTextBox.Text, out distancia) ||
                     distanciaKMTextBox.Text.Length > 18 ||
                     !Regex.IsMatch(distanciaKMTextBox.Text, @"^\d{1,15}(\.\d{1,4})?$"))
            {
                errorProvider1.SetError(distanciaKMTextBox, "Formato incorrecto para Distancia. Debe ser un número con hasta 18 dígitos y 2 decimales.");
            }
            else
            {
                errorProvider1.SetError(distanciaKMTextBox, ""); // Limpia el mensaje de error
            }

            // Validar empleadoIDComboBox
            if (empleadoIDComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(empleadoIDComboBox, "Seleccione un empleado.");
            }
            else
            {
                errorProvider1.SetError(empleadoIDComboBox, ""); // Limpia el mensaje de error
            }

            // Validar camionIDComboBox
            if (camionIDComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(camionIDComboBox, "Seleccione un camión.");
            }
            else
            {
                errorProvider1.SetError(camionIDComboBox, ""); // Limpia el mensaje de error
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

            // Validar codigoPostalTextBox
            if (string.IsNullOrWhiteSpace(codigoPostalTextBox.Text))
            {
                errorProvider1.SetError(codigoPostalTextBox, "El campo Código Postal no puede estar vacío.");
            }
            else if (!Regex.IsMatch(codigoPostalTextBox.Text, @"^\d+$") || codigoPostalTextBox.Text.Length > 5)
            {
                errorProvider1.SetError(codigoPostalTextBox, "El campo Código Postal debe ser numérico y tener un máximo de 5 caracteres.");
            }
            else
            {
                errorProvider1.SetError(codigoPostalTextBox, ""); // Limpia el mensaje de error
            }

            // Validar horaInicioTextBox
            TimeSpan horaInicio;
            if (string.IsNullOrWhiteSpace(horaInicioTextBox.Text) ||
                !TimeSpan.TryParseExact(horaInicioTextBox.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out horaInicio))
            {
                errorProvider1.SetError(horaInicioTextBox, "Formato incorrecto para Hora de Inicio. Debe ser en el formato 01:00:00.");
            }
            else
            {
                errorProvider1.SetError(horaInicioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar horaFinTextBox
            TimeSpan horaFin;
            if (string.IsNullOrWhiteSpace(horaFinTextBox.Text) ||
                !TimeSpan.TryParseExact(horaFinTextBox.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out horaFin))
            {
                errorProvider1.SetError(horaFinTextBox, "Formato incorrecto para Hora de Fin. Debe ser en el formato 01:00:00.");
            }
            else
            {
                errorProvider1.SetError(horaFinTextBox, ""); // Limpia el mensaje de error
            }

            // Validar costoRutaTextBox
            decimal costoRuta;
            if (string.IsNullOrWhiteSpace(costoRutaTextBox.Text))
            {
                errorProvider1.SetError(costoRutaTextBox, "El campo Costo Ruta no puede estar vacío.");
            }
            else if (!decimal.TryParse(costoRutaTextBox.Text.Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out costoRuta) ||
                     costoRutaTextBox.Text.Length > 20 ||
                     !Regex.IsMatch(costoRutaTextBox.Text, @"^\d{1,15}(\,\d{1,4})?$"))
            {
                errorProvider1.SetError(costoRutaTextBox, "Formato incorrecto para Costo Ruta. Debe ser un número con hasta 15 dígitos y 4 decimales, utilizando coma como separador decimal.");
            }
            else
            {
                errorProvider1.SetError(costoRutaTextBox, ""); // Limpia el mensaje de error
            }
            // Verificar si todos los campos tienen errores vacíos
            if (errorProvider1.GetError(origenTextBox) == "" &&
                errorProvider1.GetError(destinoTextBox) == "" &&
                errorProvider1.GetError(distanciaKMTextBox) == "" &&
                errorProvider1.GetError(empleadoIDComboBox) == "" &&
                errorProvider1.GetError(camionIDComboBox) == "" &&
                errorProvider1.GetError(direccionTextBox) == "" &&
                errorProvider1.GetError(codigoPostalTextBox) == "" &&
                errorProvider1.GetError(horaInicioTextBox) == "" &&
                errorProvider1.GetError(horaFinTextBox) == "" &&
                errorProvider1.GetError(costoRutaTextBox) == "")
            {
                // Todos los ErrorProvider están vacíos, por lo tanto, puedes realizar las acciones deseadas.
                rutasBindingSource.EndEdit();
                DeshabilitarBotones();
                botonGuardar.Enabled = true;
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            rutasBindingSource.CancelEdit();
            ruta_DetalleBindingSource.CancelEdit();
            DeshabilitarBotones();
            botonPrincipio.Enabled = true;
            botonAnterior.Enabled = true;
            botonSiguiente.Enabled = true;
            botonFinal.Enabled = true;
            botonBuscar.Enabled = true;
        }

        private void mapaPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*|" + "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { mapaPictureBox.Image = Image.FromFile(openFileDialog1.FileName); }
            else
            { mapaPictureBox.Image = null; }
        }

        private void HabilitarBotones()
        {
            botonAceptar.Enabled = true;
            botonCancelar.Enabled = true;
            origenTextBox.Enabled = true;
            destinoTextBox.Enabled = true;
            distanciaKMTextBox.Enabled = true;
            mapaPictureBox.Enabled = true;
            horaFinTextBox.Enabled = true;
            horaInicioTextBox.Enabled = true;
            fechaInicioDateTimePicker.Enabled = true;
            fechaFinDateTimePicker.Enabled = true;
            empleadoIDComboBox.Enabled = true;
            botonAceptarD.Enabled = true;
            botonCancelarD.Enabled = true;
            camionIDComboBox.Enabled = true;
            direccionTextBox.Enabled = true;
            codigoPostalTextBox.Enabled = true;
            costoRutaTextBox.Enabled = true;


        }
        private void DeshabilitarBotones()
        {
            botonAceptar.Enabled = false;
            botonCancelar.Enabled = false;
            origenTextBox.Enabled = false;
            destinoTextBox.Enabled = false;
            distanciaKMTextBox.Enabled = false;
            mapaPictureBox.Enabled = false;
            horaFinTextBox.Enabled = false;
            horaInicioTextBox.Enabled = false;
            fechaInicioDateTimePicker.Enabled = false;
            fechaFinDateTimePicker.Enabled = false;
            empleadoIDComboBox.Enabled = false;
            camionIDComboBox.Enabled = false;
            botonAceptarD.Enabled = false;
            botonCancelarD.Enabled = false;
            direccionTextBox.Enabled = false;
            codigoPostalTextBox.Enabled = false;
            costoRutaTextBox.Enabled = false;

        }

        private void botonMeter_Click(object sender, EventArgs e)
        {
            ruta_DetalleBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(transGlobalDataSet);
            DeshabilitarBotones();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
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

            // Validar codigoPostalTextBox
            if (string.IsNullOrWhiteSpace(codigoPostalTextBox.Text))
            {
                errorProvider1.SetError(codigoPostalTextBox, "El campo Código Postal no puede estar vacío.");
            }
            else if (!Regex.IsMatch(codigoPostalTextBox.Text, @"^\d+$") || codigoPostalTextBox.Text.Length > 5)
            {
                errorProvider1.SetError(codigoPostalTextBox, "El campo Código Postal debe ser numérico y tener un máximo de 5 caracteres.");
            }
            else
            {
                errorProvider1.SetError(codigoPostalTextBox, ""); // Limpia el mensaje de error
            }


            // Validar horaInicioTextBox
            TimeSpan horaInicio;
            if (string.IsNullOrWhiteSpace(horaInicioTextBox.Text) ||
                !TimeSpan.TryParseExact(horaInicioTextBox.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out horaInicio))
            {
                errorProvider1.SetError(horaInicioTextBox, "Formato incorrecto para Hora de Inicio. Debe ser en el formato 01:00:00.");
            }
            else
            {
                errorProvider1.SetError(horaInicioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar horaFinTextBox
            TimeSpan horaFin;
            if (string.IsNullOrWhiteSpace(horaFinTextBox.Text) ||
                !TimeSpan.TryParseExact(horaFinTextBox.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out horaFin))
            {
                errorProvider1.SetError(horaFinTextBox, "Formato incorrecto para Hora de Fin. Debe ser en el formato 01:00:00.");
            }
            else
            {
                errorProvider1.SetError(horaFinTextBox, ""); // Limpia el mensaje de error
            }

            // Validar costoRutaTextBox
            decimal costoRuta;
            if (string.IsNullOrWhiteSpace(costoRutaTextBox.Text))
            {
                errorProvider1.SetError(costoRutaTextBox, "El campo Costo Ruta no puede estar vacío.");
            }
            else if (!decimal.TryParse(costoRutaTextBox.Text.Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out costoRuta) ||
                     costoRutaTextBox.Text.Length > 20 ||
                     !Regex.IsMatch(costoRutaTextBox.Text, @"^\d{1,15}(\,\d{1,4})?$"))
            {
                errorProvider1.SetError(costoRutaTextBox, "Formato incorrecto para Costo Ruta. Debe ser un número con hasta 15 dígitos y 4 decimales, utilizando coma como separador decimal.");
            }
            else
            {
                errorProvider1.SetError(costoRutaTextBox, ""); // Limpia el mensaje de error
            }
            // Verificar si todos los campos tienen errores vacíos
            if (errorProvider1.GetError(direccionTextBox) == "" &&
                errorProvider1.GetError(codigoPostalTextBox) == "" &&
                errorProvider1.GetError(horaInicioTextBox) == "" &&
                errorProvider1.GetError(horaFinTextBox) == "" &&
                errorProvider1.GetError(costoRutaTextBox) == "")
            {
                ruta_DetalleBindingSource.AddNew();
                HabilitarBotones();
            }
        }

        private void botonBorrarDetalle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Borrar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ruta_DetalleBindingSource.RemoveCurrent();
                DeshabilitarBotones();
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
                        rutasBindingSource.EndEdit();
                        ruta_DetalleBindingSource.EndEdit();
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
            else {
                this.Hide();
                menu menu = new menu();
                menu.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

            // Validar codigoPostalTextBox
            if (string.IsNullOrWhiteSpace(codigoPostalTextBox.Text))
            {
                errorProvider1.SetError(codigoPostalTextBox, "El campo Código Postal no puede estar vacío.");
            }
            else if (!Regex.IsMatch(codigoPostalTextBox.Text, @"^\d+$") || codigoPostalTextBox.Text.Length > 5)
            {
                errorProvider1.SetError(codigoPostalTextBox, "El campo Código Postal debe ser numérico y tener un máximo de 5 caracteres.");
            }
            else
            {
                errorProvider1.SetError(codigoPostalTextBox, ""); // Limpia el mensaje de error
            }


            // Validar horaInicioTextBox
            TimeSpan horaInicio;
            if (string.IsNullOrWhiteSpace(horaInicioTextBox.Text) ||
                !TimeSpan.TryParseExact(horaInicioTextBox.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out horaInicio))
            {
                errorProvider1.SetError(horaInicioTextBox, "Formato incorrecto para Hora de Inicio. Debe ser en el formato 01:00:00.");
            }
            else
            {
                errorProvider1.SetError(horaInicioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar horaFinTextBox
            TimeSpan horaFin;
            if (string.IsNullOrWhiteSpace(horaFinTextBox.Text) ||
                !TimeSpan.TryParseExact(horaFinTextBox.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out horaFin))
            {
                errorProvider1.SetError(horaFinTextBox, "Formato incorrecto para Hora de Fin. Debe ser en el formato 01:00:00.");
            }
            else
            {
                errorProvider1.SetError(horaFinTextBox, ""); // Limpia el mensaje de error
            }

            // Validar costoRutaTextBox
            decimal costoRuta;
            if (string.IsNullOrWhiteSpace(costoRutaTextBox.Text))
            {
                errorProvider1.SetError(costoRutaTextBox, "El campo Costo Ruta no puede estar vacío.");
            }
            else if (!decimal.TryParse(costoRutaTextBox.Text.Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out costoRuta) ||
                     costoRutaTextBox.Text.Length > 20 ||
                     !Regex.IsMatch(costoRutaTextBox.Text, @"^\d{1,15}(\,\d{1,4})?$"))
            {
                errorProvider1.SetError(costoRutaTextBox, "Formato incorrecto para Costo Ruta. Debe ser un número con hasta 15 dígitos y 4 decimales, utilizando coma como separador decimal.");
            }
            else
            {
                errorProvider1.SetError(costoRutaTextBox, ""); // Limpia el mensaje de error
            }
            // Verificar si todos los campos tienen errores vacíos
            if (errorProvider1.GetError(direccionTextBox) == "" &&
                errorProvider1.GetError(codigoPostalTextBox) == "" &&
                errorProvider1.GetError(horaInicioTextBox) == "" &&
                errorProvider1.GetError(horaFinTextBox) == "" &&
                errorProvider1.GetError(costoRutaTextBox) == "")
            {
                // Todos los ErrorProvider están vacíos, por lo tanto, puedes realizar las acciones deseadas.
                ruta_DetalleBindingSource.EndEdit();
                DeshabilitarBotones();
                botonGuardar.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ruta_DetalleBindingSource.CancelEdit();
            DeshabilitarBotones();
        }

        private void botonInforme_Click(object sender, EventArgs e)
        {
            InformeRutasDetalle informeRutasDetalle = new InformeRutasDetalle();
            informeRutasDetalle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformeCamiones informeCamiones = new InformeCamiones();
            informeCamiones.Show();
        }

        private void rutasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.rutasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transGlobalDataSet);

        }

        private void rutasBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.rutasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transGlobalDataSet);

        }

        private void costoRutaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                botonAceptar.PerformClick();
            }
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\..\\Crear documentación chm\\TransGlobal.chm", "Rutas.htm");
        }
    }
}
