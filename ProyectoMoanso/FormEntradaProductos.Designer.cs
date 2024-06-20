namespace ProyectoMoanso
{
    partial class FormEntradaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntradaProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvEntradaProductos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEliminarEntradaProductos = new System.Windows.Forms.Button();
            this.btnActualizarEntradaProductos = new System.Windows.Forms.Button();
            this.btnAgregarEntradaProductos = new System.Windows.Forms.Button();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.btnProovedor = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTRADA DE PRODUCTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(23, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proveedor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(23, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(23, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(313, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(404, 103);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 86);
            this.txtDescripcion.TabIndex = 16;
            // 
            // dgvEntradaProductos
            // 
            this.dgvEntradaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradaProductos.Location = new System.Drawing.Point(26, 288);
            this.dgvEntradaProductos.Name = "dgvEntradaProductos";
            this.dgvEntradaProductos.Size = new System.Drawing.Size(844, 219);
            this.dgvEntradaProductos.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.Location = new System.Drawing.Point(313, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(386, 245);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(103, 20);
            this.txtCantidad.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(922, 58);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEliminarEntradaProductos
            // 
            this.btnEliminarEntradaProductos.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminarEntradaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
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
            this.btnActualizarEntradaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
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
            this.btnAgregarEntradaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
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
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(162, 151);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(121, 23);
            this.dtpFechaEntrada.TabIndex = 29;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtProveedor.Location = new System.Drawing.Point(110, 200);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(60, 21);
            this.txtProveedor.TabIndex = 35;
            // 
            // btnProovedor
            // 
            this.btnProovedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnProovedor.IconColor = System.Drawing.Color.Black;
            this.btnProovedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProovedor.IconSize = 18;
            this.btnProovedor.Location = new System.Drawing.Point(188, 200);
            this.btnProovedor.Name = "btnProovedor";
            this.btnProovedor.Size = new System.Drawing.Size(24, 24);
            this.btnProovedor.TabIndex = 37;
            this.btnProovedor.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox1.Location = new System.Drawing.Point(110, 248);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(60, 21);
            this.textBox1.TabIndex = 40;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(188, 247);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(24, 24);
            this.iconButton1.TabIndex = 41;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // FormEntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(922, 535);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProovedor);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.btnEliminarEntradaProductos);
            this.Controls.Add(this.btnActualizarEntradaProductos);
            this.Controls.Add(this.btnAgregarEntradaProductos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvEntradaProductos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEntradaProductos";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvEntradaProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarEntradaProductos;
        private System.Windows.Forms.Button btnActualizarEntradaProductos;
        private System.Windows.Forms.Button btnEliminarEntradaProductos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.TextBox txtProveedor;
        private FontAwesome.Sharp.IconButton btnProovedor;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}