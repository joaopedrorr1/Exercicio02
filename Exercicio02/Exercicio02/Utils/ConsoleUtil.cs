using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Utils
{
    /// <summary>
    /// Classe utilitária para leitura de dados através do Console
    /// </summary>
    public class ConsoleUtil
    {
        /// <summary>
        /// Método para ler um valor texto informado pelo usuário do console
        /// </summary>
        /// <param name="message">Mensagem que será mostrada no console</param>
        /// <returns>Valor texto digitado pelo usuário do console</returns>
        public static string ReadText(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        /// <summary>
        /// Método para ler um valor numérico inteiro informado pelo usuário do console
        /// </summary>
        /// <param name="message">Mensagem que será mostrada no console</param>
        /// <returns>Valor numérico inteiro digitado pelo usuário do console</returns>
        public static int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        ///  Método para ler um valor Data/Hora informado pelo usuário do console
        /// </summary>
        /// <param name="message">Mensagem que será mostrada no console</param>
        /// <returns>Valor Data/Hora digitado pelo usuário do console</returns>
        public static DateTime ReadDateTime(string message)
        {
            Console.Write(message);
            return DateTime.Parse(Console.ReadLine());
        }

        /// <summary>
        ///  Método para ler um valor Double informado pelo usuário do console
        /// </summary>
        /// <param name="message">Mensagem que será mostrada no console</param>
        /// <returns>Valor Double digitado pelo usuário do console</returns>
        public static double ReadDouble(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }
    }
}
