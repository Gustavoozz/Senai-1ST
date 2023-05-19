using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos_POO
{
    public class Marca
    {
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        public static List<Marca> marcas = new List<Marca>();


        public Marca Cadastrar()
        {
            Marca marca = new Marca();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
            ===========================================
                        Cadastro de marca
            ===========================================
            ");
            Console.ResetColor();
            Console.WriteLine($"Informe o código da marca: ");
            marca.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome da marca: ");
            marca.NomeMarca = Console.ReadLine()!;

            marcas.Add(marca);
            Console.Clear();

            return marca;
        }

        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
            ===========================================
                        Marcas cadastradas
            ===========================================
            ");
            Console.ResetColor();

            if (marcas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nenhuma marca cadastrada.");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Marca item in marcas)
            {
            Console.WriteLine(@$"
            Código: {item.Codigo}
            Nome da marca: {item.NomeMarca.ToUpper()}
            Data de cadastro: {item.DataCadastro}
            ");
            }
            Console.ResetColor();
        }

        public void Deletar(int Codigo)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
            ==========================================
                        Remoção de Marcas
            ==========================================
            ");
            Console.ResetColor();
            Console.WriteLine($"Informe o codigo da marca que deseja remover: ");
            int cod = int.Parse(Console.ReadLine()!);

            Marca marcaDelete = marcas.Find(x => x.Codigo == cod);
            marcas.Remove(marcaDelete);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"MARCA REMOVIDA COM SUCESSO!");
            Console.ResetColor();
            
        }
    }
}