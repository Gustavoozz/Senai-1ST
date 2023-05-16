using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cellphone
{
    public class Celular
    {
        public string cor = "";

        public string modelo = "";

        public float tamanho;

        public bool power;

        public string contato = "";

        public string zap = "";

        public string mens = "";



        public void ligar() 
        {
          power = true;
          Console.WriteLine($"O dispositivo está ligando...");
          
            
        }

        public void desligar()
        {
           power = false;
           Console.WriteLine($"O dispositivo está desligando...");
           
            
        }

        public void ligacao()
        {
            Console.WriteLine($"Escreva o contato que você deseja ligar.");
            contato = Console.ReadLine()!;
            
            Console.WriteLine($"Ligando para {contato}...");
        }

        public void mensagem()
        {
            Console.WriteLine($"Insira o nome do contato que você deseja enviar mensagens.");
            zap = Console.ReadLine()!;
            
            Console.WriteLine($"Envie sua mensagem: ");
            mens = Console.ReadLine()!;
            
            Console.WriteLine($"Enviando mensagem para {zap}...");
            
        }
    }
}