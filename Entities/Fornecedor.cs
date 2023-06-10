using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.Entities
{
    /// <summary>
    /// Classe de modelo de entidade para fornecedor.
    /// </summary>
    public class Fornecedor
    {
        #region Propiedades
        public Guid IdFornecedor { get; set; }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; } 
        #endregion

        #region Relacionamentos
        public List<Produto>? Produtos { get; set; }
        #endregion
    }
}
