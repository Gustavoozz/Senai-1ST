// Salario

// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.


Console.WriteLine($"Informe seu salario: ");
float salario = float.Parse(Console.ReadLine());


Console.WriteLine($"Agora informe o total gasto: ");
float gasto = float.Parse(Console.ReadLine());



if (salario >= gasto)
{
    Console.WriteLine($"Parabéns! Voce esta dentro do orçamento.");
}

else 
{
    Console.WriteLine($"Voce ultrapassou o orçamento.");  
}