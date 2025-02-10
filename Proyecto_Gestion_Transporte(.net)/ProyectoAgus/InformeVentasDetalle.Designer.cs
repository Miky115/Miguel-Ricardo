namespace ProyectoAgus
{
    partial class InformeVentasDetalle
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
            this.ventasDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transGlobalDataSet = new ProyectoAgus.TransGlobalDataSet();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventasTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.VentasTableAdapter();
            this.ventas_DetalleTableAdapter = new ProyectoAgus.TransGlobalDataSetTableAdapters.Ventas_DetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ventasDetalleBindingSource
            // 
            this.ventasDetalleBindingSource.DataMember = "Ventas_Detalle";
            this.ventasDetalleBindingSource.DataSource = this.transGlobalDataSet;
            // 
            // transGlobalDataSet
            // 
            this.transGlobalDataSet.DataSetName = "TransGlobalDataSet";
            this.transGlobalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.transGlobalDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ventasDetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoAgus.Ventas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(988, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // ventas_DetalleTableAdapter
            // 
            this.ventas_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // InformeVentasDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeVentasDetalle";
            this.Text = "Informe de ventas";
            this.Load += new System.EventHandler(this.InformeVentasDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transGlobalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TransGlobalDataSet transGlobalDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private TransGlobalDataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.BindingSource ventasDetalleBindingSource;
        private TransGlobalDataSetTableAdapters.Ventas_DetalleTableAdapter ventas_DetalleTableAdapter;
    }
}