using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
//using System.Threading.Tasks;

namespace finalNivelamento
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite um numero e aperte enter, retita tres vezes!");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            while (n1 >= 0.0 && n2 >= 0.0 && n3 >= 0.0)
            { 
                double resultado = Maior(n1, n2, n3);
                Console.WriteLine("O maior numero digitado foi: " + resultado);
                Console.WriteLine("Repita o processo mais uma vez!");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                n3 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Voce digitou numeros menores que zero!");
        }
        static int Maior(int a, int c, int b)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
