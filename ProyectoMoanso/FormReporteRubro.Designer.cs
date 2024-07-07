namespace ProyectoMoanso
{
    partial class FormReporteRubro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteRubro));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ReporteRubro = new System.Windows.Forms.DataGridView();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaRub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReporteRubro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rubros:";
            // 
            // dgv_ReporteRubro
            // 
            this.dgv_ReporteRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReporteRubro.Location = new System.Drawing.Point(56, 164);
            this.dgv_ReporteRubro.Name = "dgv_ReporteRubro";
            this.dgv_ReporteRubro.RowHeadersWidth = 51;
            this.dgv_ReporteRubro.RowTemplate.Height = 24;
            this.dgv_ReporteRubro.Size = new System.Drawing.Size(679, 249);
            this.dgv_ReporteRubro.TabIndex = 1;
            this.dgv_ReporteRubro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ReporteRubro_CellClick);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cerrar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cerrar.Location = new System.Drawing.Point(558, 93);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(177, 44);
            this.btn_Cerrar.TabIndex = 36;
            this.btn_Cerrar.Text = "Cancelar";
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nuevo.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(558, 27);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(177, 44);
            this.btn_Nuevo.TabIndex = 37;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaRub);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(228, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 110);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSQUEDA";
            // 
            // txtBuscaRub
            // 
            this.txtBuscaRub.Location = new System.Drawing.Point(84, 51);
            this.txtBuscaRub.Name = "txtBuscaRub";
            this.txtBuscaRub.Size = new System.Drawing.Size(143, 22);
            this.txtBuscaRub.TabIndex = 1;
            this.txtBuscaRub.TextChanged += new System.EventHandler(this.txtBuscaRub_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rubro:";
            // 
            // FormReporteRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.dgv_ReporteRubro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormReporteRubro";
            this.Text = "ReporteRubro";
            this.Load += new System.EventHandler(this.FormReporteRubro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReporteRubro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ReporteRubro;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaRub;
        private System.Windows.Forms.Label label2;
    }
}