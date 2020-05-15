using Exercicio02_02.Entities;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Exercicio02_02.Repositories
{
    /// <summary>
    /// Classe de repositório de dados para Produto
    /// </summary>
    public class ProdutoRepository
    {
        #region Atributos

        /// <summary>
        /// Atributo para definir o caminho do diretório de exportação
        /// </summary>
        private const string path = "c:\\temp\\";

        #endregion

        #region Métodos

        /// <summary>
        /// Método para exportar os dados de um produto para arquivo JSON
        /// </summary>
        /// <param name="produto">Objeto da classe de entidade Produto</param>
        public void ExportarJSON(Produto produto)
        {
            CriarDiretorio();

            var json = JsonConvert.SerializeObject(produto, Formatting.Indented);
            var filename = string.Format("produto_{0}.json", DateTime.Now.ToString("ddMMyyyyHHmmss"));

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
