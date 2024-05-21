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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            AddTypeProductToList();
        }

        List<string> products_brand = new List<string>();
        List<string> products_type = new List<string>();

        private void AddTypeProductToList()
        {
            products_type.Add("Destornillador");
            products_type.Add("Taladro");
            products_type.Add("Cable");
            products_type.Add("Tornillo");

            foreach (string product_type in products_type)
                listBox_productType.Items.Add(product_type);
        }

        private void AddBrandProductToList()
        {
            switch (listBox_productType.SelectedIndex)
            {
                case 0:
                    // Limpia la lista con las marcas y añade las correspondientes
                    products_brand.Clear();
                    products_brand.Add("AAA");
                    products_brand.Add("BBB");
                    products_brand.Add("CCC");
                    products_brand.Add("DDD");

                    // Limpia el listBox de marcas
                    listBox_productBrand.Items.Clear();
                    // Añade las marcas de la lista
                    foreach (string product_brand in products_brand)
                        listBox_productBrand.Items.Add(product_brand);
                    break;
                default:
                    products_brand.Clear();
                    break;
            }
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            // FALTA
            // FALTA
            // FALTA
            // FALTA
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox_productType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddBrandProductToList();
        }

        private void button_newProduct_Click(object sender, EventArgs e)
        {
            AddNewProduct aNP = new AddNewProduct();
            aNP.ShowDialog();
        }
    }
}
