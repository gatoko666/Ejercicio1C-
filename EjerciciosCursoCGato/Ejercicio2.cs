using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2) Escribir un método que acepte un número y devuelva True si el número es par, o false si es impar.

namespace EjerciciosCursoCGato
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Escriba un número: ");
            int numero1 = int.Parse(Console.ReadLine());

            if (numero1%2==0)
            {
                Console.WriteLine("El número es par ");

            }
            else 
            {
                Console.WriteLine("El número es impar ");

            }



        }



    }
}
