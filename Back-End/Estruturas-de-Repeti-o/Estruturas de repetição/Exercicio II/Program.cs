Console.WriteLine($"Insira o nome de usuario: ");
string usuario = Console.ReadLine();

Console.WriteLine($"Insira a senha do usuário: ");
string senha = Console.ReadLine();

while (usuario == senha)
{
    Console.WriteLine($"O nome de usuário e a senha são identicos. Tente novamente.");
    senha = Console.ReadLine();
    
}

Console.WriteLine($"O cadastro é válido.");
