using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agencia_Turismo.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public string rcontrasena { get; set; }
        public string celular { get; set; }

        public Usuario()
        {

        }

        public Usuario(int id, string Nombre, string Apellido, string Email, string Contrasena, 
            string Rcontrasena, string Celular)
        {
            idUsuario = id;
            nombre = Nombre;
            apellido = Apellido;
            email = Email;
            contrasena = Contrasena;
            rcontrasena = Rcontrasena;
            celular = Celular;
        }

        public Usuario(string Nombre, string Apellido, string Email, string Contrasena,
            string Rcontrasena, string Celular)
        {
            nombre = Nombre;
            apellido = Apellido;
            email = Email;
            contrasena = Contrasena;
            rcontrasena = Rcontrasena;
            celular = Celular;
        }

    }
}