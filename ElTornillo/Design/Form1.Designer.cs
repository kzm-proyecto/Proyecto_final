namespace Design
{
    partial class Form1
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_modifySupplier = new System.Windows.Forms.Button();
            this.button_removeSupplier = new System.Windows.Forms.Button();
            this.button_addSupplier = new System.Windows.Forms.Button();
            this.button_modifyProduct = new System.Windows.Forms.Button();
            this.button_removeProduct = new System.Windows.Forms.Button();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(23, 257);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "Salir";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_modifySupplier
            // 
            this.button_modifySupplier.Location = new System.Drawing.Point(23, 199);
            this.button_modifySupplier.Name = "button_modifySupplier";
            this.button_modifySupplier.Size = new System.Drawing.Size(75, 23);
            this.button_modifySupplier.TabIndex = 12;
            this.button_modifySupplier.Text = "Mod Prov";
            this.button_modifySupplier.UseVisualStyleBackColor = true;
            // 
            // button_removeSupplier
            // 
            this.button_removeSupplier.Location = new System.Drawing.Point(23, 170);
            this.button_removeSupplier.Name = "button_removeSupplier";
            this.button_removeSupplier.Size = new System.Drawing.Size(75, 23);
            this.button_removeSupplier.TabIndex = 11;
            this.button_removeSupplier.Text = "Rem Prov";
            this.button_removeSupplier.UseVisualStyleBackColor = true;
            // 
            // button_addSupplier
            // 
            this.button_addSupplier.Location = new System.Drawing.Point(23, 141);
            this.button_addSupplier.Name = "button_addSupplier";
            this.button_addSupplier.Size = new System.Drawing.Size(75, 23);
            this.button_addSupplier.TabIndex = 10;
            this.button_addSupplier.Text = "Add Prov";
            this.button_addSupplier.UseVisualStyleBackColor = true;
            // 
            // button_modifyProduct
            // 
            this.button_modifyProduct.Location = new System.Drawing.Point(23, 70);
            this.button_modifyProduct.Name = "button_modifyProduct";
            this.button_modifyProduct.Size = new System.Drawing.Size(75, 23);
            this.button_modifyProduct.TabIndex = 9;
            this.button_modifyProduct.Text = "Mod Prod";
            this.button_modifyProduct.UseVisualStyleBackColor = true;
            // 
            // button_removeProduct
            // 
            this.button_removeProduct.Location = new System.Drawing.Point(23, 41);
            this.button_removeProduct.Name = "button_removeProduct";
            this.button_removeProduct.Size = new System.Drawing.Size(75, 23);
            this.button_removeProduct.TabIndex = 8;
            this.button_removeProduct.Text = "Rem Prod";
            this.button_removeProduct.UseVisualStyleBackColor = true;
            // 
            // button_addProduct
            // 
            this.button_addProduct.Location = new System.Drawing.Point(23, 12);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(75, 23);
            this.button_addProduct.TabIndex = 7;
            this.button_addProduct.Text = "Add Prod";
            this.button_addProduct.UseVisualStyleBackColor = true;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(120, 298);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_modifySupplier);
            this.Controls.Add(this.button_removeSupplier);
            this.Controls.Add(this.button_addSupplier);
            this.Controls.Add(this.button_modifyProduct);
            this.Controls.Add(this.button_removeProduct);
            this.Controls.Add(this.button_addProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_modifySupplier;
        private System.Windows.Forms.Button button_removeSupplier;
        private System.Windows.Forms.Button button_addSupplier;
        private System.Windows.Forms.Button button_modifyProduct;
        private System.Windows.Forms.Button button_removeProduct;
        private System.Windows.Forms.Button button_addProduct;
    }
}

