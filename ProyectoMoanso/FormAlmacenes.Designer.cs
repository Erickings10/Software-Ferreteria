namespace ProyectoMoanso
{
    partial class FormAlmacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacenes));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvAlmacenes = new System.Windows.Forms.DataGridView();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.chbx_Estado = new System.Windows.Forms.CheckBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gbBotones2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gboBotones1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenes)).BeginInit();
            this.gbInformacion.SuspendLayout();
            this.gbBotones2.SuspendLayout();
            this.gboBotones1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(245, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "REGISTRO DE ALMACENES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1204, 71);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvAlmacenes
            // 
            this.dgvAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacenes.Location = new System.Drawing.Point(543, 117);
            this.dgvAlmacenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlmacenes.Name = "dgvAlmacenes";
            this.dgvAlmacenes.ReadOnly = true;
            this.dgvAlmacenes.RowHeadersWidth = 51;
            this.dgvAlmacenes.Size = new System.Drawing.Size(607, 497);
            this.dgvAlmacenes.TabIndex = 26;
            this.dgvAlmacenes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlmacenes_CellDoubleClick);
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.chbx_Estado);
            this.gbInformacion.Controls.Add(this.txtCantidad);
            this.gbInformacion.Controls.Add(this.txtDescripcion);
            this.gbInformacion.Controls.Add(this.lblTipo);
            this.gbInformacion.Controls.Add(this.txtTipo);
            this.gbInformacion.Controls.Add(this.txtId);
            this.gbInformacion.Controls.Add(this.lblId);
            this.gbInformacion.Controls.Add(this.lblCapacidad);
            this.gbInformacion.Controls.Add(this.lblDescripcion);
            this.gbInformacion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbInformacion.Location = new System.Drawing.Point(51, 196);
            this.gbInformacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInformacion.Size = new System.Drawing.Size(461, 343);
            this.gbInformacion.TabIndex = 27;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Informacion";
            // 
            // chbx_Estado
            // 
            this.chbx_Estado.AutoSize = true;
            this.chbx_Estado.Font = new System.Drawing.Font("Roboto", 9F);
            this.chbx_Estado.Location = new System.Drawing.Point(341, 298);
            this.chbx_Estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbx_Estado.Name = "chbx_Estado";
            this.chbx_Estado.Size = new System.Drawing.Size(77, 22);
            this.chbx_Estado.TabIndex = 33;
            this.chbx_Estado.Text = "Estado";
            this.chbx_Estado.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtCantidad.Location = new System.Drawing.Point(143, 194);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(152, 26);
            this.txtCantidad.TabIndex = 32;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescripcion.Location = new System.Drawing.Point(143, 102);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(192, 69);
            this.txtDescripcion.TabIndex = 29;
            this.txtDescripcion.Text = "";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblTipo.Location = new System.Drawing.Point(36, 247);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(47, 18);
            this.lblTipo.TabIndex = 31;
            this.lblTipo.Text = "Tipo: ";
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtTipo.Location = new System.Drawing.Point(143, 244);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(152, 26);
            this.txtTipo.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtId.Location = new System.Drawing.Point(143, 49);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 26);
            this.txtId.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblId.Location = new System.Drawing.Point(36, 53);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(92, 18);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id Almacen: ";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblCapacidad.Location = new System.Drawing.Point(36, 198);
            this.lblCapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(77, 18);
            this.lblCapacidad.TabIndex = 4;
            this.lblCapacidad.Text = "Cantidad: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblDescripcion.Location = new System.Drawing.Point(33, 122);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 18);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion: ";
            // 
            // gbBotones2
            // 
            this.gbBotones2.Controls.Add(this.btnAgregar);
            this.gbBotones2.Controls.Add(this.btnDeshabilitar);
            this.gbBotones2.Controls.Add(this.btnActualizar);
            this.gbBotones2.Location = new System.Drawing.Point(51, 546);
            this.gbBotones2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBotones2.Name = "gbBotones2";
            this.gbBotones2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBotones2.Size = new System.Drawing.Size(461, 90);
            this.gbBotones2.TabIndex = 28;
            this.gbBotones2.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnAgregar.Image = global::ProyectoMoanso.Properties.Resources.Disco;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(12, 22);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 44);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.Tan;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnDeshabilitar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitar.Image")));
            this.btnDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitar.Location = new System.Drawing.Point(301, 22);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(153, 44);
            this.btnDeshabilitar.TabIndex = 21;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Tan;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(157, 22);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(139, 44);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gboBotones1
            // 
            this.gboBotones1.Controls.Add(this.btnNuevo);
            this.gboBotones1.Controls.Add(this.btnCancelar);
            this.gboBotones1.Location = new System.Drawing.Point(51, 108);
            this.gboBotones1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboBotones1.Name = "gboBotones1";
            this.gboBotones1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboBotones1.Size = new System.Drawing.Size(461, 80);
            this.gboBotones1.TabIndex = 40;
            this.gboBotones1.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(27, 23);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(177, 44);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "Nuevo ";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(237, 23);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 44);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1204, 671);
            this.Controls.Add(this.gboBotones1);
            this.Controls.Add(this.gbBotones2);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.dgvAlmacenes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAlmacenes";
            this.Text = "FormAlmacenes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenes)).EndInit();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.gbBotones2.ResumeLayout(false);
            this.gboBotones1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvAlmacenes;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.GroupBox gbBotones2;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.GroupBox gboBotones1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.CheckBox chbx_Estado;
    }
}