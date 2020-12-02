using System;

namespace Atributos_e_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem avatarUm = new Personagem();

            avatarUm.nome = "Giovanna";
            avatarUm.idade = 7;
            avatarUm.armadura = "Dança Mc Leozinho";
            avatarUm.arma = "Forninho";

            Personagem avatarDois = new Personagem();

            avatarDois.nome = "Paulinha";
            avatarDois.idade = 14;
            avatarDois.armadura = "X de Xuxa com os braços";
            avatarDois.arma = "Golpes de Capoeira";

            System.Console.WriteLine($"{avatarUm.nome} ataca com {avatarUm.arma} e diz '{avatarUm.Ataque()}'\n");
            
            System.Console.WriteLine($"Mas o que {avatarUm.nome} não esperava é que {avatarDois.nome} tinha uma carta na manga!\n");
            
            System.Console.WriteLine($"{avatarDois.nome} utiliza sua {avatarDois.armadura} para absorver o ataque sofrido...\n");
            
            System.Console.WriteLine($"e diz {avatarDois.Defender()}\n");
        
            System.Console.WriteLine($"e num contra-golpe ágil, {avatarDois.nome} utiliza seu {avatarDois.arma} para atacar {avatarUm.nome} que não consegue ativar seu {avatarUm.armadura}\n");

            System.Console.WriteLine($"Com a derrota devastadora {avatarUm.nome} só consegue esboçar as palavras {avatarUm.Derrota()}\n");

            System.Console.WriteLine($"Rindo, {avatarDois.nome} responde: {avatarDois.Vitoria()}");

            
        }
    }
}
