﻿namespace ProyectoMoanso
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvRegistroProducto = new System.Windows.Forms.DataGridView();
            this.errorStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label6 = new System.Windows.Forms.Label();
            this.gbBotones2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.gboDatos = new System.Windows.Forms.GroupBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboMedida = new System.Windows.Forms.ComboBox();
            this.dtPFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadirMedida = new FontAwesome.Sharp.IconButton();
            this.lblMedida = new System.Windows.Forms.Label();
            this.chbxEstado = new System.Windows.Forms.CheckBox();
            this.btnBuscarMarca = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCategoria = new FontAwesome.Sharp.IconButton();
            this.gboBotones1 = new System.Windows.Forms.GroupBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStock)).BeginInit();
            this.gbBotones2.SuspendLayout();
            this.gboDatos.SuspendLayout();
            this.gboBotones1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblId.Location = new System.Drawing.Point(41, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.CausesValidation = false;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(391, 36);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(113, 20);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F);
            this.label4.Location = new System.Drawing.Point(36, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F);
            this.label5.Location = new System.Drawing.Point(36, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(145, 36);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(52, 27);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(516, 31);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(187, 27);
            this.txtDescripcion.TabIndex = 6;
            // 
            // dgvRegistroProducto
            // 
            this.dgvRegistroProducto.AllowUserToAddRows = false;
            this.dgvRegistroProducto.AllowUserToDeleteRows = false;
            this.dgvRegistroProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroProducto.Location = new System.Drawing.Point(44, 363);
            this.dgvRegistroProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRegistroProducto.Name = "dgvRegistroProducto";
            this.dgvRegistroProducto.ReadOnly = true;
            this.dgvRegistroProducto.RowHeadersWidth = 51;
            this.dgvRegistroProducto.RowTemplate.Height = 24;
            this.dgvRegistroProducto.Size = new System.Drawing.Size(857, 290);
            this.dgvRegistroProducto.TabIndex = 10;
            this.dgvRegistroProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroProducto_CellDoubleClick);
            // 
            // errorStock
            // 
            this.errorStock.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1187, 71);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(293, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 40);
            this.label6.TabIndex = 26;
            this.label6.Text = "REGISTRO DE PRODUCTOS";
            // 
            // gbBotones2
            // 
            this.gbBotones2.Controls.Add(this.btnAgregar);
            this.gbBotones2.Controls.Add(this.btnActualizar);
            this.gbBotones2.Controls.Add(this.btnDeshabilitar);
            this.gbBotones2.Location = new System.Drawing.Point(924, 363);
            this.gbBotones2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBotones2.Name = "gbBotones2";
            this.gbBotones2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBotones2.Size = new System.Drawing.Size(231, 290);
            this.gbBotones2.TabIndex = 43;
            this.gbBotones2.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Tan;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::ProyectoMoanso.Properties.Resources.Disco;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(25, 44);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(179, 47);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btn_Guardar_Produc_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Tan;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(25, 119);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(179, 47);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.Tan;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitar.Image")));
            this.btnDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitar.Location = new System.Drawing.Point(25, 199);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(179, 47);
            this.btnDeshabilitar.TabIndex = 14;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // gboDatos
            // 
            this.gboDatos.Controls.Add(this.cboCategoria);
            this.gboDatos.Controls.Add(this.cboMarca);
            this.gboDatos.Controls.Add(this.cboMedida);
            this.gboDatos.Controls.Add(this.dtPFecha);
            this.gboDatos.Controls.Add(this.label7);
            this.gboDatos.Controls.Add(this.txtPrecioVenta);
            this.gboDatos.Controls.Add(this.label2);
            this.gboDatos.Controls.Add(this.txtPrecioCompra);
            this.gboDatos.Controls.Add(this.label1);
            this.gboDatos.Controls.Add(this.btnAñadirMedida);
            this.gboDatos.Controls.Add(this.lblMedida);
            this.gboDatos.Controls.Add(this.chbxEstado);
            this.gboDatos.Controls.Add(this.btnBuscarMarca);
            this.gboDatos.Controls.Add(this.btnBuscarCategoria);
            this.gboDatos.Controls.Add(this.lblDescripcion);
            this.gboDatos.Controls.Add(this.label4);
            this.gboDatos.Controls.Add(this.txtDescripcion);
            this.gboDatos.Controls.Add(this.lblId);
            this.gboDatos.Controls.Add(this.label5);
            this.gboDatos.Controls.Add(this.txtCodigo);
            this.gboDatos.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDatos.Location = new System.Drawing.Point(236, 103);
            this.gboDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboDatos.Name = "gboDatos";
            this.gboDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboDatos.Size = new System.Drawing.Size(899, 234);
            this.gboDatos.TabIndex = 44;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "Datos";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(148, 85);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(129, 27);
            this.cboCategoria.TabIndex = 61;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(147, 133);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(129, 27);
            this.cboMarca.TabIndex = 60;
            // 
            // cboMedida
            // 
            this.cboMedida.FormattingEnabled = true;
            this.cboMedida.Location = new System.Drawing.Point(147, 177);
            this.cboMedida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMedida.Name = "cboMedida";
            this.cboMedida.Size = new System.Drawing.Size(129, 27);
            this.cboMedida.TabIndex = 59;
            // 
            // dtPFecha
            // 
            this.dtPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPFecha.Location = new System.Drawing.Point(516, 177);
            this.dtPFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtPFecha.Name = "dtPFecha";
            this.dtPFecha.Size = new System.Drawing.Size(187, 27);
            this.dtPFecha.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F);
            this.label7.Location = new System.Drawing.Point(444, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Fecha:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(516, 123);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(187, 27);
            this.txtPrecioVenta.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F);
            this.label2.Location = new System.Drawing.Point(391, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(516, 78);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(187, 27);
            this.txtPrecioCompra.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F);
            this.label1.Location = new System.Drawing.Point(373, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Precio Compra:";
            // 
            // btnAñadirMedida
            // 
            this.btnAñadirMedida.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAñadirMedida.IconColor = System.Drawing.Color.Black;
            this.btnAñadirMedida.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnAñadirMedida.IconSize = 19;
            this.btnAñadirMedida.Location = new System.Drawing.Point(287, 177);
            this.btnAñadirMedida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadirMedida.Name = "btnAñadirMedida";
            this.btnAñadirMedida.Size = new System.Drawing.Size(32, 30);
            this.btnAñadirMedida.TabIndex = 51;
            this.btnAñadirMedida.UseVisualStyleBackColor = true;
            this.btnAñadirMedida.Click += new System.EventHandler(this.btnBuscarMedida_Click);
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblMedida.Location = new System.Drawing.Point(36, 177);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(70, 20);
            this.lblMedida.TabIndex = 49;
            this.lblMedida.Text = "Medida:";
            // 
            // chbxEstado
            // 
            this.chbxEstado.AutoSize = true;
            this.chbxEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbxEstado.Location = new System.Drawing.Point(759, 55);
            this.chbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxEstado.Name = "chbxEstado";
            this.chbxEstado.Size = new System.Drawing.Size(84, 24);
            this.chbxEstado.TabIndex = 46;
            this.chbxEstado.Text = "Estado";
            this.chbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnBuscarMarca.IconColor = System.Drawing.Color.Black;
            this.btnBuscarMarca.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnBuscarMarca.IconSize = 19;
            this.btnBuscarMarca.Location = new System.Drawing.Point(287, 132);
            this.btnBuscarMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(32, 30);
            this.btnBuscarMarca.TabIndex = 44;
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnBuscarCategoria.IconColor = System.Drawing.Color.Black;
            this.btnBuscarCategoria.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnBuscarCategoria.IconSize = 19;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(287, 81);
            this.btnBuscarCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(32, 30);
            this.btnBuscarCategoria.TabIndex = 43;
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // gboBotones1
            // 
            this.gboBotones1.Controls.Add(this.btn_Nuevo);
            this.gboBotones1.Controls.Add(this.btn_Cancelar);
            this.gboBotones1.Location = new System.Drawing.Point(44, 103);
            this.gboBotones1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboBotones1.Name = "gboBotones1";
            this.gboBotones1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboBotones1.Size = new System.Drawing.Size(167, 234);
            this.gboBotones1.TabIndex = 45;
            this.gboBotones1.TabStop = false;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nuevo.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(17, 42);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(136, 49);
            this.btn_Nuevo.TabIndex = 3;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(17, 148);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(136, 50);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1187, 695);
            this.Controls.Add(this.gboBotones1);
            this.Controls.Add(this.gboDatos);
            this.Controls.Add(this.gbBotones2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvRegistroProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProductos";
            this.Text = "D";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStock)).EndInit();
            this.gbBotones2.ResumeLayout(false);
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
            this.gboBotones1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvRegistroProducto;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider errorStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gbBotones2;
        private System.Windows.Forms.GroupBox gboDatos;
        private FontAwesome.Sharp.IconButton btnBuscarMarca;
        private FontAwesome.Sharp.IconButton btnBuscarCategoria;
        private System.Windows.Forms.GroupBox gboBotones1;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.CheckBox chbxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnAñadirMedida;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.DateTimePicker dtPFecha;
        private System.Windows.Forms.ComboBox cboMedida;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
    }
}