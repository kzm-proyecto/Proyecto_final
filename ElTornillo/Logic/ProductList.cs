using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductList
    {

        private List<Product> productList;

        public ProductList()
        {
            productList = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            productList.Remove(product);
        }

        public List<Product> GetProductList()
        {
            return productList;
        }

        public Product GetProductId(int id)
        {
            return productList.Find(p => p.Id == id);
        }

        public void ModifyProduct(Product product)
        {
            int index = productList.FindIndex(p => p.Id == product.Id);
            if (index >= 0)
            {
                productList[index] = product;
            }
        }

        public StringBuilder GetProduct()
        {
            StringBuilder product = new StringBuilder();
            foreach (Product p in productList)
                product.Append($"[{p.ToString()}]\n");
            return product;
        }

    }
}
