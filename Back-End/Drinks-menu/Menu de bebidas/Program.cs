
// Crie um menu de opções e peça para o usuário escolher uma das opções
// a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
// se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
// caso contrário, a bebida é sem gelo adicional


Console.WriteLine(@$"Cardápio de bebidas: 
1- Coca-cola
2- Pepsi
3- Fanta de Laranja
4- Monster Mango Loco
5- Pitú
6- Corote de Maracujá
");

int refri = int.Parse(Console.ReadLine()!);
int gelo = 0;

switch (refri)
{
    case 1:
        Console.WriteLine($"Você escolheu Coca-cola");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Quero a bebida com gelo
        2- Quero a bebida sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você optou pela coca-cola com gelo.");
                break;
            case 2:
                Console.WriteLine($"Você optou pela coca-cola sem gelo.");
                break;
            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }


        break;
    case 2:
        Console.WriteLine($"Você escolheu Pepsi");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Quero a bebida com gelo
        2- Quero a bebida sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você optou pela Pepsi com gelo.");
                break;
            case 2:
                Console.WriteLine($"Você optou pela PEpsi sem gelo.");
                break;
            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;
    case 3:
        Console.WriteLine($"Você escolheu Fanta");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Quero a bebida com gelo
        2- Quero a bebida sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você optou pela Fanta com gelo.");
                break;
            case 2:
                Console.WriteLine($"Você optou pela Fanta sem gelo.");
                break;
            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;
    case 4:
        Console.WriteLine($"Você escolheu Monster");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Quero a bebida com gelo.
        2- Quero a bebida sem gelo.");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você optou pelo Monster com gelo.");
                break;
            case 2:
                Console.WriteLine($"Você optou pelo Monster sem gelo.");
                break;
            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;
            case 5:
        Console.WriteLine($"Você escolheu Pitú");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Quero a bebida com gelo.
        2- Quero a bebida sem gelo.");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você optou pela Pitú com gelo.");
                break;
            case 2:
                Console.WriteLine($"Você optou pela Pitú sem gelo.");
                break;
            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;
            case 6:
        Console.WriteLine($"Você escolheu Corote de Maracujá");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Quero a bebida com gelo.
        2- Quero a bebida sem gelo.");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você optou pelo Corote com gelo.");
                break;
            case 2:
                Console.WriteLine($"Você optou pelo Corote sem gelo.");
                break;
            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;
    default:
        Console.WriteLine($"Escolha inválida.");
        break;
}

