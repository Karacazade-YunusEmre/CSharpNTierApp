namespace NTierAppWindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxSearchByCategory = new System.Windows.Forms.GroupBox();
            this.gbxSearchByProductName = new System.Windows.Forms.GroupBox();
            this.lblSearchByCategory = new System.Windows.Forms.Label();
            this.lblSearchByProductName = new System.Windows.Forms.Label();
            this.tbxSearchByProductName = new System.Windows.Forms.TextBox();
            this.cbxSearchByCategory = new System.Windows.Forms.ComboBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.lblAddStockAmount = new System.Windows.Forms.Label();
            this.lblAddQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.tbxAddStockAmount = new System.Windows.Forms.TextBox();
            this.tbxAddPrice = new System.Windows.Forms.TextBox();
            this.tbxAddQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.cbxAddCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.gbxSearchByCategory.SuspendLayout();
            this.gbxSearchByProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSearchByCategory
            // 
            this.gbxSearchByCategory.Controls.Add(this.cbxSearchByCategory);
            this.gbxSearchByCategory.Controls.Add(this.lblSearchByCategory);
            this.gbxSearchByCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxSearchByCategory.Name = "gbxSearchByCategory";
            this.gbxSearchByCategory.Size = new System.Drawing.Size(645, 78);
            this.gbxSearchByCategory.TabIndex = 0;
            this.gbxSearchByCategory.TabStop = false;
            this.gbxSearchByCategory.Text = "Kategoriye Göre Ara";
            // 
            // gbxSearchByProductName
            // 
            this.gbxSearchByProductName.Controls.Add(this.tbxSearchByProductName);
            this.gbxSearchByProductName.Controls.Add(this.lblSearchByProductName);
            this.gbxSearchByProductName.Location = new System.Drawing.Point(12, 96);
            this.gbxSearchByProductName.Name = "gbxSearchByProductName";
            this.gbxSearchByProductName.Size = new System.Drawing.Size(645, 78);
            this.gbxSearchByProductName.TabIndex = 1;
            this.gbxSearchByProductName.TabStop = false;
            this.gbxSearchByProductName.Text = "Ürün Adına Göre Ara";
            // 
            // lblSearchByCategory
            // 
            this.lblSearchByCategory.AutoSize = true;
            this.lblSearchByCategory.Location = new System.Drawing.Point(6, 34);
            this.lblSearchByCategory.Name = "lblSearchByCategory";
            this.lblSearchByCategory.Size = new System.Drawing.Size(54, 15);
            this.lblSearchByCategory.TabIndex = 0;
            this.lblSearchByCategory.Text = "Kategori:";
            // 
            // lblSearchByProductName
            // 
            this.lblSearchByProductName.AutoSize = true;
            this.lblSearchByProductName.Location = new System.Drawing.Point(6, 35);
            this.lblSearchByProductName.Name = "lblSearchByProductName";
            this.lblSearchByProductName.Size = new System.Drawing.Size(60, 15);
            this.lblSearchByProductName.TabIndex = 1;
            this.lblSearchByProductName.Text = "Ürün Adı: ";
            // 
            // tbxSearchByProductName
            // 
            this.tbxSearchByProductName.Location = new System.Drawing.Point(73, 32);
            this.tbxSearchByProductName.Name = "tbxSearchByProductName";
            this.tbxSearchByProductName.Size = new System.Drawing.Size(278, 23);
            this.tbxSearchByProductName.TabIndex = 1;
            // 
            // cbxSearchByCategory
            // 
            this.cbxSearchByCategory.FormattingEnabled = true;
            this.cbxSearchByCategory.Location = new System.Drawing.Point(73, 31);
            this.cbxSearchByCategory.Name = "cbxSearchByCategory";
            this.cbxSearchByCategory.Size = new System.Drawing.Size(287, 23);
            this.cbxSearchByCategory.TabIndex = 1;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(14, 183);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.Size = new System.Drawing.Size(643, 192);
            this.dgvProduct.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(443, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(214, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.btnAdd);
            this.gbxAddProduct.Controls.Add(this.cbxAddCategory);
            this.gbxAddProduct.Controls.Add(this.tbxAddQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.tbxAddPrice);
            this.gbxAddProduct.Controls.Add(this.tbxAddStockAmount);
            this.gbxAddProduct.Controls.Add(this.tbxAddProductName);
            this.gbxAddProduct.Controls.Add(this.lblAddQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.lblAddStockAmount);
            this.gbxAddProduct.Controls.Add(this.lblAddPrice);
            this.gbxAddProduct.Controls.Add(this.lblAddCategory);
            this.gbxAddProduct.Controls.Add(this.lblAddProductName);
            this.gbxAddProduct.Location = new System.Drawing.Point(672, 14);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(645, 137);
            this.gbxAddProduct.TabIndex = 4;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Yeni Ürün Ekle";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(11, 28);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(54, 15);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Ürün Adı";
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(11, 64);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(51, 15);
            this.lblAddCategory.TabIndex = 1;
            this.lblAddCategory.Text = "Kategori";
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Location = new System.Drawing.Point(11, 100);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(32, 15);
            this.lblAddPrice.TabIndex = 2;
            this.lblAddPrice.Text = "Fiyat";
            // 
            // lblAddStockAmount
            // 
            this.lblAddStockAmount.AutoSize = true;
            this.lblAddStockAmount.Location = new System.Drawing.Point(322, 28);
            this.lblAddStockAmount.Name = "lblAddStockAmount";
            this.lblAddStockAmount.Size = new System.Drawing.Size(64, 15);
            this.lblAddStockAmount.TabIndex = 3;
            this.lblAddStockAmount.Text = "Stok Adedi";
            // 
            // lblAddQuantityPerUnit
            // 
            this.lblAddQuantityPerUnit.AutoSize = true;
            this.lblAddQuantityPerUnit.Location = new System.Drawing.Point(322, 64);
            this.lblAddQuantityPerUnit.Name = "lblAddQuantityPerUnit";
            this.lblAddQuantityPerUnit.Size = new System.Drawing.Size(69, 15);
            this.lblAddQuantityPerUnit.TabIndex = 4;
            this.lblAddQuantityPerUnit.Text = "Birim Adedi";
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(73, 25);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(230, 23);
            this.tbxAddProductName.TabIndex = 5;
            // 
            // tbxAddStockAmount
            // 
            this.tbxAddStockAmount.Location = new System.Drawing.Point(398, 22);
            this.tbxAddStockAmount.Name = "tbxAddStockAmount";
            this.tbxAddStockAmount.Size = new System.Drawing.Size(230, 23);
            this.tbxAddStockAmount.TabIndex = 6;
            // 
            // tbxAddPrice
            // 
            this.tbxAddPrice.Location = new System.Drawing.Point(73, 97);
            this.tbxAddPrice.Name = "tbxAddPrice";
            this.tbxAddPrice.Size = new System.Drawing.Size(230, 23);
            this.tbxAddPrice.TabIndex = 7;
            // 
            // tbxAddQuantityPerUnit
            // 
            this.tbxAddQuantityPerUnit.Location = new System.Drawing.Point(398, 61);
            this.tbxAddQuantityPerUnit.Name = "tbxAddQuantityPerUnit";
            this.tbxAddQuantityPerUnit.Size = new System.Drawing.Size(230, 23);
            this.tbxAddQuantityPerUnit.TabIndex = 8;
            // 
            // cbxAddCategory
            // 
            this.cbxAddCategory.FormattingEnabled = true;
            this.cbxAddCategory.Location = new System.Drawing.Point(73, 61);
            this.cbxAddCategory.Name = "cbxAddCategory";
            this.cbxAddCategory.Size = new System.Drawing.Size(230, 23);
            this.cbxAddCategory.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(398, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(230, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.btnUpdate);
            this.gbxUpdateProduct.Controls.Add(this.cbxUpdateCategory);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdatePrice);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateStockAmount);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdateProduct.Controls.Add(this.label1);
            this.gbxUpdateProduct.Controls.Add(this.label2);
            this.gbxUpdateProduct.Controls.Add(this.label3);
            this.gbxUpdateProduct.Controls.Add(this.label4);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductName);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(672, 183);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(645, 137);
            this.gbxUpdateProduct.TabIndex = 5;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(398, 97);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(230, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Ekle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(73, 61);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(230, 23);
            this.cbxUpdateCategory.TabIndex = 9;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(398, 61);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(230, 23);
            this.tbxUpdateQuantityPerUnit.TabIndex = 8;
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.Location = new System.Drawing.Point(73, 97);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(230, 23);
            this.tbxUpdatePrice.TabIndex = 7;
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(398, 22);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(230, 23);
            this.tbxUpdateStockAmount.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(73, 25);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(230, 23);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(11, 28);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(54, 15);
            this.lblUpdateProductName.TabIndex = 0;
            this.lblUpdateProductName.Text = "Ürün Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 440);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.gbxSearchByProductName);
            this.Controls.Add(this.gbxSearchByCategory);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.gbxSearchByCategory.ResumeLayout(false);
            this.gbxSearchByCategory.PerformLayout();
            this.gbxSearchByProductName.ResumeLayout(false);
            this.gbxSearchByProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxSearchByCategory;
        private ComboBox cbxSearchByCategory;
        private Label lblSearchByCategory;
        private GroupBox gbxSearchByProductName;
        private TextBox tbxSearchByProductName;
        private Label lblSearchByProductName;
        private DataGridView dgvProduct;
        private Button btnDelete;
        private GroupBox gbxAddProduct;
        private ComboBox cbxAddCategory;
        private TextBox tbxAddQuantityPerUnit;
        private TextBox tbxAddPrice;
        private TextBox tbxAddStockAmount;
        private TextBox tbxAddProductName;
        private Label lblAddQuantityPerUnit;
        private Label lblAddStockAmount;
        private Label lblAddPrice;
        private Label lblAddCategory;
        private Label lblAddProductName;
        private Button btnAdd;
        private GroupBox gbxUpdateProduct;
        private Button btnUpdate;
        private ComboBox cbxUpdateCategory;
        private TextBox tbxUpdateQuantityPerUnit;
        private TextBox tbxUpdatePrice;
        private TextBox tbxUpdateStockAmount;
        private TextBox tbxUpdateProductName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblUpdateProductName;
    }
}