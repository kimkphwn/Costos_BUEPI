namespace prjCostosBUEPI.Layers.UI.Mantenimientos
{
    partial class frmMantProductos
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
            this.SplMantProd = new System.Windows.Forms.SplitContainer();
            this.PnlList = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TblPnlAtributos = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.txtCodPrd = new System.Windows.Forms.TextBox();
            this.LblDescPrd = new System.Windows.Forms.Label();
            this.LblCant = new System.Windows.Forms.Label();
            this.LblPrcCot = new System.Windows.Forms.Label();
            this.LblFchCot = new System.Windows.Forms.Label();
            this.LblUntMed = new System.Windows.Forms.Label();
            this.LblPrcCmp = new System.Windows.Forms.Label();
            this.LblFchCmp = new System.Windows.Forms.Label();
            this.txtDescPrd = new System.Windows.Forms.TextBox();
            this.NumUDCant = new System.Windows.Forms.NumericUpDown();
            this.CmbUntMed = new System.Windows.Forms.ComboBox();
            this.TxtPrcCod = new System.Windows.Forms.TextBox();
            this.TxtPrcCmp = new System.Windows.Forms.TextBox();
            this.DTPFchCot = new System.Windows.Forms.DateTimePicker();
            this.DTPFchCmp = new System.Windows.Forms.DateTimePicker();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SplMantProd)).BeginInit();
            this.SplMantProd.Panel1.SuspendLayout();
            this.SplMantProd.Panel2.SuspendLayout();
            this.SplMantProd.SuspendLayout();
            this.PnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TblPnlAtributos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCant)).BeginInit();
            this.SuspendLayout();
            // 
            // SplMantProd
            // 
            this.SplMantProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplMantProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplMantProd.Location = new System.Drawing.Point(0, 0);
            this.SplMantProd.Name = "SplMantProd";
            // 
            // SplMantProd.Panel1
            // 
            this.SplMantProd.Panel1.Controls.Add(this.BtnSalvar);
            this.SplMantProd.Panel1.Controls.Add(this.btnCancelar);
            this.SplMantProd.Panel1.Controls.Add(this.BtnLimpiar);
            this.SplMantProd.Panel1.Controls.Add(this.TblPnlAtributos);
            this.SplMantProd.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // SplMantProd.Panel2
            // 
            this.SplMantProd.Panel2.Controls.Add(this.PnlList);
            this.SplMantProd.Size = new System.Drawing.Size(776, 308);
            this.SplMantProd.SplitterDistance = 420;
            this.SplMantProd.TabIndex = 0;
            this.SplMantProd.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // PnlList
            // 
            this.PnlList.Controls.Add(this.dataGridView1);
            this.PnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlList.Location = new System.Drawing.Point(0, 0);
            this.PnlList.Name = "PnlList";
            this.PnlList.Size = new System.Drawing.Size(348, 304);
            this.PnlList.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.PrecioCompra});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // TblPnlAtributos
            // 
            this.TblPnlAtributos.AutoSize = true;
            this.TblPnlAtributos.ColumnCount = 2;
            this.TblPnlAtributos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlAtributos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlAtributos.Controls.Add(this.DTPFchCmp, 1, 7);
            this.TblPnlAtributos.Controls.Add(this.TxtPrcCod, 1, 4);
            this.TblPnlAtributos.Controls.Add(this.txtDescPrd, 1, 1);
            this.TblPnlAtributos.Controls.Add(this.LblUntMed, 0, 3);
            this.TblPnlAtributos.Controls.Add(this.LblDescPrd, 0, 1);
            this.TblPnlAtributos.Controls.Add(this.lblCodProd, 0, 0);
            this.TblPnlAtributos.Controls.Add(this.txtCodPrd, 1, 0);
            this.TblPnlAtributos.Controls.Add(this.LblCant, 0, 2);
            this.TblPnlAtributos.Controls.Add(this.LblPrcCot, 0, 4);
            this.TblPnlAtributos.Controls.Add(this.LblFchCot, 0, 5);
            this.TblPnlAtributos.Controls.Add(this.LblPrcCmp, 0, 6);
            this.TblPnlAtributos.Controls.Add(this.LblFchCmp, 0, 7);
            this.TblPnlAtributos.Controls.Add(this.NumUDCant, 1, 2);
            this.TblPnlAtributos.Controls.Add(this.CmbUntMed, 1, 3);
            this.TblPnlAtributos.Controls.Add(this.TxtPrcCmp, 1, 6);
            this.TblPnlAtributos.Controls.Add(this.DTPFchCot, 1, 5);
            this.TblPnlAtributos.Location = new System.Drawing.Point(3, 10);
            this.TblPnlAtributos.Name = "TblPnlAtributos";
            this.TblPnlAtributos.RowCount = 8;
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblPnlAtributos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblPnlAtributos.Size = new System.Drawing.Size(410, 246);
            this.TblPnlAtributos.TabIndex = 0;
            // 
            // lblCodProd
            // 
            this.lblCodProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.Location = new System.Drawing.Point(75, 5);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(127, 20);
            this.lblCodProd.TabIndex = 0;
            this.lblCodProd.Text = "Codigo Producto";
            this.lblCodProd.Click += new System.EventHandler(this.lblCodProd_Click);
            // 
            // txtCodPrd
            // 
            this.txtCodPrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodPrd.Location = new System.Drawing.Point(210, 5);
            this.txtCodPrd.Name = "txtCodPrd";
            this.txtCodPrd.ReadOnly = true;
            this.txtCodPrd.Size = new System.Drawing.Size(195, 20);
            this.txtCodPrd.TabIndex = 1;
            this.txtCodPrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblDescPrd
            // 
            this.LblDescPrd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblDescPrd.AutoSize = true;
            this.LblDescPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescPrd.Location = new System.Drawing.Point(69, 35);
            this.LblDescPrd.Name = "LblDescPrd";
            this.LblDescPrd.Size = new System.Drawing.Size(133, 20);
            this.LblDescPrd.TabIndex = 2;
            this.LblDescPrd.Text = "Nombre Producto";
            // 
            // LblCant
            // 
            this.LblCant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCant.AutoSize = true;
            this.LblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCant.Location = new System.Drawing.Point(129, 65);
            this.LblCant.Name = "LblCant";
            this.LblCant.Size = new System.Drawing.Size(73, 20);
            this.LblCant.TabIndex = 3;
            this.LblCant.Text = "Cantidad";
            // 
            // LblPrcCot
            // 
            this.LblPrcCot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPrcCot.AutoSize = true;
            this.LblPrcCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrcCot.Location = new System.Drawing.Point(82, 125);
            this.LblPrcCot.Name = "LblPrcCot";
            this.LblPrcCot.Size = new System.Drawing.Size(120, 20);
            this.LblPrcCot.TabIndex = 4;
            this.LblPrcCot.Text = "Precio Cotizado";
            // 
            // LblFchCot
            // 
            this.LblFchCot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblFchCot.AutoSize = true;
            this.LblFchCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFchCot.Location = new System.Drawing.Point(70, 155);
            this.LblFchCot.Name = "LblFchCot";
            this.LblFchCot.Size = new System.Drawing.Size(132, 20);
            this.LblFchCot.TabIndex = 5;
            this.LblFchCot.Text = "Fecha Cotizacion";
            // 
            // LblUntMed
            // 
            this.LblUntMed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblUntMed.AutoSize = true;
            this.LblUntMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUntMed.Location = new System.Drawing.Point(64, 95);
            this.LblUntMed.Name = "LblUntMed";
            this.LblUntMed.Size = new System.Drawing.Size(138, 20);
            this.LblUntMed.TabIndex = 6;
            this.LblUntMed.Text = "Unidad de Medida";
            // 
            // LblPrcCmp
            // 
            this.LblPrcCmp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPrcCmp.AutoSize = true;
            this.LblPrcCmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrcCmp.Location = new System.Drawing.Point(89, 185);
            this.LblPrcCmp.Name = "LblPrcCmp";
            this.LblPrcCmp.Size = new System.Drawing.Size(113, 20);
            this.LblPrcCmp.TabIndex = 7;
            this.LblPrcCmp.Text = "Precio Compra";
            // 
            // LblFchCmp
            // 
            this.LblFchCmp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblFchCmp.AutoSize = true;
            this.LblFchCmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFchCmp.Location = new System.Drawing.Point(88, 218);
            this.LblFchCmp.Name = "LblFchCmp";
            this.LblFchCmp.Size = new System.Drawing.Size(114, 20);
            this.LblFchCmp.TabIndex = 8;
            this.LblFchCmp.Text = "Fecha Compra";
            // 
            // txtDescPrd
            // 
            this.txtDescPrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescPrd.Location = new System.Drawing.Point(208, 35);
            this.txtDescPrd.Name = "txtDescPrd";
            this.txtDescPrd.Size = new System.Drawing.Size(198, 20);
            this.txtDescPrd.TabIndex = 1;
            this.txtDescPrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumUDCant
            // 
            this.NumUDCant.Location = new System.Drawing.Point(208, 63);
            this.NumUDCant.Name = "NumUDCant";
            this.NumUDCant.Size = new System.Drawing.Size(199, 20);
            this.NumUDCant.TabIndex = 9;
            // 
            // CmbUntMed
            // 
            this.CmbUntMed.FormattingEnabled = true;
            this.CmbUntMed.Location = new System.Drawing.Point(208, 93);
            this.CmbUntMed.Name = "CmbUntMed";
            this.CmbUntMed.Size = new System.Drawing.Size(197, 21);
            this.CmbUntMed.TabIndex = 10;
            // 
            // TxtPrcCod
            // 
            this.TxtPrcCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPrcCod.Location = new System.Drawing.Point(209, 125);
            this.TxtPrcCod.Name = "TxtPrcCod";
            this.TxtPrcCod.Size = new System.Drawing.Size(196, 20);
            this.TxtPrcCod.TabIndex = 11;
            this.TxtPrcCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPrcCmp
            // 
            this.TxtPrcCmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPrcCmp.Location = new System.Drawing.Point(209, 185);
            this.TxtPrcCmp.Name = "TxtPrcCmp";
            this.TxtPrcCmp.Size = new System.Drawing.Size(197, 20);
            this.TxtPrcCmp.TabIndex = 12;
            this.TxtPrcCmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPrcCmp.TextChanged += new System.EventHandler(this.TxtPrcCmp_TextChanged);
            // 
            // DTPFchCot
            // 
            this.DTPFchCot.Location = new System.Drawing.Point(208, 153);
            this.DTPFchCot.Name = "DTPFchCot";
            this.DTPFchCot.Size = new System.Drawing.Size(197, 20);
            this.DTPFchCot.TabIndex = 13;
            // 
            // DTPFchCmp
            // 
            this.DTPFchCmp.Location = new System.Drawing.Point(208, 213);
            this.DTPFchCmp.Name = "DTPFchCmp";
            this.DTPFchCmp.Size = new System.Drawing.Size(197, 20);
            this.DTPFchCmp.TabIndex = 14;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(300, 262);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(113, 32);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(181, 262);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 32);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(62, 262);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(113, 32);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // frmMantProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 308);
            this.Controls.Add(this.SplMantProd);
            this.Name = "frmMantProductos";
            this.Text = "Mantenimiento de Productos";
            this.SplMantProd.Panel1.ResumeLayout(false);
            this.SplMantProd.Panel1.PerformLayout();
            this.SplMantProd.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplMantProd)).EndInit();
            this.SplMantProd.ResumeLayout(false);
            this.PnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TblPnlAtributos.ResumeLayout(false);
            this.TblPnlAtributos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplMantProd;
        private System.Windows.Forms.TableLayoutPanel TblPnlAtributos;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Panel PnlList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblUntMed;
        private System.Windows.Forms.Label LblDescPrd;
        private System.Windows.Forms.TextBox txtCodPrd;
        private System.Windows.Forms.Label LblCant;
        private System.Windows.Forms.Label LblPrcCot;
        private System.Windows.Forms.Label LblFchCot;
        private System.Windows.Forms.Label LblPrcCmp;
        private System.Windows.Forms.Label LblFchCmp;
        private System.Windows.Forms.TextBox txtDescPrd;
        private System.Windows.Forms.DateTimePicker DTPFchCmp;
        private System.Windows.Forms.TextBox TxtPrcCod;
        private System.Windows.Forms.NumericUpDown NumUDCant;
        private System.Windows.Forms.ComboBox CmbUntMed;
        private System.Windows.Forms.TextBox TxtPrcCmp;
        private System.Windows.Forms.DateTimePicker DTPFchCot;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
    }
}