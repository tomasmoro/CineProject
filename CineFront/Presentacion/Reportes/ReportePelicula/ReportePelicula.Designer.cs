namespace CineFront.Presentacion.Reportes.ReportePelicula
{
    partial class ReportePelicula
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
            this.pELICULASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pelicula = new CineFront.Presentacion.Reportes.ReportePelicula.Pelicula();
            this.pELICULASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pELICULASTableAdapter = new CineFront.Presentacion.Reportes.ReportePelicula.PeliculaTableAdapters.PELICULASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pELICULASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELICULASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PELICULA";
            reportDataSource1.Value = this.pELICULASBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Presentacion.Reportes.ReportePelicula.ReportePelicula.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // pELICULASBindingSource1
            // 
            this.pELICULASBindingSource1.DataMember = "PELICULAS";
            this.pELICULASBindingSource1.DataSource = this.pelicula;
            // 
            // pelicula
            // 
            this.pelicula.DataSetName = "Pelicula";
            this.pelicula.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pELICULASBindingSource
            // 
            this.pELICULASBindingSource.DataMember = "PELICULAS";
            this.pELICULASBindingSource.DataSource = this.pelicula;
            // 
            // pELICULASTableAdapter
            // 
            this.pELICULASTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePelicula";
            this.Text = "ReportePelicula";
            this.Load += new System.EventHandler(this.ReportePelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pELICULASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELICULASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Pelicula pelicula;
        private System.Windows.Forms.BindingSource pELICULASBindingSource;
        private PeliculaTableAdapters.PELICULASTableAdapter pELICULASTableAdapter;
        private System.Windows.Forms.BindingSource pELICULASBindingSource1;
    }
}