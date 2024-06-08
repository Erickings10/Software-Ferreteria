namespace ProyectoMoanso
{
    partial class FormAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCategoriaProd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvEntradaProductos = new System.Windows.Forms.DataGridView();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEliminarEntradaProductos = new System.Windows.Forms.Button();
            this.btnActualizarEntradaProductos = new System.Windows.Forms.Button();
            this.btnAgregarEntradaProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Roboto", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(277, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTRADA DE PRODUCTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod Entrada:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCodEntrada
            // 
            this.txtCodEntrada.Location = new System.Drawing.Point(162, 100);
            this.txtCodEntrada.Name = "txtCodEntrada";
            this.txtCodEntrada.Size = new System.Drawing.Size(99, 20);
            this.txtCodEntrada.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.label4.Location = new System.Drawing.Point(23, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proveedor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Location = new System.Drawing.Point(162, 151);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEntrada.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.label3.Location = new System.Drawing.Point(23, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria Producto:";
            // 
            // cboCategoriaProd
            // 
            this.cboCategoriaProd.FormattingEnabled = true;
            this.cboCategoriaProd.Location = new System.Drawing.Point(162, 248);
            this.cboCategoriaProd.Name = "cboCategoriaProd";
            this.cboCategoriaProd.Size = new System.Drawing.Size(121, 21);
            this.cboCategoriaProd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.label6.Location = new System.Drawing.Point(378, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Producto:";
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(462, 82);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(121, 21);
            this.cboProducto.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.label7.Location = new System.Drawing.Point(371, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(462, 133);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(254, 86);
            this.txtDescripcion.TabIndex = 16;
            // 
            // dgvEntradaProductos
            // 
            this.dgvEntradaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradaProductos.Location = new System.Drawing.Point(74, 288);
            this.dgvEntradaProductos.Name = "dgvEntradaProductos";
            this.dgvEntradaProductos.Size = new System.Drawing.Size(690, 185);
            this.dgvEntradaProductos.TabIndex = 17;
            // 
            // cboProveedor
            // 
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(162, 202);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(121, 21);
            this.cboProveedor.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.label8.Location = new System.Drawing.Point(378, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(462, 231);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 20);
            this.txtCantidad.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(897, 58);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEliminarEntradaProductos
            // 
            this.btnEliminarEntradaProductos.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminarEntradaProductos.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEntradaProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEntradaProductos.Image")));
            this.btnEliminarEntradaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEntradaProductos.Location = new System.Drawing.Point(750, 215);
            this.btnEliminarEntradaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEntradaProductos.Name = "btnEliminarEntradaProductos";
            this.btnEliminarEntradaProductos.Size = new System.Drawing.Size(129, 50);
            this.btnEliminarEntradaProductos.TabIndex = 22;
            this.btnEliminarEntradaProductos.Text = "Inhabilitar";
            this.btnEliminarEntradaProductos.UseVisualStyleBackColor = false;
            // 
            // btnActualizarEntradaProductos
            // 
            this.btnActualizarEntradaProductos.BackColor = System.Drawing.Color.Aqua;
            this.btnActualizarEntradaProductos.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnActualizarEntradaProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarEntradaProductos.Image")));
            this.btnActualizarEntradaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarEntradaProductos.Location = new System.Drawing.Point(750, 151);
            this.btnActualizarEntradaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarEntradaProductos.Name = "btnActualizarEntradaProductos";
            this.btnActualizarEntradaProductos.Size = new System.Drawing.Size(129, 51);
            this.btnActualizarEntradaProductos.TabIndex = 21;
            this.btnActualizarEntradaProductos.Text = "Modificar";
            this.btnActualizarEntradaProductos.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEntradaProductos
            // 
            this.btnAgregarEntradaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarEntradaProductos.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAgregarEntradaProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarEntradaProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEntradaProductos.Image")));
            this.btnAgregarEntradaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEntradaProductos.Location = new System.Drawing.Point(750, 86);
            this.btnAgregarEntradaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEntradaProductos.Name = "btnAgregarEntradaProductos";
            this.btnAgregarEntradaProductos.Size = new System.Drawing.Size(129, 53);
            this.btnAgregarEntradaProductos.TabIndex = 20;
            this.btnAgregarEntradaProductos.Text = "Registrar";
            this.btnAgregarEntradaProductos.UseVisualStyleBackColor = false;
            // 
            // FormAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(897, 485);
            this.Controls.Add(this.btnEliminarEntradaProductos);
            this.Controls.Add(this.btnActualizarEntradaProductos);
            this.Controls.Add(this.btnAgregarEntradaProductos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvEntradaProductos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.cboCategoriaProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAlmacen";
            this.Text = "FormAlmacen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCategoriaProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvEntradaProductos;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarEntradaProductos;
        private System.Windows.Forms.Button btnActualizarEntradaProductos;
        private System.Windows.Forms.Button btnEliminarEntradaProductos;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}