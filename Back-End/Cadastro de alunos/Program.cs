// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.
 
// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

using Cadastro_de_alunos; 

Aluno calc = new Aluno();


Console.WriteLine($"Informe o nome do aluno: ");
calc.nome = Console.ReadLine()!;

Console.WriteLine($"Informe o curso do aluno: ");
calc.curso = Console.ReadLine()!;

Console.WriteLine($"Informe a idade do aluno: ");
calc.idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o RG do aluno: ");
calc.rg = Console.ReadLine()!;

Console.WriteLine($"O aluno cadastrado é bolsista? Digite [True] para SIM ou [False] para NÃO.");
calc.bolsa = bool.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a média final do aluno: ");
calc.media = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a mensalidade do aluno: ");
calc.mensalidade = float.Parse(Console.ReadLine()!);

string opcao;

do {
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($@"
============================================
Bem-vindo ao menu de opções!
O cadastro do aluno está quase pronto, use o
menu pra visualizar a média e o valor da
mensalidade.

Escolha a opção que mais atende seus desejos:

[1] - Visualizar a média final.
[2] - Visualizar o valor da mensalidade.
[0] - Sair.
=============================================
");
Console.ResetColor();

opcao = Console.ReadLine()!;

switch (opcao)
{
    case "0":  
    {
        Console.WriteLine($"Você saiu do menu.");
        
        break;
    }

    case "1":
    {
        calc.VerMediaFinal();
        break;
    }

    case "2":
    {
      calc.VerMensalidade();
      break;
    }

    default:
        Console.WriteLine($"Entrada inválida. Tente novamente");
        break;
}
} while (opcao != "0");

