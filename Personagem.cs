namespace Atributos_e_Metodos
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string arma;

        public string Ataque(){

            return "Desce, sobe, empina e rebola"; 
        }

        public string Defender(){
            return "'Vem traquilo'";
        }

        public string Derrota(){
            return "'Já acabou, Jéssica?'";
        }

        public string Vitoria(){
            return "'Apenas meu silêncio para você'";
        }
    }
}