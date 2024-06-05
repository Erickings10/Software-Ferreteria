namespace ProyectoMoanso
{
    partial class FormProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbxEstado = new System.Windows.Forms.CheckBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dgv_RegistroProveedor = new System.Windows.Forms.DataGridView();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RegistroProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLE DE PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razon Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // chbxEstado
            // 
            this.chbxEstado.AutoSize = true;
            this.chbxEstado.Location = new System.Drawing.Point(143, 223);
            this.chbxEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbxEstado.Name = "chbxEstado";
            this.chbxEstado.Size = new System.Drawing.Size(128, 17);
            this.chbxEstado.TabIndex = 5;
            this.chbxEstado.Text = "Estado del Proveedor";
            this.chbxEstado.UseVisualStyleBackColor = true;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(106, 58);
            this.txtNroDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(165, 20);
            this.txtNroDocumento.TabIndex = 6;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(106, 93);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(165, 20);
            this.txtRazonSocial.TabIndex = 7;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(106, 133);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(165, 20);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(106, 173);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(165, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // dgv_RegistroProveedor
            // 
            this.dgv_RegistroProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RegistroProveedor.Location = new System.Drawing.Point(304, 47);
            this.dgv_RegistroProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_RegistroProveedor.Name = "dgv_RegistroProveedor";
            this.dgv_RegistroProveedor.RowHeadersWidth = 51;
            this.dgv_RegistroProveedor.RowTemplate.Height = 24;
            this.dgv_RegistroProveedor.Size = new System.Drawing.Size(685, 375);
            this.dgv_RegistroProveedor.TabIndex = 10;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(25, 266);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(104, 49);
            this.btn_Registrar.TabIndex = 11;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(167, 266);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(104, 49);
            this.btn_Actualizar.TabIndex = 12;
            this.btn_Actualizar.Text = "ACTUALIZAR";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(96, 348);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(104, 53);
            this.btn_Eliminar.TabIndex = 13;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 485);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.dgv_RegistroProveedor);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.chbxEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormProveedor";
            this.Text = "Registro de Proveedor";
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RegistroProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbxEstado;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridView dgv_RegistroProveedor;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}