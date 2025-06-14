using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POO_PabRam_YT
{
    /* Crear un programa que permita almacenar la siguiente información de Persona
     * Modele una clase para ella: Cédula, Nombre y Dirección
     * Nota: cada Dirección es una cadena de caracteres de la forma: Provincia, Cantón, Distrito
     */
    public class Program
    {
        
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        public static void Menu()
        {
            Console.WriteLine("Bienvenido al sistema!");
            Console.WriteLine("A continuación ingrese los datos requeridos...");
            Console.WriteLine("--- --- --- --- ---");
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su cédula:");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese una dirección: ");
            string direccion = Console.ReadLine();
            
            Persona p1 = new Persona(cedula, nombre, direccion);
            Console.WriteLine("------- ------- -------");
            p1.MostrarDatos();
        }


    }
}
