// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using Cellphone;

Celular act = new Celular();


string opcao;

do {
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($@"
============================================
Bem-vindo ao menu do celular!
Escolha a opção que mais atende seus desejos:

[1] - Ligar (Para efetuar as outras ações, 
esta deve estar ativa).
[2] - Desligar.
[3] - Fazer ligação.
[4] - Mandar mensagem.
[0] - Sair.
=============================================
");
Console.ResetColor();

opcao = Console.ReadLine()!;

switch (opcao)
{   
    case "0":
    {
        break;
    }


    case "1":  
    {
    if (act.power)
    {
        Console.WriteLine($"O dispositivo já está ligado.");
        
    }
    
    else {
          act.ligar();
    }
    break;
    
    }


    case "2":
    {
     if (act.power == false) {
        Console.WriteLine($"O dispositivo já está desligado.");
        
     }

     else {
        act.desligar();
     }
        break;
        
    }


    case "3":
    {
        if (act.power) {
            act.ligacao();
            
        }

        else {
      Console.WriteLine($"A ação não pode ser executada. O dispositivo está desligado.");
    }
      break;
    }

    case "4":
    {
        if (act.power) {
        act.mensagem();
            
        }

        else {
       
        Console.WriteLine($"A ação não pode ser executada. O dispositivo está desligado.");
        }
        break;
    }

    default:
        Console.WriteLine($"Entrada inválida. Tente novamente");
        break;
}
} while (opcao != "0");

