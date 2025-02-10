namespace ProyectoAgus
{
    partial class Form1
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
            System.Windows.Forms.Label aliasLabel;
            System.Windows.Forms.Label contrasenaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.transGlobalDataSet = new ProyectoAgus.TransGlobalDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new ProyectoAgus.TransGlobalDataSetTableAdapters.TableAdapterManager();
            this.alias = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.botonVer = new System.Windows.Forms.Button();
            this.botonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ayuda = new System.Windows.Forms.ToolStripButton();
            this.bienvenido = new System.Windows.Forms.ToolStripButton();
            aliasLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aliasLabel
            // 
            aliasLabel.AutoSize = true;
            aliasLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aliasLabel.ForeColor = System.Drawing.SystemColors.Control;
            aliasLabel.Location = new System.Drawing.Point(115, 249);
            aliasLabel.Name = "aliasLabel";
            aliasLabel.Size = new System.Drawing.Size(38, 13);
            aliasLabel.TabIndex = 12;
            aliasLabel.Text = "Alias:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrasenaLabel.ForeColor = System.Drawing.SystemColors.Control;
            contrasenaLabel.Location = new System.Drawing.Point(83, 275);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(72, 13);
            contrasenaLabel.TabIndex = 13;
            contrasenaLabel.Text = "Contrasena:";
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
            // alias
            // 
            this.alias.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alias.Location = new System.Drawing.Point(156, 246);
            this.alias.Name = "alias";
            this.alias.Size = new System.Drawing.Size(100, 22);
            this.alias.TabIndex = 14;
            this.alias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.alias_KeyDown);
            // 
            // contrasena
            // 
            this.contrasena.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasena.Location = new System.Drawing.Point(156, 273);
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '*';
            this.contrasena.Size = new System.Drawing.Size(100, 22);
            this.contrasena.TabIndex = 15;
            this.contrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contrasena_KeyDown);
            // 
            // botonVer
            // 
            this.botonVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVer.FlatAppearance.BorderSize = 0;
            this.botonVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVer.Image = global::ProyectoAgus.Properties.Resources.mostrar;
            this.botonVer.Location = new System.Drawing.Point(262, 267);
            this.botonVer.Name = "botonVer";
            this.botonVer.Size = new System.Drawing.Size(31, 31);
            this.botonVer.TabIndex = 16;
            this.botonVer.UseVisualStyleBackColor = true;
            this.botonVer.Click += new System.EventHandler(this.botonVer_Click);
            // 
            // botonLogin
            // 
            this.botonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLogin.FlatAppearance.BorderSize = 0;
            this.botonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLogin.Image = global::ProyectoAgus.Properties.Resources.iniciarsesion;
            this.botonLogin.Location = new System.Drawing.Point(291, 267);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(35, 30);
            this.botonLogin.TabIndex = 12;
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoAgus.Properties.Resources.TransGlobalSinFondo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayuda,
            this.bienvenido});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(403, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ayuda
            // 
            this.ayuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ayuda.Image = ((System.Drawing.Image)(resources.GetObject("ayuda.Image")));
            this.ayuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(45, 22);
            this.ayuda.Text = "Ayuda";
            this.ayuda.Click += new System.EventHandler(this.ayuda_Click);
            // 
            // bienvenido
            // 
            this.bienvenido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bienvenido.Image = ((System.Drawing.Image)(resources.GetObject("bienvenido.Image")));
            this.bienvenido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bienvenido.Name = "bienvenido";
            this.bienvenido.Size = new System.Drawing.Size(70, 22);
            this.bienvenido.Text = "Bienvenido";
            this.bienvenido.ToolTipText = "bienvenido";
            this.bienvenido.Click += new System.EventHandler(this.bienvenido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(403, 316);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonVer);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.alias);
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(aliasLabel);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "TransGlobal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransGlobalDataSet transGlobalDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private TransGlobalDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private TransGlobalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox alias;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Button botonVer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ayuda;
        private System.Windows.Forms.ToolStripButton bienvenido;
    }
}