using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agencia_Turismo.Models
{
    public class Agencia
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public string email { get; set; }
        public string celular { get; set; }

        public Agencia() { }
        
        public Agencia(int id, string Nombre, string Apellido,
            string Cedula, string Email, string Celular)
        {
            idCliente = id;
            nombre = Nombre;
            apellido = Apellido;
            cedula = Cedula;
            email = Email;
            celular = Celular;
        }

        public Agencia(string Nombre, string Apellido,
            string Cedula, string Email, string Celular)
        {
            nombre = Nombre;
            apellido = Apellido;
            cedula = Cedula;
            email = Email;
            celular = Celular;
        }
    }
}