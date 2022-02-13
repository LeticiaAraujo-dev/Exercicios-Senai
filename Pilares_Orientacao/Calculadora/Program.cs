using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação que deseja fazer \n Soma, Subtração, Mutiplicação e Divisão");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            switch(operacao){
                case "Soma":
                    resultado = num1 + num2;
                    break;
                case "Subtração":
                    resultado = num1 - num2;
                    break;
                case "Divisão":
                    resultado = num1 / num2;
                    break;
                case "Multiplicação":
                    resultado = num1 + num2;
                    break;
                default:
                    Console.WriteLine ("operação invalida");
                    break;
            }
            Console.WriteLine($"Calculo: {num1} e {num2} = resultado: {resultado}");
        }
    }
}
