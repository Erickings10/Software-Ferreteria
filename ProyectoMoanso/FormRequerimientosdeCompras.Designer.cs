namespace ProyectoMoanso
{
    partial class FormRequerimientosdeCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequerimientosdeCompras));
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAgregaRequeri = new System.Windows.Forms.Button();
            this.dgvRequerimientos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gboRequerimientos = new System.Windows.Forms.GroupBox();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.chboEstadoReque = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmReque = new System.Windows.Forms.DateTimePicker();
            this.gboBotones2 = new System.Windows.Forms.GroupBox();
            this.btnNuevoReque = new System.Windows.Forms.Button();
            this.btnDeshabilitarReque = new System.Windows.Forms.Button();
            this.gboBotones1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientos)).BeginInit();
            this.gboRequerimientos.SuspendLayout();
            this.gboBotones2.SuspendLayout();
            this.gboBotones1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F);
            this.label5.Location = new System.Drawing.Point(18, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Producto:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtCantidad.Location = new System.Drawing.Point(509, 33);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(112, 22);
            this.txtCantidad.TabIndex = 31;
            // 
            // txt_marca
            // 
            this.txt_marca.Font = new System.Drawing.Font("Roboto", 9F);
            this.txt_marca.Location = new System.Drawing.Point(298, 77);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(112, 22);
            this.txt_marca.TabIndex = 30;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblMarca.Location = new System.Drawing.Point(241, 79);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 29;
            this.lblMarca.Text = "Marca:";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtProducto.Location = new System.Drawing.Point(104, 73);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 22);
            this.txtProducto.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F);
            this.label2.Location = new System.Drawing.Point(435, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cantidad:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(104, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(28, 22);
            this.txtCodigo.TabIndex = 26;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(32, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 17);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Codigo:";
            // 
            // btnAgregaRequeri
            // 
            this.btnAgregaRequeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregaRequeri.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnAgregaRequeri.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregaRequeri.Image")));
            this.btnAgregaRequeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregaRequeri.Location = new System.Drawing.Point(17, 18);
            this.btnAgregaRequeri.Name = "btnAgregaRequeri";
            this.btnAgregaRequeri.Size = new System.Drawing.Size(133, 37);
            this.btnAgregaRequeri.TabIndex = 24;
            this.btnAgregaRequeri.Text = "Agregar";
            this.btnAgregaRequeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregaRequeri.UseVisualStyleBackColor = true;
            this.btnAgregaRequeri.Click += new System.EventHandler(this.btnAgregaRequeri_Click);
            // 
            // dgvRequerimientos
            // 
            this.dgvRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequerimientos.Location = new System.Drawing.Point(28, 286);
            this.dgvRequerimientos.Name = "dgvRequerimientos";
            this.dgvRequerimientos.RowHeadersWidth = 51;
            this.dgvRequerimientos.Size = new System.Drawing.Size(856, 215);
            this.dgvRequerimientos.TabIndex = 23;
            this.dgvRequerimientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequerimientos_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(233, 9);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(359, 31);
            this.label6.TabIndex = 36;
            this.label6.Text = "Requerimientos de Compras";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(900, 58);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "NECESIDADES DE COMPRA";
            // 
            // gboRequerimientos
            // 
            this.gboRequerimientos.Controls.Add(this.cbPrioridad);
            this.gboRequerimientos.Controls.Add(this.label3);
            this.gboRequerimientos.Controls.Add(this.txtModelo);
            this.gboRequerimientos.Controls.Add(this.lblModelo);
            this.gboRequerimientos.Controls.Add(this.chboEstadoReque);
            this.gboRequerimientos.Controls.Add(this.label1);
            this.gboRequerimientos.Controls.Add(this.dtmReque);
            this.gboRequerimientos.Controls.Add(this.lblCodigo);
            this.gboRequerimientos.Controls.Add(this.txtCodigo);
            this.gboRequerimientos.Controls.Add(this.label2);
            this.gboRequerimientos.Controls.Add(this.txtCantidad);
            this.gboRequerimientos.Controls.Add(this.label5);
            this.gboRequerimientos.Controls.Add(this.txt_marca);
            this.gboRequerimientos.Controls.Add(this.txtProducto);
            this.gboRequerimientos.Controls.Add(this.lblMarca);
            this.gboRequerimientos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboRequerimientos.Location = new System.Drawing.Point(28, 144);
            this.gboRequerimientos.Name = "gboRequerimientos";
            this.gboRequerimientos.Size = new System.Drawing.Size(856, 125);
            this.gboRequerimientos.TabIndex = 37;
            this.gboRequerimientos.TabStop = false;
            this.gboRequerimientos.Text = "DATOS:";
            // 
            // cbPrioridad
            // 
            this.cbPrioridad.Font = new System.Drawing.Font("Roboto", 9F);
            this.cbPrioridad.FormattingEnabled = true;
            this.cbPrioridad.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.cbPrioridad.Location = new System.Drawing.Point(725, 77);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(105, 22);
            this.cbPrioridad.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F);
            this.label3.Location = new System.Drawing.Point(648, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Prioridad: ";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtModelo.Location = new System.Drawing.Point(509, 79);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(112, 22);
            this.txtModelo.TabIndex = 37;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblModelo.Location = new System.Drawing.Point(443, 79);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(60, 17);
            this.lblModelo.TabIndex = 36;
            this.lblModelo.Text = "Modelo: ";
            // 
            // chboEstadoReque
            // 
            this.chboEstadoReque.AutoSize = true;
            this.chboEstadoReque.Font = new System.Drawing.Font("Roboto", 10F);
            this.chboEstadoReque.Location = new System.Drawing.Point(651, 36);
            this.chboEstadoReque.Name = "chboEstadoReque";
            this.chboEstadoReque.Size = new System.Drawing.Size(164, 21);
            this.chboEstadoReque.TabIndex = 35;
            this.chboEstadoReque.Text = "Estado Requerimiento";
            this.chboEstadoReque.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F);
            this.label1.Location = new System.Drawing.Point(241, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha: ";
            // 
            // dtmReque
            // 
            this.dtmReque.Font = new System.Drawing.Font("Roboto", 9F);
            this.dtmReque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmReque.Location = new System.Drawing.Point(299, 38);
            this.dtmReque.Name = "dtmReque";
            this.dtmReque.Size = new System.Drawing.Size(111, 22);
            this.dtmReque.TabIndex = 33;
            // 
            // gboBotones2
            // 
            this.gboBotones2.Controls.Add(this.btnAgregaRequeri);
            this.gboBotones2.Controls.Add(this.btnDeshabilitarReque);
            this.gboBotones2.Location = new System.Drawing.Point(517, 73);
            this.gboBotones2.Name = "gboBotones2";
            this.gboBotones2.Size = new System.Drawing.Size(341, 65);
            this.gboBotones2.TabIndex = 38;
            this.gboBotones2.TabStop = false;
            // 
            // btnNuevoReque
            // 
            this.btnNuevoReque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoReque.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnNuevoReque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevoReque.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoReque.Image")));
            this.btnNuevoReque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoReque.Location = new System.Drawing.Point(20, 19);
            this.btnNuevoReque.Name = "btnNuevoReque";
            this.btnNuevoReque.Size = new System.Drawing.Size(133, 36);
            this.btnNuevoReque.TabIndex = 24;
            this.btnNuevoReque.Text = "Nuevo ";
            this.btnNuevoReque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoReque.UseVisualStyleBackColor = true;
            this.btnNuevoReque.Click += new System.EventHandler(this.btnNuevoRequerimiento_Click);
            // 
            // btnDeshabilitarReque
            // 
            this.btnDeshabilitarReque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshabilitarReque.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnDeshabilitarReque.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitarReque.Image")));
            this.btnDeshabilitarReque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitarReque.Location = new System.Drawing.Point(173, 19);
            this.btnDeshabilitarReque.Name = "btnDeshabilitarReque";
            this.btnDeshabilitarReque.Size = new System.Drawing.Size(133, 36);
            this.btnDeshabilitarReque.TabIndex = 39;
            this.btnDeshabilitarReque.Text = "Anular";
            this.btnDeshabilitarReque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitarReque.UseVisualStyleBackColor = true;
            this.btnDeshabilitarReque.Click += new System.EventHandler(this.btnDeshabilitarReque_Click);
            // 
            // gboBotones1
            // 
            this.gboBotones1.Controls.Add(this.btnNuevoReque);
            this.gboBotones1.Controls.Add(this.btnCancelar);
            this.gboBotones1.Location = new System.Drawing.Point(76, 73);
            this.gboBotones1.Name = "gboBotones1";
            this.gboBotones1.Size = new System.Drawing.Size(346, 65);
            this.gboBotones1.TabIndex = 39;
            this.gboBotones1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(178, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 36);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // FormRequerimientosdeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.Controls.Add(this.gboBotones1);
            this.Controls.Add(this.gboBotones2);
            this.Controls.Add(this.gboRequerimientos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvRequerimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRequerimientosdeCompras";
            this.Text = "NecesidadesdeCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientos)).EndInit();
            this.gboRequerimientos.ResumeLayout(false);
            this.gboRequerimientos.PerformLayout();
            this.gboBotones2.ResumeLayout(false);
            this.gboBotones1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregaRequeri;
        private System.Windows.Forms.DataGridView dgvRequerimientos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gboRequerimientos;
        private System.Windows.Forms.GroupBox gboBotones2;
        private System.Windows.Forms.Button btnNuevoReque;
        private System.Windows.Forms.DateTimePicker dtmReque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitarReque;
        private System.Windows.Forms.CheckBox chboEstadoReque;
        private System.Windows.Forms.GroupBox gboBotones1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPrioridad;
        private System.Windows.Forms.Button btnCancelar;
    }
}