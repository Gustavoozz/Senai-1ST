using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos =  new List<Contato>();

        public void Adicionar(Contato contato)
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }
    }
}