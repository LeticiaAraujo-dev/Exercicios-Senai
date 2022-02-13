namespace Abstracao.classes
{
        public abstract class Pagamento{
            private DateTime data;

            protected float valor;
            public string Cancelar(){
                return"";

            }

            public abstract string Desconto(int valor);
    }
}