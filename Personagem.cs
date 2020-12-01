namespace Atributos_e_Metodos
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;

        public string Ataque(){

            return "Ataque com espada!"; 
        }

        public string Defender(){
            return "Modo defesa ativado! ";
        }
    }
}