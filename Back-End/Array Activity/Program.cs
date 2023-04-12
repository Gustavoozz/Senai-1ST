// Criar um programa em C# que receba 5 números inteiros e ao final exiba p seu dobro.

// Voce deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números, a estrutura FOR para a leitura dos números e a estrutura foreach para exibi-los.


int[]inteiros = new int[5];

for (int i = 0; i < inteiros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número: ");
    inteiros[i] = int.Parse(Console.ReadLine());
    
}

foreach (int cont in inteiros)
{
    Console.WriteLine($"O número selecionado é {cont} e o dobro do mesmo é {cont * 2}");
    
}