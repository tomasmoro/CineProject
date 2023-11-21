namespace CineFront.Presentacion.Reportes
{
    partial class ReportesProducto
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
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto = new CineFront.Presentacion.Reportes.ReportProduc.Producto();
            this.pRODUCTOSTableAdapter = new CineFront.Presentacion.Reportes.ReportProduc.ProductoTableAdapters.PRODUCTOSTableAdapter();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PRODUCTO";
            reportDataSource1.Value = this.pRODUCTOSBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Presentacion.Reportes.ReportProduc.ReporteProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.producto;
            // 
            // producto
            // 
            this.producto.DataSetName = "Producto";
            this.producto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = this.producto;
            this.productoBindingSource.Position = 0;
            // 
            // pRODUCTOSBindingSource1
            // 
            this.pRODUCTOSBindingSource1.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource1.DataSource = this.productoBindingSource;
            // 
            // ReportesProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesProducto";
            this.Text = "ReportesProducto";
            this.Load += new System.EventHandler(this.ReportesProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportProduc.Producto producto;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private ReportProduc.ProductoTableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource1;
        private System.Windows.Forms.BindingSource productoBindingSource;
    }
}