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

string[] carros = new string[3];

Console.WriteLine($"Digite o nome do carro:");
carros[0] = Console.ReadLine();

Console.WriteLine($"Digite o nome do carro:");
carros[1] = Console.ReadLine();

Console.WriteLine($"Digite o nome do carro:");
carros[2] = Console.ReadLine();

// Foreach = "Economizar" o CWL.

// Console.WriteLine($"Primeiro carro da lista: {carros[0]}");
// Console.WriteLine($"Segundo carro da lista: {carros[1]}");
// Console.WriteLine($"Terceiro carro da lista: {carros[2]}");

