namespace ProyectoAgus
{
    partial class InformeRutasDetalle
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
            this.rutaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transGlobalDataSet = new ProyectoAgus.TransGlobalDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ruta_DetalleTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.Ruta_DetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rutaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rutaDetalleBindingSource
            // 
            this.rutaDetalleBindingSource.DataMember = "Ruta_Detalle";
            this.rutaDetalleBindingSource.DataSource = this.transGlobalDataSet;
            // 
            // transGlobalDataSet
            // 
            this.transGlobalDataSet.DataSetName = "TransGlobalDataSet";
            this.transGlobalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rutaDetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoAgus.RutasDetalle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ruta_DetalleTableAdapter
            // 
            this.ruta_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // InformeRutasDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeRutasDetalle";
            this.Text = "Informe de rutas";
            this.Load += new System.EventHandler(this.InformeRutasDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rutaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TransGlobalDataSet transGlobalDataSet;
        private System.Windows.Forms.BindingSource rutaDetalleBindingSource;
        private TransGlobalDataSetTableAdapters.Ruta_DetalleTableAdapter ruta_DetalleTableAdapter;
    }
}