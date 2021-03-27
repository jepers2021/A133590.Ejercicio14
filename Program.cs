using System;

namespace A133590.Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 14");
            Console.WriteLine("Dadas dos frases, determina si son iguales. (NO es sensible a mayúsculas y minúsculas)");
            Console.Write("Ingrese una frase: ");
            string unaFrase = Console.ReadLine();
            Console.Write("Ingrese otra frase: ");
            string otraFrase = Console.ReadLine();

            if (unaFrase.Equals(otraFrase, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Las frases son iguales.");
            }
            else
            {
                Console.WriteLine("Las frases no son iguales.");
            }


            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
