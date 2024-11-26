namespace CAPAPRESENTACION
{
    partial class CompraBuscarProveedor
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
            this.txtNroDocProv = new System.Windows.Forms.TextBox();
            this.dtgListProveedor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNroDocProv
            // 
            this.txtNroDocProv.Location = new System.Drawing.Point(174, 62);
            this.txtNroDocProv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroDocProv.Name = "txtNroDocProv";
            this.txtNroDocProv.Size = new System.Drawing.Size(102, 20);
            this.txtNroDocProv.TabIndex = 7;
            // 
            // dtgListProveedor
            // 
            this.dtgListProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListProveedor.Location = new System.Drawing.Point(49, 110);
            this.dtgListProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.dtgListProveedor.Name = "dtgListProveedor";
            this.dtgListProveedor.RowHeadersWidth = 62;
            this.dtgListProveedor.RowTemplate.Height = 28;
            this.dtgListProveedor.Size = new System.Drawing.Size(508, 208);
            this.dtgListProveedor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione al proveedor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUSCAR POR RUC :";
            // 
            // CompraBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNroDocProv);
            this.Controls.Add(this.dtgListProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompraBuscarProveedor";
            this.Text = "CompraBuscarProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroDocProv;
        public System.Windows.Forms.DataGridView dtgListProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}