using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos_POO
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; }

        public Marca Marca = new Marca();
    
        public Usuario Usuario = new Usuario();

        public static List<Produto> produtos = new List<Produto>();
        public void Cadastrar()
        {
            Produto produto = new Produto();
            Codigo:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
            ===========================================
                        Cadastro de produto
            ===========================================
            ");
            Console.ResetColor();

            Produto codigoExistente;

            Console.WriteLine($"Informe o código do produto: ");
            produto.Codigo = int.Parse(Console.ReadLine()!);

            codigoExistente = Produto.produtos.Find(x => x.Codigo == produto.Codigo);
            if (codigoExistente != null)
            {
                Console.Clear();
                Console.WriteLine($"O codigo informado já existe! Tente novamente");
                goto Codigo;
            }

            Console.WriteLine($"Informe o nome do produto: ");
            produto.NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Informe o valor do produto: ");
            produto.Preco = float.Parse(Console.ReadLine()!);

            Marca marcaExistente;
            string opcao;

            do
            {
            InfMarca:
                Console.WriteLine($"Informe o código da marca: ");
                int codigoMarca = int.Parse(Console.ReadLine()!);

                marcaExistente = Marca.marcas.Find(x => x.Codigo == codigoMarca);
                if (marcaExistente != null)
                {
                    produto.Marca = marcaExistente;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Marca não identificada!");
                    Console.ResetColor();
                MenuMarca:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"
                    ===========================================
                    Bem-vindo ao menu de cadastro de marcas!
                    [1] - Cadastrar marca.
                    [2] - Listar marcas existentes.
                    ===========================================
                    ");
                    Console.ResetColor();
                    opcao = Console.ReadLine()!;

                    switch (opcao)
                    {
                        case "1":
                            Console.Clear();

                            Marca m = new Marca();
                            m.Cadastrar();
                            Console.Clear();
                            break;

                        case "2":
                            Console.Clear();
                            goto InfMarca;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"OPÇÃO INVÁLIDA!");
                            Console.ResetColor();
                            Console.WriteLine($"Pressione ENTER para tentar novamente.");
                            Console.ReadKey();
                            Console.Clear();
                            goto MenuMarca;
                    }
                }
            } while (marcaExistente == null);


            produto.Usuario = new Usuario();

            produtos.Add(produto);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Produto cadastrado com sucesso!");
            Console.ResetColor();
        }

        public void Listar()
        {
             Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
            ===========================================
                        Cadastro de produto
            ===========================================
            ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Produto item in produtos)
            {
            Console.WriteLine(@$"
            Código: {item.Codigo}
            Marca: {item.Marca.NomeMarca.ToUpper()}
            Nome do produto: {item.NomeProduto.ToUpper()}
            Valor do produto: {item.Preco:C}
            Data de cadastro: {item.DataCadastro}
            ");
            }
            Console.ResetColor();
        }

        public string Deletar(int Codigo)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
            ===========================================
                        Deletar produto
            ===========================================
            ");
            Console.ResetColor();

            Console.WriteLine($"Informe o codigo do produto que deseja remover: ");
            int cod = int.Parse(Console.ReadLine()!);

            Produto produtoDelete = produtos.Find(x => x.Codigo == cod);
            produtos.Remove(produtoDelete);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"PRODUTO REMOVIDO COM SUCESSO!");
            Console.ResetColor();
            return "Produto removido!";
        }


       
    }
}