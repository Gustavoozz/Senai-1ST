using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos_POO
{
    public class Usuario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        public int cod = 0;
        public static List<Usuario> usuarios = new List<Usuario>();


        public void Cadastrar()
        {
             Usuario user = new Usuario();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------- CADASTRO --------");
            Console.ResetColor();
            
            Console.WriteLine($"Informe seu usuário: ");
            user.Nome = Console.ReadLine();

            Console.WriteLine($"Informe seu email: ");
            user.Email = Console.ReadLine();

            Console.WriteLine($"Informe sua senha: ");
            user.Senha = Console.ReadLine();

            cod++;

            usuarios.Add(user);

            // return @$"Usuário cadastrado! Código de cadastro: {cod}";
        }

        public string Deletar()
        {
            Console.WriteLine($"Informe o ID do usuário que deseja remover: ");
            int cod = int.Parse(Console.ReadLine()!);

            Usuario userDelete = usuarios.Find(x => x.Codigo == cod);
            usuarios.Remove(userDelete);
            return "Usuário removido!";
        }
    }
}