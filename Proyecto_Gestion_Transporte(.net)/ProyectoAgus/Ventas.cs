using Microsoft.Reporting.WinForms;
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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            DeshabilitarBotones();
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transGlobalDataSet);
        }

        private void VentasBueno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.transGlobalDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.transGlobalDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Ventas_Detalle' Puede moverla o quitarla según sea necesario.
            this.ventas_DetalleTableAdapter.Fill(this.transGlobalDataSet.Ventas_Detalle);
            // TODO: esta línea de código carga datos en la tabla 'transGlobalDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.transGlobalDataSet.Ventas);
           

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
                        ventasBindingSource.EndEdit();
                        ventas_DetalleBindingSource.EndEdit();
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

        private void botonPrincipio_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveFirst();
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MovePrevious();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveNext();
        }

        private void botonFinal_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveLast();
        }

        private void botonAdd_Click(object sender, EventArgs e)
        {
            // Validar clienteIDComboBox
            if (string.IsNullOrWhiteSpace(clienteIDComboBox.Text))
            {
                errorProvider1.SetError(clienteIDComboBox, "Cliente ID no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(clienteIDComboBox, ""); // Limpia el mensaje de error
            }

            // Validar telefonoClienteTextBox
            if (string.IsNullOrWhiteSpace(telefonoClienteTextBox.Text))
            {
                errorProvider1.SetError(telefonoClienteTextBox, "Teléfono no puede estar vacío.");
            }
            else if (!int.TryParse(telefonoClienteTextBox.Text, out _))
            {
                errorProvider1.SetError(telefonoClienteTextBox, "Teléfono debe ser numérico.");
            }
            else if (telefonoClienteTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(telefonoClienteTextBox, "Teléfono debe tener hasta 9 dígitos.");
            }
            else
            {
                errorProvider1.SetError(telefonoClienteTextBox, ""); // Limpia el mensaje de error
            }

            // Validar emailClienteTextBox
            if (string.IsNullOrWhiteSpace(emailClienteTextBox.Text))
            {
                errorProvider1.SetError(emailClienteTextBox, "Email no puede estar vacío.");
            }
            else if (emailClienteTextBox.Text.Length > 100)
            {
                errorProvider1.SetError(emailClienteTextBox, "Email no puede tener más de 100 caracteres.");
            }
            else
            {
                errorProvider1.SetError(emailClienteTextBox, ""); // Limpia el mensaje de error
            }

            // Validar direccionEnvioTextBox
            if (string.IsNullOrWhiteSpace(direccionEnvioTextBox.Text))
            {
                errorProvider1.SetError(direccionEnvioTextBox, "Dirección de envío no puede estar vacía.");
            }
            else if (direccionEnvioTextBox.Text.Length > 150)
            {
                errorProvider1.SetError(direccionEnvioTextBox, "Dirección de envío no puede tener más de 150 caracteres.");
            }
            else
            {
                errorProvider1.SetError(direccionEnvioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar precioTextBox
            decimal precio;
            if (string.IsNullOrWhiteSpace(precioTextBox.Text))
            {
                errorProvider1.SetError(precioTextBox, "Precio no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioTextBox.Text, out precio) ||
                     precioTextBox.Text.Length > 13)
            {
                errorProvider1.SetError(precioTextBox, "Formato incorrecto para Precio. Debe ser un número con hasta 8 dígitos enteros y 4 decimales.");
            }
            else
            {
                errorProvider1.SetError(precioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar metodoPagoComboBox
            if (string.IsNullOrWhiteSpace(metodoPagoComboBox.Text))
            {
                errorProvider1.SetError(metodoPagoComboBox, "Método de pago no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(metodoPagoComboBox, ""); // Limpia el mensaje de error
            }

            // Validar observacionesTextBox
            if (observacionesTextBox.Text.Length > 254)
            {
                errorProvider1.SetError(observacionesTextBox, "Observaciones no pueden tener más de 254 caracteres.");
            }
            else
            {
                errorProvider1.SetError(observacionesTextBox, ""); // Limpia el mensaje de error
            }

            // Validar productoIDComboBox
            if (string.IsNullOrWhiteSpace(productoIDComboBox.Text))
            {
                errorProvider1.SetError(productoIDComboBox, "Producto ID no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(productoIDComboBox, ""); // Limpia el mensaje de error
            }

            // Validar precioUnitarioTextBox
            decimal precioUnitario;
            if (string.IsNullOrWhiteSpace(precioUnitarioTextBox.Text))
            {
                errorProvider1.SetError(precioUnitarioTextBox, "Precio unitario no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioUnitarioTextBox.Text, out precioUnitario) ||
                     precioUnitarioTextBox.Text.Length > 13)
            {
                errorProvider1.SetError(precioUnitarioTextBox, "Formato incorrecto para Precio unitario. Debe ser un número con hasta 8 dígitos enteros y 4 decimales.");
            }
            else
            {
                errorProvider1.SetError(precioUnitarioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar cantidadTextBox
            int cantidad;
            if (string.IsNullOrWhiteSpace(cantidadTextBox.Text))
            {
                errorProvider1.SetError(cantidadTextBox, "Cantidad no puede estar vacía.");
            }
            else if (!int.TryParse(cantidadTextBox.Text, out cantidad) ||
                     cantidadTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(cantidadTextBox, "Cantidad debe ser un número con hasta 9 dígitos.");
            }
            else
            {
                errorProvider1.SetError(cantidadTextBox, ""); // Limpia el mensaje de error
            }

            // Validar precioTotalTextBox
            decimal precioTotal;
            if (string.IsNullOrWhiteSpace(precioTotalTextBox.Text))
            {
                errorProvider1.SetError(precioTotalTextBox, "Precio total no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioTotalTextBox.Text, out precioTotal) ||
                     precioTotalTextBox.Text.Length > 13)
            {
                errorProvider1.SetError(precioTotalTextBox, "Formato incorrecto para Precio total. Debe ser un número con hasta 8 dígitos enteros y 4 decimales.");
            }
            else
            {
                errorProvider1.SetError(precioTotalTextBox, ""); // Limpia el mensaje de error
            }
            // Verifica si hay algún error en alguno de los controles
            if (errorProvider1.GetError(clienteIDComboBox) == "" &&
                errorProvider1.GetError(telefonoClienteTextBox) == "" &&
                errorProvider1.GetError(emailClienteTextBox) == "" &&
                errorProvider1.GetError(direccionEnvioTextBox) == "" &&
                errorProvider1.GetError(precioTextBox) == "" &&
                errorProvider1.GetError(metodoPagoComboBox) == "" &&
                errorProvider1.GetError(observacionesTextBox) == "" &&
                errorProvider1.GetError(productoIDComboBox) == "" &&
                errorProvider1.GetError(precioUnitarioTextBox) == "" &&
                errorProvider1.GetError(cantidadTextBox) == "" &&
                errorProvider1.GetError(precioTotalTextBox) == "")
            {
                // No hay errores en los controles, puedes continuar con las acciones adicionales
                ventasBindingSource.AddNew();
                ventas_DetalleBindingSource.AddNew();
                fechaVentaDateTimePicker.Value = DateTime.Now;
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
                ventasBindingSource.RemoveCurrent();
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
                ventasBindingSource.EndEdit();
                ventas_DetalleBindingSource.EndEdit();
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
            // Validar clienteIDComboBox
            if (string.IsNullOrWhiteSpace(clienteIDComboBox.Text))
            {
                errorProvider1.SetError(clienteIDComboBox, "Cliente ID no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(clienteIDComboBox, ""); // Limpia el mensaje de error
            }

            // Validar telefonoClienteTextBox
            if (string.IsNullOrWhiteSpace(telefonoClienteTextBox.Text))
            {
                errorProvider1.SetError(telefonoClienteTextBox, "Teléfono no puede estar vacío.");
            }
            else if (!int.TryParse(telefonoClienteTextBox.Text, out _))
            {
                errorProvider1.SetError(telefonoClienteTextBox, "Teléfono debe ser numérico.");
            }
            else if (telefonoClienteTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(telefonoClienteTextBox, "Teléfono debe tener hasta 9 dígitos.");
            }
            else
            {
                errorProvider1.SetError(telefonoClienteTextBox, ""); // Limpia el mensaje de error
            }

            // Validar emailClienteTextBox
            if (string.IsNullOrWhiteSpace(emailClienteTextBox.Text))
            {
                errorProvider1.SetError(emailClienteTextBox, "Email no puede estar vacío.");
            }
            else if (emailClienteTextBox.Text.Length > 100)
            {
                errorProvider1.SetError(emailClienteTextBox, "Email no puede tener más de 100 caracteres.");
            }
            else
            {
                errorProvider1.SetError(emailClienteTextBox, ""); // Limpia el mensaje de error
            }

            // Validar direccionEnvioTextBox
            if (string.IsNullOrWhiteSpace(direccionEnvioTextBox.Text))
            {
                errorProvider1.SetError(direccionEnvioTextBox, "Dirección de envío no puede estar vacía.");
            }
            else if (direccionEnvioTextBox.Text.Length > 150)
            {
                errorProvider1.SetError(direccionEnvioTextBox, "Dirección de envío no puede tener más de 150 caracteres.");
            }
            else
            {
                errorProvider1.SetError(direccionEnvioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar precioTextBox
            decimal precio;
            if (string.IsNullOrWhiteSpace(precioTextBox.Text))
            {
                errorProvider1.SetError(precioTextBox, "Precio no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioTextBox.Text, out precio) ||
                     precioTextBox.Text.Length > 13)
            {
                errorProvider1.SetError(precioTextBox, "Formato incorrecto para Precio. Debe ser un número con hasta 8 dígitos enteros y 4 decimales.");
            }
            else
            {
                errorProvider1.SetError(precioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar metodoPagoComboBox
            if (string.IsNullOrWhiteSpace(metodoPagoComboBox.Text))
            {
                errorProvider1.SetError(metodoPagoComboBox, "Método de pago no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(metodoPagoComboBox, ""); // Limpia el mensaje de error
            }

            // Validar observacionesTextBox
            if (observacionesTextBox.Text.Length > 254)
            {
                errorProvider1.SetError(observacionesTextBox, "Observaciones no pueden tener más de 254 caracteres.");
            }
            else
            {
                errorProvider1.SetError(observacionesTextBox, ""); // Limpia el mensaje de error
            }

            // Validar productoIDComboBox
            if (string.IsNullOrWhiteSpace(productoIDComboBox.Text))
            {
                errorProvider1.SetError(productoIDComboBox, "Producto ID no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(productoIDComboBox, ""); // Limpia el mensaje de error
            }

            // Validar precioUnitarioTextBox
            decimal precioUnitario;
            if (string.IsNullOrWhiteSpace(precioUnitarioTextBox.Text))
            {
                errorProvider1.SetError(precioUnitarioTextBox, "Precio unitario no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioUnitarioTextBox.Text, out precioUnitario) ||
                     precioUnitarioTextBox.Text.Length > 13)
            {
                errorProvider1.SetError(precioUnitarioTextBox, "Formato incorrecto para Precio unitario. Debe ser un número con hasta 8 dígitos enteros y 4 decimales.");
            }
            else
            {
                errorProvider1.SetError(precioUnitarioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar cantidadTextBox
            int cantidad;
            if (string.IsNullOrWhiteSpace(cantidadTextBox.Text))
            {
                errorProvider1.SetError(cantidadTextBox, "Cantidad no puede estar vacía.");
            }
            else if (!int.TryParse(cantidadTextBox.Text, out cantidad) ||
                     cantidadTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(cantidadTextBox, "Cantidad debe ser un número con hasta 9 dígitos.");
            }
            else
            {
                errorProvider1.SetError(cantidadTextBox, ""); // Limpia el mensaje de error
            }

            // Validar precioTotalTextBox
            decimal precioTotal;
            if (string.IsNullOrWhiteSpace(precioTotalTextBox.Text))
            {
                errorProvider1.SetError(precioTotalTextBox, "Precio total no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioTotalTextBox.Text, out precioTotal) ||
                     precioTotalTextBox.Text.Length > 13)
            {
                errorProvider1.SetError(precioTotalTextBox, "Formato incorrecto para Precio total. Debe ser un número con hasta 8 dígitos enteros y 4 decimales.");
            }
            else
            {
                errorProvider1.SetError(precioTotalTextBox, ""); // Limpia el mensaje de error
            }
            // Verifica si hay algún error en alguno de los controles
            if (errorProvider1.GetError(clienteIDComboBox) == "" &&
                errorProvider1.GetError(telefonoClienteTextBox) == "" &&
                errorProvider1.GetError(emailClienteTextBox) == "" &&
                errorProvider1.GetError(direccionEnvioTextBox) == "" &&
                errorProvider1.GetError(precioTextBox) == "" &&
                errorProvider1.GetError(metodoPagoComboBox) == "" &&
                errorProvider1.GetError(observacionesTextBox) == "" &&
                errorProvider1.GetError(productoIDComboBox) == "" &&
                errorProvider1.GetError(precioUnitarioTextBox) == "" &&
                errorProvider1.GetError(cantidadTextBox) == "" &&
                errorProvider1.GetError(precioTotalTextBox) == "")
            {
                // No hay errores en los controles, puedes continuar con las acciones adicionales
                ventasBindingSource.EndEdit();
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
            ventasBindingSource.CancelEdit();
            ventas_DetalleBindingSource.CancelEdit();
            DeshabilitarBotones();
            botonPrincipio.Enabled = true;
            botonAnterior.Enabled = true;
            botonSiguiente.Enabled = true;
            botonFinal.Enabled = true;
            botonBuscar.Enabled = true;
        }
        private void HabilitarBotones()
        {
            botonAceptar.Enabled = true;
            botonCancelar.Enabled = true;
            ventaIDTextBox.Enabled = true;
            fechaVentaDateTimePicker.Enabled = true;
            clienteIDComboBox.Enabled = true;
            productoIDComboBox.Enabled = true;
            cantidadTextBox.Enabled = true;
            precioUnitarioTextBox.Enabled = true;
            metodoPagoComboBox.Enabled = true;
            detalleIDTextBox.Enabled = true;
            observacionesTextBox.Enabled = true;
            botonAceptar.Enabled = true;
            botonCancelar.Enabled = true;
            botonNuevo.Enabled = true;
            botonBorrarDetalle.Enabled = true;
            descuentoCheckBox.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;


        }
        private void DeshabilitarBotones()
        {
            botonAceptar.Enabled = false;
            botonCancelar.Enabled = false;
            ventaIDTextBox.Enabled = false;
            fechaVentaDateTimePicker.Enabled = false;
            clienteIDComboBox.Enabled = false;
            productoIDComboBox.Enabled = false;
            cantidadTextBox.Enabled = false;
            precioUnitarioTextBox.Enabled = false;
            metodoPagoComboBox.Enabled = false;
            detalleIDTextBox.Enabled = false;
            observacionesTextBox.Enabled = false;
            botonAceptar.Enabled = false;
            botonCancelar.Enabled = false;
            botonNuevo.Enabled = false;
            descuentoCheckBox.Enabled = false;
            botonBorrarDetalle.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void botonInforme_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numVenta = ventaIDTextBox.Text;
            InformeVentasDetalle informeVentasDetalles = new InformeVentasDetalle();
            informeVentasDetalles.Show();
        }

        private void botonInforme2_Click(object sender, EventArgs e)
        {
            InformeClientes informeClientes = new InformeClientes();
            informeClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InformeProductos informeProductos = new InformeProductos();
            informeProductos.Show();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            // Validar productoIDComboBox
            if (string.IsNullOrWhiteSpace(productoIDComboBox.Text))
            {
                errorProvider1.SetError(productoIDComboBox, "Producto ID no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(productoIDComboBox, ""); // Limpia el mensaje de error
            }

            // Validar precioUnitarioTextBox
            decimal precioUnitario;
            if (string.IsNullOrWhiteSpace(precioUnitarioTextBox.Text))
            {
                errorProvider1.SetError(precioUnitarioTextBox, "Precio unitario no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioUnitarioTextBox.Text, out precioUnitario) ||
                     precioUnitarioTextBox.Text.Length > 13)
            {
                errorProvider1.SetError(precioUnitarioTextBox, "Formato incorrecto para Precio unitario. Debe ser un número con hasta 8 dígitos enteros y 4 decimales.");
            }
            else
            {
                errorProvider1.SetError(precioUnitarioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar cantidadTextBox
            int cantidad;
            if (string.IsNullOrWhiteSpace(cantidadTextBox.Text))
            {
                errorProvider1.SetError(cantidadTextBox, "Cantidad no puede estar vacía.");
            }
            else if (!int.TryParse(cantidadTextBox.Text, out cantidad) ||
                     cantidadTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(cantidadTextBox, "Cantidad debe ser un número con hasta 9 dígitos.");
            }
            else
            {
                errorProvider1.SetError(cantidadTextBox, ""); // Limpia el mensaje de error
            }

            // Validar precioTotalTextBox
            decimal precioTotal;
            if (string.IsNullOrWhiteSpace(precioTotalTextBox.Text))
            {
                errorProvider1.SetError(precioTotalTextBox, "Precio total no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioTotalTextBox.Text, out precioTotal) ||
                     precioTotalTextBox.Text.Length > 13)
            {
                errorProvider1.SetError(precioTotalTextBox, "Formato incorrecto para Precio total. Debe ser un número con hasta 8 dígitos enteros y 4 decimales.");
            }
            else
            {
                errorProvider1.SetError(precioTotalTextBox, ""); // Limpia el mensaje de error
            }
            // Verifica si hay algún error en alguno de los controles
            if (errorProvider1.GetError(clienteIDComboBox) == "" &&
                errorProvider1.GetError(telefonoClienteTextBox) == "" &&
                errorProvider1.GetError(emailClienteTextBox) == "" &&
                errorProvider1.GetError(direccionEnvioTextBox) == "" &&
                errorProvider1.GetError(precioTextBox) == "" &&
                errorProvider1.GetError(metodoPagoComboBox) == "" &&
                errorProvider1.GetError(observacionesTextBox) == "" &&
                errorProvider1.GetError(productoIDComboBox) == "" &&
                errorProvider1.GetError(precioUnitarioTextBox) == "" &&
                errorProvider1.GetError(cantidadTextBox) == "" &&
                errorProvider1.GetError(precioTotalTextBox) == "")
            {
                ventas_DetalleBindingSource.AddNew();
                HabilitarBotones();
            }
        }

        private void botonBorrarDetalle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Borrar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ventas_DetalleBindingSource.RemoveCurrent();
                DeshabilitarBotones();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validar productoIDComboBox
            if (string.IsNullOrWhiteSpace(productoIDComboBox.Text))
            {
                errorProvider1.SetError(productoIDComboBox, "Producto ID no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(productoIDComboBox, ""); // Limpia el mensaje de error
            }

            // Validar precioUnitarioTextBox
            decimal precioUnitario;
            if (string.IsNullOrWhiteSpace(precioUnitarioTextBox.Text))
            {
                errorProvider1.SetError(precioUnitarioTextBox, "Precio unitario no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioUnitarioTextBox.Text, out precioUnitario) ||
                     precioUnitarioTextBox.Text.Length > 13)
            {
                errorProvider1.SetError(precioUnitarioTextBox, "Formato incorrecto para Precio unitario. Debe ser un número con hasta 8 dígitos enteros y 4 decimales.");
            }
            else
            {
                errorProvider1.SetError(precioUnitarioTextBox, ""); // Limpia el mensaje de error
            }

            // Validar cantidadTextBox
            int cantidad;
            if (string.IsNullOrWhiteSpace(cantidadTextBox.Text))
            {
                errorProvider1.SetError(cantidadTextBox, "Cantidad no puede estar vacía.");
            }
            else if (!int.TryParse(cantidadTextBox.Text, out cantidad) ||
                     cantidadTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(cantidadTextBox, "Cantidad debe ser un número con hasta 9 dígitos.");
            }
            else
            {
                errorProvider1.SetError(cantidadTextBox, ""); // Limpia el mensaje de error
            }

            // Validar precioTotalTextBox
            decimal precioTotal;
            if (string.IsNullOrWhiteSpace(precioTotalTextBox.Text))
            {
                errorProvider1.SetError(precioTotalTextBox, "Precio total no puede estar vacío.");
            }
            else if (!decimal.TryParse(precioTotalTextBox.Text, out precioTotal) ||
                     precioTotalTextBox.Text.Length > 13)
            {
                errorProvider1.SetError(precioTotalTextBox, "Formato incorrecto para Precio total. Debe ser un número con hasta 8 dígitos enteros y 4 decimales.");
            }
            else
            {
                errorProvider1.SetError(precioTotalTextBox, ""); // Limpia el mensaje de error
            }
            // Verifica si hay algún error en alguno de los controles
            if (errorProvider1.GetError(clienteIDComboBox) == "" &&
                errorProvider1.GetError(telefonoClienteTextBox) == "" &&
                errorProvider1.GetError(emailClienteTextBox) == "" &&
                errorProvider1.GetError(direccionEnvioTextBox) == "" &&
                errorProvider1.GetError(precioTextBox) == "" &&
                errorProvider1.GetError(metodoPagoComboBox) == "" &&
                errorProvider1.GetError(observacionesTextBox) == "" &&
                errorProvider1.GetError(productoIDComboBox) == "" &&
                errorProvider1.GetError(precioUnitarioTextBox) == "" &&
                errorProvider1.GetError(cantidadTextBox) == "" &&
                errorProvider1.GetError(precioTotalTextBox) == "")
            {
                ventas_DetalleBindingSource.EndEdit();
                botonGuardar.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ventas_DetalleBindingSource.CancelEdit();
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
                case "Buscar por Email":
                    BuscarPorEmail(valorBusqueda);
                    break;
                case "Buscar por Direccion":
                    BuscarPorDireccion(valorBusqueda);
                    break;
                default:
                    MessageBox.Show("Filtro no válido");
                    break;
            }
        }
        private void BuscarPorNombre(string nombre)
        {
            int index = ventasBindingSource.Find("Nombre", nombre);
            MostrarResultadoBusqueda(index, "Nombre");
        }
        private void BuscarPorId(string id)
        {
            int idBusqueda;
            if (int.TryParse(id, out idBusqueda))
            {
                int index = ventasBindingSource.Find("VentaID", idBusqueda);
                if (index == -1)
                {
                    MessageBox.Show("No existe una venta con ese ID.");
                }
                else
                {
                    ventasBindingSource.Position = index;
                }
            }
            else
            {
                MessageBox.Show("ID no válido. Ingresa un número entero.");
            }
        }
        private void BuscarPorEmail(string email)
        {
            int index = ventasBindingSource.Find("EmailCliente", email);
            MostrarResultadoBusqueda(index, "EmailCliente");
        }
        private void BuscarPorDireccion(string direccion)
        {
            int index = ventasBindingSource.Find("DireccionEnvio", direccion);
            MostrarResultadoBusqueda(index, "DireccionEnvio");
        }
        private void MostrarResultadoBusqueda(int index, string filtro)
        {
            if (index == -1)
            {
                MessageBox.Show($"No existe una venta con ese {filtro}.");
            }
            else
            {
                ventasBindingSource.Position = index;
            }
        }

        private void cantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void precioTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            int ventaID;
            if (int.TryParse(ventaIDTextBox.Text, out ventaID))
            {
                // Obtén la vista de la tabla Ventas_Detalle
                DataView vistaDetalle = ((DataView)ventas_DetalleBindingSource.List);

                // Filtra las filas con el VentaID ingresado
                var filasFiltradas = vistaDetalle
                    .Cast<DataRowView>()
                    .Where(fila => Convert.ToInt32(fila["VentaID"]) == ventaID);

                // Calcula la suma de los precios totales, maneja DBNull
                decimal sumaPrecios = filasFiltradas.Sum(fila =>
                {
                    object valorPrecioTotal = fila["PrecioTotal"];
                    return (valorPrecioTotal != DBNull.Value) ? Convert.ToDecimal(valorPrecioTotal) : 0;
                });

                // Muestra la suma en el TextBox precioTextBox
                precioTextBox.Text = sumaPrecios.ToString();
            }
        }

        private void clienteIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransGlobalDataSet.ClientesRow cliente;
            if (clienteIDComboBox.SelectedIndex != -1)
            {
                cliente = transGlobalDataSet.Clientes[clienteIDComboBox.SelectedIndex];
                nombreClienteTextBox.Text = cliente.Nombre.ToString();
                telefonoClienteTextBox.Text = cliente.Telefono.ToString();
                emailClienteTextBox.Text = cliente.Correo.ToString();
                direccionEnvioTextBox.Text = cliente.Direccion.ToString();
            }
        }

        private void productoIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransGlobalDataSet.ProductoRow productocompra;
            if (productoIDComboBox.SelectedIndex != -1)
            {
                productocompra = transGlobalDataSet.Producto[productoIDComboBox.SelectedIndex];
                nombreProductoTextBox.Text = productocompra.Nombre.ToString();
                precioUnitarioTextBox.Text = productocompra.Precio.ToString();
                cantidadTextBox.Text = "1";

            }
        }

        private void cantidadTextBox_TextChanged_1(object sender, EventArgs e)
        {
            double.TryParse(precioUnitarioTextBox.Text, out double precio);
            double.TryParse(cantidadTextBox.Text, out double cant);

            precioTotalTextBox.Text = (precio * cant).ToString();
        }

        private void ventasBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = "Venta " + (ventasBindingSource.Position + 1) + " de " + (ventasBindingSource.Count);
        }

        private void cantidadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                botonAceptar.PerformClick();
            }
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\..\\Crear documentación chm\\TransGlobal.chm", "Ventas.htm");
        }
    }
}
