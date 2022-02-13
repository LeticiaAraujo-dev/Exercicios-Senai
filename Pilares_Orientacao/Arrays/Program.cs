using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");

            string[] nomes = new string[3];
            int[] idades = new int[3];

            for (var contador = 0; contador < 3; contador++)
            {
                Console.WriteLine($"Digite o {contador+1}º nome");
                nomes [contador] = Console.ReadLine();
                Console.WriteLine("Digite a idade");
                idades[contador] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Nomes cadastrados");

            for (var contador = 0; contador < 3; contador++)
            {
                Console.WriteLine("Nome: "+nomes[contador]);
                Console.WriteLine("Nome: "+idades[contador]);
            }
        }
    }
}
