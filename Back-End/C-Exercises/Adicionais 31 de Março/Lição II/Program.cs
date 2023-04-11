// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"Informe o primeiro número: ");
float um = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo número: ");
float dois = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o terceiro número: ");
float tres = float.Parse(Console.ReadLine());


if (a > b && b > c && a > c )
{
    Console.WriteLine($"O maior valor é {a} e o menor valor é {c}");
    
}

else if (b > a && a > c && b > c){
    Console.WriteLine($"O maior valor é {b} e o menor valor é {c}");
    
}