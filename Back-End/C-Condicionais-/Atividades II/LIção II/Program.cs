// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"Informe o número de gols do Barcelona: ");
int barcelona = int.Parse(Console.ReadLine());


Console.WriteLine($"Informe o número de gols do Real Madrid:  ");
int real = int.Parse(Console.ReadLine());



if (barcelona > real)
{
    Console.WriteLine($"Barcelona venceu a partida!");
}

else if (barcelona == real)
{
    Console.WriteLine($"Os times empataram!");  
}

else 
{
    Console.WriteLine($"Real Madrid venceu a partida!");  
}
