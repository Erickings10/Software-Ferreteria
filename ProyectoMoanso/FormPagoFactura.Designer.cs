namespace ProyectoMoanso
{
    partial class FormPagoFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Button btnRealizarPago;
            this.txtMontoFac = new System.Windows.Forms.TextBox();
            this.txtpProveedorFac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListaFactura = new System.Windows.Forms.DataGridView();
            this.txtNroOrdenCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NRO_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            btnRealizarPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMontoFac
            // 
            this.txtMontoFac.Location = new System.Drawing.Point(643, 143);
            this.txtMontoFac.Name = "txtMontoFac";
            this.txtMontoFac.Size = new System.Drawing.Size(144, 22);
            this.txtMontoFac.TabIndex = 30;
            // 
            // txtpProveedorFac
            // 
            this.txtpProveedorFac.Location = new System.Drawing.Point(643, 101);
            this.txtpProveedorFac.Name = "txtpProveedorFac";
            this.txtpProveedorFac.Size = new System.Drawing.Size(268, 22);
            this.txtpProveedorFac.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nro de Orden de Compra:";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(197, 143);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(157, 22);
            this.txtNroFactura.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "LISTA DE FACTURAS:";
            // 
            // dgvListaFactura
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaFactura.ColumnHeadersHeight = 29;
            this.dgvListaFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NRO_Orden,
            this.Nro_Factura,
            this.NombreProveedor,
            this.MontoPagar});
            this.dgvListaFactura.Location = new System.Drawing.Point(49, 253);
            this.dgvListaFactura.Name = "dgvListaFactura";
            this.dgvListaFactura.RowHeadersWidth = 51;
            this.dgvListaFactura.RowTemplate.Height = 24;
            this.dgvListaFactura.Size = new System.Drawing.Size(702, 207);
            this.dgvListaFactura.TabIndex = 25;
            // 
            // txtNroOrdenCompra
            // 
            this.txtNroOrdenCompra.Location = new System.Drawing.Point(277, 103);
            this.txtNroOrdenCompra.Name = "txtNroOrdenCompra";
            this.txtNroOrdenCompra.Size = new System.Drawing.Size(149, 22);
            this.txtNroOrdenCompra.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nro de Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Monto S/:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "PAGO DE FACTURAS";
            // 
            // NRO_Orden
            // 
            this.NRO_Orden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NRO_Orden.HeaderText = "Nro de Orden de Compra";
            this.NRO_Orden.MinimumWidth = 6;
            this.NRO_Orden.Name = "NRO_Orden";
            this.NRO_Orden.Width = 248;
            // 
            // Nro_Factura
            // 
            this.Nro_Factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nro_Factura.HeaderText = "Nro de Factura";
            this.Nro_Factura.MinimumWidth = 6;
            this.Nro_Factura.Name = "Nro_Factura";
            this.Nro_Factura.Width = 164;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NombreProveedor.HeaderText = "Proveedor";
            this.NombreProveedor.MinimumWidth = 6;
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.Width = 123;
            // 
            // MontoPagar
            // 
            this.MontoPagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MontoPagar.HeaderText = "Monto S/";
            this.MontoPagar.MinimumWidth = 6;
            this.MontoPagar.Name = "MontoPagar";
            this.MontoPagar.Width = 113;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1058, 71);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnRealizarPago
            // 
            btnRealizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRealizarPago.Image = global::ProyectoMoanso.Properties.Resources.Confirmar;
            btnRealizarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRealizarPago.Location = new System.Drawing.Point(786, 336);
            btnRealizarPago.Name = "btnRealizarPago";
            btnRealizarPago.Size = new System.Drawing.Size(167, 65);
            btnRealizarPago.TabIndex = 35;
            btnRealizarPago.Text = "Realizar Pago";
            btnRealizarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRealizarPago.UseVisualStyleBackColor = true;
            // 
            // FormPagoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1058, 532);
            this.Controls.Add(btnRealizarPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontoFac);
            this.Controls.Add(this.txtpProveedorFac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListaFactura);
            this.Controls.Add(this.txtNroOrdenCompra);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPagoFactura";
            this.Text = "FormPagoFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontoFac;
        private System.Windows.Forms.TextBox txtpProveedorFac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListaFactura;
        private System.Windows.Forms.TextBox txtNroOrdenCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPagar;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}