namespace Design
{
    partial class Login
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
            this.button_accept = new System.Windows.Forms.Button();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(44, 159);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(79, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancelar";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(44, 119);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(79, 23);
            this.button_accept.TabIndex = 8;
            this.button_accept.Text = "Entrar";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(66, 76);
            this.textBox_user.MaxLength = 8;
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(100, 20);
            this.textBox_user.TabIndex = 7;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(17, 79);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(43, 13);
            this.label_user.TabIndex = 6;
            this.label_user.Text = "Usuario";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Location = new System.Drawing.Point(49, 22);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(65, 13);
            this.label_welcome.TabIndex = 5;
            this.label_welcome.Text = "Bienvenid@";
            // 
            // Login
            // 
            this.AcceptButton = this.button_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(178, 206);
            this.ControlBox = false;
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_welcome);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_welcome;
    }
}