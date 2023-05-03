using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    public static class ProgramConsts
    {
        public const int InitialAmount = 5000;

        public static string Menu = buildMenu();

        /// <summary>
        /// Pinta el menu de la aplicacion de consola
        /// </summary>
        private static string buildMenu()
        {
            StringBuilder menuStringBuilder = new StringBuilder();

            menuStringBuilder.AppendLine("______________________________________________________________________");
            menuStringBuilder.AppendLine("                                                                  ");
            menuStringBuilder.AppendLine("                   BIENVENIDO AL CAJERO AUTOMATICO");
            menuStringBuilder.AppendLine("______________________________________________________________________");
            menuStringBuilder.AppendLine("");
            menuStringBuilder.AppendLine("      1.- DESEA DEPOSITAR");
            menuStringBuilder.AppendLine("      2.- DESEA CONSULTAR SU SALDO");
            menuStringBuilder.AppendLine("      3.- DESEA RETIRAR");
            menuStringBuilder.AppendLine("      4.- DESEA SALIR");
            menuStringBuilder.AppendLine("");
            menuStringBuilder.AppendLine("______________________________________________________________________");
            menuStringBuilder.AppendLine("");

            return menuStringBuilder.ToString();
        }            
            
    }
}
