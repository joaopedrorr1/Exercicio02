using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    public class Departamento
    {
        #region Properties

        public int IdFepartamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        #endregion

        #region Construtores

        public Departamento()
        {

        }

        #endregion

    }
}
