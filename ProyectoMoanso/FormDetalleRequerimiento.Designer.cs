namespace ProyectoMoanso
{
    partial class FormDetalleRequerimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleRequerimiento));
            this.dgvNuevoReq = new System.Windows.Forms.DataGridView();
            this.gboRequerimientos = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductoID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarPro = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtmReque = new System.Windows.Forms.DateTimePicker();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDeshabilitar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevoReq)).BeginInit();
            this.gboRequerimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNuevoReq
            // 
            this.dgvNuevoReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevoReq.Location = new System.Drawing.Point(59, 276);
            this.dgvNuevoReq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNuevoReq.Name = "dgvNuevoReq";
            this.dgvNuevoReq.RowHeadersWidth = 51;
            this.dgvNuevoReq.Size = new System.Drawing.Size(760, 244);
            this.dgvNuevoReq.TabIndex = 43;
            // 
            // gboRequerimientos
            // 
            this.gboRequerimientos.Controls.Add(this.txtDescripcion);
            this.gboRequerimientos.Controls.Add(this.label5);
            this.gboRequerimientos.Controls.Add(this.cbPrioridad);
            this.gboRequerimientos.Controls.Add(this.txtCantidad);
            this.gboRequerimientos.Controls.Add(this.label2);
            this.gboRequerimientos.Controls.Add(this.txtProductoID);
            this.gboRequerimientos.Controls.Add(this.label3);
            this.gboRequerimientos.Controls.Add(this.btnBuscarPro);
            this.gboRequerimientos.Controls.Add(this.label4);
            this.gboRequerimientos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboRequerimientos.Location = new System.Drawing.Point(59, 101);
            this.gboRequerimientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboRequerimientos.Name = "gboRequerimientos";
            this.gboRequerimientos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboRequerimientos.Size = new System.Drawing.Size(760, 148);
            this.gboRequerimientos.TabIndex = 42;
            this.gboRequerimientos.TabStop = false;
            this.gboRequerimientos.Text = "DATOS:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtDescripcion.Location = new System.Drawing.Point(155, 75);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(148, 26);
            this.txtDescripcion.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F);
            this.label5.Location = new System.Drawing.Point(55, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Producto:";
            // 
            // cbPrioridad
            // 
            this.cbPrioridad.Font = new System.Drawing.Font("Roboto", 9F);
            this.cbPrioridad.FormattingEnabled = true;
            this.cbPrioridad.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.cbPrioridad.Location = new System.Drawing.Point(635, 78);
            this.cbPrioridad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(101, 26);
            this.cbPrioridad.TabIndex = 39;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtCantidad.Location = new System.Drawing.Point(425, 78);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(72, 26);
            this.txtCantidad.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F);
            this.label2.Location = new System.Drawing.Point(327, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cantidad:";
            // 
            // txtProductoID
            // 
            this.txtProductoID.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtProductoID.Location = new System.Drawing.Point(155, 26);
            this.txtProductoID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Size = new System.Drawing.Size(148, 26);
            this.txtProductoID.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F);
            this.label3.Location = new System.Drawing.Point(532, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Prioridad: ";
            // 
            // btnBuscarPro
            // 
            this.btnBuscarPro.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarPro.IconColor = System.Drawing.Color.Black;
            this.btnBuscarPro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarPro.IconSize = 18;
            this.btnBuscarPro.Location = new System.Drawing.Point(312, 26);
            this.btnBuscarPro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPro.Name = "btnBuscarPro";
            this.btnBuscarPro.Size = new System.Drawing.Size(105, 30);
            this.btnBuscarPro.TabIndex = 42;
            this.btnBuscarPro.UseVisualStyleBackColor = true;
            this.btnBuscarPro.Click += new System.EventHandler(this.btnBuscarPro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F);
            this.label4.Location = new System.Drawing.Point(36, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Descripción:";
            // 
            // dtmReque
            // 
            this.dtmReque.Font = new System.Drawing.Font("Roboto", 9F);
            this.dtmReque.Location = new System.Drawing.Point(175, 53);
            this.dtmReque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtmReque.Name = "dtmReque";
            this.dtmReque.Size = new System.Drawing.Size(300, 26);
            this.dtmReque.TabIndex = 33;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(541, 62);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(68, 20);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F);
            this.label1.Location = new System.Drawing.Point(83, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(637, 59);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(92, 26);
            this.txtCodigo.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(865, 415);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 44);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(865, 126);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(197, 44);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDeshabilitar
            // 
            this.txtDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtDeshabilitar.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtDeshabilitar.Image = ((System.Drawing.Image)(resources.GetObject("txtDeshabilitar.Image")));
            this.txtDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDeshabilitar.Location = new System.Drawing.Point(865, 204);
            this.txtDeshabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeshabilitar.Name = "txtDeshabilitar";
            this.txtDeshabilitar.Size = new System.Drawing.Size(197, 44);
            this.txtDeshabilitar.TabIndex = 51;
            this.txtDeshabilitar.Text = "Quitar";
            this.txtDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(865, 331);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(197, 44);
            this.btnGrabar.TabIndex = 52;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // FormDetalleRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1116, 545);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dtmReque);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDeshabilitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvNuevoReq);
            this.Controls.Add(this.gboRequerimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDetalleRequerimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormRequerimientoNuevo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevoReq)).EndInit();
            this.gboRequerimientos.ResumeLayout(false);
            this.gboRequerimientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvNuevoReq;
        private System.Windows.Forms.GroupBox gboRequerimientos;
        private FontAwesome.Sharp.IconButton btnBuscarPro;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmReque;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbPrioridad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtDeshabilitar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
    }
}