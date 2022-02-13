using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.name = "Tsukamoto";
            objetoPersonagem1.idade = 32;
            objetoPersonagem1.armadura = "Voadora";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.name = "Paulo";
            objetoPersonagem2.idade = 28;
            objetoPersonagem2.armadura = "Flash";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.name} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.name} - {objetoPersonagem2.Defender()}");
        }
    }
}
