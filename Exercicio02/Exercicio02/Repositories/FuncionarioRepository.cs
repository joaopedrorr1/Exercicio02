using Exercicio02.Entities;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Exercicio02.Repositories
{
    /// <summary>
    /// Classe de repositório de dados para Funcionario
    /// </summary>
    public class FuncionarioRepository
    {
        #region Atributos

        /// <summary>
        /// Atributo para definir o caminho do diretório de exportação
        /// </summary>
        private const string path = "c:\\temp\\";

        #endregion

        #region Métodos

        /// <summary>
        /// Método para exportar os dados de um funcionario para arquivo JSON
        /// </summary>
        /// <param name="funcionario">Objeto da classe de entidade Funcionario</param>
        public void ExportarJSON(Funcionario funcionario)
        {
            CriarDiretorio();

            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);
            var filename = string.Format("funcinario_{0}.json", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            using (var streamWriter = new StreamWriter(path + filename))
            {
                streamWriter.WriteLine(json);
            }
        }

        /// <summary>
        /// Método para criar a pasta onde os arquivos serão gravados
        /// </summary>
        private void CriarDiretorio()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        #endregion
    }
}
