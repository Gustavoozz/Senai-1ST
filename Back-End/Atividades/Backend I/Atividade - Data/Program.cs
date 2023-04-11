//Calculadora de idade pela data

// Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos
// e semanas e imprima o resultado no console.

Console.WriteLine($"Calculadora pela data");

Console.WriteLine($"Informe a sua data de nascimento: ");
int anodeNasc = int.Parse(Console.ReadLine());

int emAnos = 2023 - anodeNasc;
int semana = 52 * anodeNasc;

Console.WriteLine($"A sua idade em anos é: {emAnos}");
Console.WriteLine($"A sua idade em semanas é: {semana}");



