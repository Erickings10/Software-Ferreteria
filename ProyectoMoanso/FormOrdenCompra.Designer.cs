
namespace ProyectoMoanso
{
    partial class dgv_productosRequeridos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dgv_productosRequeridos));
            this.lblOrden = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gBoBotones = new System.Windows.Forms.GroupBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Deshabilitar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarOrden = new FontAwesome.Sharp.IconButton();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.lblOrdden = new System.Windows.Forms.Label();
            this.btnProovedor = new FontAwesome.Sharp.IconButton();
            this.txtProovedor = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gBoBotones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrden.Location = new System.Drawing.Point(33, 39);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(21, 17);
            this.lblOrden.TabIndex = 1;
            this.lblOrden.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha: ";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProveedor.Location = new System.Drawing.Point(239, 88);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(82, 17);
            this.lblProveedor.TabIndex = 3;
            this.lblProveedor.Text = "Proveedor: ";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtID.Location = new System.Drawing.Point(115, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(56, 21);
            this.txtID.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(24, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 200);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 246);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos Requeridos";
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
            this.menuStrip1.Size = new System.Drawing.Size(946, 58);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "ORDEN DE COMPRA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(100, 88);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(85, 23);
            this.dtpFecha.TabIndex = 28;
            // 
            // gBoBotones
            // 
            this.gBoBotones.Controls.Add(this.btn_Agregar);
            this.gBoBotones.Controls.Add(this.btn_Deshabilitar);
            this.gBoBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gBoBotones.Location = new System.Drawing.Point(690, 72);
            this.gBoBotones.Name = "gBoBotones";
            this.gBoBotones.Size = new System.Drawing.Size(192, 181);
            this.gBoBotones.TabIndex = 29;
            this.gBoBotones.TabStop = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(16, 25);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(164, 38);
            this.btn_Agregar.TabIndex = 16;
            this.btn_Agregar.Text = "Agregar ";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // btn_Deshabilitar
            // 
            this.btn_Deshabilitar.BackColor = System.Drawing.Color.Tomato;
            this.btn_Deshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Deshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Deshabilitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Deshabilitar.Image")));
            this.btn_Deshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Deshabilitar.Location = new System.Drawing.Point(16, 130);
            this.btn_Deshabilitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(164, 38);
            this.btn_Deshabilitar.TabIndex = 18;
            this.btn_Deshabilitar.Text = "Deshabilitar";
            this.btn_Deshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Deshabilitar.UseVisualStyleBackColor = false;
            this.btn_Deshabilitar.Click += new System.EventHandler(this.btn_Deshabilitar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxEstado);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.btnBuscarOrden);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtOrdenCompra);
            this.groupBox2.Controls.Add(this.lblOrdden);
            this.groupBox2.Controls.Add(this.btnProovedor);
            this.groupBox2.Controls.Add(this.txtProovedor);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.lblOrden);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblProveedor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(167, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 202);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Generales";
            // 
            // btnBuscarOrden
            // 
            this.btnBuscarOrden.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarOrden.IconColor = System.Drawing.Color.Black;
            this.btnBuscarOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarOrden.IconSize = 18;
            this.btnBuscarOrden.Location = new System.Drawing.Point(397, 39);
            this.btnBuscarOrden.Name = "btnBuscarOrden";
            this.btnBuscarOrden.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarOrden.TabIndex = 39;
            this.btnBuscarOrden.UseVisualStyleBackColor = true;
            this.btnBuscarOrden.Click += new System.EventHandler(this.btnBuscarOrden_Click);
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtOrdenCompra.Location = new System.Drawing.Point(327, 41);
            this.txtOrdenCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.ReadOnly = true;
            this.txtOrdenCompra.Size = new System.Drawing.Size(76, 21);
            this.txtOrdenCompra.TabIndex = 38;
            // 
            // lblOrdden
            // 
            this.lblOrdden.AutoSize = true;
            this.lblOrdden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrdden.Location = new System.Drawing.Point(239, 44);
            this.lblOrdden.Name = "lblOrdden";
            this.lblOrdden.Size = new System.Drawing.Size(72, 17);
            this.lblOrdden.TabIndex = 37;
            this.lblOrdden.Text = "N° Orden:";
            // 
            // btnProovedor
            // 
            this.btnProovedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnProovedor.IconColor = System.Drawing.Color.Black;
            this.btnProovedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProovedor.IconSize = 18;
            this.btnProovedor.Location = new System.Drawing.Point(397, 83);
            this.btnProovedor.Name = "btnProovedor";
            this.btnProovedor.Size = new System.Drawing.Size(24, 24);
            this.btnProovedor.TabIndex = 36;
            this.btnProovedor.UseVisualStyleBackColor = true;
            this.btnProovedor.Click += new System.EventHandler(this.btnProovedor_Click);
            // 
            // txtProovedor
            // 
            this.txtProovedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtProovedor.Location = new System.Drawing.Point(326, 85);
            this.txtProovedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProovedor.Name = "txtProovedor";
            this.txtProovedor.ReadOnly = true;
            this.txtProovedor.Size = new System.Drawing.Size(76, 21);
            this.txtProovedor.TabIndex = 34;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTotal.Location = new System.Drawing.Point(85, 141);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(112, 21);
            this.txtTotal.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Total";
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstado.Location = new System.Drawing.Point(439, 176);
            this.checkBoxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(70, 21);
            this.checkBoxEstado.TabIndex = 55;
            this.checkBoxEstado.Text = "estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // dgv_productosRequeridos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(946, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBoBotones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dgv_productosRequeridos";
            this.Text = "FormOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gBoBotones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Deshabilitar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox gBoBotones;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnProovedor;
        private System.Windows.Forms.TextBox txtProovedor;
        private System.Windows.Forms.Label lblOrdden;
        private System.Windows.Forms.TextBox txtOrdenCompra;
        private FontAwesome.Sharp.IconButton btnBuscarOrden;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
    }
}