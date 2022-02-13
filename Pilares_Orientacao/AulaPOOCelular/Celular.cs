namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        public bool Ligar(){
            return ligado = true;
        }

        public bool Desligar(){
            return ligado = false;
        }
        public string FazerLigação(){
            return "Ligando....";
        }
        public string EnviarMensagem(){
            return "Mandando mensagem....";
        }
    }
}