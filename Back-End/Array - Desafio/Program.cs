int pares = 0;
int impares = 0;


int[] numeros = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Digite um número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    if ((numeros[i] % 2 == 0) && (numeros[i] > 0)) {
        pares++;

    } else {
        impares++;
    }
}

foreach (int x in numeros)
{
    if (x % 2 == 0)
    {
        Console.WriteLine($"O número {x} é PAR!");
        
    } else {
        Console.WriteLine($"O número {x} é IMPAR!");
        
    }
}

Console.WriteLine($"Há {pares} PARES e {impares} IMPARES!");
