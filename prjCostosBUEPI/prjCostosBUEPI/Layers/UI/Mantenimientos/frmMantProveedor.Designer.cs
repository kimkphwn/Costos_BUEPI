namespace prjCostosBUEPI.Layers.UI.Mantenimientos
{
    partial class frmMantProveedor
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
            this.SplMantProv = new System.Windows.Forms.SplitContainer();
            this.TblPnlAtributos = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescPrd = new System.Windows.Forms.TextBox();
            this.LblDescPrd = new System.Windows.Forms.Label();
            this.lblCodProv = new System.Windows.Forms.Label();
            this.txtCodPrd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplMantProv)).BeginInit();
            this.SplMantProv.Panel1.SuspendLayout();
            this.SplMantProv.Panel2.SuspendLayout();
            this.SplMantProv.SuspendLayout();
            this.TblPnlAtributos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplMantProv
            // 
            this.SplMantProv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplMantProv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplMantProv.Location = new System.Drawing.Point(0, 0);
            this.SplMantProv.Name = "SplMantProv";
            // 
            // SplMantProv.Panel1
            // 
            this.SplMantProv.Panel1.Controls.Add(this.BtnSalvar);
            this.SplMantProv.Panel1.Controls.Add(this.btnCancelar);
            this.SplMantProv.Panel1.Controls.Add(this.BtnLimpiar);
            this.SplMantProv.Panel1.Controls.Add(this.TblPnlAtributos);
            // 
            // SplMantProv.Panel2
            // 
            this.SplMantProv.Panel2.Controls.Add(this.dataGridView1);
            this.SplMantProv.Size = new System.Drawing.Size(776, 308);
            this.SplMantProv.SplitterDistance = 415;
            this.SplMantProv.TabIndex = 0;
            // 
            // TblPnlAtributos
            // 
            this.TblPnlAtributos.AutoSize = true;
            this.TblPnlAtributos.ColumnCount = 2;
            this.TblPnlAtributos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlAtributos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlAtributos.Controls.Add(this.txtDescPrd, 1, 1);
            this.TblPnlAtributos.Controls.Add(this.LblDescPrd, 0, 1);
            this.TblPnlAtributos.Controls.Add(this.lblCodProv, 0, 0);
            this.TblPnlAtributos.Controls.Add(this.txtCodPrd, 1, 0);
            this.TblPnlAtributos.Location = new System.Drawing.Point(3, 3);
            this.TblPnlAtributos.Name = "TblPnlAtributos";
            this.TblPnlAtributos.RowCount = 2;
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblPnlAtributos.Size = new System.Drawing.Size(410, 75);
            this.TblPnlAtributos.TabIndex = 1;
            // 
            // txtDescPrd
            // 
            this.txtDescPrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescPrd.Location = new System.Drawing.Point(208, 46);
            this.txtDescPrd.Name = "txtDescPrd";
            this.txtDescPrd.Size = new System.Drawing.Size(198, 20);
            this.txtDescPrd.TabIndex = 1;
            this.txtDescPrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblDescPrd
            // 
            this.LblDescPrd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblDescPrd.AutoSize = true;
            this.LblDescPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescPrd.Location = new System.Drawing.Point(61, 46);
            this.LblDescPrd.Name = "LblDescPrd";
            this.LblDescPrd.Size = new System.Drawing.Size(141, 20);
            this.LblDescPrd.TabIndex = 2;
            this.LblDescPrd.Text = "Nombre Proveedor";
            // 
            // lblCodProv
            // 
            this.lblCodProv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodProv.AutoSize = true;
            this.lblCodProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProv.Location = new System.Drawing.Point(67, 8);
            this.lblCodProv.Name = "lblCodProv";
            this.lblCodProv.Size = new System.Drawing.Size(135, 20);
            this.lblCodProv.TabIndex = 0;
            this.lblCodProv.Text = "Codigo Proveedor";
            // 
            // txtCodPrd
            // 
            this.txtCodPrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodPrd.Location = new System.Drawing.Point(210, 8);
            this.txtCodPrd.Name = "txtCodPrd";
            this.txtCodPrd.ReadOnly = true;
            this.txtCodPrd.Size = new System.Drawing.Size(195, 20);
            this.txtCodPrd.TabIndex = 1;
            this.txtCodPrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Proveedor});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 300;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(30, 262);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(113, 32);
            this.BtnSalvar.TabIndex = 6;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(149, 262);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(268, 262);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(113, 32);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmMantProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 308);
            this.Controls.Add(this.SplMantProv);
            this.Name = "frmMantProveedor";
            this.Text = "frmMantProveedor";
            this.SplMantProv.Panel1.ResumeLayout(false);
            this.SplMantProv.Panel1.PerformLayout();
            this.SplMantProv.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplMantProv)).EndInit();
            this.SplMantProv.ResumeLayout(false);
            this.TblPnlAtributos.ResumeLayout(false);
            this.TblPnlAtributos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplMantProv;
        private System.Windows.Forms.TableLayoutPanel TblPnlAtributos;
        private System.Windows.Forms.TextBox txtDescPrd;
        private System.Windows.Forms.Label LblDescPrd;
        private System.Windows.Forms.Label lblCodProv;
        private System.Windows.Forms.TextBox txtCodPrd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}