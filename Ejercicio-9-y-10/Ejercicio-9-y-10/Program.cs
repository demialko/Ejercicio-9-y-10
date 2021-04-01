using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9_y_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "";
            do
            {
                Console.WriteLine("Ingrese una frase");
                palabra = Console.ReadLine();
            } while (palabra == "");
            Console.WriteLine("La frase en minuscula es " + palabra.ToLower());
            Console.WriteLine("La frase en mayuscula es " + palabra.ToUpper());
            Console.ReadKey();
        }
    }
}
