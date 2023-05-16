using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf { get; set; }

        public bool ValidarCPF(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}