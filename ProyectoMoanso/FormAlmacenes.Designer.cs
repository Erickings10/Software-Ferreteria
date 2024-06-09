namespace ProyectoMoanso
{
    partial class FormAlmacenes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar_Almacenes = new System.Windows.Forms.Button();
            this.btn_actualizar_Almacenes = new System.Windows.Forms.Button();
            this.btn_agregar_almacenes = new System.Windows.Forms.Button();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "REGISTRO DE ALMACENES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(668, 58);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 186);
            this.dataGridView1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSeleccionar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 220);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_eliminar_Almacenes);
            this.groupBox2.Controls.Add(this.btn_actualizar_Almacenes);
            this.groupBox2.Controls.Add(this.btn_agregar_almacenes);
            this.groupBox2.Location = new System.Drawing.Point(420, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 220);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // btn_eliminar_Almacenes
            // 
            this.btn_eliminar_Almacenes.BackColor = System.Drawing.Color.Tomato;
            this.btn_eliminar_Almacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_Almacenes.Image = global::ProyectoMoanso.Properties.Resources.bote_de_basura;
            this.btn_eliminar_Almacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar_Almacenes.Location = new System.Drawing.Point(38, 141);
            this.btn_eliminar_Almacenes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar_Almacenes.Name = "btn_eliminar_Almacenes";
            this.btn_eliminar_Almacenes.Size = new System.Drawing.Size(125, 40);
            this.btn_eliminar_Almacenes.TabIndex = 21;
            this.btn_eliminar_Almacenes.Text = "Eliminar";
            this.btn_eliminar_Almacenes.UseVisualStyleBackColor = false;
            // 
            // btn_actualizar_Almacenes
            // 
            this.btn_actualizar_Almacenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_actualizar_Almacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_Almacenes.Image = global::ProyectoMoanso.Properties.Resources.reset;
            this.btn_actualizar_Almacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar_Almacenes.Location = new System.Drawing.Point(38, 83);
            this.btn_actualizar_Almacenes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizar_Almacenes.Name = "btn_actualizar_Almacenes";
            this.btn_actualizar_Almacenes.Size = new System.Drawing.Size(125, 39);
            this.btn_actualizar_Almacenes.TabIndex = 20;
            this.btn_actualizar_Almacenes.Text = "Actualizar";
            this.btn_actualizar_Almacenes.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_almacenes
            // 
            this.btn_agregar_almacenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_agregar_almacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_almacenes.Image = global::ProyectoMoanso.Properties.Resources.Disco;
            this.btn_agregar_almacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar_almacenes.Location = new System.Drawing.Point(38, 27);
            this.btn_agregar_almacenes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar_almacenes.Name = "btn_agregar_almacenes";
            this.btn_agregar_almacenes.Size = new System.Drawing.Size(125, 39);
            this.btn_agregar_almacenes.TabIndex = 19;
            this.btn_agregar_almacenes.Text = "Agregar";
            this.btn_agregar_almacenes.UseVisualStyleBackColor = false;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(27, 92);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(161, 18);
            this.lblSeleccionar.TabIndex = 2;
            this.lblSeleccionar.Text = "Categoria de Almacen: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Espacio de Almacen: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 24);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 24);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id de Almacen: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 24);
            this.textBox3.TabIndex = 8;
            // 
            // FormAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(668, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlmacenes";
            this.Text = "FormAlmacenes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_eliminar_Almacenes;
        private System.Windows.Forms.Button btn_actualizar_Almacenes;
        private System.Windows.Forms.Button btn_agregar_almacenes;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}