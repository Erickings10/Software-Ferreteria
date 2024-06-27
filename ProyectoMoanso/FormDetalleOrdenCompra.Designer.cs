namespace ProyectoMoanso
{
    partial class FormDetalleOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleOrdenCompra));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvNuevoReq = new System.Windows.Forms.DataGridView();
            this.gboRequerimientos = new System.Windows.Forms.GroupBox();
            this.btnBuscarRequerimiento = new FontAwesome.Sharp.IconButton();
            this.txtRequerimiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.chboEstadoReque = new System.Windows.Forms.CheckBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmReque = new System.Windows.Forms.DateTimePicker();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txtDeshabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevoReq)).BeginInit();
            this.gboRequerimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(101, 449);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 36);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnAgregar.Image = global::ProyectoMoanso.Properties.Resources.enviar_orden;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(24, 407);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 36);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvNuevoReq
            // 
            this.dgvNuevoReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevoReq.Location = new System.Drawing.Point(300, 22);
            this.dgvNuevoReq.Name = "dgvNuevoReq";
            this.dgvNuevoReq.Size = new System.Drawing.Size(574, 463);
            this.dgvNuevoReq.TabIndex = 47;
            // 
            // gboRequerimientos
            // 
            this.gboRequerimientos.Controls.Add(this.btnBuscarRequerimiento);
            this.gboRequerimientos.Controls.Add(this.txtRequerimiento);
            this.gboRequerimientos.Controls.Add(this.label3);
            this.gboRequerimientos.Controls.Add(this.btnBuscarProducto);
            this.gboRequerimientos.Controls.Add(this.txtCategoria);
            this.gboRequerimientos.Controls.Add(this.chboEstadoReque);
            this.gboRequerimientos.Controls.Add(this.txtCantidad);
            this.gboRequerimientos.Controls.Add(this.lblModelo);
            this.gboRequerimientos.Controls.Add(this.label2);
            this.gboRequerimientos.Controls.Add(this.dtmReque);
            this.gboRequerimientos.Controls.Add(this.lblCodigo);
            this.gboRequerimientos.Controls.Add(this.label1);
            this.gboRequerimientos.Controls.Add(this.txtCodigo);
            this.gboRequerimientos.Controls.Add(this.label5);
            this.gboRequerimientos.Controls.Add(this.txtProducto);
            this.gboRequerimientos.Controls.Add(this.lblMarca);
            this.gboRequerimientos.Controls.Add(this.txt_marca);
            this.gboRequerimientos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboRequerimientos.Location = new System.Drawing.Point(12, 22);
            this.gboRequerimientos.Name = "gboRequerimientos";
            this.gboRequerimientos.Size = new System.Drawing.Size(267, 370);
            this.gboRequerimientos.TabIndex = 46;
            this.gboRequerimientos.TabStop = false;
            this.gboRequerimientos.Text = "DATOS:";
            // 
            // btnBuscarRequerimiento
            // 
            this.btnBuscarRequerimiento.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarRequerimiento.IconColor = System.Drawing.Color.Black;
            this.btnBuscarRequerimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarRequerimiento.IconSize = 18;
            this.btnBuscarRequerimiento.Location = new System.Drawing.Point(234, 70);
            this.btnBuscarRequerimiento.Name = "btnBuscarRequerimiento";
            this.btnBuscarRequerimiento.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarRequerimiento.TabIndex = 45;
            this.btnBuscarRequerimiento.UseVisualStyleBackColor = true;
            this.btnBuscarRequerimiento.Click += new System.EventHandler(this.btnBuscarRequerimiento_Click);
            // 
            // txtRequerimiento
            // 
            this.txtRequerimiento.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtRequerimiento.Location = new System.Drawing.Point(116, 70);
            this.txtRequerimiento.Name = "txtRequerimiento";
            this.txtRequerimiento.Size = new System.Drawing.Size(112, 22);
            this.txtRequerimiento.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F);
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Requerimiento";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 18;
            this.btnBuscarProducto.Location = new System.Drawing.Point(234, 115);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarProducto.TabIndex = 42;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtCategoria.Location = new System.Drawing.Point(117, 208);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(112, 22);
            this.txtCategoria.TabIndex = 37;
            // 
            // chboEstadoReque
            // 
            this.chboEstadoReque.AutoSize = true;
            this.chboEstadoReque.Font = new System.Drawing.Font("Roboto", 10F);
            this.chboEstadoReque.Location = new System.Drawing.Point(37, 339);
            this.chboEstadoReque.Name = "chboEstadoReque";
            this.chboEstadoReque.Size = new System.Drawing.Size(183, 21);
            this.chboEstadoReque.TabIndex = 35;
            this.chboEstadoReque.Text = "Estado Orden de Compra";
            this.chboEstadoReque.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtCantidad.Location = new System.Drawing.Point(116, 253);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(112, 22);
            this.txtCantidad.TabIndex = 31;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblModelo.Location = new System.Drawing.Point(20, 208);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(69, 17);
            this.lblModelo.TabIndex = 36;
            this.lblModelo.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F);
            this.label2.Location = new System.Drawing.Point(21, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cantidad:";
            // 
            // dtmReque
            // 
            this.dtmReque.Font = new System.Drawing.Font("Roboto", 9F);
            this.dtmReque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmReque.Location = new System.Drawing.Point(116, 299);
            this.dtmReque.Name = "dtmReque";
            this.dtmReque.Size = new System.Drawing.Size(111, 22);
            this.dtmReque.TabIndex = 33;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(34, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 17);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F);
            this.label1.Location = new System.Drawing.Point(38, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(116, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(28, 22);
            this.txtCodigo.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F);
            this.label5.Location = new System.Drawing.Point(33, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtProducto.Location = new System.Drawing.Point(117, 115);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(112, 22);
            this.txtProducto.TabIndex = 28;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblMarca.Location = new System.Drawing.Point(38, 164);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 29;
            this.lblMarca.Text = "Marca:";
            // 
            // txt_marca
            // 
            this.txt_marca.Font = new System.Drawing.Font("Roboto", 9F);
            this.txt_marca.Location = new System.Drawing.Point(116, 162);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(112, 22);
            this.txt_marca.TabIndex = 30;
            // 
            // txtDeshabilitar
            // 
            this.txtDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtDeshabilitar.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtDeshabilitar.Image = global::ProyectoMoanso.Properties.Resources.cancelar_orden;
            this.txtDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDeshabilitar.Location = new System.Drawing.Point(146, 407);
            this.txtDeshabilitar.Name = "txtDeshabilitar";
            this.txtDeshabilitar.Size = new System.Drawing.Size(133, 36);
            this.txtDeshabilitar.TabIndex = 50;
            this.txtDeshabilitar.Text = "Deshabilitar";
            this.txtDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // FormDetalleOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(886, 505);
            this.Controls.Add(this.txtDeshabilitar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvNuevoReq);
            this.Controls.Add(this.gboRequerimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetalleOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDetalleOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevoReq)).EndInit();
            this.gboRequerimientos.ResumeLayout(false);
            this.gboRequerimientos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvNuevoReq;
        private System.Windows.Forms.GroupBox gboRequerimientos;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.CheckBox chboEstadoReque;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmReque;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnBuscarRequerimiento;
        private System.Windows.Forms.TextBox txtRequerimiento;
        private System.Windows.Forms.Button txtDeshabilitar;
    }
}