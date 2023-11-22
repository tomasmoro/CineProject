namespace CineFront.Presentacion.Reportes.ReportProduc
{
    partial class ReporteProducto
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
            this.pRODUCTO = new CineFront.Presentacion.Reportes.ReportProduc.PRODUCTO();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOSTableAdapter = new CineFront.Presentacion.Reportes.ReportProduc.PRODUCTOTableAdapters.PRODUCTOSTableAdapter();
            this.pRODUCTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pRODUCTOSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pRODUCTO
            // 
            this.pRODUCTO.DataSetName = "PRODUCTO";
            this.pRODUCTO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.pRODUCTO;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTOSBindingSource1
            // 
            this.pRODUCTOSBindingSource1.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource1.DataSource = this.pRODUCTO;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PRODUCTO";
            reportDataSource1.Value = this.pRODUCTOSBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Presentacion.Reportes.ReportProduc.ReporteProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1065, 629);
            this.reportViewer1.TabIndex = 0;
            // 
            // pRODUCTOSBindingSource2
            // 
            this.pRODUCTOSBindingSource2.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource2.DataSource = this.pRODUCTO;
            // 
            // ReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 689);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProducto";
            this.Text = "ReporteProducto";
            this.Load += new System.EventHandler(this.ReporteProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PRODUCTO pRODUCTO;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private PRODUCTOTableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource2;
    }
}