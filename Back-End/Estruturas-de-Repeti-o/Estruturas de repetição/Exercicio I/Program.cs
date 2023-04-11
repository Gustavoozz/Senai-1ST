Console.WriteLine($"Insira uma nota: ");
float nota = float.Parse(Console.ReadLine());

while (nota < 0 || nota > 10)
{
    Console.WriteLine($"Nota inválida. Insira novamente: ");
    nota = float.Parse(Console.ReadLine());
    
}
Console.WriteLine($"A sua nota é {nota}");
