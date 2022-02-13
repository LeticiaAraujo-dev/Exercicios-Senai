namespace PrimeiroPOO
{
    public class Personagem
    {
        public string name;
        public int idade;
        public string armadura;

        public string Atacar(){
            return "Ataque de fogo!";
        }

        public string Defender(){
            return "Não foi dessa vez!";
        }
    }
}