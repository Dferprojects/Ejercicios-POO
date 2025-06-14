using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PabRam_YT
{
    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        
        public Persona(string cedula, string nombre, string direccion) {
            Cedula = cedula;
            Nombre = nombre;
            Direccion = direccion;
        }
        public void MostrarDatos()
        {
            Console.WriteLine("Datos de la persona: ");
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Cédula: " + this.Cedula);
            Console.WriteLine("Dirección: " + this.Direccion);
        }
    }
}
