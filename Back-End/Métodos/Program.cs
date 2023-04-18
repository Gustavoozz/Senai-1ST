Console.WriteLine($"Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Escolha a sua operação: ");
char operation = char.Parse(Console.ReadLine());




// Criar método para somar 2 números.

static float Soma(float n1, float n2) {
    float r = n1 + n2;
    return r;
}

float adicao = Soma(16, 123);

Console.WriteLine($"Resultado da soma: {adicao}");



// Criar método para multiplicar 2 números.

static float Mult(float n1, float n2) {
    float r = n1 * n2;
    return r;
}

float multi = Mult(16, 123);

Console.WriteLine($"Resultado da multiplicação: {multi}");



// Criar método para dividir 2 números.

static float Div(float n1, float n2) {
    float r = n1 / n2;
    return r;
}

float divi = Div(16, 123);

Console.WriteLine($"Resultado da divisão: {divi}");



// Criar método para subtrair 2 números.

static float Sub(float n1, float n2) {
    float r = n1 - n2;
    return r;
}

float menos = Sub(16, 123);

Console.WriteLine($"Resultado da subtração: {menos}");

