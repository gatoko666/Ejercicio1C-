using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Permitir al usuario escribir dos números y mostrar en pantalla cuál de los dos es el más grande.Si son iguales, mostrar cualquiera.


namespace EjerciciosCursoCGato
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Escriba un número: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba otro  número: ");
                    int numero2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("El número más grande es :");

                    if (numero1 > numero2)
                    {
                        Console.WriteLine(numero1);
                    }
                    else
                    {
                        Console.WriteLine(numero2);
                    }

                    break;

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Escibre un número XD ");
                }
            }

            Console.Read();

        }
    }
}
