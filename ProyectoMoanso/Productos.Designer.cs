namespace ProyectoMoanso
{
    partial class Productos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_codigo_produc = new System.Windows.Forms.TextBox();
            this.txt_nombre_produc = new System.Windows.Forms.TextBox();
            this.txt_stock_produc = new System.Windows.Forms.TextBox();
            this.txt_marca_produc = new System.Windows.Forms.TextBox();
            this.txt_categoria_produc = new System.Windows.Forms.TextBox();
            this.dgv_registro_productos = new System.Windows.Forms.DataGridView();
            this.errorStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Proveedor_Produc = new System.Windows.Forms.ComboBox();
            this.btn_Guardar_Produc = new System.Windows.Forms.Button();
            this.btn_Eliminar_Produc = new System.Windows.Forms.Button();
            this.btn_Actualizar_Produc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría:";
            // 
            // txt_codigo_produc
            // 
            this.txt_codigo_produc.Location = new System.Drawing.Point(181, 89);
            this.txt_codigo_produc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo_produc.Name = "txt_codigo_produc";
            this.txt_codigo_produc.Size = new System.Drawing.Size(85, 20);
            this.txt_codigo_produc.TabIndex = 5;
            // 
            // txt_nombre_produc
            // 
            this.txt_nombre_produc.Location = new System.Drawing.Point(124, 132);
            this.txt_nombre_produc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_produc.Name = "txt_nombre_produc";
            this.txt_nombre_produc.Size = new System.Drawing.Size(141, 20);
            this.txt_nombre_produc.TabIndex = 6;
            // 
            // txt_stock_produc
            // 
            this.txt_stock_produc.Location = new System.Drawing.Point(124, 167);
            this.txt_stock_produc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_stock_produc.Name = "txt_stock_produc";
            this.txt_stock_produc.Size = new System.Drawing.Size(141, 20);
            this.txt_stock_produc.TabIndex = 7;
            this.txt_stock_produc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_produc_KeyPress);
            // 
            // txt_marca_produc
            // 
            this.txt_marca_produc.Location = new System.Drawing.Point(386, 88);
            this.txt_marca_produc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_marca_produc.Name = "txt_marca_produc";
            this.txt_marca_produc.Size = new System.Drawing.Size(141, 20);
            this.txt_marca_produc.TabIndex = 8;
            // 
            // txt_categoria_produc
            // 
            this.txt_categoria_produc.Location = new System.Drawing.Point(386, 129);
            this.txt_categoria_produc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_categoria_produc.Name = "txt_categoria_produc";
            this.txt_categoria_produc.Size = new System.Drawing.Size(141, 20);
            this.txt_categoria_produc.TabIndex = 9;
            // 
            // dgv_registro_productos
            // 
            this.dgv_registro_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registro_productos.Location = new System.Drawing.Point(43, 228);
            this.dgv_registro_productos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_registro_productos.Name = "dgv_registro_productos";
            this.dgv_registro_productos.RowHeadersWidth = 51;
            this.dgv_registro_productos.RowTemplate.Height = 24;
            this.dgv_registro_productos.Size = new System.Drawing.Size(680, 254);
            this.dgv_registro_productos.TabIndex = 10;
            // 
            // errorStock
            // 
            this.errorStock.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(302, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Proveedor:";
            // 
            // cbx_Proveedor_Produc
            // 
            this.cbx_Proveedor_Produc.FormattingEnabled = true;
            this.cbx_Proveedor_Produc.Location = new System.Drawing.Point(386, 165);
            this.cbx_Proveedor_Produc.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Proveedor_Produc.Name = "cbx_Proveedor_Produc";
            this.cbx_Proveedor_Produc.Size = new System.Drawing.Size(141, 21);
            this.cbx_Proveedor_Produc.TabIndex = 17;
            // 
            // btn_Guardar_Produc
            // 
            this.btn_Guardar_Produc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Guardar_Produc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar_Produc.Image = global::ProyectoMoanso.Properties.Resources.Disco;
            this.btn_Guardar_Produc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar_Produc.Location = new System.Drawing.Point(588, 67);
            this.btn_Guardar_Produc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guardar_Produc.Name = "btn_Guardar_Produc";
            this.btn_Guardar_Produc.Size = new System.Drawing.Size(134, 38);
            this.btn_Guardar_Produc.TabIndex = 15;
            this.btn_Guardar_Produc.Text = "Guardar";
            this.btn_Guardar_Produc.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar_Produc
            // 
            this.btn_Eliminar_Produc.BackColor = System.Drawing.Color.Tomato;
            this.btn_Eliminar_Produc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar_Produc.Image = global::ProyectoMoanso.Properties.Resources.bote_de_basura;
            this.btn_Eliminar_Produc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar_Produc.Location = new System.Drawing.Point(588, 168);
            this.btn_Eliminar_Produc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar_Produc.Name = "btn_Eliminar_Produc";
            this.btn_Eliminar_Produc.Size = new System.Drawing.Size(134, 38);
            this.btn_Eliminar_Produc.TabIndex = 14;
            this.btn_Eliminar_Produc.Text = "Eliminar";
            this.btn_Eliminar_Produc.UseVisualStyleBackColor = false;
            // 
            // btn_Actualizar_Produc
            // 
            this.btn_Actualizar_Produc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Actualizar_Produc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar_Produc.Image = global::ProyectoMoanso.Properties.Resources.reset;
            this.btn_Actualizar_Produc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Actualizar_Produc.Location = new System.Drawing.Point(588, 119);
            this.btn_Actualizar_Produc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Actualizar_Produc.Name = "btn_Actualizar_Produc";
            this.btn_Actualizar_Produc.Size = new System.Drawing.Size(134, 38);
            this.btn_Actualizar_Produc.TabIndex = 13;
            this.btn_Actualizar_Produc.Text = "Actualizar";
            this.btn_Actualizar_Produc.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(799, 58);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(220, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(340, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "REGISTRO DE PRODUCTOS";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(799, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbx_Proveedor_Produc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Guardar_Produc);
            this.Controls.Add(this.btn_Eliminar_Produc);
            this.Controls.Add(this.btn_Actualizar_Produc);
            this.Controls.Add(this.dgv_registro_productos);
            this.Controls.Add(this.txt_categoria_produc);
            this.Controls.Add(this.txt_marca_produc);
            this.Controls.Add(this.txt_stock_produc);
            this.Controls.Add(this.txt_nombre_produc);
            this.Controls.Add(this.txt_codigo_produc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_codigo_produc;
        private System.Windows.Forms.TextBox txt_nombre_produc;
        private System.Windows.Forms.TextBox txt_stock_produc;
        private System.Windows.Forms.TextBox txt_marca_produc;
        private System.Windows.Forms.TextBox txt_categoria_produc;
        private System.Windows.Forms.DataGridView dgv_registro_productos;
        private System.Windows.Forms.Button btn_Actualizar_Produc;
        private System.Windows.Forms.Button btn_Eliminar_Produc;
        private System.Windows.Forms.Button btn_Guardar_Produc;
        private System.Windows.Forms.ErrorProvider errorStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_Proveedor_Produc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}