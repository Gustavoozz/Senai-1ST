// Faça um método para calcular imposto sobre a renda

// Regras de negócio
// Tabela de imposto vs renda
// Até $1500 - isento
// De $1501 até $3500 - 20% de imposto
// De $3501 até $6000 - 25% de imposto
// Acima de $6000 - 35% de imposto


// Receber o renda via console
// Chamar o método passando a renda como parâmetro
// Exibir o valor do imposto referente á renda

Console.WriteLine($"Informe a sua renda: ");
float rendimento = float.Parse(Console.ReadLine());


static float Leaofaminto(float rendimento) {
    

if (rendimento <= 1500) {
    Console.WriteLine($"Você esta isento de Imposto de renda."); 
}

else if (rendimento >= 1501 && rendimento < 3500) {
    float calculo = (rendimento * 0.20F);
    Console.WriteLine($"A taxa de 20% de Imposto de renda será aplicada, o valor do imposto a pagar será: {calculo} reais.");
    
}

else if (rendimento >= 3501 && rendimento < 6000) {
    float calculo2 = (rendimento * 0.25F);
    Console.WriteLine($"A taxa de 25% de Imposto de renda será aplicada, o valor do imposto a pagar será: {calculo2} reais.");
    
}

else {
    float calculo3 = (rendimento * 0.35F);
    Console.WriteLine($"A taxa de 35% de Imposto de renda será aplicada, o valor do imposto a pagar será: {calculo3} reais.");
    
}

return (rendimento);
}

float impostos = Leaofaminto(rendimento);

