namespace CineFront.Presentacion.Registros
{
    partial class RegistroCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAtras = new System.Windows.Forms.PictureBox();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(794, 603);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(228, 62);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Agregar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre_Apellido,
            this.Fecha,
            this.Correo,
            this.Quitar,
            this.colModificar});
            this.dataGridView1.Location = new System.Drawing.Point(42, 170);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 343);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(153, 117);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(291, 26);
            this.txtCodigo.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(79, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(178, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 56);
            this.label1.TabIndex = 20;
            this.label1.Text = "CLIENTE";
            // 
            // pbAtras
            // 
            this.pbAtras.BackColor = System.Drawing.Color.Transparent;
            this.pbAtras.BackgroundImage = global::CineFront.Properties.Resources._580b57fcd9996e24bc43c44c1;
            this.pbAtras.Image = global::CineFront.Properties.Resources._580b57fcd9996e24bc43c44c1;
            this.pbAtras.Location = new System.Drawing.Point(14, 5);
            this.pbAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAtras.Name = "pbAtras";
            this.pbAtras.Size = new System.Drawing.Size(105, 94);
            this.pbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAtras.TabIndex = 25;
            this.pbAtras.TabStop = false;
            this.pbAtras.Click += new System.EventHandler(this.pbAtras_Click);
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 150;
            // 
            // Nombre_Apellido
            // 
            this.Nombre_Apellido.HeaderText = "Nombre_Apellido";
            this.Nombre_Apellido.MinimumWidth = 6;
            this.Nombre_Apellido.Name = "Nombre_Apellido";
            this.Nombre_Apellido.ReadOnly = true;
            this.Nombre_Apellido.Width = 200;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 200;
            // 
            // Quitar
            // 
            this.Quitar.HeaderText = "Quitar";
            this.Quitar.MinimumWidth = 6;
            this.Quitar.Name = "Quitar";
            this.Quitar.ReadOnly = true;
            this.Quitar.Width = 125;
            // 
            // colModificar
            // 
            this.colModificar.HeaderText = "Modificar";
            this.colModificar.MinimumWidth = 8;
            this.colModificar.Name = "colModificar";
            this.colModificar.ReadOnly = true;
            this.colModificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colModificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colModificar.Width = 150;
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CineFront.Properties.Resources.Fondo1;
            this.ClientSize = new System.Drawing.Size(1186, 698);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbAtras);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "RegistroCliente";
            this.Text = "RegistroCliente";
            this.Load += new System.EventHandler(this.RegistroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbAtras;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar;
        private System.Windows.Forms.DataGridViewButtonColumn colModificar;
    }
}