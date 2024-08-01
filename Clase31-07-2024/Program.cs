using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase31_07_2024
{
    internal class Program
    {
        //crear una clases llamada matematica (suma resta y multi)
        static void Main(string[] args)
        {

            Console.Write("Ingrese un número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro número: ");
            int b = int.Parse(Console.ReadLine());

            matematicas mate = new matematicas();


            int suma = mate.Sumar(a,b);
            int resta = mate.Restar(a, b);
            int multi = mate.Multiplicar(a, b);

            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"La resta es: {resta}");
            Console.WriteLine($"El producto es: {multi}");

            Console.ReadKey();

        }
    }
}
