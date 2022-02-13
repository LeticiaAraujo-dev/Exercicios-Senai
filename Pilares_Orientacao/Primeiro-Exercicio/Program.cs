using System;

namespace Primeiro_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
        // entrada de dados
            Console.WriteLine("Qual é a sua idade");
            int idade = int.Parse(Console.ReadLine());
        // processamento
            int idademes = idade * 12;
            int idadedia = idade * 365;
            int idadehora = idade * 8760;

        //exibir 
            Console.WriteLine("Sua idade em mês é "+idademes+" Sua idade em dias é "+idadedia+ " e Sua idade em horas é "+idadehora);
        }
    }
}
