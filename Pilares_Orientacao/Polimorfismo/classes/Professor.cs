using System;

namespace Polimorfismo.classes
{
    public class Professor : Taxa
    {
        public string turma;
        public override void ValeRefeicao(){
            Console.WriteLine($"A taxa a ser paga é 10%");
        }
    }
}