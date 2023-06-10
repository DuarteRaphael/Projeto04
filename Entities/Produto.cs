﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.Entities
{
    public class Produto
    {
        #region Propriedades
        public Guid IdProduto { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public int IdFornecedor { get; set; }
        #endregion

        #region Relacionamentos
        public Fornecedor? Fornecedor { get; set; }
        #endregion
    }
}
