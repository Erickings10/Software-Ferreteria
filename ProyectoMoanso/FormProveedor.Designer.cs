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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chbx_Estado_pro = new System.Windows.Forms.CheckBox();
            this.txt_Codi_pro = new System.Windows.Forms.TextBox();
            this.txt_nrodocu_pro = new System.Windows.Forms.TextBox();
            this.txt_razsoc_pro = new System.Windows.Forms.TextBox();
            this.txt_correo_pro = new System.Windows.Forms.TextBox();
            this.txt_telefono_pro = new System.Windows.Forms.TextBox();
            this.cbx_seccom_pro = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorDocumento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_eliminar_proveedores = new System.Windows.Forms.Button();
            this.btn_actualizar_pro = new System.Windows.Forms.Button();
            this.btn_agregar_pro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razon Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sector Comercial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "N° Documento:";
            // 
            // chbx_Estado_pro
            // 
            this.chbx_Estado_pro.AutoSize = true;
            this.chbx_Estado_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx_Estado_pro.Location = new System.Drawing.Point(328, 203);
            this.chbx_Estado_pro.Margin = new System.Windows.Forms.Padding(2);
            this.chbx_Estado_pro.Name = "chbx_Estado_pro";
            this.chbx_Estado_pro.Size = new System.Drawing.Size(71, 21);
            this.chbx_Estado_pro.TabIndex = 7;
            this.chbx_Estado_pro.Text = "Estado";
            this.chbx_Estado_pro.UseVisualStyleBackColor = true;
            // 
            // txt_Codi_pro
            // 
            this.txt_Codi_pro.Location = new System.Drawing.Point(178, 87);
            this.txt_Codi_pro.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Codi_pro.Name = "txt_Codi_pro";
            this.txt_Codi_pro.Size = new System.Drawing.Size(54, 20);
            this.txt_Codi_pro.TabIndex = 8;
            // 
            // txt_nrodocu_pro
            // 
            this.txt_nrodocu_pro.Location = new System.Drawing.Point(156, 132);
            this.txt_nrodocu_pro.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nrodocu_pro.Name = "txt_nrodocu_pro";
            this.txt_nrodocu_pro.Size = new System.Drawing.Size(121, 20);
            this.txt_nrodocu_pro.TabIndex = 9;
            this.txt_nrodocu_pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nrodocu_pro_KeyPress);
            // 
            // txt_razsoc_pro
            // 
            this.txt_razsoc_pro.Location = new System.Drawing.Point(156, 180);
            this.txt_razsoc_pro.Margin = new System.Windows.Forms.Padding(2);
            this.txt_razsoc_pro.Name = "txt_razsoc_pro";
            this.txt_razsoc_pro.Size = new System.Drawing.Size(121, 20);
            this.txt_razsoc_pro.TabIndex = 10;
            // 
            // txt_correo_pro
            // 
            this.txt_correo_pro.Location = new System.Drawing.Point(395, 110);
            this.txt_correo_pro.Margin = new System.Windows.Forms.Padding(2);
            this.txt_correo_pro.Name = "txt_correo_pro";
            this.txt_correo_pro.Size = new System.Drawing.Size(114, 20);
            this.txt_correo_pro.TabIndex = 12;
            // 
            // txt_telefono_pro
            // 
            this.txt_telefono_pro.Location = new System.Drawing.Point(395, 149);
            this.txt_telefono_pro.Margin = new System.Windows.Forms.Padding(2);
            this.txt_telefono_pro.Name = "txt_telefono_pro";
            this.txt_telefono_pro.Size = new System.Drawing.Size(114, 20);
            this.txt_telefono_pro.TabIndex = 13;
            this.txt_telefono_pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_pro_KeyPress);
            // 
            // cbx_seccom_pro
            // 
            this.cbx_seccom_pro.FormattingEnabled = true;
            this.cbx_seccom_pro.Location = new System.Drawing.Point(156, 224);
            this.cbx_seccom_pro.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_seccom_pro.Name = "cbx_seccom_pro";
            this.cbx_seccom_pro.Size = new System.Drawing.Size(121, 21);
            this.cbx_seccom_pro.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 265);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(614, 224);
            this.dataGridView1.TabIndex = 15;
            // 
            // errorDocumento
            // 
            this.errorDocumento.ContainerControl = this;
            // 
            // errorTelefono
            // 
            this.errorTelefono.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(725, 58);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 28);
            this.label8.TabIndex = 25;
            this.label8.Text = "REGISTRO DE PROVEEDORES";
            // 
            // btn_eliminar_proveedores
            // 
            this.btn_eliminar_proveedores.BackColor = System.Drawing.Color.Tomato;
            this.btn_eliminar_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_proveedores.Image = global::ProyectoMoanso.Properties.Resources.bote_de_basura;
            this.btn_eliminar_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar_proveedores.Location = new System.Drawing.Point(568, 203);
            this.btn_eliminar_proveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar_proveedores.Name = "btn_eliminar_proveedores";
            this.btn_eliminar_proveedores.Size = new System.Drawing.Size(125, 40);
            this.btn_eliminar_proveedores.TabIndex = 18;
            this.btn_eliminar_proveedores.Text = "Eliminar";
            this.btn_eliminar_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_actualizar_pro
            // 
            this.btn_actualizar_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_actualizar_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_pro.Image = global::ProyectoMoanso.Properties.Resources.reset;
            this.btn_actualizar_pro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar_pro.Location = new System.Drawing.Point(568, 149);
            this.btn_actualizar_pro.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizar_pro.Name = "btn_actualizar_pro";
            this.btn_actualizar_pro.Size = new System.Drawing.Size(125, 39);
            this.btn_actualizar_pro.TabIndex = 17;
            this.btn_actualizar_pro.Text = "Actualizar";
            this.btn_actualizar_pro.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_pro
            // 
            this.btn_agregar_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_agregar_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_pro.Image = global::ProyectoMoanso.Properties.Resources.Disco;
            this.btn_agregar_pro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar_pro.Location = new System.Drawing.Point(568, 91);
            this.btn_agregar_pro.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar_pro.Name = "btn_agregar_pro";
            this.btn_agregar_pro.Size = new System.Drawing.Size(125, 39);
            this.btn_agregar_pro.TabIndex = 16;
            this.btn_agregar_pro.Text = "Agregar";
            this.btn_agregar_pro.UseVisualStyleBackColor = false;
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(725, 517);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_eliminar_proveedores);
            this.Controls.Add(this.btn_actualizar_pro);
            this.Controls.Add(this.btn_agregar_pro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_seccom_pro);
            this.Controls.Add(this.txt_telefono_pro);
            this.Controls.Add(this.txt_correo_pro);
            this.Controls.Add(this.txt_razsoc_pro);
            this.Controls.Add(this.txt_nrodocu_pro);
            this.Controls.Add(this.txt_Codi_pro);
            this.Controls.Add(this.chbx_Estado_pro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProveedor";
            this.Text = "FormProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbx_Estado_pro;
        private System.Windows.Forms.TextBox txt_Codi_pro;
        private System.Windows.Forms.TextBox txt_nrodocu_pro;
        private System.Windows.Forms.TextBox txt_razsoc_pro;
        private System.Windows.Forms.TextBox txt_correo_pro;
        private System.Windows.Forms.TextBox txt_telefono_pro;
        private System.Windows.Forms.ComboBox cbx_seccom_pro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_agregar_pro;
        private System.Windows.Forms.Button btn_actualizar_pro;
        private System.Windows.Forms.Button btn_eliminar_proveedores;
        private System.Windows.Forms.ErrorProvider errorDocumento;
        private System.Windows.Forms.ErrorProvider errorTelefono;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label8;
    }
}