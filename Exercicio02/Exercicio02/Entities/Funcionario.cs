using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    public class Funcionario
    {
        #region Properties
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        #endregion

        #region Construtores

        public Funcionario()
        {

        }

        #endregion

        #region Relacionamentos

        public Departamento Departamento { get; set; }

        #endregion
    }
}
