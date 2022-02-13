namespace Abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;
        public override string Desconto(int valor)
        {
            return"";
        }

        public void Registrar(){
            Console.writeLine("Registrado");
        }
    }
}