using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome de usuário:");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite uma senha:");
            string senha = Console.ReadLine();

           while(nomeUsuario == senha){
               Console.WriteLine("Senha e Nome de Usuário iguais, por favor digite novamente");
               
               Console.WriteLine("Nome de usuário:");
               nomeUsuario = Console.ReadLine();

                Console.WriteLine("Senha:");
                senha = Console.ReadLine();
           }

           Console.WriteLine("blz, obrigado flor do dia");
        }
    }
}
