namespace ProyectoMoanso
{
    partial class FormRequerimientosdeCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequerimientosdeCompras));
            this.dgvRequerimientos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gboBotones2 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gboBotones1 = new System.Windows.Forms.GroupBox();
            this.btnDeshabilitarReque = new System.Windows.Forms.Button();
            this.btnNuevoReque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientos)).BeginInit();
            this.gboBotones2.SuspendLayout();
            this.gboBotones1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRequerimientos
            // 
            this.dgvRequerimientos.AllowUserToAddRows = false;
            this.dgvRequerimientos.AllowUserToDeleteRows = false;
            this.dgvRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequerimientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRequerimientos.Location = new System.Drawing.Point(291, 112);
            this.dgvRequerimientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRequerimientos.Name = "dgvRequerimientos";
            this.dgvRequerimientos.ReadOnly = true;
            this.dgvRequerimientos.RowHeadersWidth = 51;
            this.dgvRequerimientos.Size = new System.Drawing.Size(856, 495);
            this.dgvRequerimientos.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(311, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(443, 40);
            this.label6.TabIndex = 36;
            this.label6.Text = "Requerimientos de Compras";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1200, 71);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "NECESIDADES DE COMPRA";
            // 
            // gboBotones2
            // 
            this.gboBotones2.Controls.Add(this.btnActualizar);
            this.gboBotones2.Controls.Add(this.btnCancelar);
            this.gboBotones2.Location = new System.Drawing.Point(51, 357);
            this.gboBotones2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboBotones2.Name = "gboBotones2";
            this.gboBotones2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboBotones2.Size = new System.Drawing.Size(217, 187);
            this.gboBotones2.TabIndex = 38;
            this.gboBotones2.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Tan;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(21, 36);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(176, 44);
            this.btnActualizar.TabIndex = 42;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(21, 110);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 44);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // gboBotones1
            // 
            this.gboBotones1.Controls.Add(this.btnDeshabilitarReque);
            this.gboBotones1.Controls.Add(this.btnNuevoReque);
            this.gboBotones1.Location = new System.Drawing.Point(44, 138);
            this.gboBotones1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboBotones1.Name = "gboBotones1";
            this.gboBotones1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboBotones1.Size = new System.Drawing.Size(224, 169);
            this.gboBotones1.TabIndex = 39;
            this.gboBotones1.TabStop = false;
            // 
            // btnDeshabilitarReque
            // 
            this.btnDeshabilitarReque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshabilitarReque.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnDeshabilitarReque.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitarReque.Image")));
            this.btnDeshabilitarReque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitarReque.Location = new System.Drawing.Point(27, 97);
            this.btnDeshabilitarReque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeshabilitarReque.Name = "btnDeshabilitarReque";
            this.btnDeshabilitarReque.Size = new System.Drawing.Size(177, 44);
            this.btnDeshabilitarReque.TabIndex = 39;
            this.btnDeshabilitarReque.Text = "Anular";
            this.btnDeshabilitarReque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitarReque.UseVisualStyleBackColor = true;
            this.btnDeshabilitarReque.Click += new System.EventHandler(this.btnDeshabilitarReque_Click);
            // 
            // btnNuevoReque
            // 
            this.btnNuevoReque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoReque.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnNuevoReque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevoReque.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoReque.Image")));
            this.btnNuevoReque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoReque.Location = new System.Drawing.Point(27, 23);
            this.btnNuevoReque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoReque.Name = "btnNuevoReque";
            this.btnNuevoReque.Size = new System.Drawing.Size(177, 44);
            this.btnNuevoReque.TabIndex = 24;
            this.btnNuevoReque.Text = "Nuevo ";
            this.btnNuevoReque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoReque.UseVisualStyleBackColor = true;
            this.btnNuevoReque.Click += new System.EventHandler(this.btnNuevoRequerimiento_Click);
            // 
            // FormRequerimientosdeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.gboBotones1);
            this.Controls.Add(this.gboBotones2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvRequerimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRequerimientosdeCompras";
            this.Text = "NecesidadesdeCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientos)).EndInit();
            this.gboBotones2.ResumeLayout(false);
            this.gboBotones1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRequerimientos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gboBotones2;
        private System.Windows.Forms.Button btnNuevoReque;
        private System.Windows.Forms.Button btnDeshabilitarReque;
        private System.Windows.Forms.GroupBox gboBotones1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
    }
}