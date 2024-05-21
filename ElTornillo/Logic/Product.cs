using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Product
    {
        // Creacion de variables
        int id, stock;
        string name, description, type, brand;
        double price;

        // Constructor por defecto
        public Product()
        { }

        // Constructor especifico
        public Product(int id, int stock, string name, string description, string type, string brand, double price)
        {
            this.id = id;
            this.stock = stock;
            this.name = name;
            this.description = description;
            this.type = type;
            this.brand = brand;
            this.price = price;
        }

        // Getters y setters
        public int Id { get => id; set => id = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
        public string Brand { get => brand; set => brand = value; }
        public double Price { get => price; set => price = value; }

        // Metodo ToString
        public override string ToString()
        {
            return $"Nombre [{name}], Precio [{price}], Tipo [{type}], Marca [{brand}], Cantidad [{stock}], Descripcion [{description}]";
        }

    }
}