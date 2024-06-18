namespace ProyectoMoanso
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnAlmacenes = new System.Windows.Forms.Button();
            this.btnProovedores = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnPagoFacturas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnRequerimiento = new System.Windows.Forms.Button();
            this.btnOrdenCompra = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.Panel();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnMaximizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.btnRestaurar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1102, 65);
            this.panelTitulo.TabIndex = 4;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.InitialImage = null;
            this.btnMinimizar.Location = new System.Drawing.Point(992, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 35);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1031, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(29, 35);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1070, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Location = new System.Drawing.Point(425, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FERRETERIA SAN JUAN LINKOL";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1031, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(33, 35);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.Gray;
            this.panelOpciones.Controls.Add(this.btnAlmacenes);
            this.panelOpciones.Controls.Add(this.btnProovedores);
            this.panelOpciones.Controls.Add(this.btnDevolucion);
            this.panelOpciones.Controls.Add(this.btnPagoFacturas);
            this.panelOpciones.Controls.Add(this.btnProductos);
            this.panelOpciones.Controls.Add(this.btnAlmacen);
            this.panelOpciones.Controls.Add(this.btnRequerimiento);
            this.panelOpciones.Controls.Add(this.btnOrdenCompra);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 65);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(195, 526);
            this.panelOpciones.TabIndex = 5;
            // 
            // btnAlmacenes
            // 
            this.btnAlmacenes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacenes.Image = ((System.Drawing.Image)(resources.GetObject("btnAlmacenes.Image")));
            this.btnAlmacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacenes.Location = new System.Drawing.Point(4, 428);
            this.btnAlmacenes.Name = "btnAlmacenes";
            this.btnAlmacenes.Size = new System.Drawing.Size(185, 53);
            this.btnAlmacenes.TabIndex = 8;
            this.btnAlmacenes.Text = "Almacenes";
            this.btnAlmacenes.UseVisualStyleBackColor = false;
            this.btnAlmacenes.Click += new System.EventHandler(this.btnAlmacenes_Click);
            // 
            // btnProovedores
            // 
            this.btnProovedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProovedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProovedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProovedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProovedores.Image")));
            this.btnProovedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProovedores.Location = new System.Drawing.Point(4, 369);
            this.btnProovedores.Name = "btnProovedores";
            this.btnProovedores.Size = new System.Drawing.Size(185, 53);
            this.btnProovedores.TabIndex = 7;
            this.btnProovedores.Text = "Proovedores";
            this.btnProovedores.UseVisualStyleBackColor = false;
            this.btnProovedores.Click += new System.EventHandler(this.btnProovedores_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolucion.Image")));
            this.btnDevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucion.Location = new System.Drawing.Point(4, 310);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(185, 53);
            this.btnDevolucion.TabIndex = 6;
            this.btnDevolucion.Text = "Devolucion de Productos";
            this.btnDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolucion.UseVisualStyleBackColor = false;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnPagoFacturas
            // 
            this.btnPagoFacturas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPagoFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagoFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoFacturas.Image = ((System.Drawing.Image)(resources.GetObject("btnPagoFacturas.Image")));
            this.btnPagoFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagoFacturas.Location = new System.Drawing.Point(3, 133);
            this.btnPagoFacturas.Name = "btnPagoFacturas";
            this.btnPagoFacturas.Size = new System.Drawing.Size(186, 53);
            this.btnPagoFacturas.TabIndex = 5;
            this.btnPagoFacturas.Text = "Pago de Facturas";
            this.btnPagoFacturas.UseVisualStyleBackColor = false;
            this.btnPagoFacturas.Click += new System.EventHandler(this.btnPagoFacturas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(4, 251);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(185, 53);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("btnAlmacen.Image")));
            this.btnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.Location = new System.Drawing.Point(3, 192);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(186, 53);
            this.btnAlmacen.TabIndex = 3;
            this.btnAlmacen.Text = "Entrada de Productos";
            this.btnAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlmacen.UseVisualStyleBackColor = false;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnRequerimiento
            // 
            this.btnRequerimiento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRequerimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequerimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequerimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnRequerimiento.Image")));
            this.btnRequerimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequerimiento.Location = new System.Drawing.Point(3, 74);
            this.btnRequerimiento.Name = "btnRequerimiento";
            this.btnRequerimiento.Size = new System.Drawing.Size(186, 53);
            this.btnRequerimiento.TabIndex = 2;
            this.btnRequerimiento.Text = "Requerimiento de Compra";
            this.btnRequerimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequerimiento.UseVisualStyleBackColor = false;
            this.btnRequerimiento.Click += new System.EventHandler(this.btnNecesidad_Click);
            // 
            // btnOrdenCompra
            // 
            this.btnOrdenCompra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenCompra.Image")));
            this.btnOrdenCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenCompra.Location = new System.Drawing.Point(3, 15);
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.Size = new System.Drawing.Size(186, 53);
            this.btnOrdenCompra.TabIndex = 1;
            this.btnOrdenCompra.Text = "Orden de Compra";
            this.btnOrdenCompra.UseVisualStyleBackColor = false;
            this.btnOrdenCompra.Click += new System.EventHandler(this.btnOrdenCompra_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.Highlight;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(195, 65);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(907, 526);
            this.contenedor.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 591);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "FERRETERIA SLK";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Button btnOrdenCompra;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnRequerimiento;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnPagoFacturas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProovedores;
        private System.Windows.Forms.Button btnAlmacenes;
    }
}

