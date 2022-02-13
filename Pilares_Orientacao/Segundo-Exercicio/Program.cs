using System;

namespace Segundo_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados
            Console.WriteLine("Digite seu ano de nascimento");
            int anoN = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual");
            int anoA = int.Parse(Console.ReadLine());

            //processo
            int idade = anoA - anoN;
            int idadeS = idade * 52;

            //exibição
            Console.WriteLine("Vc tem "+idade+ " anos ou "+idadeS+ " semanas");

        }
    }
}
