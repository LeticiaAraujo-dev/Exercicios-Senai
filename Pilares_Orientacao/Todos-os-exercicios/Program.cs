using System;

namespace Todos_os_exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Primeiro Exercicio
            // Console.WriteLine("Digite seu ano nascimento:"); //exibe no console
            // int anoN = int.Parse(Console.ReadLine()); //entrada de informação
            // Console.WriteLine("Digite a data atual:");
            // int anoA = int.Parse(Console.ReadLine());

            // int idade = anoA - anoN;
            // if(idade >= 16){
            //     Console.WriteLine($"Você tem {idade} anos e pode votar");
            // }else{
            //     Console.WriteLine($"Você tem {idade} anos e NÃO pode votar");
            // }











            // // Segundo Exercicio
            // Console.WriteLine("Digite o tipo de combustível");
            // Console.WriteLine("Álcool - A");
            // Console.WriteLine("Gasolina - G");
            // string tipoC = Console.ReadLine();
            // Console.WriteLine("Digite a quantidade de compustivel em litro que deseja comprar");
            // float litros = float.Parse(Console.ReadLine());
            // switch(tipoC)
            //     {
            //         case "A": 
            //             if(litros <= 20){
            //                 float desconto = 0.03f;
            //                 float preco = 4.9f;
            //                 Console.WriteLine($"O valor a ser pago é {AplicaDesconto(litros, preco, desconto)} Reais");

            //             }else{
            //                 float desconto = 0.05f;
            //                 float preco = 4.9f;
            //                 Console.WriteLine($"O valor a ser pago é {AplicaDesconto(litros, preco, desconto)} Reais");
            //             }
            //         break;
            //         case "G":
            //             if(litros <= 20){
            //                 float desconto = 0.04f;
            //                 float preco = 5.30f;
            //                 Console.WriteLine($"O valor a ser pago é {AplicaDesconto(litros, preco, desconto)} Reais");

            //             }else{
            //                 float desconto = 0.06f;
            //                 float preco = 5.30f;
            //                 Console.WriteLine($"O valor a ser pago é {AplicaDesconto(litros, preco, desconto)} Reais");
            //             }
            //         break;
            //     }
            
            // float AplicaDesconto(float litros, float preco, float desconto){
            //     float valorTotal = litros * preco;
            //     float valorDes = (valorTotal * desconto);
            //     float precoFinal = valorTotal - valorDes;
            //     return precoFinal;
            // }















            // //Terceiro Exercicio
            // Console.WriteLine("Digite o nome do seu produto:");
            // string nome = Console.ReadLine();
            // Console.WriteLine("Digite a quantidade:");
            // int quant = int.Parse(Console.ReadLine());
            // Console.WriteLine("Digite o preço do produto:");
            // float preco = float.Parse(Console.ReadLine());

            // if(quant <= 5){
            //     float total = quant*preco;
            //     float desconto = total * 0.02f; 
            //     float totalP = total - desconto;
            //     Console.WriteLine($"O valor a ser pago é {totalP} reais no(s) produto(s) {nome}");
            // } else if(quant > 5 && quant <= 10){
            //     float total = quant*preco;
            //     float desconto = total * 0.03f; 
            //     float totalP = total - desconto;
            //     Console.WriteLine($"O valor a ser pago é {totalP} reais no(s) produto(s) {nome}");

            // } else{
            //     float total = quant*preco;
            //     float desconto = total * 0.05f; 
            //     float totalP = total - desconto;
            //     Console.WriteLine($"O valor a ser pago é {totalP} reais no(s) produto(s) {nome}");

            // }


        }
    }
}
