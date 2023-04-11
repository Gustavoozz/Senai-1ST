// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.


Console.WriteLine($"Informe o número de maçãs compradas: ");
int maças = int.Parse(Console.ReadLine());

if (maças <= 12)
{
    Console.WriteLine($"Sua compra deu: {maças * 0.30} reais"); 
}

else 
{
    Console.WriteLine($"Sua compra totalizou: {maças * 0.25} reais");  
}