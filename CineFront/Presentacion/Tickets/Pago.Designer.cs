namespace CineFront.Presentacion.Tickets
{
    partial class Pago
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.lblentradas = new System.Windows.Forms.Label();
            this.cboVendedores = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboClientes);
            this.panel1.Controls.Add(this.lblentradas);
            this.panel1.Controls.Add(this.cboVendedores);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cboFormaPago);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(43, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 422);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "CLIENTE:";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(106, 47);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(213, 21);
            this.cboClientes.TabIndex = 25;
            // 
            // lblentradas
            // 
            this.lblentradas.AutoSize = true;
            this.lblentradas.Location = new System.Drawing.Point(103, 88);
            this.lblentradas.Name = "lblentradas";
            this.lblentradas.Size = new System.Drawing.Size(10, 13);
            this.lblentradas.TabIndex = 23;
            this.lblentradas.Text = "-";
            // 
            // cboVendedores
            // 
            this.cboVendedores.FormattingEnabled = true;
            this.cboVendedores.Location = new System.Drawing.Point(106, 17);
            this.cboVendedores.Name = "cboVendedores";
            this.cboVendedores.Size = new System.Drawing.Size(213, 21);
            this.cboVendedores.TabIndex = 19;
            this.cboVendedores.SelectedIndexChanged += new System.EventHandler(this.cboVendedores_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "VENDEDOR:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "FORMA DE PAGO:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(37, 355);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(10, 13);
            this.lbltotal.TabIndex = 12;
            this.lbltotal.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "TOTAL A PAGAR";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(157, 350);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(121, 21);
            this.cboFormaPago.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entrada,
            this.Precio});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(48, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(319, 113);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.MinimumWidth = 8;
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            this.Entrada.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ASIENTOS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ENTRADAS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Maroon;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gold;
            this.label14.Location = new System.Drawing.Point(161, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "FACTURA STRAR CINEPLEX";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CineFront.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(511, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 596);
            this.MinimumSize = new System.Drawing.Size(527, 596);
            this.Name = "Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblentradas;
        private System.Windows.Forms.ComboBox cboVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClientes;
    }
}