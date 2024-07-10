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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvEntradaProductos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.chbx_Estado = new System.Windows.Forms.CheckBox();
            this.gboDatos = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.cboAlmacen = new System.Windows.Forms.ComboBox();
            this.btnBuscarProductos = new FontAwesome.Sharp.IconButton();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaProductos)).BeginInit();
            this.gboDatos.SuspendLayout();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(33, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(122, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(46, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(285, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(33, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(266, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(354, 22);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(163, 86);
            this.txtDescripcion.TabIndex = 16;
            // 
            // dgvEntradaProductos
            // 
            this.dgvEntradaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradaProductos.Location = new System.Drawing.Point(26, 288);
            this.dgvEntradaProductos.Name = "dgvEntradaProductos";
            this.dgvEntradaProductos.ReadOnly = true;
            this.dgvEntradaProductos.Size = new System.Drawing.Size(844, 219);
            this.dgvEntradaProductos.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(34, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(122, 169);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(103, 22);
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
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(354, 129);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(163, 23);
            this.dtpFechaEntrada.TabIndex = 29;
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.AutoSize = true;
            this.lblAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAlmacen.Location = new System.Drawing.Point(33, 88);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(70, 17);
            this.lblAlmacen.TabIndex = 42;
            this.lblAlmacen.Text = "Almacen: ";
            // 
            // chbx_Estado
            // 
            this.chbx_Estado.AutoSize = true;
            this.chbx_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbx_Estado.Location = new System.Drawing.Point(565, 182);
            this.chbx_Estado.Margin = new System.Windows.Forms.Padding(2);
            this.chbx_Estado.Name = "chbx_Estado";
            this.chbx_Estado.Size = new System.Drawing.Size(71, 21);
            this.chbx_Estado.TabIndex = 44;
            this.chbx_Estado.Text = "Estado";
            this.chbx_Estado.UseVisualStyleBackColor = true;
            // 
            // gboDatos
            // 
            this.gboDatos.Controls.Add(this.txtProducto);
            this.gboDatos.Controls.Add(this.txtidProducto);
            this.gboDatos.Controls.Add(this.chbEstado);
            this.gboDatos.Controls.Add(this.cboAlmacen);
            this.gboDatos.Controls.Add(this.chbx_Estado);
            this.gboDatos.Controls.Add(this.dtpFechaEntrada);
            this.gboDatos.Controls.Add(this.label2);
            this.gboDatos.Controls.Add(this.txtCodigo);
            this.gboDatos.Controls.Add(this.label6);
            this.gboDatos.Controls.Add(this.lblAlmacen);
            this.gboDatos.Controls.Add(this.label8);
            this.gboDatos.Controls.Add(this.txtDescripcion);
            this.gboDatos.Controls.Add(this.label7);
            this.gboDatos.Controls.Add(this.btnBuscarProductos);
            this.gboDatos.Controls.Add(this.label3);
            this.gboDatos.Controls.Add(this.txtCantidad);
            this.gboDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDatos.Location = new System.Drawing.Point(198, 61);
            this.gboDatos.Name = "gboDatos";
            this.gboDatos.Size = new System.Drawing.Size(537, 204);
            this.gboDatos.TabIndex = 46;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "Datos";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(129, 131);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(103, 22);
            this.txtProducto.TabIndex = 49;
            // 
            // txtidProducto
            // 
            this.txtidProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtidProducto.Location = new System.Drawing.Point(94, 132);
            this.txtidProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.ReadOnly = true;
            this.txtidProducto.Size = new System.Drawing.Size(30, 21);
            this.txtidProducto.TabIndex = 47;
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbEstado.Location = new System.Drawing.Point(446, 171);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(71, 21);
            this.chbEstado.TabIndex = 46;
            this.chbEstado.Text = "Estado";
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // cboAlmacen
            // 
            this.cboAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboAlmacen.FormattingEnabled = true;
            this.cboAlmacen.Location = new System.Drawing.Point(129, 85);
            this.cboAlmacen.Name = "cboAlmacen";
            this.cboAlmacen.Size = new System.Drawing.Size(103, 23);
            this.cboAlmacen.TabIndex = 45;
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProductos.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProductos.IconSize = 18;
            this.btnBuscarProductos.Location = new System.Drawing.Point(231, 131);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarProductos.TabIndex = 41;
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(26, 190);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(149, 41);
            this.btn_Cancelar.TabIndex = 48;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(26, 121);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(149, 39);
            this.btn_nuevo.TabIndex = 47;
            this.btn_nuevo.Text = "Nuevo ";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.Tomato;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeshabilitar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitar.Image")));
            this.btnDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitar.Location = new System.Drawing.Point(750, 215);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(129, 50);
            this.btnDeshabilitar.TabIndex = 22;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Aqua;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(750, 151);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 51);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(750, 86);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 53);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FormEntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(922, 535);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.gboDatos);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvEntradaProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEntradaProductos";
            this.Text = "FormAlmacen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaProductos)).EndInit();
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvEntradaProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private FontAwesome.Sharp.IconButton btnBuscarProductos;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.CheckBox chbx_Estado;
        private System.Windows.Forms.GroupBox gboDatos;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cboAlmacen;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.TextBox txtProducto;
    }
}