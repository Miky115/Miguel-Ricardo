namespace ProyectoAgus
{
    partial class productos
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
            System.Windows.Forms.Label productoIDLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label iSBNLabel;
            this.buscar = new System.Windows.Forms.TextBox();
            this.buscarComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transGlobalDataSet = new ProyectoAgus.TransGlobalDataSet();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager();
            this.productoIDTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.botonAyuda = new System.Windows.Forms.Button();
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
            productoIDLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productoIDLabel
            // 
            productoIDLabel.AutoSize = true;
            productoIDLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productoIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            productoIDLabel.Location = new System.Drawing.Point(47, 93);
            productoIDLabel.Name = "productoIDLabel";
            productoIDLabel.Size = new System.Drawing.Size(72, 13);
            productoIDLabel.TabIndex = 340;
            productoIDLabel.Text = "Producto ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.SystemColors.Control;
            nombreLabel.Location = new System.Drawing.Point(47, 119);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(52, 13);
            nombreLabel.TabIndex = 342;
            nombreLabel.Text = "Nombre:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.ForeColor = System.Drawing.SystemColors.Control;
            precioLabel.Location = new System.Drawing.Point(47, 145);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(44, 13);
            precioLabel.TabIndex = 344;
            precioLabel.Text = "Precio:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pesoLabel.ForeColor = System.Drawing.SystemColors.Control;
            pesoLabel.Location = new System.Drawing.Point(47, 171);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(35, 13);
            pesoLabel.TabIndex = 346;
            pesoLabel.Text = "Peso:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.ForeColor = System.Drawing.SystemColors.Control;
            stockLabel.Location = new System.Drawing.Point(47, 197);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(40, 13);
            stockLabel.TabIndex = 348;
            stockLabel.Text = "Stock:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSBNLabel.ForeColor = System.Drawing.SystemColors.Control;
            iSBNLabel.Location = new System.Drawing.Point(47, 223);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(38, 13);
            iSBNLabel.TabIndex = 350;
            iSBNLabel.Text = "ISBN:";
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(567, 12);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(100, 22);
            this.buscar.TabIndex = 8;
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
            "Buscar por ISBN"});
            this.buscarComboBox.Location = new System.Drawing.Point(456, 13);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(105, 21);
            this.buscarComboBox.TabIndex = 317;
            this.buscarComboBox.TabStop = false;
            this.buscarComboBox.Text = "Buscar por Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 311;
            this.label1.Text = "Producto x de x";
            // 
            // transGlobalDataSet
            // 
            this.transGlobalDataSet.DataSetName = "TransGlobalDataSet";
            this.transGlobalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.transGlobalDataSet;
            this.productoBindingSource.PositionChanged += new System.EventHandler(this.productoBindingSource_PositionChanged);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CamionesTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.Ruta_DetalleTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Ventas_DetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // productoIDTextBox
            // 
            this.productoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "ProductoID", true));
            this.productoIDTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoIDTextBox.Location = new System.Drawing.Point(120, 90);
            this.productoIDTextBox.Name = "productoIDTextBox";
            this.productoIDTextBox.Size = new System.Drawing.Size(25, 22);
            this.productoIDTextBox.TabIndex = 341;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(120, 116);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(122, 22);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombreTextBox_KeyDown);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(120, 142);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(50, 22);
            this.precioTextBox.TabIndex = 2;
            this.precioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.precioTextBox_KeyDown);
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Peso", true));
            this.pesoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoTextBox.Location = new System.Drawing.Point(120, 168);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(60, 22);
            this.pesoTextBox.TabIndex = 3;
            this.pesoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pesoTextBox_KeyDown);
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Stock", true));
            this.stockTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTextBox.Location = new System.Drawing.Point(120, 194);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(60, 22);
            this.stockTextBox.TabIndex = 4;
            this.stockTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stockTextBox_KeyDown);
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "ISBN", true));
            this.iSBNTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSBNTextBox.Location = new System.Drawing.Point(120, 220);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 22);
            this.iSBNTextBox.TabIndex = 5;
            this.iSBNTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iSBNTextBox_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.botonAyuda.Location = new System.Drawing.Point(713, 9);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Size = new System.Drawing.Size(37, 31);
            this.botonAyuda.TabIndex = 354;
            this.botonAyuda.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAyuda, "Buscar");
            this.botonAyuda.UseVisualStyleBackColor = true;
            this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackgroundImage = global::ProyectoAgus.Properties.Resources.foto2;
            this.fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fotoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productoBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(277, 61);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(426, 236);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox.TabIndex = 353;
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
            this.botonCerrar.Location = new System.Drawing.Point(5, 285);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(35, 32);
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
            this.botonAceptar.Location = new System.Drawing.Point(150, 248);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(30, 30);
            this.botonAceptar.TabIndex = 6;
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
            this.botonCancelar.Location = new System.Drawing.Point(181, 248);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(39, 30);
            this.botonCancelar.TabIndex = 7;
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
            this.botonImprimir.Location = new System.Drawing.Point(713, 61);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(35, 31);
            this.botonImprimir.TabIndex = 319;
            this.botonImprimir.TabStop = false;
            this.toolTip1.SetToolTip(this.botonImprimir, "Informe del producto");
            this.botonImprimir.UseVisualStyleBackColor = true;
            this.botonImprimir.Click += new System.EventHandler(this.botonImprimir_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscar.FlatAppearance.BorderSize = 0;
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscar.Image = global::ProyectoAgus.Properties.Resources.buscar;
            this.botonBuscar.Location = new System.Drawing.Point(670, 10);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(37, 31);
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
            this.botonGuardar.Location = new System.Drawing.Point(393, 8);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(32, 32);
            this.botonGuardar.TabIndex = 315;
            this.botonGuardar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonGuardar, "Guardar producto");
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEditar.FlatAppearance.BorderSize = 0;
            this.botonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditar.Image = global::ProyectoAgus.Properties.Resources.editar;
            this.botonEditar.Location = new System.Drawing.Point(349, 8);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(38, 32);
            this.botonEditar.TabIndex = 314;
            this.botonEditar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonEditar, "Editar producto");
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBorrar.FlatAppearance.BorderSize = 0;
            this.botonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBorrar.Image = global::ProyectoAgus.Properties.Resources.borrar;
            this.botonBorrar.Location = new System.Drawing.Point(302, 8);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(36, 31);
            this.botonBorrar.TabIndex = 313;
            this.botonBorrar.TabStop = false;
            this.toolTip1.SetToolTip(this.botonBorrar, "Borrar producto");
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // botonAdd
            // 
            this.botonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAdd.FlatAppearance.BorderSize = 0;
            this.botonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAdd.Image = global::ProyectoAgus.Properties.Resources.añadir;
            this.botonAdd.Location = new System.Drawing.Point(262, 8);
            this.botonAdd.Name = "botonAdd";
            this.botonAdd.Size = new System.Drawing.Size(34, 31);
            this.botonAdd.TabIndex = 312;
            this.botonAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAdd, "Añadir producto");
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
            this.botonFinal.Location = new System.Drawing.Point(224, 12);
            this.botonFinal.Name = "botonFinal";
            this.botonFinal.Size = new System.Drawing.Size(30, 23);
            this.botonFinal.TabIndex = 310;
            this.botonFinal.TabStop = false;
            this.toolTip1.SetToolTip(this.botonFinal, "Último producto");
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
            this.botonSiguiente.Location = new System.Drawing.Point(190, 12);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(28, 23);
            this.botonSiguiente.TabIndex = 309;
            this.botonSiguiente.TabStop = false;
            this.toolTip1.SetToolTip(this.botonSiguiente, "Siguiente producto");
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
            this.botonAnterior.Location = new System.Drawing.Point(41, 12);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(29, 23);
            this.botonAnterior.TabIndex = 308;
            this.botonAnterior.TabStop = false;
            this.toolTip1.SetToolTip(this.botonAnterior, "Producto anterior");
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
            this.botonPrincipio.Location = new System.Drawing.Point(5, 11);
            this.botonPrincipio.Name = "botonPrincipio";
            this.botonPrincipio.Size = new System.Drawing.Size(30, 24);
            this.botonPrincipio.TabIndex = 307;
            this.botonPrincipio.TabStop = false;
            this.toolTip1.SetToolTip(this.botonPrincipio, "Primer producto");
            this.botonPrincipio.UseVisualStyleBackColor = true;
            this.botonPrincipio.Click += new System.EventHandler(this.botonPrincipio_Click);
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(756, 323);
            this.Controls.Add(this.botonAyuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(productoIDLabel);
            this.Controls.Add(this.productoIDTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(pesoLabel);
            this.Controls.Add(this.pesoTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
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
            this.Name = "productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource productoBindingSource;
        private TransGlobalDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private TransGlobalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox productoIDTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button botonAyuda;
    }
}