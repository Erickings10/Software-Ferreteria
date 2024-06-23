<<<<<<< HEAD
﻿
namespace ProyectoMoanso
=======
﻿namespace ProyectoMoanso
>>>>>>> dd31acfd6d4433f67da2818ac7f53c9b037bda6a
{
    partial class FormCategoriaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoriaProducto));
<<<<<<< HEAD
            this.dgvCategoriaPro = new System.Windows.Forms.DataGridView();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.gboxDatos = new System.Windows.Forms.GroupBox();
            this.chbxEstado = new System.Windows.Forms.CheckBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaPro)).BeginInit();
            this.gbBotones.SuspendLayout();
            this.gboxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategoriaPro
            // 
            this.dgvCategoriaPro.AllowUserToAddRows = false;
            this.dgvCategoriaPro.AllowUserToDeleteRows = false;
            this.dgvCategoriaPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriaPro.Location = new System.Drawing.Point(220, 112);
            this.dgvCategoriaPro.Name = "dgvCategoriaPro";
            this.dgvCategoriaPro.ReadOnly = true;
            this.dgvCategoriaPro.Size = new System.Drawing.Size(565, 267);
            this.dgvCategoriaPro.TabIndex = 50;
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btnAgregar);
            this.gbBotones.Controls.Add(this.btnModificar);
            this.gbBotones.Controls.Add(this.btnDeshabilitar);
            this.gbBotones.Location = new System.Drawing.Point(27, 121);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(171, 197);
            this.gbBotones.TabIndex = 49;
            this.gbBotones.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(18, 18);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 38);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(18, 80);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 38);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnDeshabilitar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitar.Image")));
            this.btnDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitar.Location = new System.Drawing.Point(18, 140);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(134, 38);
            this.btnDeshabilitar.TabIndex = 14;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            // 
            // gboxDatos
            // 
            this.gboxDatos.Controls.Add(this.chbxEstado);
            this.gboxDatos.Controls.Add(this.txtCategoria);
            this.gboxDatos.Controls.Add(this.txtId);
            this.gboxDatos.Controls.Add(this.label3);
            this.gboxDatos.Controls.Add(this.label2);
            this.gboxDatos.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDatos.Location = new System.Drawing.Point(219, 22);
            this.gboxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gboxDatos.Name = "gboxDatos";
            this.gboxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gboxDatos.Size = new System.Drawing.Size(566, 71);
            this.gboxDatos.TabIndex = 48;
            this.gboxDatos.TabStop = false;
            this.gboxDatos.Text = "Datos Generales";
            // 
            // chbxEstado
            // 
            this.chbxEstado.AutoSize = true;
            this.chbxEstado.Location = new System.Drawing.Point(441, 32);
            this.chbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.chbxEstado.Name = "chbxEstado";
            this.chbxEstado.Size = new System.Drawing.Size(71, 21);
            this.chbxEstado.TabIndex = 7;
            this.chbxEstado.Text = "Estado";
            this.chbxEstado.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(249, 29);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(108, 24);
            this.txtCategoria.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(69, 29);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 24);
            this.txtId.TabIndex = 4;
