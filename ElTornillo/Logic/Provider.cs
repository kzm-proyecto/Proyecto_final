using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Provider
    {
        // Creacion de variables
        int id;
        string name, email, phone, address;

        // Constructor por defecto
        public Provider()
        { }

        // Constructor especifico
        public Provider(int id, string name, string email, string phone, string address)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

        // Getters y setters
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }

        public override string ToString()
        {
            return $"Nombre [{name}], Email [{email}], Telefono [{phone}], Direccion [{address}]";
        }
    }
}