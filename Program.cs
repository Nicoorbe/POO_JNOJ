using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// notas de mi para mi por que pus se me va el avion
namespace SobrecargaMetodos
{
    
    class Calculadora
    {
        // suma 2 
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        // suma 3
        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }

        // suma 4 
        public int Sumar(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    } // cada version hace lo mismo, solo hay mas numeros

    class Program
    {
        static void Main(string[] args)
        {
            // objeto calculadora
            Calculadora calc = new Calculadora();

            Console.WriteLine(" Calculadora");

            // lo que pongas se guarda y suma
            Console.Write("Ingresa el primer número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado2 = calc.Sumar(n1, n2);
            Console.WriteLine("Resultado de sumar 2 números: " + resultado2);

            // aqui tambien pero con 3 num
            Console.Write("\nIngresa el tercer número: ");
            int n3 = int.Parse(Console.ReadLine());

            int resultado3 = calc.Sumar(n1, n2, n3);
            Console.WriteLine("Resultado de sumar 3 números: " + resultado3);

            // lo mismo pero con 4
            Console.Write("\nIngresa el cuarto número: ");
            int n4 = int.Parse(Console.ReadLine());

            int resultado4 = calc.Sumar(n1, n2, n3, n4);
            Console.WriteLine("Resultado de sumar 4 números: " + resultado4);

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
