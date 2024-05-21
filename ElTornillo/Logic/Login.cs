using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Login
    {
        // Campo privado para almacenar el código
        private string code;

        // Constantes para los diferentes tipos de usuarios
        private const string
            ROOT = "root",
            SUPER = "super",
            SELLER = "seller";

        // Constructor sin parámetros
        public Login() { }

        // Constructor que acepta un código
        public Login(string code)
        {
            this.code = code;
        }

        // Propiedad para acceder y modificar el campo 'code'
        public string Code { get => code; set => code = value; }

        // Método para verificar el código y retornar un valor según el tipo de usuario
        public int Verification(string code)
        {
            int user = -1; // Valor por defecto si el código no coincide con ninguno conocido
            switch (code)
            {
                case ROOT:
                    user = 0; // Código para usuario root
                    break;

                case SUPER:
                    user = 1; // Código para usuario super
                    break;

                case SELLER:
                    user = 3; // Código para usuario seller
                    break;

                default:
                    user = -1; // Código no reconocido
                    break;
            }
            return user; // Retorna el valor correspondiente al tipo de usuario
        }
    }
}