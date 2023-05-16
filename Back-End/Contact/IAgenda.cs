using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact
{
    public interface IAgenda
    {
        void Adicionar(Contato contato);

        void Listar();
    }
}