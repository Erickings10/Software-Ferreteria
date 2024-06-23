namespace ProyectoMoanso
{
    partial class FormRubroProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRubroProveedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox_Datos = new System.Windows.Forms.GroupBox();
            this.chbx_Estado = new System.Windows.Forms.CheckBox();
            this.datp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_Rubro = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbox_Botons = new System.Windows.Forms.GroupBox();
            this.dgb_Rubro = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gbox_Datos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbox_Botons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Rubro)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(759, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "RUBRO DE PROVEEDOR";
            // 
            // gbox_Datos
            // 
            this.gbox_Datos.Controls.Add(this.chbx_Estado);
            this.gbox_Datos.Controls.Add(this.datp_Fecha);
            this.gbox_Datos.Controls.Add(this.txt_Rubro);
            this.gbox_Datos.Controls.Add(this.txt_ID);
            this.gbox_Datos.Controls.Add(this.label4);
            this.gbox_Datos.Controls.Add(this.label3);
            this.gbox_Datos.Controls.Add(this.label2);
            this.gbox_Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_Datos.Location = new System.Drawing.Point(203, 72);
            this.gbox_Datos.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_Datos.Name = "gbox_Datos";
            this.gbox_Datos.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_Datos.Size = new System.Drawing.Size(340, 176);
            this.gbox_Datos.TabIndex = 2;
            this.gbox_Datos.TabStop = false;
            this.gbox_Datos.Text = "Datos Generales";
            // 
            // chbx_Estado
            // 
            this.chbx_Estado.AutoSize = true;
            this.chbx_Estado.Location = new System.Drawing.Point(249, 47);
            this.chbx_Estado.Margin = new System.Windows.Forms.Padding(2);
            this.chbx_Estado.Name = "chbx_Estado";
            this.chbx_Estado.Size = new System.Drawing.Size(71, 21);
            this.chbx_Estado.TabIndex = 7;
            this.chbx_Estado.Text = "Estado";
            this.chbx_Estado.UseVisualStyleBackColor = true;
            // 
            // datp_Fecha
            // 
            this.datp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datp_Fecha.Location = new System.Drawing.Point(152, 115);
            this.datp_Fecha.Margin = new System.Windows.Forms.Padding(2);
            this.datp_Fecha.Name = "datp_Fecha";
            this.datp_Fecha.Size = new System.Drawing.Size(151, 23);
            this.datp_Fecha.TabIndex = 6;
            // 
            // txt_Rubro
            // 
            this.txt_Rubro.Location = new System.Drawing.Point(91, 80);
            this.txt_Rubro.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Rubro.Name = "txt_Rubro";
            this.txt_Rubro.Size = new System.Drawing.Size(108, 23);
            this.txt_Rubro.TabIndex = 5;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(65, 29);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(74, 23);
            this.txt_ID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de registro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rubro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Nuevo);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Location = new System.Drawing.Point(22, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(159, 176);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // gbox_Botons
            // 
            this.gbox_Botons.Controls.Add(this.btn_agregar);
            this.gbox_Botons.Controls.Add(this.btn_eliminar);
            this.gbox_Botons.Controls.Add(this.btn_actualizar);
            this.gbox_Botons.Location = new System.Drawing.Point(563, 72);
            this.gbox_Botons.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_Botons.Name = "gbox_Botons";
            this.gbox_Botons.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_Botons.Size = new System.Drawing.Size(150, 176);
            this.gbox_Botons.TabIndex = 9;
            this.gbox_Botons.TabStop = false;
            // 
            // dgb_Rubro
            // 
            this.dgb_Rubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Rubro.Location = new System.Drawing.Point(130, 260);
            this.dgb_Rubro.Margin = new System.Windows.Forms.Padding(2);
            this.dgb_Rubro.Name = "dgb_Rubro";
            this.dgb_Rubro.RowHeadersWidth = 51;
            this.dgb_Rubro.RowTemplate.Height = 24;
            this.dgb_Rubro.Size = new System.Drawing.Size(490, 198);
            this.dgb_Rubro.TabIndex = 10;
            this.dgb_Rubro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Rubro_CellClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(18, 17);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(118, 43);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(18, 120);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(118, 43);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar.Location = new System.Drawing.Point(18, 70);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(118, 43);
            this.btn_actualizar.TabIndex = 7;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(25, 29);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(112, 40);
            this.btn_Nuevo.TabIndex = 3;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(26, 108);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 41);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
<<<<<<< HEAD
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Nuevo);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Location = new System.Drawing.Point(22, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(159, 176);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(18, 17);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(118, 43);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar.Location = new System.Drawing.Point(18, 70);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(118, 43);
            this.btn_actualizar.TabIndex = 7;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(18, 120);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(118, 43);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // gbox_Botons
            // 
            this.gbox_Botons.Controls.Add(this.btn_agregar);
            this.gbox_Botons.Controls.Add(this.btn_eliminar);
            this.gbox_Botons.Controls.Add(this.btn_actualizar);
            this.gbox_Botons.Location = new System.Drawing.Point(563, 72);
            this.gbox_Botons.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_Botons.Name = "gbox_Botons";
            this.gbox_Botons.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_Botons.Size = new System.Drawing.Size(150, 176);
            this.gbox_Botons.TabIndex = 9;
            this.gbox_Botons.TabStop = false;
            // 
            // dgb_Rubro
            // 
            this.dgb_Rubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Rubro.Location = new System.Drawing.Point(130, 265);
            this.dgb_Rubro.Margin = new System.Windows.Forms.Padding(2);
            this.dgb_Rubro.Name = "dgb_Rubro";
            this.dgb_Rubro.RowHeadersWidth = 51;
            this.dgb_Rubro.RowTemplate.Height = 24;
            this.dgb_Rubro.Size = new System.Drawing.Size(490, 198);
            this.dgb_Rubro.TabIndex = 10;
            this.dgb_Rubro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Rubro_CellClick);
            // 
=======
>>>>>>> dd31acfd6d4433f67da2818ac7f53c9b037bda6a
            // FormRubroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(759, 474);
            this.Controls.Add(this.dgb_Rubro);
            this.Controls.Add(this.gbox_Botons);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbox_Datos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRubroProveedor";
            this.Text = "FormRubroProveedor";
            this.gbox_Datos.ResumeLayout(false);
            this.gbox_Datos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbox_Botons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Rubro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbox_Datos;
        private System.Windows.Forms.CheckBox chbx_Estado;
        private System.Windows.Forms.DateTimePicker datp_Fecha;
        private System.Windows.Forms.TextBox txt_Rubro;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.GroupBox gbox_Botons;
        private System.Windows.Forms.DataGridView dgb_Rubro;
    }
}