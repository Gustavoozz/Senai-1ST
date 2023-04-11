
Console.WriteLine($"Informe o seu nome: ");
string name = Console.ReadLine();

while (name == "")
{

Console.WriteLine($"Nome inválido. Informe o nome novamente: ");
name = Console.ReadLine();
}
Console.WriteLine($"O nome do usuario é {name}");




Console.WriteLine($"Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());

while (idade < 0 || idade > 100)
{

Console.WriteLine($"Idade inválida. Informe a idade novamente: ");
idade = int.Parse(Console.ReadLine());

}
Console.WriteLine($"A idade do usuário é {idade} ");



Console.WriteLine($"Informe seu salario: ");
float salario = float.Parse(Console.ReadLine());

while (salario <= 0)
{
    Console.WriteLine($"Salario inválido. Informe o mesmo novamente: ");
    salario = float.Parse(Console.ReadLine());
}
Console.WriteLine($"O salário do usuário é {salario}");



Console.WriteLine($"Informe seu estado civil: ");
char civil = char.Parse(Console.ReadLine());

while (civil != 's' && civil != 'v' && civil != 'c' && civil != 'd')
{
    Console.WriteLine($"Estado civil inválido. Informe novamente: ");
    civil = char.Parse(Console.ReadLine()); 
}
Console.WriteLine($"O estado civil do usuário é {civil}");

