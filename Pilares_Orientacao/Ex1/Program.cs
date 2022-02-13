using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor dá sua nota:");
            int nota = int.Parse(Console.ReadLine());

            while(nota > 10){
                Console.WriteLine("Nota invalida, por favor digite novamente:");
                nota = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota valida, Obrigado!");
        }
    }
}
