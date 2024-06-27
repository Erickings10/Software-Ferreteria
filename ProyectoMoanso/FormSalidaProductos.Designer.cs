namespace ProyectoMoanso
{
    partial class FormSalidaProductos
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
            this.panelDevolucion = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.dTPickerFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chbxEstado = new System.Windows.Forms.CheckBox();
            this.panelDevolucion.SuspendLayout();
            this.gBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDevolucion
            // 
            this.panelDevolucion.BackColor = System.Drawing.Color.RosyBrown;
            this.panelDevolucion.Controls.Add(this.lblTitulo);
            this.panelDevolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDevolucion.Location = new System.Drawing.Point(0, 0);
            this.panelDevolucion.Name = "panelDevolucion";
            this.panelDevolucion.Size = new System.Drawing.Size(926, 60);
            this.panelDevolucion.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(289, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(288, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SALIDA DE PRODUCTOS";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblProductos.Location = new System.Drawing.Point(18, 68);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(79, 17);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Productos: ";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblMotivo.Location = new System.Drawing.Point(18, 106);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(62, 17);
            this.lblMotivo.TabIndex = 2;
            this.lblMotivo.Text = "Almacen";
            // 
            // gBox
            // 
            this.gBox.BackColor = System.Drawing.Color.Transparent;
            this.gBox.Controls.Add(this.chbxEstado);
            this.gBox.Controls.Add(this.lblId);
            this.gBox.Controls.Add(this.txtId);
            this.gBox.Controls.Add(this.txtProductos);
            this.gBox.Controls.Add(this.txtAlmacen);
            this.gBox.Controls.Add(this.dTPickerFecha);
            this.gBox.Controls.Add(this.lblFecha);
            this.gBox.Controls.Add(this.lblMotivo);
            this.gBox.Controls.Add(this.lblProductos);
            this.gBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox.Location = new System.Drawing.Point(256, 81);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(484, 152);
            this.gBox.TabIndex = 3;
            this.gBox.TabStop = false;
            this.gBox.Text = "Datos";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblId.Location = new System.Drawing.Point(41, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 17);
            this.lblId.TabIndex = 46;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtId.Location = new System.Drawing.Point(103, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 24);
            this.txtId.TabIndex = 45;
            // 
            // txtProductos
            // 
            this.txtProductos.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtProductos.Location = new System.Drawing.Point(103, 64);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(115, 24);
            this.txtProductos.TabIndex = 44;
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtAlmacen.Location = new System.Drawing.Point(103, 99);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(115, 24);
            this.txtAlmacen.TabIndex = 43;
            // 
            // dTPickerFecha
            // 
            this.dTPickerFecha.Font = new System.Drawing.Font("Roboto", 10F);
            this.dTPickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerFecha.Location = new System.Drawing.Point(334, 28);
            this.dTPickerFecha.Name = "dTPickerFecha";
            this.dTPickerFecha.Size = new System.Drawing.Size(115, 24);
            this.dTPickerFecha.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblFecha.Location = new System.Drawing.Point(271, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 17);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 216);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(761, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 152);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(32, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Inhabilitar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(32, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(32, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // chbxEstado
            // 
            this.chbxEstado.AutoSize = true;
            this.chbxEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbxEstado.Location = new System.Drawing.Point(378, 102);
            this.chbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.chbxEstado.Name = "chbxEstado";
            this.chbxEstado.Size = new System.Drawing.Size(71, 21);
            this.chbxEstado.TabIndex = 8;
            this.chbxEstado.Text = "Estado";
            this.chbxEstado.UseVisualStyleBackColor = true;
            // 
            // FormSalidaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(926, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.panelDevolucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalidaProductos";
            this.Text = "FormDevolucionCompra";
            this.panelDevolucion.ResumeLayout(false);
            this.panelDevolucion.PerformLayout();
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDevolucion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.DateTimePicker dTPickerFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.CheckBox chbxEstado;
    }
}