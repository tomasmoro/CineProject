namespace CineFront.Presentacion.Reportes.ReporteCliente
{
    partial class ReporteCliente
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cliente = new CineFront.Presentacion.Reportes.ReporteCliente.Cliente();
            this.dtClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtClienteTableAdapter = new CineFront.Presentacion.Reportes.ReporteCliente.ClienteTableAdapters.DtClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "CLIENTE";
            reportDataSource1.Value = this.dtClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Presentacion.Reportes.ReporteCliente.ReporteCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1069, 578);
            this.reportViewer1.TabIndex = 0;
            // 
            // cliente
            // 
            this.cliente.DataSetName = "Cliente";
            this.cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtClienteBindingSource
            // 
            this.dtClienteBindingSource.DataMember = "DtCliente";
            this.dtClienteBindingSource.DataSource = this.cliente;
            // 
            // dtClienteTableAdapter
            // 
            this.dtClienteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 582);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCliente";
            this.Text = "ReporteCliente";
            this.Load += new System.EventHandler(this.ReporteCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Cliente cliente;
        private System.Windows.Forms.BindingSource dtClienteBindingSource;
        private ClienteTableAdapters.DtClienteTableAdapter dtClienteTableAdapter;
    }
}