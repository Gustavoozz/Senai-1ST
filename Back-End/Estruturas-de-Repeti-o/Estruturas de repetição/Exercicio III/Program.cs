Console.WriteLine($"Insira um número para obter a sua tabuada: ");
int tabuada = int.Parse(Console.ReadLine());

while (tabuada < 0)
{
    Console.WriteLine($"Valor inválido. Digite o numero novamente: ");
    tabuada = int.Parse(Console.ReadLine()!);
    
}

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
    
}