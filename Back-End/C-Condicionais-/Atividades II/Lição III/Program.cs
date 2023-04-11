// Escreva um programa que leia as medidas dos lados de um triângulo     e escreva se ele é Equilátero, Isósceles ou Escaleno. 
// Sendo que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.WriteLine($"Informe o lado 1 do triangulo: ");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o lado 2 do triangulo: ");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Por fim, informe o lado 3 do triangulo: ");
float lado3 = float.Parse(Console.ReadLine());

if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
{
    Console.WriteLine($"O triangulo informado é EQUILÁTERO!");
}

else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3 )
{
 Console.WriteLine($"O triangulo informado é ISÓCELES!");
 
}

else 
{
    Console.WriteLine($"O triangulo informado é ESCALENO!");
    
}


