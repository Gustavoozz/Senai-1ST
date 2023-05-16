

namespace POO
{
    public class Personagem
    {
        // Atributos.
        // NOME, IDADE, ARMADURA, I.A
        public string nome;

        public int idade;

        public string armadura;

        public string ia;


        // Métodos.
        // ATACAR, DEFENDER, RESTAURAR ARMADURA.
        
        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou!");
            
        }

        public void Defender()
        {
            Console.WriteLine($"O personagem defendeu!");
            
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"A armadura foi restaurada!");
            
        }
    }
}