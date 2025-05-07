namespace pryMBergagnaConexionBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpbCargaDeDatos = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gpbCargaDeDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCargaDeDatos
            // 
            this.gpbCargaDeDatos.BackColor = System.Drawing.Color.SteelBlue;
            this.gpbCargaDeDatos.Controls.Add(this.cmbCategoria);
            this.gpbCargaDeDatos.Controls.Add(this.label6);
            this.gpbCargaDeDatos.Controls.Add(this.label5);
            this.gpbCargaDeDatos.Controls.Add(this.nudPrecio);
            this.gpbCargaDeDatos.Controls.Add(this.nudStock);
            this.gpbCargaDeDatos.Controls.Add(this.txtDescripcion);
            this.gpbCargaDeDatos.Controls.Add(this.txtNombre);
            this.gpbCargaDeDatos.Controls.Add(this.label4);
            this.gpbCargaDeDatos.Controls.Add(this.label3);
            this.gpbCargaDeDatos.Controls.Add(this.label2);
            this.gpbCargaDeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCargaDeDatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbCargaDeDatos.Location = new System.Drawing.Point(38, 13);
            this.gpbCargaDeDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbCargaDeDatos.Name = "gpbCargaDeDatos";
            this.gpbCargaDeDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbCargaDeDatos.Size = new System.Drawing.Size(310, 291);
            this.gpbCargaDeDatos.TabIndex = 12;
            this.gpbCargaDeDatos.TabStop = false;
            this.gpbCargaDeDatos.Text = "Carga de Datos";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(147, 253);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(137, 30);
            this.cmbCategoria.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Stock";
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(147, 201);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(102, 28);
            this.nudPrecio.TabIndex = 14;
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(147, 149);
            this.nudStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(102, 28);
            this.nudStock.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 94);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(155, 28);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 28);
            this.txtNombre.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(253, 28);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(165, 28);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(372, 107);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(711, 444);
            this.dgvProductos.TabIndex = 8;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(372, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 70);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Producto";
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(962, 23);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 60);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(426, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 41);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(85, 331);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(202, 53);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::pryMBergagnaConexionBD.Properties.Resources.boton_editar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(85, 392);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(202, 53);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::pryMBergagnaConexionBD.Properties.Resources.eliminar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(85, 453);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 53);
            this.button3.TabIndex = 11;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1122, 575);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbCargaDeDatos);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbCargaDeDatos.ResumeLayout(false);
            this.gpbCargaDeDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCargaDeDatos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
    }
}

