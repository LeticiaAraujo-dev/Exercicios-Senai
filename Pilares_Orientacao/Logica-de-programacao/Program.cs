using System;

namespace Logica_de_programacao
{
    class Program
    {
        static void Main(string[] args)
        {

            int valorUm;
            int valorDois;

            Console.WriteLine("Soma de dois números");
            Console.WriteLine("-----------------------");
            Console.Write("Digite o primeiro valor")
            valorUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor")
            valorDois = int.Parse(Console.ReadLine());

            int soma = valorUm + valorDois;

            Console.WriteLine("Soma de "+valorUm+" + "+valorDois+" = "+soma);
        }
    }
}
