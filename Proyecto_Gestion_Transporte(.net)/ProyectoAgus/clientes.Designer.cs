namespace ProyectoAgus
{
    partial class clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label clienteIDLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label tipoClienteLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            this.buscar = new System.Windows.Forms.TextBox();
            this.buscarComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transGlobalDataSet = new ProyectoAgus.TransGlobalDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager();
            this.clienteIDTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.provinciaTextBox = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.codigoPostalTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipoClienteComboBox = new System.Windows.Forms.ComboBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonImprimir = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.botonAdd = new System.Windows.Forms.Button();
            this.botonFinal = new System.Windows.Forms.Button();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.botonAnterior = new System.Windows.Forms.Button();
            this.botonPrincipio = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.botonAyuda = new System.Windows.Forms.Button();
            clienteIDLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            tipoClienteLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteIDLabel
            // 
            clienteIDLabel.AutoSize = true;
            clienteIDLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            clienteIDLabel.Location = new System.Drawing.Point(51, 99);
            clienteIDLabel.Name = "clienteIDLabel";
            clienteIDLabel.Size = new System.Drawing.Size(23, 13);
            clienteIDLabel.TabIndex = 340;
            clienteIDLabel.Text = "ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.SystemColors.Control;
            nombreLabel.Location = new System.Drawing.Point(51, 125);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(56, 14);
            nombreLabel.TabIndex = 342;
            nombreLabel.Text = "Nombre:";
            // 
            // tipoClienteLabel
            // 
            tipoClienteLabel.AutoSize = true;
            tipoClienteLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoClienteLabel.ForeColor = System.Drawing.SystemColors.Control;
            tipoClienteLabel.Location = new System.Drawing.Point(51, 151);
            tipoClienteLabel.Name = "tipoClienteLabel";
            tipoClienteLabel.Size = new System.Drawing.Size(76, 13);
            tipoClienteLabel.TabIndex = 344;
            tipoClienteLabel.Text = "Tipo Cliente:";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dniLabel.ForeColor = System.Drawing.SystemColors.Control;
            dniLabel.Location = new System.Drawing.Point(51, 177);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(53, 13);
            dniLabel.TabIndex = 346;
            dniLabel.Text = "DNI/CIF:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            provinciaLabel.ForeColor = System.Drawing.SystemColors.Control;
            provinciaLabel.Location = new System.Drawing.Point(524, 122);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(60, 13);
            provinciaLabel.TabIndex = 348;
            provinciaLabel.Text = "Provincia:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localidadLabel.ForeColor = System.Drawing.SystemColors.Control;
            localidadLabel.Location = new System.Drawing.Point(524, 148);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(61, 13);
            localidadLabel.TabIndex = 350;
            localidadLabel.Text = "Localidad:";
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoPostalLabel.ForeColor = System.Drawing.SystemColors.Control;
            codigoPostalLabel.Location = new System.Drawing.Point(524, 174);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new System.Drawing.Size(83, 13);
            codigoPostalLabel.TabIndex = 352;
            codigoPostalLabel.Text = "Codigo Postal:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.ForeColor = System.Drawing.SystemColors.Control;
            direccionLabel.Location = new System.Drawing.Point(524, 200);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(61, 13);
            direccionLabel.TabIndex = 354;
            direccionLabel.Text = "Direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.ForeColor = System.Drawing.SystemColors.Control;
            telefonoLabel.Location = new System.Drawing.Point(51, 203);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(55, 13);
            telefonoLabel.TabIndex = 356;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.ForeColor = System.Drawing.SystemColors.Control;
            correoLabel.Location = new System.Drawing.Point(51, 229);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(45, 13);
            correoLabel.TabIndex = 358;
            correoLabel.Text = "E-mail:";
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(591, 12);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(100, 22);
            this.buscar.TabIndex = 10;
            this.buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buscar_KeyDown);
            // 
            // buscarComboBox
            // 
            this.buscarComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.buscarComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarComboBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarComboBox.ForeColor = System.Drawing.Color.Black;
            this.buscarComboBox.FormattingEnabled = true;
            this.buscarComboBox.Items.AddRange(new object[] {
            "Buscar por Id",
            "Buscar por Nombre",
            "Buscar por DNI/CIF",
            "Buscar por Correo"});
            this.buscarComboBox.Location = new System.Drawing.Point(463, 12);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(121, 21);
            this.buscarComboBox.TabIndex = 317;
            this.buscarComboBox.TabStop = false;
            this.buscarComboBox.Text = "Buscar por Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(68, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 311;
            this.label1.Text = "Cliente x de x";
            // 
            // transGlobalDataSet
            // 
            this.transGlobalDataSet.DataSetName = "TransGlobalDataSet";
            this.transGlobalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.transGlobalDataSet;
            this.clientesBindingSource.PositionChanged += new System.EventHandler(this.clientesBindingSource_PositionChanged);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CamionesTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.Ruta_DetalleTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Ventas_DetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // clienteIDTextBox
            // 
            this.clienteIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "ClienteID", true));
            this.clienteIDTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteIDTextBox.Location = new System.Drawing.Point(132, 96);
            this.clienteIDTextBox.Name = "clienteIDTextBox";
            this.clienteIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.clienteIDTextBox.TabIndex = 341;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(132, 122);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombreTextBox_KeyDown);
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "dni", true));
            this.dniTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniTextBox.Location = new System.Drawing.Point(132, 174);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(80, 22);
            this.dniTextBox.TabIndex = 3;
            this.dniTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dniTextBox_KeyDown);
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Provincia", true));
            this.provinciaTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinciaTextBox.Location = new System.Drawing.Point(611, 119);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.Size = new System.Drawing.Size(134, 22);
            this.provinciaTextBox.TabIndex = 4;
            this.provinciaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.provinciaTextBox_KeyDown);
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Localidad", true));
            this.localidadTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadTextBox.Location = new System.Drawing.Point(611, 145);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(134, 22);
            this.localidadTextBox.TabIndex = 5;
            this.localidadTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.localidadTextBox_KeyDown);
            // 
            // codigoPostalTextBox
            // 
            this.codigoPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CodigoPostal", true));
            this.codigoPostalTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoPostalTextBox.Location = new System.Drawing.Point(611, 171);
            this.codigoPostalTextBox.Name = "codigoPostalTextBox";
            this.codigoPostalTextBox.Size = new System.Drawing.Size(66, 22);
            this.codigoPostalTextBox.TabIndex = 6;
            this.codigoPostalTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codigoPostalTextBox_KeyDown);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(611, 197);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(134, 22);
            this.direccionTextBox.TabIndex = 7;
            this.direccionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.direccionTextBox_KeyDown);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(132, 200);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(80, 22);
            this.telefonoTextBox.TabIndex = 8;
            this.telefonoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.telefonoTextBox_KeyDown);
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Correo", true));
            this.correoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(132, 226);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(100, 22);
            this.correoTextBox.TabIndex = 9;
            this.correoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.correoTextBox_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tipoClienteComboBox
            // 
            this.tipoClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "TipoCliente", true));
            this.tipoClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoClienteComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoClienteComboBox.FormattingEnabled = true;
            this.tipoClienteComboBox.Items.AddRange(new object[] {
            "Particular",
            "Empresa"});
            this.tipoClienteComboBox.Location = new System.Drawing.Point(132, 148);
            this.tipoClienteComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tipoClienteComboBox.Name = "tipoClienteComboBox";
            this.tipoClienteComboBox.Size = new System.Drawing.Size(100, 21);
            this.tipoClienteComboBox.TabIndex = 2;
            this.tipoClienteComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipoClienteComboBox_KeyDown);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.fotoPictureBox.BackgroundImage = global::ProyectoAgus.Properties.Resources.foto2;
            this.fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fotoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clientesBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(257, 55);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(253, 237);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox.TabIndex = 361;
            this.fotoPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.fotoPictureBox, "Haz click para añadir o cambiar una imagen");
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.FlatAppearance.BorderSize = 0;
            this.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrar.Image = global::ProyectoAgus.Properties.Resources.salirazul;
            this.botonCerrar.Location = new System.Drawing.Point(12, 267);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(32, 28);
            this.botonCerrar.TabIndex = 339;
            this.botonCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonCerrar, "Salir");
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAceptar.FlatAppearance.BorderSize = 0;
            this.botonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAceptar.Image = global::ProyectoAgus.Properties.Resources.aceptar;
            this.botonAceptar.Location = new System.Drawing.Point(679, 225);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(30, 30);
            this.botonAceptar.TabIndex = 321;
            this.botonAceptar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAceptar, "Aceptar");
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelar.FlatAppearance.BorderSize = 0;
            this.botonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCancelar.Image = global::ProyectoAgus.Properties.Resources.cancelar;
            this.botonCancelar.Location = new System.Drawing.Point(715, 225);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(28, 30);
            this.botonCancelar.TabIndex = 320;
            this.botonCancelar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonCancelar, "Cancelar");
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonImprimir
            // 
            this.botonImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonImprimir.FlatAppearance.BorderSize = 0;
            this.botonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonImprimir.Image = global::ProyectoAgus.Properties.Resources.informe;
            this.botonImprimir.Location = new System.Drawing.Point(428, 6);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(29, 33);
            this.botonImprimir.TabIndex = 319;
            this.botonImprimir.TabStop = false;
            this.toolTip1.SetToolTip(this.botonImprimir, "Informe del cliente");
            this.botonImprimir.UseVisualStyleBackColor = true;
            this.botonImprimir.Click += new System.EventHandler(this.botonImprimir_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscar.FlatAppearance.BorderSize = 0;
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscar.Image = global::ProyectoAgus.Properties.Resources.buscar;
            this.botonBuscar.Location = new System.Drawing.Point(697, 8);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(31, 29);
            this.botonBuscar.TabIndex = 318;
            this.botonBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonBuscar, "Buscar");
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonGuardar.Enabled = false;
            this.botonGuardar.FlatAppearance.BorderSize = 0;
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGuardar.Image = global::ProyectoAgus.Properties.Resources.guardar;
            this.botonGuardar.Location = new System.Drawing.Point(379, 8);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(32, 29);
            this.botonGuardar.TabIndex = 315;
            this.botonGuardar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonGuardar, "Guardar cliente");
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEditar.FlatAppearance.BorderSize = 0;
            this.botonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditar.Image = global::ProyectoAgus.Properties.Resources.editar;
            this.botonEditar.Location = new System.Drawing.Point(340, 7);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(35, 30);
            this.botonEditar.TabIndex = 314;
            this.botonEditar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonEditar, "Editar cliente");
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBorrar.FlatAppearance.BorderSize = 0;
            this.botonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBorrar.Image = global::ProyectoAgus.Properties.Resources.borrar;
            this.botonBorrar.Location = new System.Drawing.Point(295, 4);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(30, 34);
            this.botonBorrar.TabIndex = 313;
            this.botonBorrar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonBorrar, "Borrar cliente");
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // botonAdd
            // 
            this.botonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAdd.FlatAppearance.BorderSize = 0;
            this.botonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAdd.Image = global::ProyectoAgus.Properties.Resources.añadir;
            this.botonAdd.Location = new System.Drawing.Point(257, 5);
            this.botonAdd.Name = "botonAdd";
            this.botonAdd.Size = new System.Drawing.Size(32, 33);
            this.botonAdd.TabIndex = 312;
            this.botonAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAdd, "Añadir cliente");
            this.botonAdd.UseVisualStyleBackColor = true;
            this.botonAdd.Click += new System.EventHandler(this.botonAdd_Click);
            // 
            // botonFinal
            // 
            this.botonFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonFinal.FlatAppearance.BorderSize = 0;
            this.botonFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonFinal.Image = global::ProyectoAgus.Properties.Resources.doblederecha3;
            this.botonFinal.Location = new System.Drawing.Point(218, 7);
            this.botonFinal.Name = "botonFinal";
            this.botonFinal.Size = new System.Drawing.Size(31, 29);
            this.botonFinal.TabIndex = 310;
            this.botonFinal.TabStop = false;
            this.toolTip1.SetToolTip(this.botonFinal, "Último cliente");
            this.botonFinal.UseVisualStyleBackColor = true;
            this.botonFinal.Click += new System.EventHandler(this.botonFinal_Click);
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSiguiente.FlatAppearance.BorderSize = 0;
            this.botonSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSiguiente.Image = global::ProyectoAgus.Properties.Resources.adelante;
            this.botonSiguiente.Location = new System.Drawing.Point(184, 9);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(28, 24);
            this.botonSiguiente.TabIndex = 309;
            this.botonSiguiente.TabStop = false;
            this.toolTip1.SetToolTip(this.botonSiguiente, "Siguiente cliente");
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // botonAnterior
            // 
            this.botonAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAnterior.FlatAppearance.BorderSize = 0;
            this.botonAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAnterior.Image = global::ProyectoAgus.Properties.Resources.retroceder1;
            this.botonAnterior.Location = new System.Drawing.Point(38, 9);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(29, 23);
            this.botonAnterior.TabIndex = 308;
            this.botonAnterior.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAnterior, "Cliente anterior");
            this.botonAnterior.UseVisualStyleBackColor = true;
            this.botonAnterior.Click += new System.EventHandler(this.botonAnterior_Click);
            // 
            // botonPrincipio
            // 
            this.botonPrincipio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonPrincipio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonPrincipio.FlatAppearance.BorderSize = 0;
            this.botonPrincipio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPrincipio.Image = global::ProyectoAgus.Properties.Resources.dobleizquierda1;
            this.botonPrincipio.Location = new System.Drawing.Point(6, 9);
            this.botonPrincipio.Name = "botonPrincipio";
            this.botonPrincipio.Size = new System.Drawing.Size(30, 24);
            this.botonPrincipio.TabIndex = 307;
            this.botonPrincipio.TabStop = false;
            this.toolTip1.SetToolTip(this.botonPrincipio, "Primer cliente");
            this.botonPrincipio.UseVisualStyleBackColor = true;
            this.botonPrincipio.Click += new System.EventHandler(this.botonPrincipio_Click);
            // 
            // botonAyuda
            // 
            this.botonAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAyuda.FlatAppearance.BorderSize = 0;
            this.botonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAyuda.Image = global::ProyectoAgus.Properties.Resources.ayudaazul;
            this.botonAyuda.Location = new System.Drawing.Point(734, 8);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Size = new System.Drawing.Size(31, 29);
            this.botonAyuda.TabIndex = 362;
            this.botonAyuda.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAyuda, "Buscar");
            this.botonAyuda.UseVisualStyleBackColor = true;
            this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(766, 307);
            this.Controls.Add(this.botonAyuda);
            this.Controls.Add(this.tipoClienteComboBox);
            this.Controls.Add(clienteIDLabel);
            this.Controls.Add(this.clienteIDTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(tipoClienteLabel);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(provinciaLabel);
            this.Controls.Add(this.provinciaTextBox);
            this.Controls.Add(localidadLabel);
            this.Controls.Add(this.localidadTextBox);
            this.Controls.Add(codigoPostalLabel);
            this.Controls.Add(this.codigoPostalTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonImprimir);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.buscarComboBox);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonFinal);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.botonAnterior);
            this.Controls.Add(this.botonPrincipio);
            this.Name = "clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonImprimir;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.ComboBox buscarComboBox;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button botonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonFinal;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Button botonAnterior;
        private System.Windows.Forms.Button botonPrincipio;
        private TransGlobalDataSet transGlobalDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private TransGlobalDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private TransGlobalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox clienteIDTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox provinciaTextBox;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox codigoPostalTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox tipoClienteComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button botonAyuda;
    }
}