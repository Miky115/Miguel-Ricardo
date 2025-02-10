namespace ProyectoAgus
{
    partial class empleados
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
            System.Windows.Forms.Label empleadosIDLabel;
            System.Windows.Forms.Label aliasLabel;
            System.Windows.Forms.Label rolLabel;
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label fechaContratacionLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label cargoLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            this.botonCerrar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonImprimir = new System.Windows.Forms.Button();
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
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager();
            this.empleadosIDTextBox = new System.Windows.Forms.TextBox();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.fechaContratacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.botonAyuda = new System.Windows.Forms.Button();
            empleadosIDLabel = new System.Windows.Forms.Label();
            aliasLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            fechaContratacionLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadosIDLabel
            // 
            empleadosIDLabel.AutoSize = true;
            empleadosIDLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empleadosIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            empleadosIDLabel.Location = new System.Drawing.Point(15, 84);
            empleadosIDLabel.Name = "empleadosIDLabel";
            empleadosIDLabel.Size = new System.Drawing.Size(81, 13);
            empleadosIDLabel.TabIndex = 340;
            empleadosIDLabel.Text = "Empleados ID:";
            // 
            // aliasLabel
            // 
            aliasLabel.AutoSize = true;
            aliasLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aliasLabel.ForeColor = System.Drawing.SystemColors.Control;
            aliasLabel.Location = new System.Drawing.Point(15, 110);
            aliasLabel.Name = "aliasLabel";
            aliasLabel.Size = new System.Drawing.Size(38, 13);
            aliasLabel.TabIndex = 342;
            aliasLabel.Text = "Alias:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rolLabel.ForeColor = System.Drawing.SystemColors.Control;
            rolLabel.Location = new System.Drawing.Point(15, 136);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(29, 13);
            rolLabel.TabIndex = 344;
            rolLabel.Text = "Rol:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrasenaLabel.ForeColor = System.Drawing.SystemColors.Control;
            contrasenaLabel.Location = new System.Drawing.Point(15, 162);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(72, 13);
            contrasenaLabel.TabIndex = 346;
            contrasenaLabel.Text = "Contrasena:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.SystemColors.Control;
            nombreLabel.Location = new System.Drawing.Point(15, 188);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(52, 13);
            nombreLabel.TabIndex = 348;
            nombreLabel.Text = "Nombre:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dNILabel.ForeColor = System.Drawing.SystemColors.Control;
            dNILabel.Location = new System.Drawing.Point(15, 214);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(31, 13);
            dNILabel.TabIndex = 350;
            dNILabel.Text = "DNI:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.ForeColor = System.Drawing.SystemColors.Control;
            telefonoLabel.Location = new System.Drawing.Point(583, 81);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(55, 13);
            telefonoLabel.TabIndex = 352;
            telefonoLabel.Text = "Telefono:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.ForeColor = System.Drawing.SystemColors.Control;
            direccionLabel.Location = new System.Drawing.Point(583, 107);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(61, 13);
            direccionLabel.TabIndex = 354;
            direccionLabel.Text = "Direccion:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.ForeColor = System.Drawing.SystemColors.Control;
            correoLabel.Location = new System.Drawing.Point(583, 133);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(48, 13);
            correoLabel.TabIndex = 356;
            correoLabel.Text = "Correo:";
            // 
            // fechaContratacionLabel
            // 
            fechaContratacionLabel.AutoSize = true;
            fechaContratacionLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaContratacionLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaContratacionLabel.Location = new System.Drawing.Point(583, 160);
            fechaContratacionLabel.Name = "fechaContratacionLabel";
            fechaContratacionLabel.Size = new System.Drawing.Size(113, 13);
            fechaContratacionLabel.TabIndex = 358;
            fechaContratacionLabel.Text = "Fecha Contratacion:";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salarioLabel.ForeColor = System.Drawing.SystemColors.Control;
            salarioLabel.Location = new System.Drawing.Point(583, 210);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(49, 13);
            salarioLabel.TabIndex = 360;
            salarioLabel.Text = "Salario:";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cargoLabel.ForeColor = System.Drawing.SystemColors.Control;
            cargoLabel.Location = new System.Drawing.Point(583, 236);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(43, 13);
            cargoLabel.TabIndex = 362;
            cargoLabel.Text = "Cargo:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaNacimientoLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaNacimientoLabel.Location = new System.Drawing.Point(583, 186);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(104, 13);
            fechaNacimientoLabel.TabIndex = 364;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // botonCerrar
            // 
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.FlatAppearance.BorderSize = 0;
            this.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrar.Image = global::ProyectoAgus.Properties.Resources.salirazul;
            this.botonCerrar.Location = new System.Drawing.Point(2, 283);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(33, 31);
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
            this.botonAceptar.Location = new System.Drawing.Point(827, 255);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(35, 31);
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
            this.botonCancelar.Location = new System.Drawing.Point(868, 255);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(34, 31);
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
            this.botonImprimir.Location = new System.Drawing.Point(487, 4);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(33, 31);
            this.botonImprimir.TabIndex = 319;
            this.botonImprimir.TabStop = false;
            this.toolTip1.SetToolTip(this.botonImprimir, "Informe del empleado");
            this.botonImprimir.UseVisualStyleBackColor = true;
            this.botonImprimir.Click += new System.EventHandler(this.botonImprimir_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscar.FlatAppearance.BorderSize = 0;
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscar.Image = global::ProyectoAgus.Properties.Resources.buscar;
            this.botonBuscar.Location = new System.Drawing.Point(819, 7);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(35, 28);
            this.botonBuscar.TabIndex = 318;
            this.botonBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonBuscar, "Buscar");
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(674, 11);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(139, 20);
            this.buscar.TabIndex = 13;
            this.buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buscar_KeyDown);
            // 
            // buscarComboBox
            // 
            this.buscarComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.buscarComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarComboBox.ForeColor = System.Drawing.Color.Black;
            this.buscarComboBox.FormattingEnabled = true;
            this.buscarComboBox.Items.AddRange(new object[] {
            "Buscar por Id",
            "Buscar por DNI",
            "Buscar por Correo"});
            this.buscarComboBox.Location = new System.Drawing.Point(546, 11);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(121, 21);
            this.buscarComboBox.TabIndex = 317;
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
            this.botonGuardar.Location = new System.Drawing.Point(416, 5);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(34, 28);
            this.botonGuardar.TabIndex = 315;
            this.botonGuardar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonGuardar, "Guardar empleado");
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEditar.FlatAppearance.BorderSize = 0;
            this.botonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditar.Image = global::ProyectoAgus.Properties.Resources.editar;
            this.botonEditar.Location = new System.Drawing.Point(378, 5);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(32, 28);
            this.botonEditar.TabIndex = 314;
            this.botonEditar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonEditar, "Editar empleado");
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBorrar.FlatAppearance.BorderSize = 0;
            this.botonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBorrar.Image = global::ProyectoAgus.Properties.Resources.borrar;
            this.botonBorrar.Location = new System.Drawing.Point(320, 2);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(33, 32);
            this.botonBorrar.TabIndex = 313;
            this.botonBorrar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonBorrar, "Borrar empleado");
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // botonAdd
            // 
            this.botonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAdd.FlatAppearance.BorderSize = 0;
            this.botonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAdd.Image = global::ProyectoAgus.Properties.Resources.añadir;
            this.botonAdd.Location = new System.Drawing.Point(280, 2);
            this.botonAdd.Name = "botonAdd";
            this.botonAdd.Size = new System.Drawing.Size(34, 32);
            this.botonAdd.TabIndex = 312;
            this.botonAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAdd, "Añadir empleado");
            this.botonAdd.UseVisualStyleBackColor = true;
            this.botonAdd.Click += new System.EventHandler(this.botonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(63, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 311;
            this.label1.Text = "Empleado x de x";
            // 
            // botonFinal
            // 
            this.botonFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonFinal.FlatAppearance.BorderSize = 0;
            this.botonFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonFinal.Image = global::ProyectoAgus.Properties.Resources.doblederecha3;
            this.botonFinal.Location = new System.Drawing.Point(235, 7);
            this.botonFinal.Name = "botonFinal";
            this.botonFinal.Size = new System.Drawing.Size(30, 23);
            this.botonFinal.TabIndex = 310;
            this.botonFinal.TabStop = false;
            this.toolTip1.SetToolTip(this.botonFinal, "Último empleado");
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
            this.botonSiguiente.Location = new System.Drawing.Point(201, 7);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(28, 23);
            this.botonSiguiente.TabIndex = 309;
            this.botonSiguiente.TabStop = false;
            this.toolTip1.SetToolTip(this.botonSiguiente, "Siguiente empleado");
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
            this.botonAnterior.Location = new System.Drawing.Point(41, 7);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(29, 23);
            this.botonAnterior.TabIndex = 308;
            this.botonAnterior.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAnterior, "Empleado anterior");
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
            this.botonPrincipio.Location = new System.Drawing.Point(5, 6);
            this.botonPrincipio.Name = "botonPrincipio";
            this.botonPrincipio.Size = new System.Drawing.Size(30, 24);
            this.botonPrincipio.TabIndex = 307;
            this.botonPrincipio.TabStop = false;
            this.toolTip1.SetToolTip(this.botonPrincipio, "Primer empleado");
            this.botonPrincipio.UseVisualStyleBackColor = true;
            this.botonPrincipio.Click += new System.EventHandler(this.botonPrincipio_Click);
            // 
            // transGlobalDataSet
            // 
            this.transGlobalDataSet.DataSetName = "TransGlobalDataSet";
            this.transGlobalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.transGlobalDataSet;
            this.empleadosBindingSource.PositionChanged += new System.EventHandler(this.empleadosBindingSource_PositionChanged);
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CamionesTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = this.empleadosTableAdapter;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.Ruta_DetalleTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Ventas_DetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // empleadosIDTextBox
            // 
            this.empleadosIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "EmpleadosID", true));
            this.empleadosIDTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadosIDTextBox.Location = new System.Drawing.Point(124, 81);
            this.empleadosIDTextBox.Name = "empleadosIDTextBox";
            this.empleadosIDTextBox.Size = new System.Drawing.Size(32, 22);
            this.empleadosIDTextBox.TabIndex = 341;
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Alias", true));
            this.aliasTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aliasTextBox.Location = new System.Drawing.Point(124, 107);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(105, 22);
            this.aliasTextBox.TabIndex = 1;
            this.aliasTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aliasTextBox_KeyDown);
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Contrasena", true));
            this.contrasenaTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaTextBox.Location = new System.Drawing.Point(124, 159);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.Size = new System.Drawing.Size(105, 22);
            this.contrasenaTextBox.TabIndex = 3;
            this.contrasenaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contrasenaTextBox_KeyDown);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(124, 185);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 22);
            this.nombreTextBox.TabIndex = 4;
            this.nombreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombreTextBox_KeyDown);
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "DNI", true));
            this.dNITextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dNITextBox.Location = new System.Drawing.Point(124, 211);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(83, 22);
            this.dNITextBox.TabIndex = 5;
            this.dNITextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dNITextBox_KeyDown);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(695, 78);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(80, 22);
            this.telefonoTextBox.TabIndex = 6;
            this.telefonoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.telefonoTextBox_KeyDown);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(695, 104);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(207, 22);
            this.direccionTextBox.TabIndex = 7;
            this.direccionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.direccionTextBox_KeyDown);
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Correo", true));
            this.correoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(695, 130);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(140, 22);
            this.correoTextBox.TabIndex = 8;
            this.correoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.correoTextBox_KeyDown);
            // 
            // fechaContratacionDateTimePicker
            // 
            this.fechaContratacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empleadosBindingSource, "FechaContratacion", true));
            this.fechaContratacionDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaContratacionDateTimePicker.Location = new System.Drawing.Point(695, 156);
            this.fechaContratacionDateTimePicker.Name = "fechaContratacionDateTimePicker";
            this.fechaContratacionDateTimePicker.Size = new System.Drawing.Size(207, 22);
            this.fechaContratacionDateTimePicker.TabIndex = 9;
            this.fechaContratacionDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaContratacionDateTimePicker_KeyDown);
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Salario", true));
            this.salarioTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioTextBox.Location = new System.Drawing.Point(695, 206);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(70, 22);
            this.salarioTextBox.TabIndex = 10;
            this.salarioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salarioTextBox_KeyDown);
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Cargo", true));
            this.cargoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoTextBox.Location = new System.Drawing.Point(695, 232);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(108, 22);
            this.cargoTextBox.TabIndex = 11;
            this.cargoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cargoTextBox_KeyDown);
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empleadosBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(695, 182);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(207, 22);
            this.fechaNacimientoDateTimePicker.TabIndex = 12;
            this.fechaNacimientoDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaNacimientoDateTimePicker_KeyDown);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackgroundImage = global::ProyectoAgus.Properties.Resources.foto2;
            this.fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fotoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.empleadosBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(330, 65);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(247, 212);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox.TabIndex = 367;
            this.fotoPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.fotoPictureBox, "Haz click para añadir o cambiar una imagen");
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rolComboBox
            // 
            this.rolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Rol", true));
            this.rolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.rolComboBox.Location = new System.Drawing.Point(124, 133);
            this.rolComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(105, 21);
            this.rolComboBox.TabIndex = 2;
            this.rolComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rolComboBox_KeyDown);
            // 
            // botonAyuda
            // 
            this.botonAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAyuda.FlatAppearance.BorderSize = 0;
            this.botonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAyuda.Image = global::ProyectoAgus.Properties.Resources.ayudaazul;
            this.botonAyuda.Location = new System.Drawing.Point(860, 6);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Size = new System.Drawing.Size(35, 28);
            this.botonAyuda.TabIndex = 368;
            this.botonAyuda.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAyuda, "Buscar");
            this.botonAyuda.UseVisualStyleBackColor = true;
            this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(905, 320);
            this.Controls.Add(this.botonAyuda);
            this.Controls.Add(this.fechaContratacionDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(empleadosIDLabel);
            this.Controls.Add(this.empleadosIDTextBox);
            this.Controls.Add(aliasLabel);
            this.Controls.Add(this.aliasTextBox);
            this.Controls.Add(rolLabel);
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(fechaContratacionLabel);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(cargoLabel);
            this.Controls.Add(this.cargoTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
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
            this.Controls.Add(this.botonFinal);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.botonAnterior);
            this.Controls.Add(this.botonPrincipio);
            this.Name = "empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private TransGlobalDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private TransGlobalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox empleadosIDTextBox;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.DateTimePicker fechaContratacionDateTimePicker;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button botonAyuda;
    }
}