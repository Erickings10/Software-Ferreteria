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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Eliminar_Produc = new System.Windows.Forms.Button();
            this.btn_Actualizar_Produc = new System.Windows.Forms.Button();
            this.btn_Guardar_Produc = new System.Windows.Forms.Button();
            this.errorStock = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría:";
            // 
            // txt_codigo_produc
            // 
            this.txt_codigo_produc.Location = new System.Drawing.Point(241, 110);
            this.txt_codigo_produc.Name = "txt_codigo_produc";
            this.txt_codigo_produc.Size = new System.Drawing.Size(112, 22);
            this.txt_codigo_produc.TabIndex = 5;
            // 
            // txt_nombre_produc
            // 
            this.txt_nombre_produc.Location = new System.Drawing.Point(166, 163);
            this.txt_nombre_produc.Name = "txt_nombre_produc";
            this.txt_nombre_produc.Size = new System.Drawing.Size(187, 22);
            this.txt_nombre_produc.TabIndex = 6;
            // 
            // txt_stock_produc
            // 
            this.txt_stock_produc.Location = new System.Drawing.Point(166, 205);
            this.txt_stock_produc.Name = "txt_stock_produc";
            this.txt_stock_produc.Size = new System.Drawing.Size(187, 22);
            this.txt_stock_produc.TabIndex = 7;
            this.txt_stock_produc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_produc_KeyPress);
            // 
            // txt_marca_produc
            // 
            this.txt_marca_produc.Location = new System.Drawing.Point(166, 247);
            this.txt_marca_produc.Name = "txt_marca_produc";
            this.txt_marca_produc.Size = new System.Drawing.Size(187, 22);
            this.txt_marca_produc.TabIndex = 8;
            // 
            // txt_categoria_produc
            // 
            this.txt_categoria_produc.Location = new System.Drawing.Point(166, 289);
            this.txt_categoria_produc.Name = "txt_categoria_produc";
            this.txt_categoria_produc.Size = new System.Drawing.Size(187, 22);
            this.txt_categoria_produc.TabIndex = 9;
            // 
            // dgv_registro_productos
            // 
            this.dgv_registro_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registro_productos.Location = new System.Drawing.Point(57, 334);
            this.dgv_registro_productos.Name = "dgv_registro_productos";
            this.dgv_registro_productos.RowHeadersWidth = 51;
            this.dgv_registro_productos.RowTemplate.Height = 24;
            this.dgv_registro_productos.Size = new System.Drawing.Size(625, 295);
            this.dgv_registro_productos.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(413, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "REGISTRO DE PRODUCTOS";
            // 
            // btn_Eliminar_Produc
            // 
            this.btn_Eliminar_Produc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar_Produc.Image = global::ProyectoMoanso.Properties.Resources.bote_de_basura;
            this.btn_Eliminar_Produc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar_Produc.Location = new System.Drawing.Point(530, 237);
            this.btn_Eliminar_Produc.Name = "btn_Eliminar_Produc";
            this.btn_Eliminar_Produc.Size = new System.Drawing.Size(179, 47);
            this.btn_Eliminar_Produc.TabIndex = 14;
            this.btn_Eliminar_Produc.Text = "Eliminar";
            this.btn_Eliminar_Produc.UseVisualStyleBackColor = true;
            // 
            // btn_Actualizar_Produc
            // 
            this.btn_Actualizar_Produc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar_Produc.Image = global::ProyectoMoanso.Properties.Resources.reset;
            this.btn_Actualizar_Produc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Actualizar_Produc.Location = new System.Drawing.Point(530, 163);
            this.btn_Actualizar_Produc.Name = "btn_Actualizar_Produc";
            this.btn_Actualizar_Produc.Size = new System.Drawing.Size(179, 47);
            this.btn_Actualizar_Produc.TabIndex = 13;
            this.btn_Actualizar_Produc.Text = "Actualizar";
            this.btn_Actualizar_Produc.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar_Produc
            // 
            this.btn_Guardar_Produc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar_Produc.Image = global::ProyectoMoanso.Properties.Resources.Disco;
            this.btn_Guardar_Produc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar_Produc.Location = new System.Drawing.Point(530, 85);
            this.btn_Guardar_Produc.Name = "btn_Guardar_Produc";
            this.btn_Guardar_Produc.Size = new System.Drawing.Size(179, 47);
            this.btn_Guardar_Produc.TabIndex = 15;
            this.btn_Guardar_Produc.Text = "Guardar";
            this.btn_Guardar_Produc.UseVisualStyleBackColor = true;
            // 
            // errorStock
            // 
            this.errorStock.ContainerControl = this;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 641);
            this.Controls.Add(this.btn_Guardar_Produc);
            this.Controls.Add(this.btn_Eliminar_Produc);
            this.Controls.Add(this.btn_Actualizar_Produc);
            this.Controls.Add(this.label6);
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
            this.Name = "Productos";
            this.Text = "Productos";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Actualizar_Produc;
        private System.Windows.Forms.Button btn_Eliminar_Produc;
        private System.Windows.Forms.Button btn_Guardar_Produc;
        private System.Windows.Forms.ErrorProvider errorStock;
    }
}