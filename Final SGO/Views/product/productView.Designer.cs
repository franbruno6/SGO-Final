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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblProductHeader = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(580, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblProductHeader
            // 
            this.lblProductHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductHeader.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblProductHeader.Location = new System.Drawing.Point(0, 0);
            this.lblProductHeader.Name = "lblProductHeader";
            this.lblProductHeader.Size = new System.Drawing.Size(604, 60);
            this.lblProductHeader.TabIndex = 2;
            this.lblProductHeader.Text = "Productos";
            this.lblProductHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 63);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 23);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Agregar Producto";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(492, 70);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // productView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 407);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblProductHeader);
            this.Controls.Add(this.dataGridView1);
            this.Name = "productView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblProductHeader;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRefresh;
    }
}