=======
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_NuevoCT = new System.Windows.Forms.Button();
            this.btn_CancelarCT = new System.Windows.Forms.Button();
            this.gbox_BotonsCT = new System.Windows.Forms.GroupBox();
            this.btn_agregarCT = new System.Windows.Forms.Button();
            this.btn_eliminarCT = new System.Windows.Forms.Button();
            this.btn_actualizarCT = new System.Windows.Forms.Button();
            this.dgb_CategoriaProducto = new System.Windows.Forms.DataGridView();
            this.gbox_DatosCT = new System.Windows.Forms.GroupBox();
            this.chbx_EstadoCP = new System.Windows.Forms.CheckBox();
            this.datp_FechaCP = new System.Windows.Forms.DateTimePicker();
            this.txt_CategoriaCP = new System.Windows.Forms.TextBox();
            this.txt_IDcp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.gbox_BotonsCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_CategoriaProducto)).BeginInit();
            this.gbox_DatosCT.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(850, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "CATEGORIA PRODUCTO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_NuevoCT);
            this.groupBox2.Controls.Add(this.btn_CancelarCT);
            this.groupBox2.Location = new System.Drawing.Point(23, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(159, 176);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btn_NuevoCT
            // 
            this.btn_NuevoCT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NuevoCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoCT.Image = ((System.Drawing.Image)(resources.GetObject("btn_NuevoCT.Image")));
            this.btn_NuevoCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoCT.Location = new System.Drawing.Point(25, 29);
            this.btn_NuevoCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NuevoCT.Name = "btn_NuevoCT";
            this.btn_NuevoCT.Size = new System.Drawing.Size(112, 40);
            this.btn_NuevoCT.TabIndex = 3;
            this.btn_NuevoCT.Text = "Nuevo";
            this.btn_NuevoCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NuevoCT.UseVisualStyleBackColor = true;
            this.btn_NuevoCT.Click += new System.EventHandler(this.btn_NuevoCT_Click);
            // 
            // btn_CancelarCT
            // 
            this.btn_CancelarCT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CancelarCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarCT.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarCT.Image")));
            this.btn_CancelarCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarCT.Location = new System.Drawing.Point(26, 108);
            this.btn_CancelarCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CancelarCT.Name = "btn_CancelarCT";
            this.btn_CancelarCT.Size = new System.Drawing.Size(112, 41);
            this.btn_CancelarCT.TabIndex = 4;
            this.btn_CancelarCT.Text = "Cancelar";
            this.btn_CancelarCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CancelarCT.UseVisualStyleBackColor = true;
            this.btn_CancelarCT.Click += new System.EventHandler(this.btn_CancelarCT_Click);
            // 
            // gbox_BotonsCT
            // 
            this.gbox_BotonsCT.Controls.Add(this.btn_agregarCT);
            this.gbox_BotonsCT.Controls.Add(this.btn_eliminarCT);
            this.gbox_BotonsCT.Controls.Add(this.btn_actualizarCT);
            this.gbox_BotonsCT.Location = new System.Drawing.Point(674, 71);
            this.gbox_BotonsCT.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_BotonsCT.Name = "gbox_BotonsCT";
            this.gbox_BotonsCT.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_BotonsCT.Size = new System.Drawing.Size(150, 176);
            this.gbox_BotonsCT.TabIndex = 10;
            this.gbox_BotonsCT.TabStop = false;
            // 
            // btn_agregarCT
            // 
            this.btn_agregarCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarCT.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregarCT.Image")));
            this.btn_agregarCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarCT.Location = new System.Drawing.Point(18, 17);
            this.btn_agregarCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregarCT.Name = "btn_agregarCT";
            this.btn_agregarCT.Size = new System.Drawing.Size(118, 43);
            this.btn_agregarCT.TabIndex = 6;
            this.btn_agregarCT.Text = "Agregar";
            this.btn_agregarCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregarCT.UseVisualStyleBackColor = true;
            this.btn_agregarCT.Click += new System.EventHandler(this.btn_agregarCT_Click);
            // 
            // btn_eliminarCT
            // 
            this.btn_eliminarCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarCT.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminarCT.Image")));
            this.btn_eliminarCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarCT.Location = new System.Drawing.Point(18, 120);
            this.btn_eliminarCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminarCT.Name = "btn_eliminarCT";
            this.btn_eliminarCT.Size = new System.Drawing.Size(118, 43);
            this.btn_eliminarCT.TabIndex = 8;
            this.btn_eliminarCT.Text = "Inhabilitar";
            this.btn_eliminarCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminarCT.UseVisualStyleBackColor = true;
            this.btn_eliminarCT.Click += new System.EventHandler(this.btn_eliminarCT_Click);
            // 
            // btn_actualizarCT
            // 
            this.btn_actualizarCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarCT.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizarCT.Image")));
            this.btn_actualizarCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizarCT.Location = new System.Drawing.Point(18, 70);
            this.btn_actualizarCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizarCT.Name = "btn_actualizarCT";
            this.btn_actualizarCT.Size = new System.Drawing.Size(118, 43);
            this.btn_actualizarCT.TabIndex = 7;
            this.btn_actualizarCT.Text = "Actualizar";
            this.btn_actualizarCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_actualizarCT.UseVisualStyleBackColor = true;
            this.btn_actualizarCT.Click += new System.EventHandler(this.btn_ActualizarCT_Click);
            // 
            // dgb_CategoriaProducto
            // 
            this.dgb_CategoriaProducto.AllowDrop = true;
            this.dgb_CategoriaProducto.AllowUserToOrderColumns = true;
            this.dgb_CategoriaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_CategoriaProducto.Location = new System.Drawing.Point(178, 275);
            this.dgb_CategoriaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgb_CategoriaProducto.Name = "dgb_CategoriaProducto";
            this.dgb_CategoriaProducto.ReadOnly = true;
            this.dgb_CategoriaProducto.RowHeadersWidth = 51;
            this.dgb_CategoriaProducto.RowTemplate.Height = 24;
            this.dgb_CategoriaProducto.Size = new System.Drawing.Size(490, 198);
            this.dgb_CategoriaProducto.TabIndex = 11;
            this.dgb_CategoriaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Categoria_CellClick);
            // 
            // gbox_DatosCT
            // 
            this.gbox_DatosCT.Controls.Add(this.chbx_EstadoCP);
            this.gbox_DatosCT.Controls.Add(this.datp_FechaCP);
            this.gbox_DatosCT.Controls.Add(this.txt_CategoriaCP);
            this.gbox_DatosCT.Controls.Add(this.txt_IDcp);
            this.gbox_DatosCT.Controls.Add(this.label4);
            this.gbox_DatosCT.Controls.Add(this.label3);
            this.gbox_DatosCT.Controls.Add(this.label2);
            this.gbox_DatosCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_DatosCT.Location = new System.Drawing.Point(252, 71);
            this.gbox_DatosCT.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_DatosCT.Name = "gbox_DatosCT";
            this.gbox_DatosCT.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_DatosCT.Size = new System.Drawing.Size(340, 176);
            this.gbox_DatosCT.TabIndex = 12;
            this.gbox_DatosCT.TabStop = false;
            this.gbox_DatosCT.Text = "Datos Generales";
            // 
            // chbx_EstadoCP
            // 
            this.chbx_EstadoCP.AutoSize = true;
            this.chbx_EstadoCP.Location = new System.Drawing.Point(249, 47);
            this.chbx_EstadoCP.Margin = new System.Windows.Forms.Padding(2);
            this.chbx_EstadoCP.Name = "chbx_EstadoCP";
            this.chbx_EstadoCP.Size = new System.Drawing.Size(71, 21);
            this.chbx_EstadoCP.TabIndex = 7;
            this.chbx_EstadoCP.Text = "Estado";
            this.chbx_EstadoCP.UseVisualStyleBackColor = true;
            // 
            // datp_FechaCP
            // 
            this.datp_FechaCP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datp_FechaCP.Location = new System.Drawing.Point(152, 115);
            this.datp_FechaCP.Margin = new System.Windows.Forms.Padding(2);
            this.datp_FechaCP.Name = "datp_FechaCP";
            this.datp_FechaCP.Size = new System.Drawing.Size(151, 23);
            this.datp_FechaCP.TabIndex = 6;
            // 
            // txt_CategoriaCP
            // 
            this.txt_CategoriaCP.Location = new System.Drawing.Point(106, 80);
            this.txt_CategoriaCP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CategoriaCP.Name = "txt_CategoriaCP";
            this.txt_CategoriaCP.Size = new System.Drawing.Size(108, 23);
            this.txt_CategoriaCP.TabIndex = 5;
            // 
            // txt_IDcp
            // 
            this.txt_IDcp.Location = new System.Drawing.Point(65, 29);
            this.txt_IDcp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDcp.Name = "txt_IDcp";
            this.txt_IDcp.Size = new System.Drawing.Size(74, 23);
            this.txt_IDcp.TabIndex = 4;
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
>>>>>>> dd31acfd6d4433f67da2818ac7f53c9b037bda6a
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(176, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categoria";
=======
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categoria:";
>>>>>>> dd31acfd6d4433f67da2818ac7f53c9b037bda6a
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
<<<<<<< HEAD
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nuevo.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(66, 53);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(112, 40);
            this.btn_Nuevo.TabIndex = 46;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(66, 338);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 41);
            this.btn_Cancelar.TabIndex = 47;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
=======
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
>>>>>>> dd31acfd6d4433f67da2818ac7f53c9b037bda6a
            // FormCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(826, 423);
            this.Controls.Add(this.dgvCategoriaPro);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.gboxDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoriaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCategoriaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaPro)).EndInit();
            this.gbBotones.ResumeLayout(false);
            this.gboxDatos.ResumeLayout(false);
            this.gboxDatos.PerformLayout();
            this.ResumeLayout(false);
