using Exercicio02.Entities;
using Exercicio02.Repositories;
using Exercicio02.Utils;
using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n - EXPORTAÇÂO DE DADOS DE FUNCIONARIO - \n");

            try
            {
                var funcionario = new Funcionario();

                funcionario.IdFuncionario = ConsoleUtil.ReadInt("Id do Funcionario: ");
                funcionario.Nome = ConsoleUtil.ReadText("Nome do Funcionario: ");
                funcionario.DataAdmissao = ConsoleUtil.ReadDateTime("Data de Admissão: ");
                funcionario.Salario = ConsoleUtil.ReadDouble("Salário: ");

                funcionario.Departamento = new Departamento();

                funcionario.Departamento.IdFepartamento = ConsoleUtil.ReadInt("Id do Departamento: ");
                funcionario.Departamento.Nome = ConsoleUtil.ReadText("Nome: ");
                funcionario.Departamento.Descricao = ConsoleUtil.ReadText("Descrição: ");

                var funcionarioRepository = new FuncionarioRepository();
                funcionarioRepository.ExportarJSON(funcionario);

                Console.WriteLine("\nJSON gerado com sucesso.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadKey(); //pausar
        }
    }
}
