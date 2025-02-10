namespace ProyectoAgus
{
    partial class rutas
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
			System.Windows.Forms.Label rutaIDLabel;
			System.Windows.Forms.Label origenLabel;
			System.Windows.Forms.Label destinoLabel;
			System.Windows.Forms.Label distanciaKMLabel;
			System.Windows.Forms.Label empleadoIDLabel;
			System.Windows.Forms.Label camionIDLabel;
			System.Windows.Forms.Label detalleIDLabel;
			System.Windows.Forms.Label direccionLabel;
			System.Windows.Forms.Label codigoPostalLabel;
			System.Windows.Forms.Label horaInicioLabel;
			System.Windows.Forms.Label horaFinLabel;
			System.Windows.Forms.Label fechaInicioLabel;
			System.Windows.Forms.Label fechaFinLabel;
			System.Windows.Forms.Label costoRutaLabel;
			this.botonAceptar = new System.Windows.Forms.Button();
			this.botonCancelar = new System.Windows.Forms.Button();
			this.botonBuscar = new System.Windows.Forms.Button();
			this.buscar = new System.Windows.Forms.TextBox();
			this.botonGuardar = new System.Windows.Forms.Button();
			this.botonEditar = new System.Windows.Forms.Button();
			this.botonBorrar = new System.Windows.Forms.Button();
			this.botonAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.botonFinal = new System.Windows.Forms.Button();
			this.botonSiguiente = new System.Windows.Forms.Button();
			this.botonAnterior = new System.Windows.Forms.Button();
			this.botonPrincipio = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.botonBorrarDetalle = new System.Windows.Forms.Button();
			this.botonNuevo = new System.Windows.Forms.Button();
			this.botonInforme = new System.Windows.Forms.Button();
			this.botonCerrar = new System.Windows.Forms.Button();
			this.botonAceptarD = new System.Windows.Forms.Button();
			this.botonCancelarD = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.transGlobalDataSet = new ProyectoAgus.TransGlobalDataSet();
			this.rutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rutasTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.RutasTableAdapter();
			this.tableAdapterManager = new ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager();
			this.camionesTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.CamionesTableAdapter();
			this.ruta_DetalleTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.Ruta_DetalleTableAdapter();
			this.rutaIDTextBox = new System.Windows.Forms.TextBox();
			this.origenTextBox = new System.Windows.Forms.TextBox();
			this.destinoTextBox = new System.Windows.Forms.TextBox();
			this.distanciaKMTextBox = new System.Windows.Forms.TextBox();
			this.camionIDComboBox = new System.Windows.Forms.ComboBox();
			this.camionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mapaPictureBox = new System.Windows.Forms.PictureBox();
			this.ruta_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ruta_DetalleDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.detalleIDTextBox = new System.Windows.Forms.TextBox();
			this.direccionTextBox = new System.Windows.Forms.TextBox();
			this.codigoPostalTextBox = new System.Windows.Forms.TextBox();
			this.horaInicioTextBox = new System.Windows.Forms.TextBox();
			this.horaFinTextBox = new System.Windows.Forms.TextBox();
			this.fechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.fechaFinDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.costoRutaTextBox = new System.Windows.Forms.TextBox();
			this.empleadoIDComboBox = new System.Windows.Forms.ComboBox();
			this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.empleadosTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.EmpleadosTableAdapter();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.botonAyuda = new System.Windows.Forms.Button();
			rutaIDLabel = new System.Windows.Forms.Label();
			origenLabel = new System.Windows.Forms.Label();
			destinoLabel = new System.Windows.Forms.Label();
			distanciaKMLabel = new System.Windows.Forms.Label();
			empleadoIDLabel = new System.Windows.Forms.Label();
			camionIDLabel = new System.Windows.Forms.Label();
			detalleIDLabel = new System.Windows.Forms.Label();
			direccionLabel = new System.Windows.Forms.Label();
			codigoPostalLabel = new System.Windows.Forms.Label();
			horaInicioLabel = new System.Windows.Forms.Label();
			horaFinLabel = new System.Windows.Forms.Label();
			fechaInicioLabel = new System.Windows.Forms.Label();
			fechaFinLabel = new System.Windows.Forms.Label();
			costoRutaLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.camionesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mapaPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ruta_DetalleBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ruta_DetalleDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// rutaIDLabel
			// 
			rutaIDLabel.AutoSize = true;
			rutaIDLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			rutaIDLabel.ForeColor = System.Drawing.SystemColors.Control;
			rutaIDLabel.Location = new System.Drawing.Point(47, 75);
			rutaIDLabel.Name = "rutaIDLabel";
			rutaIDLabel.Size = new System.Drawing.Size(23, 13);
			rutaIDLabel.TabIndex = 310;
			rutaIDLabel.Text = "ID:";
			// 
			// origenLabel
			// 
			origenLabel.AutoSize = true;
			origenLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			origenLabel.ForeColor = System.Drawing.SystemColors.Control;
			origenLabel.Location = new System.Drawing.Point(47, 101);
			origenLabel.Name = "origenLabel";
			origenLabel.Size = new System.Drawing.Size(49, 13);
			origenLabel.TabIndex = 312;
			origenLabel.Text = "Origen:";
			// 
			// destinoLabel
			// 
			destinoLabel.AutoSize = true;
			destinoLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			destinoLabel.ForeColor = System.Drawing.SystemColors.Control;
			destinoLabel.Location = new System.Drawing.Point(47, 127);
			destinoLabel.Name = "destinoLabel";
			destinoLabel.Size = new System.Drawing.Size(51, 13);
			destinoLabel.TabIndex = 314;
			destinoLabel.Text = "Destino:";
			// 
			// distanciaKMLabel
			// 
			distanciaKMLabel.AutoSize = true;
			distanciaKMLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			distanciaKMLabel.ForeColor = System.Drawing.SystemColors.Control;
			distanciaKMLabel.Location = new System.Drawing.Point(47, 153);
			distanciaKMLabel.Name = "distanciaKMLabel";
			distanciaKMLabel.Size = new System.Drawing.Size(60, 13);
			distanciaKMLabel.TabIndex = 316;
			distanciaKMLabel.Text = "Distancia:";
			// 
			// empleadoIDLabel
			// 
			empleadoIDLabel.AutoSize = true;
			empleadoIDLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			empleadoIDLabel.ForeColor = System.Drawing.SystemColors.Control;
			empleadoIDLabel.Location = new System.Drawing.Point(47, 179);
			empleadoIDLabel.Name = "empleadoIDLabel";
			empleadoIDLabel.Size = new System.Drawing.Size(61, 13);
			empleadoIDLabel.TabIndex = 318;
			empleadoIDLabel.Text = "Empleado:";
			// 
			// camionIDLabel
			// 
			camionIDLabel.AutoSize = true;
			camionIDLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			camionIDLabel.ForeColor = System.Drawing.SystemColors.Control;
			camionIDLabel.Location = new System.Drawing.Point(47, 205);
			camionIDLabel.Name = "camionIDLabel";
			camionIDLabel.Size = new System.Drawing.Size(53, 13);
			camionIDLabel.TabIndex = 320;
			camionIDLabel.Text = "Camion:";
			// 
			// detalleIDLabel
			// 
			detalleIDLabel.AutoSize = true;
			detalleIDLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			detalleIDLabel.ForeColor = System.Drawing.SystemColors.Control;
			detalleIDLabel.Location = new System.Drawing.Point(1009, 116);
			detalleIDLabel.Name = "detalleIDLabel";
			detalleIDLabel.Size = new System.Drawing.Size(62, 13);
			detalleIDLabel.TabIndex = 323;
			detalleIDLabel.Text = "ID Parada:";
			// 
			// direccionLabel
			// 
			direccionLabel.AutoSize = true;
			direccionLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			direccionLabel.ForeColor = System.Drawing.SystemColors.Control;
			direccionLabel.Location = new System.Drawing.Point(1009, 142);
			direccionLabel.Name = "direccionLabel";
			direccionLabel.Size = new System.Drawing.Size(61, 13);
			direccionLabel.TabIndex = 327;
			direccionLabel.Text = "Direccion:";
			// 
			// codigoPostalLabel
			// 
			codigoPostalLabel.AutoSize = true;
			codigoPostalLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			codigoPostalLabel.ForeColor = System.Drawing.SystemColors.Control;
			codigoPostalLabel.Location = new System.Drawing.Point(1009, 168);
			codigoPostalLabel.Name = "codigoPostalLabel";
			codigoPostalLabel.Size = new System.Drawing.Size(83, 13);
			codigoPostalLabel.TabIndex = 329;
			codigoPostalLabel.Text = "Codigo Postal:";
			// 
			// horaInicioLabel
			// 
			horaInicioLabel.AutoSize = true;
			horaInicioLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			horaInicioLabel.ForeColor = System.Drawing.SystemColors.Control;
			horaInicioLabel.Location = new System.Drawing.Point(1009, 194);
			horaInicioLabel.Name = "horaInicioLabel";
			horaInicioLabel.Size = new System.Drawing.Size(70, 13);
			horaInicioLabel.TabIndex = 331;
			horaInicioLabel.Text = "Hora Inicio:";
			// 
			// horaFinLabel
			// 
			horaFinLabel.AutoSize = true;
			horaFinLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			horaFinLabel.ForeColor = System.Drawing.SystemColors.Control;
			horaFinLabel.Location = new System.Drawing.Point(1009, 220);
			horaFinLabel.Name = "horaFinLabel";
			horaFinLabel.Size = new System.Drawing.Size(57, 13);
			horaFinLabel.TabIndex = 333;
			horaFinLabel.Text = "Hora Fin:";
			// 
			// fechaInicioLabel
			// 
			fechaInicioLabel.AutoSize = true;
			fechaInicioLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			fechaInicioLabel.ForeColor = System.Drawing.SystemColors.Control;
			fechaInicioLabel.Location = new System.Drawing.Point(1009, 246);
			fechaInicioLabel.Name = "fechaInicioLabel";
			fechaInicioLabel.Size = new System.Drawing.Size(74, 13);
			fechaInicioLabel.TabIndex = 335;
			fechaInicioLabel.Text = "Fecha Inicio:";
			// 
			// fechaFinLabel
			// 
			fechaFinLabel.AutoSize = true;
			fechaFinLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			fechaFinLabel.ForeColor = System.Drawing.SystemColors.Control;
			fechaFinLabel.Location = new System.Drawing.Point(1009, 272);
			fechaFinLabel.Name = "fechaFinLabel";
			fechaFinLabel.Size = new System.Drawing.Size(61, 13);
			fechaFinLabel.TabIndex = 337;
			fechaFinLabel.Text = "Fecha Fin:";
			// 
			// costoRutaLabel
			// 
			costoRutaLabel.AutoSize = true;
			costoRutaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			costoRutaLabel.ForeColor = System.Drawing.SystemColors.Control;
			costoRutaLabel.Location = new System.Drawing.Point(1009, 295);
			costoRutaLabel.Name = "costoRutaLabel";
			costoRutaLabel.Size = new System.Drawing.Size(69, 13);
			costoRutaLabel.TabIndex = 339;
			costoRutaLabel.Text = "Costo Ruta:";
			// 
			// botonAceptar
			// 
			this.botonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonAceptar.FlatAppearance.BorderSize = 0;
			this.botonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonAceptar.Image = global::ProyectoAgus.Properties.Resources.aceptar;
			this.botonAceptar.Location = new System.Drawing.Point(175, 229);
			this.botonAceptar.Name = "botonAceptar";
			this.botonAceptar.Size = new System.Drawing.Size(32, 31);
			this.botonAceptar.TabIndex = 135;
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
			this.botonCancelar.Location = new System.Drawing.Point(213, 229);
			this.botonCancelar.Name = "botonCancelar";
			this.botonCancelar.Size = new System.Drawing.Size(32, 31);
			this.botonCancelar.TabIndex = 134;
			this.botonCancelar.TabStop = false;
			this.toolTip1.SetToolTip(this.botonCancelar, "Cancelar");
			this.botonCancelar.UseVisualStyleBackColor = true;
			this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
			// 
			// botonBuscar
			// 
			this.botonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonBuscar.FlatAppearance.BorderSize = 0;
			this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.botonBuscar.Image = global::ProyectoAgus.Properties.Resources.buscar;
			this.botonBuscar.Location = new System.Drawing.Point(622, 5);
			this.botonBuscar.Name = "botonBuscar";
			this.botonBuscar.Size = new System.Drawing.Size(31, 32);
			this.botonBuscar.TabIndex = 132;
			this.botonBuscar.TabStop = false;
			this.botonBuscar.UseVisualStyleBackColor = true;
			this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
			// 
			// buscar
			// 
			this.buscar.Location = new System.Drawing.Point(466, 12);
			this.buscar.Name = "buscar";
			this.buscar.Size = new System.Drawing.Size(150, 20);
			this.buscar.TabIndex = 13;
			// 
			// botonGuardar
			// 
			this.botonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonGuardar.Enabled = false;
			this.botonGuardar.FlatAppearance.BorderSize = 0;
			this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonGuardar.Image = global::ProyectoAgus.Properties.Resources.guardar;
			this.botonGuardar.Location = new System.Drawing.Point(418, 7);
			this.botonGuardar.Name = "botonGuardar";
			this.botonGuardar.Size = new System.Drawing.Size(33, 28);
			this.botonGuardar.TabIndex = 129;
			this.botonGuardar.TabStop = false;
			this.toolTip1.SetToolTip(this.botonGuardar, "Guardar ruta");
			this.botonGuardar.UseVisualStyleBackColor = true;
			this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
			// 
			// botonEditar
			// 
			this.botonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonEditar.FlatAppearance.BorderSize = 0;
			this.botonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonEditar.Image = global::ProyectoAgus.Properties.Resources.editar;
			this.botonEditar.Location = new System.Drawing.Point(376, 7);
			this.botonEditar.Name = "botonEditar";
			this.botonEditar.Size = new System.Drawing.Size(36, 28);
			this.botonEditar.TabIndex = 128;
			this.botonEditar.TabStop = false;
			this.toolTip1.SetToolTip(this.botonEditar, "Editar ruta");
			this.botonEditar.UseVisualStyleBackColor = true;
			this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
			// 
			// botonBorrar
			// 
			this.botonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonBorrar.FlatAppearance.BorderSize = 0;
			this.botonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonBorrar.Image = global::ProyectoAgus.Properties.Resources.borrar;
			this.botonBorrar.Location = new System.Drawing.Point(308, 7);
			this.botonBorrar.Name = "botonBorrar";
			this.botonBorrar.Size = new System.Drawing.Size(34, 28);
			this.botonBorrar.TabIndex = 127;
			this.botonBorrar.TabStop = false;
			this.toolTip1.SetToolTip(this.botonBorrar, "Borrar ruta");
			this.botonBorrar.UseVisualStyleBackColor = true;
			this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
			// 
			// botonAdd
			// 
			this.botonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonAdd.FlatAppearance.BorderSize = 0;
			this.botonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonAdd.Image = global::ProyectoAgus.Properties.Resources.añadir;
			this.botonAdd.Location = new System.Drawing.Point(267, 7);
			this.botonAdd.Name = "botonAdd";
			this.botonAdd.Size = new System.Drawing.Size(35, 28);
			this.botonAdd.TabIndex = 126;
			this.botonAdd.TabStop = false;
			this.toolTip1.SetToolTip(this.botonAdd, "Añadir ruta");
			this.botonAdd.UseVisualStyleBackColor = true;
			this.botonAdd.Click += new System.EventHandler(this.botonAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(64, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 22);
			this.label1.TabIndex = 125;
			this.label1.Text = "Ruta x de x";
			// 
			// botonFinal
			// 
			this.botonFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.botonFinal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonFinal.FlatAppearance.BorderSize = 0;
			this.botonFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonFinal.Image = global::ProyectoAgus.Properties.Resources.doblederecha3;
			this.botonFinal.Location = new System.Drawing.Point(191, 9);
			this.botonFinal.Name = "botonFinal";
			this.botonFinal.Size = new System.Drawing.Size(30, 23);
			this.botonFinal.TabIndex = 124;
			this.botonFinal.TabStop = false;
			this.toolTip1.SetToolTip(this.botonFinal, "Última ruta");
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
			this.botonSiguiente.Location = new System.Drawing.Point(157, 9);
			this.botonSiguiente.Name = "botonSiguiente";
			this.botonSiguiente.Size = new System.Drawing.Size(28, 23);
			this.botonSiguiente.TabIndex = 123;
			this.botonSiguiente.TabStop = false;
			this.toolTip1.SetToolTip(this.botonSiguiente, "Siguiente ruta");
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
			this.botonAnterior.Location = new System.Drawing.Point(41, 9);
			this.botonAnterior.Name = "botonAnterior";
			this.botonAnterior.Size = new System.Drawing.Size(29, 23);
			this.botonAnterior.TabIndex = 122;
			this.botonAnterior.TabStop = false;
			this.toolTip1.SetToolTip(this.botonAnterior, "Ruta anterior");
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
			this.botonPrincipio.Location = new System.Drawing.Point(5, 8);
			this.botonPrincipio.Name = "botonPrincipio";
			this.botonPrincipio.Size = new System.Drawing.Size(30, 24);
			this.botonPrincipio.TabIndex = 121;
			this.botonPrincipio.TabStop = false;
			this.toolTip1.SetToolTip(this.botonPrincipio, "Primera ruta");
			this.botonPrincipio.UseVisualStyleBackColor = true;
			this.botonPrincipio.Click += new System.EventHandler(this.botonPrincipio_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// botonBorrarDetalle
			// 
			this.botonBorrarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonBorrarDetalle.FlatAppearance.BorderSize = 0;
			this.botonBorrarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonBorrarDetalle.Image = global::ProyectoAgus.Properties.Resources.borrar;
			this.botonBorrarDetalle.Location = new System.Drawing.Point(1267, 366);
			this.botonBorrarDetalle.Name = "botonBorrarDetalle";
			this.botonBorrarDetalle.Size = new System.Drawing.Size(34, 30);
			this.botonBorrarDetalle.TabIndex = 168;
			this.botonBorrarDetalle.TabStop = false;
			this.toolTip1.SetToolTip(this.botonBorrarDetalle, "Cancelar parada");
			this.botonBorrarDetalle.UseVisualStyleBackColor = true;
			this.botonBorrarDetalle.Click += new System.EventHandler(this.botonBorrarDetalle_Click);
			// 
			// botonNuevo
			// 
			this.botonNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonNuevo.FlatAppearance.BorderSize = 0;
			this.botonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonNuevo.Image = global::ProyectoAgus.Properties.Resources.añadir;
			this.botonNuevo.Location = new System.Drawing.Point(1267, 330);
			this.botonNuevo.Name = "botonNuevo";
			this.botonNuevo.Size = new System.Drawing.Size(34, 30);
			this.botonNuevo.TabIndex = 167;
			this.botonNuevo.TabStop = false;
			this.toolTip1.SetToolTip(this.botonNuevo, "Añadir parada");
			this.botonNuevo.UseVisualStyleBackColor = true;
			this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
			// 
			// botonInforme
			// 
			this.botonInforme.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonInforme.FlatAppearance.BorderSize = 0;
			this.botonInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonInforme.ForeColor = System.Drawing.SystemColors.Control;
			this.botonInforme.Image = global::ProyectoAgus.Properties.Resources.informe;
			this.botonInforme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.botonInforme.Location = new System.Drawing.Point(1038, 17);
			this.botonInforme.Name = "botonInforme";
			this.botonInforme.Size = new System.Drawing.Size(78, 71);
			this.botonInforme.TabIndex = 259;
			this.botonInforme.TabStop = false;
			this.botonInforme.Text = "Informe &rutas";
			this.botonInforme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.botonInforme, "Informe rutas");
			this.botonInforme.UseVisualStyleBackColor = true;
			this.botonInforme.Click += new System.EventHandler(this.botonInforme_Click);
			// 
			// botonCerrar
			// 
			this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonCerrar.FlatAppearance.BorderSize = 0;
			this.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonCerrar.Image = global::ProyectoAgus.Properties.Resources.salirazul;
			this.botonCerrar.Location = new System.Drawing.Point(1269, 619);
			this.botonCerrar.Name = "botonCerrar";
			this.botonCerrar.Size = new System.Drawing.Size(32, 32);
			this.botonCerrar.TabIndex = 306;
			this.botonCerrar.TabStop = false;
			this.toolTip1.SetToolTip(this.botonCerrar, "Salir");
			this.botonCerrar.UseVisualStyleBackColor = true;
			this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
			// 
			// botonAceptarD
			// 
			this.botonAceptarD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonAceptarD.FlatAppearance.BorderSize = 0;
			this.botonAceptarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonAceptarD.Image = global::ProyectoAgus.Properties.Resources.aceptar;
			this.botonAceptarD.Location = new System.Drawing.Point(1168, 297);
			this.botonAceptarD.Name = "botonAceptarD";
			this.botonAceptarD.Size = new System.Drawing.Size(30, 27);
			this.botonAceptarD.TabIndex = 308;
			this.botonAceptarD.TabStop = false;
			this.toolTip1.SetToolTip(this.botonAceptarD, "Aceptar");
			this.botonAceptarD.UseVisualStyleBackColor = true;
			this.botonAceptarD.Click += new System.EventHandler(this.button3_Click);
			// 
			// botonCancelarD
			// 
			this.botonCancelarD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonCancelarD.FlatAppearance.BorderSize = 0;
			this.botonCancelarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonCancelarD.Image = global::ProyectoAgus.Properties.Resources.cancelar;
			this.botonCancelarD.Location = new System.Drawing.Point(1205, 297);
			this.botonCancelarD.Name = "botonCancelarD";
			this.botonCancelarD.Size = new System.Drawing.Size(32, 27);
			this.botonCancelarD.TabIndex = 307;
			this.botonCancelarD.TabStop = false;
			this.toolTip1.SetToolTip(this.botonCancelarD, "Cancelar");
			this.botonCancelarD.UseVisualStyleBackColor = true;
			this.botonCancelarD.Click += new System.EventHandler(this.button4_Click);
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Image = global::ProyectoAgus.Properties.Resources.informe;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(1162, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 71);
			this.button1.TabIndex = 309;
			this.button1.TabStop = false;
			this.button1.Text = "Informe &camiones";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.button1, "Informe camiones");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// transGlobalDataSet
			// 
			this.transGlobalDataSet.DataSetName = "TransGlobalDataSet";
			this.transGlobalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// rutasBindingSource
			// 
			this.rutasBindingSource.DataMember = "Rutas";
			this.rutasBindingSource.DataSource = this.transGlobalDataSet;
			this.rutasBindingSource.PositionChanged += new System.EventHandler(this.rutasBindingSource_PositionChanged_1);
			// 
			// rutasTableAdapter
			// 
			this.rutasTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CamionesTableAdapter = this.camionesTableAdapter;
			this.tableAdapterManager.ClientesTableAdapter = null;
			this.tableAdapterManager.EmpleadosTableAdapter = null;
			this.tableAdapterManager.ProductoTableAdapter = null;
			this.tableAdapterManager.Ruta_DetalleTableAdapter = this.ruta_DetalleTableAdapter;
			this.tableAdapterManager.RutasTableAdapter = this.rutasTableAdapter;
			this.tableAdapterManager.UpdateOrder = ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.Ventas_DetalleTableAdapter = null;
			this.tableAdapterManager.VentasTableAdapter = null;
			// 
			// camionesTableAdapter
			// 
			this.camionesTableAdapter.ClearBeforeFill = true;
			// 
			// ruta_DetalleTableAdapter
			// 
			this.ruta_DetalleTableAdapter.ClearBeforeFill = true;
			// 
			// rutaIDTextBox
			// 
			this.rutaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutasBindingSource, "RutaID", true));
			this.rutaIDTextBox.Enabled = false;
			this.rutaIDTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rutaIDTextBox.Location = new System.Drawing.Point(126, 72);
			this.rutaIDTextBox.Name = "rutaIDTextBox";
			this.rutaIDTextBox.Size = new System.Drawing.Size(25, 22);
			this.rutaIDTextBox.TabIndex = 311;
			// 
			// origenTextBox
			// 
			this.origenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutasBindingSource, "Origen", true));
			this.origenTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.origenTextBox.Location = new System.Drawing.Point(126, 98);
			this.origenTextBox.Name = "origenTextBox";
			this.origenTextBox.Size = new System.Drawing.Size(121, 22);
			this.origenTextBox.TabIndex = 1;
			// 
			// destinoTextBox
			// 
			this.destinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutasBindingSource, "Destino", true));
			this.destinoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.destinoTextBox.Location = new System.Drawing.Point(126, 124);
			this.destinoTextBox.Name = "destinoTextBox";
			this.destinoTextBox.Size = new System.Drawing.Size(121, 22);
			this.destinoTextBox.TabIndex = 2;
			// 
			// distanciaKMTextBox
			// 
			this.distanciaKMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutasBindingSource, "DistanciaKM", true));
			this.distanciaKMTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distanciaKMTextBox.Location = new System.Drawing.Point(126, 150);
			this.distanciaKMTextBox.Name = "distanciaKMTextBox";
			this.distanciaKMTextBox.Size = new System.Drawing.Size(121, 22);
			this.distanciaKMTextBox.TabIndex = 3;
			// 
			// camionIDComboBox
			// 
			this.camionIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rutasBindingSource, "CamionID", true));
			this.camionIDComboBox.DataSource = this.camionesBindingSource;
			this.camionIDComboBox.DisplayMember = "Matricula";
			this.camionIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.camionIDComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.camionIDComboBox.FormattingEnabled = true;
			this.camionIDComboBox.Location = new System.Drawing.Point(126, 202);
			this.camionIDComboBox.Name = "camionIDComboBox";
			this.camionIDComboBox.Size = new System.Drawing.Size(121, 21);
			this.camionIDComboBox.TabIndex = 5;
			this.camionIDComboBox.ValueMember = "CamionID";
			// 
			// camionesBindingSource
			// 
			this.camionesBindingSource.DataMember = "Camiones";
			this.camionesBindingSource.DataSource = this.transGlobalDataSet;
			// 
			// mapaPictureBox
			// 
			this.mapaPictureBox.BackgroundImage = global::ProyectoAgus.Properties.Resources.foto2;
			this.mapaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mapaPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.mapaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.rutasBindingSource, "Mapa", true));
			this.mapaPictureBox.Location = new System.Drawing.Point(267, 38);
			this.mapaPictureBox.Name = "mapaPictureBox";
			this.mapaPictureBox.Size = new System.Drawing.Size(739, 285);
			this.mapaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.mapaPictureBox.TabIndex = 323;
			this.mapaPictureBox.TabStop = false;
			this.mapaPictureBox.Click += new System.EventHandler(this.mapaPictureBox_Click);
			// 
			// ruta_DetalleBindingSource
			// 
			this.ruta_DetalleBindingSource.DataMember = "fk_ruta";
			this.ruta_DetalleBindingSource.DataSource = this.rutasBindingSource;
			// 
			// ruta_DetalleDataGridView
			// 
			this.ruta_DetalleDataGridView.AllowUserToAddRows = false;
			this.ruta_DetalleDataGridView.AutoGenerateColumns = false;
			this.ruta_DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ruta_DetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
			this.ruta_DetalleDataGridView.DataSource = this.ruta_DetalleBindingSource;
			this.ruta_DetalleDataGridView.Location = new System.Drawing.Point(12, 329);
			this.ruta_DetalleDataGridView.Name = "ruta_DetalleDataGridView";
			this.ruta_DetalleDataGridView.RowHeadersWidth = 51;
			this.ruta_DetalleDataGridView.Size = new System.Drawing.Size(1252, 322);
			this.ruta_DetalleDataGridView.TabIndex = 323;
			this.ruta_DetalleDataGridView.TabStop = false;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "DetalleID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID Parada";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 125;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "RutaID";
			this.dataGridViewTextBoxColumn2.HeaderText = "ID Ruta";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 125;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
			this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 125;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "CodigoPostal";
			this.dataGridViewTextBoxColumn4.HeaderText = "Codigo Postal";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 125;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "HoraInicio";
			this.dataGridViewTextBoxColumn5.HeaderText = "Hora Inicio";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 125;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "HoraFin";
			this.dataGridViewTextBoxColumn6.HeaderText = "Hora Fin";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 125;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "FechaInicio";
			this.dataGridViewTextBoxColumn7.HeaderText = "Fecha Inicio";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.Width = 125;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "FechaFin";
			this.dataGridViewTextBoxColumn8.HeaderText = "Fecha Fin";
			this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.Width = 125;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "CostoRuta";
			this.dataGridViewTextBoxColumn9.HeaderText = "Costo Ruta";
			this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.Width = 125;
			// 
			// detalleIDTextBox
			// 
			this.detalleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruta_DetalleBindingSource, "DetalleID", true));
			this.detalleIDTextBox.Enabled = false;
			this.detalleIDTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.detalleIDTextBox.Location = new System.Drawing.Point(1090, 113);
			this.detalleIDTextBox.Name = "detalleIDTextBox";
			this.detalleIDTextBox.Size = new System.Drawing.Size(29, 22);
			this.detalleIDTextBox.TabIndex = 324;
			// 
			// direccionTextBox
			// 
			this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruta_DetalleBindingSource, "Direccion", true));
			this.direccionTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.direccionTextBox.Location = new System.Drawing.Point(1090, 139);
			this.direccionTextBox.Name = "direccionTextBox";
			this.direccionTextBox.Size = new System.Drawing.Size(132, 22);
			this.direccionTextBox.TabIndex = 6;
			// 
			// codigoPostalTextBox
			// 
			this.codigoPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruta_DetalleBindingSource, "CodigoPostal", true));
			this.codigoPostalTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.codigoPostalTextBox.Location = new System.Drawing.Point(1090, 165);
			this.codigoPostalTextBox.Name = "codigoPostalTextBox";
			this.codigoPostalTextBox.Size = new System.Drawing.Size(69, 22);
			this.codigoPostalTextBox.TabIndex = 7;
			// 
			// horaInicioTextBox
			// 
			this.horaInicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruta_DetalleBindingSource, "HoraInicio", true));
			this.horaInicioTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.horaInicioTextBox.Location = new System.Drawing.Point(1090, 191);
			this.horaInicioTextBox.Name = "horaInicioTextBox";
			this.horaInicioTextBox.Size = new System.Drawing.Size(69, 22);
			this.horaInicioTextBox.TabIndex = 8;
			// 
			// horaFinTextBox
			// 
			this.horaFinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruta_DetalleBindingSource, "HoraFin", true));
			this.horaFinTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.horaFinTextBox.Location = new System.Drawing.Point(1090, 217);
			this.horaFinTextBox.Name = "horaFinTextBox";
			this.horaFinTextBox.Size = new System.Drawing.Size(69, 22);
			this.horaFinTextBox.TabIndex = 9;
			// 
			// fechaInicioDateTimePicker
			// 
			this.fechaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ruta_DetalleBindingSource, "FechaInicio", true));
			this.fechaInicioDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(1090, 242);
			this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
			this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(208, 22);
			this.fechaInicioDateTimePicker.TabIndex = 10;
			// 
			// fechaFinDateTimePicker
			// 
			this.fechaFinDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ruta_DetalleBindingSource, "FechaFin", true));
			this.fechaFinDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fechaFinDateTimePicker.Location = new System.Drawing.Point(1090, 268);
			this.fechaFinDateTimePicker.Name = "fechaFinDateTimePicker";
			this.fechaFinDateTimePicker.Size = new System.Drawing.Size(208, 22);
			this.fechaFinDateTimePicker.TabIndex = 11;
			// 
			// costoRutaTextBox
			// 
			this.costoRutaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruta_DetalleBindingSource, "CostoRuta", true));
			this.costoRutaTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.costoRutaTextBox.Location = new System.Drawing.Point(1090, 292);
			this.costoRutaTextBox.Name = "costoRutaTextBox";
			this.costoRutaTextBox.Size = new System.Drawing.Size(72, 22);
			this.costoRutaTextBox.TabIndex = 12;
			this.costoRutaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.costoRutaTextBox_KeyDown);
			// 
			// empleadoIDComboBox
			// 
			this.empleadoIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rutasBindingSource, "EmpleadoID", true));
			this.empleadoIDComboBox.DataSource = this.empleadosBindingSource;
			this.empleadoIDComboBox.DisplayMember = "Nombre";
			this.empleadoIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.empleadoIDComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.empleadoIDComboBox.FormattingEnabled = true;
			this.empleadoIDComboBox.Location = new System.Drawing.Point(126, 175);
			this.empleadoIDComboBox.Name = "empleadoIDComboBox";
			this.empleadoIDComboBox.Size = new System.Drawing.Size(121, 21);
			this.empleadoIDComboBox.TabIndex = 4;
			this.empleadoIDComboBox.ValueMember = "EmpleadosID";
			// 
			// empleadosBindingSource
			// 
			this.empleadosBindingSource.DataMember = "Empleados";
			this.empleadosBindingSource.DataSource = this.transGlobalDataSet;
			// 
			// empleadosTableAdapter
			// 
			this.empleadosTableAdapter.ClearBeforeFill = true;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// botonAyuda
			// 
			this.botonAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
			this.botonAyuda.FlatAppearance.BorderSize = 0;
			this.botonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botonAyuda.Image = global::ProyectoAgus.Properties.Resources.ayudaazul;
			this.botonAyuda.Location = new System.Drawing.Point(1269, 5);
			this.botonAyuda.Name = "botonAyuda";
			this.botonAyuda.Size = new System.Drawing.Size(36, 30);
			this.botonAyuda.TabIndex = 340;
			this.botonAyuda.TabStop = false;
			this.toolTip1.SetToolTip(this.botonAyuda, "Buscar");
			this.botonAyuda.UseVisualStyleBackColor = true;
			this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);
			// 
			// rutas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
			this.ClientSize = new System.Drawing.Size(1310, 662);
			this.Controls.Add(this.ruta_DetalleDataGridView);
			this.Controls.Add(this.botonAyuda);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.codigoPostalTextBox);
			this.Controls.Add(this.empleadoIDComboBox);
			this.Controls.Add(detalleIDLabel);
			this.Controls.Add(this.detalleIDTextBox);
			this.Controls.Add(direccionLabel);
			this.Controls.Add(this.direccionTextBox);
			this.Controls.Add(codigoPostalLabel);
			this.Controls.Add(horaInicioLabel);
			this.Controls.Add(this.horaInicioTextBox);
			this.Controls.Add(horaFinLabel);
			this.Controls.Add(this.horaFinTextBox);
			this.Controls.Add(fechaInicioLabel);
			this.Controls.Add(this.fechaInicioDateTimePicker);
			this.Controls.Add(fechaFinLabel);
			this.Controls.Add(this.fechaFinDateTimePicker);
			this.Controls.Add(costoRutaLabel);
			this.Controls.Add(this.costoRutaTextBox);
			this.Controls.Add(rutaIDLabel);
			this.Controls.Add(this.rutaIDTextBox);
			this.Controls.Add(origenLabel);
			this.Controls.Add(this.origenTextBox);
			this.Controls.Add(destinoLabel);
			this.Controls.Add(this.destinoTextBox);
			this.Controls.Add(distanciaKMLabel);
			this.Controls.Add(this.distanciaKMTextBox);
			this.Controls.Add(empleadoIDLabel);
			this.Controls.Add(camionIDLabel);
			this.Controls.Add(this.camionIDComboBox);
			this.Controls.Add(this.mapaPictureBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.botonAceptarD);
			this.Controls.Add(this.botonCancelarD);
			this.Controls.Add(this.botonCerrar);
			this.Controls.Add(this.botonInforme);
			this.Controls.Add(this.botonBorrarDetalle);
			this.Controls.Add(this.botonNuevo);
			this.Controls.Add(this.botonAceptar);
			this.Controls.Add(this.botonCancelar);
			this.Controls.Add(this.botonBuscar);
			this.Controls.Add(this.buscar);
			this.Controls.Add(this.botonGuardar);
			this.Controls.Add(this.botonEditar);
			this.Controls.Add(this.botonBorrar);
			this.Controls.Add(this.botonAdd);
			this.Controls.Add(this.botonFinal);
			this.Controls.Add(this.botonSiguiente);
			this.Controls.Add(this.botonAnterior);
			this.Controls.Add(this.botonPrincipio);
			this.Name = "rutas";
			this.Text = "Rutas";
			this.Load += new System.EventHandler(this.rutas_Load);
			((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.camionesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mapaPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ruta_DetalleBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ruta_DetalleDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button botonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonFinal;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Button botonAnterior;
        private System.Windows.Forms.Button botonPrincipio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button botonBorrarDetalle;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonInforme;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Button botonAceptarD;
        private System.Windows.Forms.Button botonCancelarD;
        private System.Windows.Forms.Button button1;
        private TransGlobalDataSet transGlobalDataSet;
        private System.Windows.Forms.BindingSource rutasBindingSource;
        private TransGlobalDataSetTableAdapters.RutasTableAdapter rutasTableAdapter;
        private TransGlobalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TransGlobalDataSetTableAdapters.Ruta_DetalleTableAdapter ruta_DetalleTableAdapter;
        private System.Windows.Forms.TextBox rutaIDTextBox;
        private System.Windows.Forms.TextBox origenTextBox;
        private System.Windows.Forms.TextBox destinoTextBox;
        private System.Windows.Forms.TextBox distanciaKMTextBox;
        private System.Windows.Forms.ComboBox camionIDComboBox;
        private System.Windows.Forms.PictureBox mapaPictureBox;
        private System.Windows.Forms.BindingSource ruta_DetalleBindingSource;
        private System.Windows.Forms.DataGridView ruta_DetalleDataGridView;
        private System.Windows.Forms.TextBox detalleIDTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox codigoPostalTextBox;
        private System.Windows.Forms.TextBox horaInicioTextBox;
        private System.Windows.Forms.TextBox horaFinTextBox;
        private System.Windows.Forms.DateTimePicker fechaInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaFinDateTimePicker;
        private System.Windows.Forms.TextBox costoRutaTextBox;
        private TransGlobalDataSetTableAdapters.CamionesTableAdapter camionesTableAdapter;
        private System.Windows.Forms.BindingSource camionesBindingSource;
        private System.Windows.Forms.ComboBox empleadoIDComboBox;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private TransGlobalDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button botonAyuda;
    }
}