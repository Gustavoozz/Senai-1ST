using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos_POO
{
    public class Login
    {
         public bool Logado { get; set; }
        Usuario user = new Usuario();
        public Login()
        {
            
            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }


            public void Deslogar(Usuario usuario)
            {  
                Logado = false;
            }

            public void GerarMenu()
            {
                string opcao;
                Produto produto = new Produto();
                Marca marca = new Marca();

                do {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($@"
                {user.Nome}
                =====================================
                Seu cadastro foi concluído com êxito.
                Bem-vindo ao Menu de opções!
                [1] - Cadastrar produto.
                [2] - Listar produto.
                [3] - Deletar produto.
                -------------------------------------
                [4] - Cadastrar marca.
                [5] - Deletar marca.
                [6] - Listar marca.
                [7] - Deslogar.
                =====================================
                "); 
                Console.ResetColor();

                opcao = Console.ReadLine()!;
                
                switch (opcao)
                {
                    case "1":
                    produto.Cadastrar();
                    break;

                    case "2":
                    produto.Listar();
                    break;

                    case "3":
                    Console.WriteLine($"Informe o código do produto que você deseja deletar: ");
                    int codigoProduto = int.Parse(Console.ReadLine()!);
                    produto.Deletar(codigoProduto);
                    break;

                    case "4":
                    marca.Cadastrar();
                    break;

                    case "5":
                    Console.WriteLine($"Informe o código do produto que você deseja deletar: ");
                    int codigoMarca = int.Parse(Console.ReadLine()!);
                    marca.Deletar(codigoMarca);
                    break;

                    case "6":
                    marca.Listar();
                    break;

                    case "7":
                    Console.WriteLine($"Programa encerrado.");
                    break;
                     case "0":
                        Console.Clear();
                        Console.WriteLine($"Desligando programa...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção inválida!");
                        Console.ResetColor();
                        Console.WriteLine($"Pressione ENTER para tentar novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                
                }
                } while (opcao != "0");

        string Deslogar()
        {
            Logado = false;
            return "Usuário deslogado.";
        }
 }

        private void Logar(Usuario user)
        {
            string opcao;
            do
            {
            Menu:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"
                =============================
                Escolha uma opção:
                [1] - Login
                [2] - Cadastro
                [0] - Sair
                =============================
                ");
                Console.ResetColor();
                opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($@"
                        =========================================
                                Bem-vindo ao menu de login!
                        =========================================
                        ");
                        Console.ResetColor();

                        Console.WriteLine($"Digite seu email: ");
                        string email = Console.ReadLine()!;

                        Console.WriteLine($"Digite sua senha: ");
                        string password = Console.ReadLine()!;

                        if (Usuario.usuarios.Any(x => x.Email == email) && Usuario.usuarios.Any(x => x.Senha == password))
                        {
                            this.Logado = true;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Login efetuado com sucesso!");
                            Console.ResetColor();
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            this.Logado = false;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"EMAIL OU SENHA INCORRETOS!");
                            Console.ResetColor();
                            Console.WriteLine($"Pressione ENTER para tentar novamente.");
                            Console.ReadKey();
                            Console.Clear();
                            goto Menu;
                        }


                    case "2":
                        Console.Clear();
                        user.Cadastrar();
                        Console.Clear();
                        goto Menu;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Encerrando aplicativo...");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"OPÇÃO INVÁLIDA!");
                        Console.ResetColor();
                        Console.WriteLine($"Pressione ENTER para tentar novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcao != "1" && opcao != "2" && opcao != "0");

        }
    }
    }
               

        
    
