// Sem Array = Método convencional


// string carro1;
// string carro2;
// string carro3;

// Console.WriteLine($"Digite o nome do carro:");
// carro1 = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro:");
// carro2 = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro:");
// carro3 = Console.ReadLine();

// Console.WriteLine($"{carro1}, {carro2}, {carro3}");



// Com Array


// string[] carros = new string[3];

// Console.WriteLine($"Digite o nome do carro:");
// carros[0] = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro:");
// carros[1] = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro:");
// carros[2] = Console.ReadLine();

// Foreach = "Economizar" o CWL.

// Console.WriteLine($"Primeiro carro da lista: {carros[0]}");
// Console.WriteLine($"Segundo carro da lista: {carros[1]}");
// Console.WriteLine($"Terceiro carro da lista: {carros[2]}");

string[]carros = new string[3];
//carros[0] = "Fusca"
//carros[1] = "Gol"
//carros[2] = "Corsa"


for (int i = 0; i < 3; i++)
{
    // Bloco de codigo a ser executado
    Console.WriteLine($"Digite o nome do {i + 1}º carro: ");
    carros[i] = Console.ReadLine();
    
}

for (int i = 0; i < 300; i++)
{
   Console.WriteLine($"O {i + 1}º carro é: {carros[i]}");
   
    
}

// foreach (var item in carros)
// {
//     Console.WriteLine($"Nome do carro: {item}");
    
// }