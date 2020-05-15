using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02_02.Entities
{
    public class Produto
    {
        #region Properties
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        #endregion

        #region Construtores

        public Produto()
        {

        }

        #endregion

        #region Relacionamentos

        public Categoria Categoria { get; set; }

        #endregion
    }
}
