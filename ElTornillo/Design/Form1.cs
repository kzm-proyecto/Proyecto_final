using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AddProduct aP = new AddProduct();
        
        private void button_addProduct_Click(object sender, EventArgs e)
        {
            aP.Show();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
