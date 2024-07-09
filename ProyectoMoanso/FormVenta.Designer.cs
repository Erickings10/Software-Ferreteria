namespace ProyectoMoanso
{
    partial class FormVenta
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gbxInformacionVen = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbmTipoDoc = new System.Windows.Forms.ComboBox();
            this.gbxPago = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbmMetodoP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvSeleccion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDetalleProducto = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnBuscarP = new FontAwesome.Sharp.IconButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioU = new System.Windows.Forms.TextBox();
            this.gbxInformacionCli = new System.Windows.Forms.GroupBox();
            this.btnBuscarD = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.btnVender = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.gbxInformacionVen.SuspendLayout();
            this.gbxPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).BeginInit();
            this.gbxDetalleProducto.SuspendLayout();
            this.gbxInformacionCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(900, 58);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gbxInformacionVen
            // 
            this.gbxInformacionVen.Controls.Add(this.label8);
            this.gbxInformacionVen.Controls.Add(this.cbmTipoDoc);
            this.gbxInformacionVen.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformacionVen.Location = new System.Drawing.Point(35, 116);
            this.gbxInformacionVen.Name = "gbxInformacionVen";
            this.gbxInformacionVen.Size = new System.Drawing.Size(173, 102);
            this.gbxInformacionVen.TabIndex = 34;
            this.gbxInformacionVen.TabStop = false;
            this.gbxInformacionVen.Text = "Informacion de venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tipo Documento:";
            // 
            // cbmTipoDoc
            // 
            this.cbmTipoDoc.FormattingEnabled = true;
            this.cbmTipoDoc.Location = new System.Drawing.Point(13, 51);
            this.cbmTipoDoc.Name = "cbmTipoDoc";
            this.cbmTipoDoc.Size = new System.Drawing.Size(154, 25);
            this.cbmTipoDoc.TabIndex = 0;
            // 
            // gbxPago
            // 
            this.gbxPago.Controls.Add(this.lblTotal);
            this.gbxPago.Controls.Add(this.label10);
            this.gbxPago.Controls.Add(this.cbmMetodoP);
            this.gbxPago.Controls.Add(this.label9);
            this.gbxPago.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPago.Location = new System.Drawing.Point(668, 393);
            this.gbxPago.Name = "gbxPago";
            this.gbxPago.Size = new System.Drawing.Size(198, 140);
            this.gbxPago.TabIndex = 33;
            this.gbxPago.TabStop = false;
            this.gbxPago.Text = "Pago:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(69, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 19);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total:";
            // 
            // cbmMetodoP
            // 
            this.cbmMetodoP.FormattingEnabled = true;
            this.cbmMetodoP.Location = new System.Drawing.Point(19, 96);
            this.cbmMetodoP.Name = "cbmMetodoP";
            this.cbmMetodoP.Size = new System.Drawing.Size(149, 25);
            this.cbmMetodoP.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Metodo de pago:";
            // 
            // dgvSeleccion
            // 
            this.dgvSeleccion.AllowUserToAddRows = false;
            this.dgvSeleccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.columnPVenta,
            this.columnCan});
            this.dgvSeleccion.Location = new System.Drawing.Point(35, 393);
            this.dgvSeleccion.MultiSelect = false;
            this.dgvSeleccion.Name = "dgvSeleccion";
            this.dgvSeleccion.RowHeadersWidth = 51;
            this.dgvSeleccion.RowTemplate.Height = 24;
            this.dgvSeleccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccion.Size = new System.Drawing.Size(587, 199);
            this.dgvSeleccion.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id Almacen";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre del Producto";
            this.Column3.Name = "Column3";
            // 
            // columnPVenta
            // 
            this.columnPVenta.HeaderText = "Precio de Venta";
            this.columnPVenta.Name = "columnPVenta";
            // 
            // columnCan
            // 
            this.columnCan.HeaderText = "Cantidad";
            this.columnCan.Name = "columnCan";
            // 
            // gbxDetalleProducto
            // 
            this.gbxDetalleProducto.Controls.Add(this.label2);
            this.gbxDetalleProducto.Controls.Add(this.txtCantidad);
            this.gbxDetalleProducto.Controls.Add(this.btnBuscarP);
            this.gbxDetalleProducto.Controls.Add(this.txtID);
            this.gbxDetalleProducto.Controls.Add(this.label5);
            this.gbxDetalleProducto.Controls.Add(this.label6);
            this.gbxDetalleProducto.Controls.Add(this.label7);
            this.gbxDetalleProducto.Controls.Add(this.txtProducto);
            this.gbxDetalleProducto.Controls.Add(this.txtPrecioU);
            this.gbxDetalleProducto.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalleProducto.Location = new System.Drawing.Point(35, 227);
            this.gbxDetalleProducto.Name = "gbxDetalleProducto";
            this.gbxDetalleProducto.Size = new System.Drawing.Size(583, 160);
            this.gbxDetalleProducto.TabIndex = 28;
            this.gbxDetalleProducto.TabStop = false;
            this.gbxDetalleProducto.Text = "Detalle de producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(196, 115);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(162, 24);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarP.IconColor = System.Drawing.Color.Black;
            this.btnBuscarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarP.IconSize = 20;
            this.btnBuscarP.Location = new System.Drawing.Point(434, 50);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(38, 30);
            this.btnBuscarP.TabIndex = 4;
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(24, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(49, 24);
            this.txtID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Precio por Unidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(100, 54);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(328, 24);
            this.txtProducto.TabIndex = 0;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.Location = new System.Drawing.Point(24, 115);
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(119, 24);
            this.txtPrecioU.TabIndex = 1;
            // 
            // gbxInformacionCli
            // 
            this.gbxInformacionCli.Controls.Add(this.btnBuscarD);
            this.gbxInformacionCli.Controls.Add(this.label4);
            this.gbxInformacionCli.Controls.Add(this.label3);
            this.gbxInformacionCli.Controls.Add(this.txtDocumento);
            this.gbxInformacionCli.Controls.Add(this.txtNombreC);
            this.gbxInformacionCli.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformacionCli.Location = new System.Drawing.Point(229, 116);
            this.gbxInformacionCli.Name = "gbxInformacionCli";
            this.gbxInformacionCli.Size = new System.Drawing.Size(606, 102);
            this.gbxInformacionCli.TabIndex = 27;
            this.gbxInformacionCli.TabStop = false;
            this.gbxInformacionCli.Text = "Informacion del cliente";
            // 
            // btnBuscarD
            // 
            this.btnBuscarD.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarD.IconColor = System.Drawing.Color.Black;
            this.btnBuscarD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarD.IconSize = 20;
            this.btnBuscarD.Location = new System.Drawing.Point(196, 50);
            this.btnBuscarD.Name = "btnBuscarD";
            this.btnBuscarD.Size = new System.Drawing.Size(38, 30);
            this.btnBuscarD.TabIndex = 4;
            this.btnBuscarD.UseVisualStyleBackColor = true;
            this.btnBuscarD.Click += new System.EventHandler(this.btnBuscarD_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Completo:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(24, 54);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(160, 24);
            this.txtDocumento.TabIndex = 0;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(278, 54);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(308, 24);
            this.txtNombreC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 47);
            this.label1.TabIndex = 26;
            this.label1.Text = "REGISTRO DE VENTA";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNuevo.IconColor = System.Drawing.Color.Black;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.Location = new System.Drawing.Point(668, 65);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(131, 54);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.Text = "Nueva Venta";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVender.IconColor = System.Drawing.Color.Black;
            this.btnVender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVender.Location = new System.Drawing.Point(704, 538);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(131, 54);
            this.btnVender.TabIndex = 32;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Crimson;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.Location = new System.Drawing.Point(704, 333);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(131, 54);
            this.btnBorrar.TabIndex = 30;
            this.btnBorrar.Text = "Borrar Producto";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Orange;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(704, 243);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 54);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(900, 610);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.gbxInformacionVen);
            this.Controls.Add(this.gbxPago);
            this.Controls.Add(this.dgvSeleccion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbxDetalleProducto);
            this.Controls.Add(this.gbxInformacionCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.gbxInformacionVen.ResumeLayout(false);
            this.gbxInformacionVen.PerformLayout();
            this.gbxPago.ResumeLayout(false);
            this.gbxPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).EndInit();
            this.gbxDetalleProducto.ResumeLayout(false);
            this.gbxDetalleProducto.PerformLayout();
            this.gbxInformacionCli.ResumeLayout(false);
            this.gbxInformacionCli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnVender;
        private System.Windows.Forms.GroupBox gbxInformacionVen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmTipoDoc;
        private System.Windows.Forms.GroupBox gbxPago;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbmMetodoP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCan;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.GroupBox gbxDetalleProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private FontAwesome.Sharp.IconButton btnBuscarP;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecioU;
        private System.Windows.Forms.GroupBox gbxInformacionCli;
        private FontAwesome.Sharp.IconButton btnBuscarD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label label1;
    }
}