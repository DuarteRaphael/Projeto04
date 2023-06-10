using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.Interfaces
{
    public interface IBaseRepository
    {
        void Inserir();
        void Alterar();
        void Excluir();
        List<T class> Consultar();
    }
}
