// Exercicio de fixação

// Escreva um programa que receba e imprima o nome e a idade de 5 pessoas.

// Personalizar cores: A resposta do nome em azul e a resposta da idade em verde (Cor da fonte).

string[]nome = new string[5];
int[]idade = new int [5];

for (int i = 0; i < 5; i++)
{
   
    Console.WriteLine($"Digite o nome da {i + 1}º pessoa: ");
    nome[i] = Console.ReadLine();
    
    Console.WriteLine($"Digite a idade da {i + 1}º pessoa: ");
    idade[i] = int.Parse(Console.ReadLine());
}


for (int i = 0; i < 5; i++)
{   
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{i + 1}) Nome: {nome[i]}");
    Console.ResetColor();
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($" Idade: {idade[i]}");
    Console.ResetColor();
    
}