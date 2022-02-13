using System;

namespace Exs_1_10_notas_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            for(var i = 0; i < 3; i++){
                Console.WriteLine($"Digite o {i+1}º nome:");
                nomes [i] = Console.ReadLine();
                Console.WriteLine("Digite a 1º nota:");
                notas [i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a 2º nota:");
                notas [i+1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a 3º nota:");
                notas [i+2] = int.Parse(Console.ReadLine());
            }
        }
    }
}
