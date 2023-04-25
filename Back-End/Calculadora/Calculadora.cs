using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    
    public class Contas
    {
        public float n1;
        public float n2;

// Métodos
            public void Soma()
        {
            Console.WriteLine($"O resultado da soma é: {n1 + n2}");
        }
        public void Subtracao()
        {
            Console.WriteLine($"O resultado da subtração é: {n1 - n2}");
        }
        public void Multiplicacao()
        {
            Console.WriteLine($"O resultado da multiplicação é: {n1 * n2}");
        }
        public void Divisao()
        {
            Console.WriteLine($"O resultado da divisao é: {n1 / n2}");
        }
    }
}


// V2 - Professor

// namespace calculadora
// {
//     public class Calculadora
//     {
//         // propriedades
//         public float numero1;
//         public float numero2;

//         // métodos
//         public float Somar()
//         {
//             return  this.numero1 + this.numero2;
//         }
//         public float Subtrair()
//         {
//             return  this.numero1 - this.numero2;
//         }
        
//         public float Multiplicar()
//         {
//             return  this.numero1 * this.numero2;
//         }
//         public float Dividir()
//         {
//             return  this.numero1 / this.numero2;
//         }
//     }
// }