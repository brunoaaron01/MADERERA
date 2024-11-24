namespace CAPAPRESENTACION
{
    partial class MantenedorTipoProducto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDescTipoProd = new System.Windows.Forms.Label();
            this.txtDescTipoProd = new System.Windows.Forms.TextBox();
            this.lblInfoProd = new System.Windows.Forms.Label();
            this.btnRegistrarTipProd = new System.Windows.Forms.Button();
            this.btnModificarTipProd = new System.Windows.Forms.Button();
            this.btnEliminarTipProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblDescTipoProd
            // 
            this.lblDescTipoProd.AutoSize = true;
            this.lblDescTipoProd.Location = new System.Drawing.Point(42, 35);
            this.lblDescTipoProd.Name = "lblDescTipoProd";
            this.lblDescTipoProd.Size = new System.Drawing.Size(128, 13);
            this.lblDescTipoProd.TabIndex = 1;
            this.lblDescTipoProd.Text = "Descripción tipo producto";
            // 
            // txtDescTipoProd
            // 
            this.txtDescTipoProd.Location = new System.Drawing.Point(186, 27);
            this.txtDescTipoProd.Name = "txtDescTipoProd";
            this.txtDescTipoProd.Size = new System.Drawing.Size(219, 20);
            this.txtDescTipoProd.TabIndex = 2;
            this.txtDescTipoProd.TextChanged += new System.EventHandler(this.txtDescTipoProd_TextChanged);
            // 
            // lblInfoProd
            // 
            this.lblInfoProd.AutoSize = true;
            this.lblInfoProd.Location = new System.Drawing.Point(45, 127);
            this.lblInfoProd.Name = "lblInfoProd";
            this.lblInfoProd.Size = new System.Drawing.Size(209, 13);
            this.lblInfoProd.TabIndex = 3;
            this.lblInfoProd.Text = "Seleccionar elemento de la lista para editar";
            // 
            // btnRegistrarTipProd
            // 
            this.btnRegistrarTipProd.Location = new System.Drawing.Point(602, 23);
            this.btnRegistrarTipProd.Name = "btnRegistrarTipProd";
            this.btnRegistrarTipProd.Size = new System.Drawing.Size(122, 25);
            this.btnRegistrarTipProd.TabIndex = 4;
            this.btnRegistrarTipProd.Text = "Registrar";
            this.btnRegistrarTipProd.UseVisualStyleBackColor = true;
            // 
            // btnModificarTipProd
            // 
            this.btnModificarTipProd.Location = new System.Drawing.Point(602, 68);
            this.btnModificarTipProd.Name = "btnModificarTipProd";
            this.btnModificarTipProd.Size = new System.Drawing.Size(122, 25);
            this.btnModificarTipProd.TabIndex = 5;
            this.btnModificarTipProd.Text = "Modificar";
            this.btnModificarTipProd.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTipProd
            // 
            this.btnEliminarTipProd.Location = new System.Drawing.Point(602, 115);
            this.btnEliminarTipProd.Name = "btnEliminarTipProd";
            this.btnEliminarTipProd.Size = new System.Drawing.Size(122, 25);
            this.btnEliminarTipProd.TabIndex = 6;
            this.btnEliminarTipProd.Text = "Eliminar";
            this.btnEliminarTipProd.UseVisualStyleBackColor = true;
            // 
            // MantenedorTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 401);
            this.Controls.Add(this.btnEliminarTipProd);
            this.Controls.Add(this.btnModificarTipProd);
            this.Controls.Add(this.btnRegistrarTipProd);
            this.Controls.Add(this.lblInfoProd);
            this.Controls.Add(this.txtDescTipoProd);
            this.Controls.Add(this.lblDescTipoProd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MantenedorTipoProducto";
            this.Text = "MantenedorTipoProducto";
            this.Load += new System.EventHandler(this.MantenedorTipoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDescTipoProd;
        private System.Windows.Forms.TextBox txtDescTipoProd;
        private System.Windows.Forms.Label lblInfoProd;
        private System.Windows.Forms.Button btnRegistrarTipProd;
        private System.Windows.Forms.Button btnModificarTipProd;
        private System.Windows.Forms.Button btnEliminarTipProd;
    }
}