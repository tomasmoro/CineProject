namespace CineFront.Presentacion.Reportes.ReporteVendedor
{
    partial class ReporteVendedor
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
            this.vENDEDOR = new CineFront.Presentacion.Reportes.ReporteVendedor.VENDEDOR();
            this.vENDEDORRRRRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDEDORRRRRTableAdapter = new CineFront.Presentacion.Reportes.ReporteVendedor.VENDEDORTableAdapters.VENDEDORRRRRTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORRRRRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "VENDEDOR";
            reportDataSource1.Value = this.vENDEDORRRRRBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Presentacion.Reportes.ReporteVendedor.ReporteVendedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1056, 683);
            this.reportViewer1.TabIndex = 0;
            // 
            // vENDEDOR
            // 
            this.vENDEDOR.DataSetName = "VENDEDOR";
            this.vENDEDOR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENDEDORRRRRBindingSource
            // 
            this.vENDEDORRRRRBindingSource.DataMember = "VENDEDORRRRR";
            this.vENDEDORRRRRBindingSource.DataSource = this.vENDEDOR;
            // 
            // vENDEDORRRRRTableAdapter
            // 
            this.vENDEDORRRRRTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 680);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVendedor";
            this.Text = "ReporteVendedor";
            this.Load += new System.EventHandler(this.ReporteVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORRRRRBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private VENDEDOR vENDEDOR;
        private System.Windows.Forms.BindingSource vENDEDORRRRRBindingSource;
        private VENDEDORTableAdapters.VENDEDORRRRRTableAdapter vENDEDORRRRRTableAdapter;
    }
}