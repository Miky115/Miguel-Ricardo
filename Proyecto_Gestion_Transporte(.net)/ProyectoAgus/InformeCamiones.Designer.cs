namespace ProyectoAgus
{
    partial class InformeCamiones
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.camionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transGlobalDataSet = new ProyectoAgus.TransGlobalDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.camionesTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.CamionesTableAdapter();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.buscarComboBox = new System.Windows.Forms.ComboBox();
            this.buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.camionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // camionesBindingSource
            // 
            this.camionesBindingSource.DataMember = "Camiones";
            this.camionesBindingSource.DataSource = this.transGlobalDataSet;
            // 
            // transGlobalDataSet
            // 
            this.transGlobalDataSet.DataSetName = "TransGlobalDataSet";
            this.transGlobalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.camionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoAgus.Camiones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(682, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // camionesTableAdapter
            // 
            this.camionesTableAdapter.ClearBeforeFill = true;
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(764, 270);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(75, 23);
            this.botonBorrar.TabIndex = 8;
            this.botonBorrar.Text = "Quitar filtro";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(764, 241);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 7;
            this.botonBuscar.Text = "Filtrar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // buscarComboBox
            // 
            this.buscarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buscarComboBox.FormattingEnabled = true;
            this.buscarComboBox.Items.AddRange(new object[] {
            "Tipo Camion",
            "Marca",
            "Tipo Combustible"});
            this.buscarComboBox.Location = new System.Drawing.Point(718, 178);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(121, 21);
            this.buscarComboBox.TabIndex = 6;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(718, 205);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(121, 20);
            this.buscar.TabIndex = 5;
            // 
            // InformeCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.buscarComboBox);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeCamiones";
            this.Text = "Informe de camiones";
            this.Load += new System.EventHandler(this.InformeCamiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TransGlobalDataSet transGlobalDataSet;
        private System.Windows.Forms.BindingSource camionesBindingSource;
        private TransGlobalDataSetTableAdapters.CamionesTableAdapter camionesTableAdapter;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.ComboBox buscarComboBox;
        private System.Windows.Forms.TextBox buscar;
    }
}