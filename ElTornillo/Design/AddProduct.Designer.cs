namespace Design
{
    partial class AddProduct
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
            this.button_newProduct = new System.Windows.Forms.Button();
            this.label_brand = new System.Windows.Forms.Label();
            this.listBox_productBrand = new System.Windows.Forms.ListBox();
            this.label_type = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_accept = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox_productType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_newProduct
            // 
            this.button_newProduct.Location = new System.Drawing.Point(12, 524);
            this.button_newProduct.Name = "button_newProduct";
            this.button_newProduct.Size = new System.Drawing.Size(104, 23);
            this.button_newProduct.TabIndex = 17;
            this.button_newProduct.Text = "Nuevo Producto";
            this.button_newProduct.UseVisualStyleBackColor = true;
            this.button_newProduct.Click += new System.EventHandler(this.button_newProduct_Click);
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Location = new System.Drawing.Point(412, 58);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(40, 13);
            this.label_brand.TabIndex = 16;
            this.label_brand.Text = "Marca:";
            // 
            // listBox_productBrand
            // 
            this.listBox_productBrand.FormattingEnabled = true;
            this.listBox_productBrand.Location = new System.Drawing.Point(297, 83);
            this.listBox_productBrand.Name = "listBox_productBrand";
            this.listBox_productBrand.Size = new System.Drawing.Size(279, 329);
            this.listBox_productBrand.TabIndex = 15;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(118, 58);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(31, 13);
            this.label_type.TabIndex = 14;
            this.label_type.Text = "Tipo:";
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(12, 484);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(564, 23);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "Cancelar";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(12, 455);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(564, 23);
            this.button_accept.TabIndex = 12;
            this.button_accept.Text = "Agregar";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 429);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(564, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // listBox_productType
            // 
            this.listBox_productType.FormattingEnabled = true;
            this.listBox_productType.Location = new System.Drawing.Point(12, 83);
            this.listBox_productType.Name = "listBox_productType";
            this.listBox_productType.Size = new System.Drawing.Size(279, 329);
            this.listBox_productType.TabIndex = 10;
            this.listBox_productType.SelectedIndexChanged += new System.EventHandler(this.listBox_productType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Añadir Producto";
            // 
            // AddProduct
            // 
            this.AcceptButton = this.button_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(589, 558);
            this.Controls.Add(this.button_newProduct);
            this.Controls.Add(this.label_brand);
            this.Controls.Add(this.listBox_productBrand);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox_productType);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_newProduct;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.ListBox listBox_productBrand;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox_productType;
        private System.Windows.Forms.Label label1;
    }
}