=======
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(850, 508);
            this.Controls.Add(this.gbox_DatosCT);
            this.Controls.Add(this.dgb_CategoriaProducto);
            this.Controls.Add(this.gbox_BotonsCT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoriaProducto";
            this.Text = "FormCategoriaProducto";
            this.groupBox2.ResumeLayout(false);
            this.gbox_BotonsCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgb_CategoriaProducto)).EndInit();
            this.gbox_DatosCT.ResumeLayout(false);
            this.gbox_DatosCT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> dd31acfd6d4433f67da2818ac7f53c9b037bda6a

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.DataGridView dgvCategoriaPro;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox gboxDatos;
        private System.Windows.Forms.CheckBox chbxEstado;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtId;
=======
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_NuevoCT;
        private System.Windows.Forms.Button btn_CancelarCT;
        private System.Windows.Forms.GroupBox gbox_BotonsCT;
        private System.Windows.Forms.Button btn_agregarCT;
        private System.Windows.Forms.Button btn_eliminarCT;
        private System.Windows.Forms.Button btn_actualizarCT;
        private System.Windows.Forms.DataGridView dgb_CategoriaProducto;
        private System.Windows.Forms.GroupBox gbox_DatosCT;
        private System.Windows.Forms.CheckBox chbx_EstadoCP;
        private System.Windows.Forms.DateTimePicker datp_FechaCP;
        private System.Windows.Forms.TextBox txt_CategoriaCP;
        private System.Windows.Forms.TextBox txt_IDcp;
        private System.Windows.Forms.Label label4;
>>>>>>> dd31acfd6d4433f67da2818ac7f53c9b037bda6a
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}