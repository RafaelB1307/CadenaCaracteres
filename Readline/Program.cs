using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;

            //Preguntamos el nombre del usuario
            Console.WriteLine("¿Como te llamas?: ");
            nombre = Console.ReadLine(); //Aqui se guarda la respuesta en la variable

            Console.WriteLine("Hola " + nombre + " ¿Quieres ver el menu? ");
            Console.ReadKey();

        }
    }
}
