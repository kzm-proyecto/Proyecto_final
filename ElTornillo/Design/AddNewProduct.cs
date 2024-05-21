using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Design
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        // INICIALIZACION DE VARIABLES
        private static int id = 0;
        Logic.ProductList pList = new ProductList();
        Logic.Product p;

        // AGREGAR PRODUCTO
        private void button_accept_Click(object sender, EventArgs e)
        {
            p = new Product(11, 10, "Producto 1", "Descripción del producto 1", "Tipo 1", "Marca 1", 19.99); // QUITAR
            pList.AddProduct(p);                                                                             // QUITAR
            p = new Product(22, 5, "Producto 2", "Descripción del producto 2", "Tipo 2", "Marca 2", 29.99);  // QUITAR
            pList.AddProduct(p);                                                                             // QUITAR
            p = new Product(33, 8, "Producto 3", "Descripción del producto 3", "Tipo 3", "Marca 3", 14.99);  // QUITAR
            pList.AddProduct(p);                                                                             // QUITAR

            id = id++;
            string name = textBox_name.Text;
            double price = double.Parse(textBox_price.Text);
            string type = textBox_type.Text;
            string brand = textBox_brand.Text;
            int stock = int.Parse(textBox_stock.Text);
            string description = textBox_description.Text;

            p = new Product(id, stock, name, description, type, brand, price);
            pList.AddProduct(p);

            MessageBox.Show($"Producto: \n{p.ToString()}\nAñadido.");

            textBox_name.Text = "";
            textBox_price.Text = "";
            textBox_type.Text = "";
            textBox_brand.Text = "";
            textBox_stock.Text = "";
            textBox_description.Text = "";
        }

        // MOSTRAR
        private void button_showList_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pList.GetProduct().ToString());
        }

        // SALIR
        private void button_cancel_Click(object sender, EventArgs e) // ARREGLAR IF
        {
            if (string.IsNullOrEmpty(textBox_name.Text) | string.IsNullOrEmpty(textBox_price.Text) | string.IsNullOrEmpty(textBox_type.Text) | string.IsNullOrEmpty(textBox_brand.Text) | string.IsNullOrEmpty(textBox_stock.Text) | string.IsNullOrEmpty(textBox_description.Text))
            {
                this.Close();
            }
            else
            {
                textBox_name.Text = "";
                textBox_price.Text = "";
                textBox_type.Text = "";
                textBox_brand.Text = "";
                textBox_stock.Text = "";
                textBox_description.Text = "";
            }
        }
    }
}
