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

        public List<String> direcciones;
        public Persona(string cedula, string nombre) {
            Cedula = cedula;
            Nombre = nombre;
            direcciones = new List<String>();
        }

        public void AgregarDirección(string direccion)
        {
           direcciones.Add(direccion);
        }

        public void MostrarDirecciones()
        {
            for (int i = 0; i < direcciones.Count; i++)
            {
                Console.WriteLine($"Dirección {i+1}: {direcciones[i]}");
            }
        }
        public void MostrarDatos()
        {
            Console.WriteLine("Datos de la persona: ");
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Cédula: " + this.Cedula);
            MostrarDirecciones();
        }
    }
}
