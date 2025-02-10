namespace ProyectoAgus
{
    partial class camiones
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
            System.Windows.Forms.Label camionIDLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label tipoCamionLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label fechaFabricacionLabel;
            System.Windows.Forms.Label capacidadaCargaLabel;
            System.Windows.Forms.Label tipoCombustibleLabel;
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.TextBox();
            this.buscarComboBox = new System.Windows.Forms.ComboBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.botonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botonFinal = new System.Windows.Forms.Button();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.botonAnterior = new System.Windows.Forms.Button();
            this.botonPrincipio = new System.Windows.Forms.Button();
            this.transGlobalDataSet = new ProyectoAgus.TransGlobalDataSet();
            this.camionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camionesTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.CamionesTableAdapter();
            this.tableAdapterManager = new ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager();
            this.camionIDTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.fechaFabricacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.capacidadaCargaTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipoCamionComboBox = new System.Windows.Forms.ComboBox();
            this.tipoCombustibleComboBox = new System.Windows.Forms.ComboBox();
            this.botonInforme = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.botonAyuda = new System.Windows.Forms.Button();
            camionIDLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            tipoCamionLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            fechaFabricacionLabel = new System.Windows.Forms.Label();
            capacidadaCargaLabel = new System.Windows.Forms.Label();
            tipoCombustibleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // camionIDLabel
            // 
            camionIDLabel.AutoSize = true;
            camionIDLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            camionIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            camionIDLabel.Location = new System.Drawing.Point(60, 110);
            camionIDLabel.Name = "camionIDLabel";
            camionIDLabel.Size = new System.Drawing.Size(68, 13);
            camionIDLabel.TabIndex = 103;
            camionIDLabel.Text = "Camion ID:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matriculaLabel.ForeColor = System.Drawing.SystemColors.Control;
            matriculaLabel.Location = new System.Drawing.Point(60, 136);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(62, 13);
            matriculaLabel.TabIndex = 105;
            matriculaLabel.Text = "Matricula:";
            // 
            // tipoCamionLabel
            // 
            tipoCamionLabel.AutoSize = true;
            tipoCamionLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoCamionLabel.ForeColor = System.Drawing.SystemColors.Control;
            tipoCamionLabel.Location = new System.Drawing.Point(60, 162);
            tipoCamionLabel.Name = "tipoCamionLabel";
            tipoCamionLabel.Size = new System.Drawing.Size(78, 13);
            tipoCamionLabel.TabIndex = 107;
            tipoCamionLabel.Text = "Tipo Camion:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.ForeColor = System.Drawing.SystemColors.Control;
            marcaLabel.Location = new System.Drawing.Point(60, 188);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(43, 13);
            marcaLabel.TabIndex = 109;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.ForeColor = System.Drawing.SystemColors.Control;
            modeloLabel.Location = new System.Drawing.Point(60, 214);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(49, 13);
            modeloLabel.TabIndex = 111;
            modeloLabel.Text = "Modelo:";
            // 
            // fechaFabricacionLabel
            // 
            fechaFabricacionLabel.AutoSize = true;
            fechaFabricacionLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaFabricacionLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaFabricacionLabel.Location = new System.Drawing.Point(60, 241);
            fechaFabricacionLabel.Name = "fechaFabricacionLabel";
            fechaFabricacionLabel.Size = new System.Drawing.Size(104, 13);
            fechaFabricacionLabel.TabIndex = 113;
            fechaFabricacionLabel.Text = "Fecha Fabricacion:";
            // 
            // capacidadaCargaLabel
            // 
            capacidadaCargaLabel.AutoSize = true;
            capacidadaCargaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            capacidadaCargaLabel.ForeColor = System.Drawing.SystemColors.Control;
            capacidadaCargaLabel.Location = new System.Drawing.Point(60, 266);
            capacidadaCargaLabel.Name = "capacidadaCargaLabel";
            capacidadaCargaLabel.Size = new System.Drawing.Size(106, 13);
            capacidadaCargaLabel.TabIndex = 115;
            capacidadaCargaLabel.Text = "Capacidada Carga:";
            // 
            // tipoCombustibleLabel
            // 
            tipoCombustibleLabel.AutoSize = true;
            tipoCombustibleLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoCombustibleLabel.ForeColor = System.Drawing.SystemColors.Control;
            tipoCombustibleLabel.Location = new System.Drawing.Point(60, 292);
            tipoCombustibleLabel.Name = "tipoCombustibleLabel";
            tipoCombustibleLabel.Size = new System.Drawing.Size(103, 13);
            tipoCombustibleLabel.TabIndex = 117;
            tipoCombustibleLabel.Text = "Tipo Combustible:";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAceptar.FlatAppearance.BorderSize = 0;
            this.botonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAceptar.Image = global::ProyectoAgus.Properties.Resources.aceptar;
            this.botonAceptar.Location = new System.Drawing.Point(177, 313);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(30, 29);
            this.botonAceptar.TabIndex = 102;
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
            this.botonCancelar.Location = new System.Drawing.Point(213, 313);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(34, 29);
            this.botonCancelar.TabIndex = 101;
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
            this.botonBuscar.Image = global::ProyectoAgus.Properties.Resources.buscar;
            this.botonBuscar.Location = new System.Drawing.Point(722, 7);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(35, 30);
            this.botonBuscar.TabIndex = 99;
            this.botonBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonBuscar, "Buscar");
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(616, 12);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(100, 22);
            this.buscar.TabIndex = 8;
            this.buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buscar_KeyDown);
            // 
            // buscarComboBox
            // 
            this.buscarComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.buscarComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarComboBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarComboBox.ForeColor = System.Drawing.Color.Black;
            this.buscarComboBox.FormattingEnabled = true;
            this.buscarComboBox.Items.AddRange(new object[] {
            "Buscar por Id",
            "Buscar por Matricula"});
            this.buscarComboBox.Location = new System.Drawing.Point(488, 12);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(121, 22);
            this.buscarComboBox.TabIndex = 98;
            this.buscarComboBox.TabStop = false;
            this.buscarComboBox.Text = "Buscar por Id";
            // 
            // botonGuardar
            // 
            this.botonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonGuardar.Enabled = false;
            this.botonGuardar.FlatAppearance.BorderSize = 0;
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGuardar.Image = global::ProyectoAgus.Properties.Resources.guardar;
            this.botonGuardar.Location = new System.Drawing.Point(397, 6);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(34, 30);
            this.botonGuardar.TabIndex = 96;
            this.botonGuardar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonGuardar, "Guardar camión");
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEditar.FlatAppearance.BorderSize = 0;
            this.botonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditar.Image = global::ProyectoAgus.Properties.Resources.editar;
            this.botonEditar.Location = new System.Drawing.Point(356, 6);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(35, 30);
            this.botonEditar.TabIndex = 95;
            this.botonEditar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonEditar, "Editar camión");
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBorrar.FlatAppearance.BorderSize = 0;
            this.botonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBorrar.Image = global::ProyectoAgus.Properties.Resources.borrar;
            this.botonBorrar.Location = new System.Drawing.Point(309, 5);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(36, 30);
            this.botonBorrar.TabIndex = 94;
            this.botonBorrar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonBorrar, "Borrar camión");
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // botonAdd
            // 
            this.botonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAdd.FlatAppearance.BorderSize = 0;
            this.botonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAdd.Image = global::ProyectoAgus.Properties.Resources.añadir;
            this.botonAdd.Location = new System.Drawing.Point(266, 5);
            this.botonAdd.Name = "botonAdd";
            this.botonAdd.Size = new System.Drawing.Size(37, 30);
            this.botonAdd.TabIndex = 93;
            this.botonAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAdd, "Nuevo camión");
            this.botonAdd.UseVisualStyleBackColor = true;
            this.botonAdd.Click += new System.EventHandler(this.botonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(66, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 92;
            this.label1.Text = "Camion x de x";
            // 
            // botonFinal
            // 
            this.botonFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonFinal.FlatAppearance.BorderSize = 0;
            this.botonFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonFinal.Image = global::ProyectoAgus.Properties.Resources.doblederecha3;
            this.botonFinal.Location = new System.Drawing.Point(222, 10);
            this.botonFinal.Name = "botonFinal";
            this.botonFinal.Size = new System.Drawing.Size(30, 23);
            this.botonFinal.TabIndex = 91;
            this.botonFinal.TabStop = false;
            this.toolTip1.SetToolTip(this.botonFinal, "Último camión");
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
            this.botonSiguiente.Location = new System.Drawing.Point(188, 10);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(28, 23);
            this.botonSiguiente.TabIndex = 90;
            this.botonSiguiente.TabStop = false;
            this.toolTip1.SetToolTip(this.botonSiguiente, "Siguiente camion");
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
            this.botonAnterior.Location = new System.Drawing.Point(37, 9);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(29, 23);
            this.botonAnterior.TabIndex = 89;
            this.botonAnterior.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAnterior, "Camion anterior");
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
            this.botonPrincipio.Location = new System.Drawing.Point(1, 9);
            this.botonPrincipio.Name = "botonPrincipio";
            this.botonPrincipio.Size = new System.Drawing.Size(30, 24);
            this.botonPrincipio.TabIndex = 88;
            this.botonPrincipio.TabStop = false;
            this.toolTip1.SetToolTip(this.botonPrincipio, "Primer camión");
            this.botonPrincipio.UseVisualStyleBackColor = true;
            this.botonPrincipio.Click += new System.EventHandler(this.botonPrincipio_Click);
            // 
            // transGlobalDataSet
            // 
            this.transGlobalDataSet.DataSetName = "TransGlobalDataSet";
            this.transGlobalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // camionesBindingSource
            // 
            this.camionesBindingSource.DataMember = "Camiones";
            this.camionesBindingSource.DataSource = this.transGlobalDataSet;
            this.camionesBindingSource.PositionChanged += new System.EventHandler(this.camionesBindingSource_PositionChanged);
            // 
            // camionesTableAdapter
            // 
            this.camionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CamionesTableAdapter = this.camionesTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.Ruta_DetalleTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Ventas_DetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // camionIDTextBox
            // 
            this.camionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camionesBindingSource, "CamionID", true));
            this.camionIDTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camionIDTextBox.Location = new System.Drawing.Point(169, 107);
            this.camionIDTextBox.Name = "camionIDTextBox";
            this.camionIDTextBox.Size = new System.Drawing.Size(43, 22);
            this.camionIDTextBox.TabIndex = 104;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camionesBindingSource, "Matricula", true));
            this.matriculaTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaTextBox.Location = new System.Drawing.Point(169, 133);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(78, 22);
            this.matriculaTextBox.TabIndex = 1;
            this.matriculaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.matriculaTextBox_KeyDown);
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camionesBindingSource, "Marca", true));
            this.marcaTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaTextBox.Location = new System.Drawing.Point(169, 185);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(104, 22);
            this.marcaTextBox.TabIndex = 3;
            this.marcaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.marcaTextBox_KeyDown);
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camionesBindingSource, "Modelo", true));
            this.modeloTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloTextBox.Location = new System.Drawing.Point(169, 211);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(104, 22);
            this.modeloTextBox.TabIndex = 4;
            this.modeloTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modeloTextBox_KeyDown);
            // 
            // fechaFabricacionDateTimePicker
            // 
            this.fechaFabricacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.camionesBindingSource, "FechaFabricacion", true));
            this.fechaFabricacionDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFabricacionDateTimePicker.Location = new System.Drawing.Point(169, 237);
            this.fechaFabricacionDateTimePicker.Name = "fechaFabricacionDateTimePicker";
            this.fechaFabricacionDateTimePicker.Size = new System.Drawing.Size(211, 22);
            this.fechaFabricacionDateTimePicker.TabIndex = 5;
            this.fechaFabricacionDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaFabricacionDateTimePicker_KeyDown);
            // 
            // capacidadaCargaTextBox
            // 
            this.capacidadaCargaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camionesBindingSource, "CapacidadaCarga", true));
            this.capacidadaCargaTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacidadaCargaTextBox.Location = new System.Drawing.Point(169, 263);
            this.capacidadaCargaTextBox.Name = "capacidadaCargaTextBox";
            this.capacidadaCargaTextBox.Size = new System.Drawing.Size(78, 22);
            this.capacidadaCargaTextBox.TabIndex = 6;
            this.capacidadaCargaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.capacidadaCargaTextBox_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.fotoPictureBox.BackgroundImage = global::ProyectoAgus.Properties.Resources.foto2;
            this.fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fotoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.camionesBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(403, 82);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(389, 270);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox.TabIndex = 120;
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
            this.botonCerrar.Location = new System.Drawing.Point(12, 356);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(37, 29);
            this.botonCerrar.TabIndex = 306;
            this.botonCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonCerrar, "Salir");
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tipoCamionComboBox
            // 
            this.tipoCamionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camionesBindingSource, "TipoCamion", true));
            this.tipoCamionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCamionComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCamionComboBox.FormattingEnabled = true;
            this.tipoCamionComboBox.Items.AddRange(new object[] {
            "Tráiler",
            "Camión Volquete",
            "Camión Cisterna",
            "Camión Frigorífico",
            "Camión de Reparto",
            "Camión rigido",
            "Camión articulado"});
            this.tipoCamionComboBox.Location = new System.Drawing.Point(169, 159);
            this.tipoCamionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tipoCamionComboBox.Name = "tipoCamionComboBox";
            this.tipoCamionComboBox.Size = new System.Drawing.Size(159, 21);
            this.tipoCamionComboBox.TabIndex = 2;
            this.tipoCamionComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipoCamionComboBox_KeyDown);
            // 
            // tipoCombustibleComboBox
            // 
            this.tipoCombustibleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camionesBindingSource, "TipoCombustible", true));
            this.tipoCombustibleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCombustibleComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCombustibleComboBox.FormattingEnabled = true;
            this.tipoCombustibleComboBox.Items.AddRange(new object[] {
            "Diésel",
            "Gasolina"});
            this.tipoCombustibleComboBox.Location = new System.Drawing.Point(169, 287);
            this.tipoCombustibleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tipoCombustibleComboBox.Name = "tipoCombustibleComboBox";
            this.tipoCombustibleComboBox.Size = new System.Drawing.Size(78, 21);
            this.tipoCombustibleComboBox.TabIndex = 7;
            this.tipoCombustibleComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipoCombustibleComboBox_KeyDown);
            // 
            // botonInforme
            // 
            this.botonInforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonInforme.FlatAppearance.BorderSize = 0;
            this.botonInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonInforme.Image = global::ProyectoAgus.Properties.Resources.informe;
            this.botonInforme.Location = new System.Drawing.Point(447, 8);
            this.botonInforme.Name = "botonInforme";
            this.botonInforme.Size = new System.Drawing.Size(26, 29);
            this.botonInforme.TabIndex = 307;
            this.botonInforme.TabStop = false;
            this.toolTip1.SetToolTip(this.botonInforme, "Informe del camión");
            this.botonInforme.UseVisualStyleBackColor = true;
            this.botonInforme.Click += new System.EventHandler(this.botonInforme_Click);
            // 
            // botonAyuda
            // 
            this.botonAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAyuda.FlatAppearance.BorderSize = 0;
            this.botonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAyuda.Image = global::ProyectoAgus.Properties.Resources.ayudaazul;
            this.botonAyuda.Location = new System.Drawing.Point(763, 6);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Size = new System.Drawing.Size(35, 30);
            this.botonAyuda.TabIndex = 308;
            this.botonAyuda.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAyuda, "Buscar");
            this.botonAyuda.UseVisualStyleBackColor = true;
            this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);
            // 
            // camiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(804, 391);
            this.Controls.Add(this.botonAyuda);
            this.Controls.Add(this.botonInforme);
            this.Controls.Add(this.tipoCombustibleComboBox);
            this.Controls.Add(this.tipoCamionComboBox);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(camionIDLabel);
            this.Controls.Add(this.camionIDTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(tipoCamionLabel);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(fechaFabricacionLabel);
            this.Controls.Add(this.fechaFabricacionDateTimePicker);
            this.Controls.Add(capacidadaCargaLabel);
            this.Controls.Add(this.capacidadaCargaTextBox);
            this.Controls.Add(tipoCombustibleLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonCancelar);
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
            this.Name = "camiones";
            this.Text = "Camiones";
            this.Load += new System.EventHandler(this.camiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
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
        private System.Windows.Forms.BindingSource camionesBindingSource;
        private TransGlobalDataSetTableAdapters.CamionesTableAdapter camionesTableAdapter;
        private TransGlobalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox camionIDTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.DateTimePicker fechaFabricacionDateTimePicker;
        private System.Windows.Forms.TextBox capacidadaCargaTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox tipoCamionComboBox;
        private System.Windows.Forms.ComboBox tipoCombustibleComboBox;
        private System.Windows.Forms.Button botonInforme;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button botonAyuda;
    }
}