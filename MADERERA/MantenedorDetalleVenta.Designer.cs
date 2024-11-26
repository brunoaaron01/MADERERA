namespace CAPAPRESENTACION
{
    partial class MantenedorDetalleVenta
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
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.dtgDetalleVenta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNroDocIdeCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarDetalle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(69, 17);
            this.txtIdVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(155, 20);
            this.txtIdVenta.TabIndex = 0;
            // 
            // dtgDetalleVenta
            // 
            this.dtgDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleVenta.Enabled = false;
            this.dtgDetalleVenta.Location = new System.Drawing.Point(8, 159);
            this.dtgDetalleVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgDetalleVenta.Name = "dtgDetalleVenta";
            this.dtgDetalleVenta.RowHeadersVisible = false;
            this.dtgDetalleVenta.RowHeadersWidth = 62;
            this.dtgDetalleVenta.RowTemplate.Height = 28;
            this.dtgDetalleVenta.Size = new System.Drawing.Size(630, 152);
            this.dtgDetalleVenta.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtNroDocIdeCliente);
            this.groupBox1.Location = new System.Drawing.Point(8, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(630, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = " codigo";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(335, 36);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(155, 20);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // txtNroDocIdeCliente
            // 
            this.txtNroDocIdeCliente.Location = new System.Drawing.Point(70, 36);
            this.txtNroDocIdeCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroDocIdeCliente.Name = "txtNroDocIdeCliente";
            this.txtNroDocIdeCliente.Size = new System.Drawing.Size(155, 20);
            this.txtNroDocIdeCliente.TabIndex = 5;
            // 
            // btnBuscarDetalle
            // 
            this.btnBuscarDetalle.Location = new System.Drawing.Point(232, 17);
            this.btnBuscarDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarDetalle.Name = "btnBuscarDetalle";
            this.btnBuscarDetalle.Size = new System.Drawing.Size(75, 22);
            this.btnBuscarDetalle.TabIndex = 3;
            this.btnBuscarDetalle.Text = "BUSCAR";
            this.btnBuscarDetalle.UseVisualStyleBackColor = true;
            this.btnBuscarDetalle.Click += new System.EventHandler(this.btnBuscarDetalle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = " codigo";
            // 
            // MantenedorDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarDetalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgDetalleVenta);
            this.Controls.Add(this.txtIdVenta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenedorDetalleVenta";
            this.Text = "MantenedorDetalleVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.DataGridView dtgDetalleVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNroDocIdeCliente;
        private System.Windows.Forms.Button btnBuscarDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}