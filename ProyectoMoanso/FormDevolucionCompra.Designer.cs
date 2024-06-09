namespace ProyectoMoanso
{
    partial class FormDevolucionCompra
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
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.chBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.cbProovedor = new System.Windows.Forms.ComboBox();
            this.lblProovedor = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dTPickerFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cBoxSeleccionar = new System.Windows.Forms.ComboBox();
            this.cBoxMotivo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
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
            this.lblTitulo.Size = new System.Drawing.Size(330, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DEVOLUCION DE COMPRAS";
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(14, 31);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(167, 18);
            this.lblSeleccionar.TabIndex = 1;
            this.lblSeleccionar.Text = "Seleccionar Productos: ";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(48, 69);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(61, 18);
            this.lblMotivo.TabIndex = 2;
            this.lblMotivo.Text = "Motivo: ";
            // 
            // gBox
            // 
            this.gBox.BackColor = System.Drawing.Color.Transparent;
            this.gBox.Controls.Add(this.chBoxHabilitado);
            this.gBox.Controls.Add(this.cbProovedor);
            this.gBox.Controls.Add(this.lblProovedor);
            this.gBox.Controls.Add(this.cbId);
            this.gBox.Controls.Add(this.lblID);
            this.gBox.Controls.Add(this.dTPickerFecha);
            this.gBox.Controls.Add(this.lblFecha);
            this.gBox.Controls.Add(this.cBoxSeleccionar);
            this.gBox.Controls.Add(this.cBoxMotivo);
            this.gBox.Controls.Add(this.lblMotivo);
            this.gBox.Controls.Add(this.lblSeleccionar);
            this.gBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox.Location = new System.Drawing.Point(49, 81);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(706, 152);
            this.gBox.TabIndex = 3;
            this.gBox.TabStop = false;
            this.gBox.Text = "Datos";
            // 
            // chBoxHabilitado
            // 
            this.chBoxHabilitado.AutoSize = true;
            this.chBoxHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxHabilitado.Location = new System.Drawing.Point(595, 114);
            this.chBoxHabilitado.Name = "chBoxHabilitado";
            this.chBoxHabilitado.Size = new System.Drawing.Size(71, 24);
            this.chBoxHabilitado.TabIndex = 3;
            this.chBoxHabilitado.Text = "Activo";
            this.chBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // cbProovedor
            // 
            this.cbProovedor.FormattingEnabled = true;
            this.cbProovedor.Location = new System.Drawing.Point(562, 69);
            this.cbProovedor.Name = "cbProovedor";
            this.cbProovedor.Size = new System.Drawing.Size(105, 28);
            this.cbProovedor.TabIndex = 11;
            // 
            // lblProovedor
            // 
            this.lblProovedor.AutoSize = true;
            this.lblProovedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProovedor.Location = new System.Drawing.Point(394, 72);
            this.lblProovedor.Name = "lblProovedor";
            this.lblProovedor.Size = new System.Drawing.Size(78, 18);
            this.lblProovedor.TabIndex = 10;
            this.lblProovedor.Text = "Proovedor";
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(595, 27);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(72, 28);
            this.cbId.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(394, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(165, 18);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID de Orden de Compra";
            // 
            // dTPickerFecha
            // 
            this.dTPickerFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerFecha.Location = new System.Drawing.Point(209, 108);
            this.dTPickerFecha.Name = "dTPickerFecha";
            this.dTPickerFecha.Size = new System.Drawing.Size(121, 24);
            this.dTPickerFecha.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(48, 114);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 18);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // cBoxSeleccionar
            // 
            this.cBoxSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxSeleccionar.FormattingEnabled = true;
            this.cBoxSeleccionar.Location = new System.Drawing.Point(209, 26);
            this.cBoxSeleccionar.Name = "cBoxSeleccionar";
            this.cBoxSeleccionar.Size = new System.Drawing.Size(121, 28);
            this.cBoxSeleccionar.TabIndex = 5;
            // 
            // cBoxMotivo
            // 
            this.cBoxMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cBoxMotivo.FormattingEnabled = true;
            this.cBoxMotivo.Location = new System.Drawing.Point(209, 64);
            this.cBoxMotivo.Name = "cBoxMotivo";
            this.cBoxMotivo.Size = new System.Drawing.Size(121, 28);
            this.cBoxMotivo.TabIndex = 4;
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
            this.btnAgregar.Location = new System.Drawing.Point(32, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // FormDevolucionCompra
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
            this.Name = "FormDevolucionCompra";
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
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.ComboBox cBoxSeleccionar;
        private System.Windows.Forms.ComboBox cBoxMotivo;
        private System.Windows.Forms.DateTimePicker dTPickerFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbProovedor;
        private System.Windows.Forms.Label lblProovedor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chBoxHabilitado;
    }
}