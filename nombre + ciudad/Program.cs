using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombre___ciudad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Escribe una ciudad ");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Hola Tu nombre es " + nombre + " Bienvenido a " + ciudad);

            Console.ReadLine();


        }
    }
}
