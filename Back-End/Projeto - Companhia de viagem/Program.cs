// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

static bool Login(string senhaInformada)
{
bool senhaCorreta = false;
string senha = "chapei123";

if(senhaInformada == senha)
{
    senhaCorreta = true;
}
else
{
    senhaCorreta = false;
}
return senhaCorreta;
}

string senha;

do
{
    Console.WriteLine($"Digite a senha do usuário: ");
    senha = Console.ReadLine()!;

} while (Login(senha) == false);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"

Acesso ao Sistema concedido com SUCESSO!
Seja bem-vindo ao menu de viagens!
Selecione uma das seguingtes opções:

1) Cadastrar passagens.
2) Listar passagens.
0) Sair.

");
Console.ResetColor();

int menu = int.Parse(Console.ReadLine()!);
string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
int[] data = new int[5];


    switch (menu) {
        case 1:

        for (var i = 0; i < nome.Length; i++)
        {
            
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Bem-vindo ao cadastro de passagens!");
        Console.ResetColor();
                 
        Console.WriteLine($"Primeiro, insira o nome do {i + 1}º passageiro: ");
        nome[i] = Console.ReadLine()!;         
       
        Console.WriteLine($"Insira a origem {i + 1}º do passageiro: ");
        origem[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira o destino {i + 1}º do passageiro: ");
        destino[i] = Console.ReadLine()!;

        Console.WriteLine($"Por fim, insira a data de voo do {i + 1}º passageiro: ");
        data[i] = int.Parse(Console.ReadLine()!);

        // Console.WriteLine($@"Cadastro CONCLUÍDO! Deseja cadastrar uma nova passagem ou retornar ao menu anterior?
        // (S) - Sim.
        // (N) - Não.
        // ");
        // char retorno = char.Parse(Console.ReadLine()!);
                
     
}   
break; 
        // case 2:
        // Console.ForegroundColor = ConsoleColor.Red;
        // Console.WriteLine($"Bem-vindo a listagem de passagens!");
        // Console.ResetColor();


    
        
}

        

      
        

    
