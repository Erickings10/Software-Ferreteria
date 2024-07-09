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
            System.Windows.Forms.Button btnRealizarPago;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMontoFac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.dgvListaFactura = new System.Windows.Forms.DataGridView();
            this.txtNroOrdenCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            btnRealizarPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRealizarPago
            // 
            btnRealizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRealizarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizarPago.Image")));
            btnRealizarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRealizarPago.Location = new System.Drawing.Point(821, 197);
            btnRealizarPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRealizarPago.Name = "btnRealizarPago";
            btnRealizarPago.Size = new System.Drawing.Size(167, 50);
            btnRealizarPago.TabIndex = 35;
            btnRealizarPago.Text = "Realizar Pago";
            btnRealizarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRealizarPago.UseVisualStyleBackColor = true;
            // 
            // txtMontoFac
            // 
            this.txtMontoFac.Location = new System.Drawing.Point(572, 103);
            this.txtMontoFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoFac.Name = "txtMontoFac";
            this.txtMontoFac.Size = new System.Drawing.Size(144, 22);
            this.txtMontoFac.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "N° Orden";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(152, 144);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(157, 22);
            this.txtNroFactura.TabIndex = 27;
            // 
            // dgvListaFactura
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaFactura.ColumnHeadersHeight = 29;
            this.dgvListaFactura.Location = new System.Drawing.Point(49, 197);
            this.dgvListaFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListaFactura.Name = "dgvListaFactura";
            this.dgvListaFactura.RowHeadersWidth = 51;
            this.dgvListaFactura.RowTemplate.Height = 24;
            this.dgvListaFactura.Size = new System.Drawing.Size(767, 418);
            this.dgvListaFactura.TabIndex = 25;
            // 
            // txtNroOrdenCompra
            // 
            this.txtNroOrdenCompra.Location = new System.Drawing.Point(152, 107);
            this.txtNroOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroOrdenCompra.Name = "txtNroOrdenCompra";
            this.txtNroOrdenCompra.Size = new System.Drawing.Size(149, 22);
            this.txtNroOrdenCompra.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "N° Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 103);
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
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1027, 71);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormPagoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1027, 663);
            this.Controls.Add(btnRealizarPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontoFac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.dgvListaFactura);
            this.Controls.Add(this.txtNroOrdenCompra);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPagoFactura";
            this.Text = "FormPagoFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontoFac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.DataGridView dgvListaFactura;
        private System.Windows.Forms.TextBox txtNroOrdenCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}