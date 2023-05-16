using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_de_alunos
{
    public class Aluno
    {
        public string nome;

        public string curso;

        public int idade;

        public string rg;

        public bool bolsa;

        public float media;

        public float mensalidade;

        public void VerMensalidade()
        {
               {
            if (bolsa == true && media >= 8) {
                Console.WriteLine($"A taxa de desconto de 50% será aplicada. O valor do desconto será: {mensalidade / 2}");
            }

            else if (bolsa == true && media > 6 && media < 8) {
                Console.WriteLine($"A taxa de desconto de 30% será aplicada. O valor do desconto será: {mensalidade * 0.30}");
                
            }
            else {
                Console.WriteLine($"Nenhuma taxa aplicada. O valor da mensalidade será integral.");
                
            }

        }

        }
        public void VerMediaFinal()
        {
            Console.WriteLine($"A média final do aluno é de: {media}");
            
        }
        }
    }
