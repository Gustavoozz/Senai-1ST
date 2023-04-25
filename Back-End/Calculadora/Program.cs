// Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.


using Calculadora;

Contas calc = new Contas();

string opcao;

do
{
    
// Console.Clear();    
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Digite o primeiro número: ");
calc.n1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo número: ");
calc.n2 = float.Parse(Console.ReadLine()!);

Console.WriteLine(@$"
=========================================
Para dar continuidade sua operação, primeiro selecione
a operação que deseja utilizar: 

[1] - SOMAR
[2] - SUBTRAIR
[3] - MULTIPLICAR
[4] - DIVIDIR
[0] - Sair.
==========================================


");
Console.ResetColor();

opcao = Console.ReadLine()!;


switch (opcao)
{
    case "0":  
    {
        break;
    }

    case "1":
    {
        calc.Soma();
        break;
    }

    case "2":
    {
        calc.Subtracao();
        break;
    }

    case "3":
    {
        calc.Multiplicacao();
        break;
    }

    case "4":
    {
        calc.Divisao();
        break;
    }

    default:
        break;
}
} while (opcao != "0");


//V2 - Professor
// using calculadora;

// Calculadora calc = new Calculadora();

// Console.WriteLine($"Digite o primeiro número:");
// calc.numero1 = float.Parse( Console.ReadLine() ) ;

// Console.WriteLine($"Digite o segundo número:");
// float n2 = float.Parse( Console.ReadLine() ) ;

// // preencher as propriedades da classe
// calc.numero2 = n2;

// Console.WriteLine($"Escolha uma opção no menu abaixo");
// Console.WriteLine(@$"
//    +) - Soma
//    -) - Subtração
//    *) - Multiplicação
//    /) - Divisão
//    s) - Sair
// ");

// string op = Console.ReadLine().ToLower();

// switch (op)
// {
//    case "+":
//       Console.WriteLine($"O resultado da soma é: {calc.Somar()}");
//       break;
//    case "-":
//       Console.WriteLine($"O resultado da subtração é: {calc.Subtrair()}");
//       break;
//    case "*":
//       Console.WriteLine($"O resultado da multiplicação é: {calc.Multiplicar()}");
//       break;
//    case "/":
//       Console.WriteLine($"O resultado da divisão é: {calc.Dividir()}");
//       break;
//    case "s":
//       Console.WriteLine($"Programa finalizado com sucesso, volte sempre!");
//       break;
//    default:
//    Console.WriteLine($"Opção Inválida");
//       break;
// }