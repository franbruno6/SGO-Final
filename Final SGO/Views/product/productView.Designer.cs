namespace Final_SGO.Views
{
    partial class productView
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
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.lblProductHeader = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Location = new System.Drawing.Point(18, 152);
            this.dataGridProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.ReadOnly = true;
            this.dataGridProducts.RowHeadersWidth = 62;
            this.dataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducts.Size = new System.Drawing.Size(870, 455);
            this.dataGridProducts.TabIndex = 1;
            // 
            // lblProductHeader
            // 
            this.lblProductHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductHeader.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblProductHeader.Location = new System.Drawing.Point(0, 0);
            this.lblProductHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductHeader.Name = "lblProductHeader";
            this.lblProductHeader.Size = new System.Drawing.Size(906, 92);
            this.lblProductHeader.TabIndex = 2;
            this.lblProductHeader.Text = "Productos";
            this.lblProductHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.Location = new System.Drawing.Point(18, 97);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 35);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Agregar Producto";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // productView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 626);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblProductHeader);
            this.Controls.Add(this.dataGridProducts);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "productView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.Label lblProductHeader;
        private System.Windows.Forms.Button btnAddProduct;
    }
}