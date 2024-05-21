namespace Design
{
    partial class AddNewProduct
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
            this.button_showList = new System.Windows.Forms.Button();
            this.textBox_brand = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_accept = new System.Windows.Forms.Button();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.label_stock = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_addNewProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_showList
            // 
            this.button_showList.Location = new System.Drawing.Point(74, 378);
            this.button_showList.Name = "button_showList";
            this.button_showList.Size = new System.Drawing.Size(75, 23);
            this.button_showList.TabIndex = 31;
            this.button_showList.Text = "Show";
            this.button_showList.UseVisualStyleBackColor = true;
            this.button_showList.Click += new System.EventHandler(this.button_showList_Click);
            // 
            // textBox_brand
            // 
            this.textBox_brand.Location = new System.Drawing.Point(97, 203);
            this.textBox_brand.Name = "textBox_brand";
            this.textBox_brand.Size = new System.Drawing.Size(100, 20);
            this.textBox_brand.TabIndex = 26;
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(97, 158);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(100, 20);
            this.textBox_type.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo";
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(122, 348);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 30;
            this.button_cancel.Text = "Cancelar";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(27, 348);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(75, 23);
            this.button_accept.TabIndex = 29;
            this.button_accept.Text = "Añadir";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(97, 294);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(100, 20);
            this.textBox_description.TabIndex = 28;
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(97, 250);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(100, 20);
            this.textBox_stock.TabIndex = 27;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(97, 119);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 20);
            this.textBox_price.TabIndex = 24;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(97, 74);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 23;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(24, 297);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(63, 13);
            this.label_description.TabIndex = 22;
            this.label_description.Text = "Descripcion";
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Location = new System.Drawing.Point(24, 253);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(49, 13);
            this.label_stock.TabIndex = 21;
            this.label_stock.Text = "Cantidad";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(24, 122);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(37, 13);
            this.label_price.TabIndex = 18;
            this.label_price.Text = "Precio";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(24, 77);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 13);
            this.label_name.TabIndex = 17;
            this.label_name.Text = "Nombre";
            // 
            // label_addNewProduct
            // 
            this.label_addNewProduct.AutoSize = true;
            this.label_addNewProduct.Location = new System.Drawing.Point(52, 30);
            this.label_addNewProduct.Name = "label_addNewProduct";
            this.label_addNewProduct.Size = new System.Drawing.Size(115, 13);
            this.label_addNewProduct.TabIndex = 16;
            this.label_addNewProduct.Text = "Añadir nuevo producto";
            // 
            // AddNewProduct
            // 
            this.AcceptButton = this.button_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(230, 420);
            this.ControlBox = false;
            this.Controls.Add(this.button_showList);
            this.Controls.Add(this.textBox_brand);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_addNewProduct);
            this.Name = "AddNewProduct";
            this.Text = "AddNewProdut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_showList;
        private System.Windows.Forms.TextBox textBox_brand;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_addNewProduct;
    }
}