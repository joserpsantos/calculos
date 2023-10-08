using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas.
    /// </summary>
    internal static class Aritemetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        
        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <returns>Retorna a soma de dois numeros</returns>
        public static int Somar(int x,int y)
         { 
            return x + y; 
         }
         /// <summary>
         /// Operação Subtração.
         /// </summary>
         /// <returns>Retorna o resulatado da subtração de dois numeros</returns>
         public static int Subtrair(int x, int y)
          {
            return x - y;
          }
          public static double ConverterTemperatura(ConversaoTemperatura conversao,double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit) 
            { 
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            { 
                return ((temperatura - 32) /1.8000)
            }
            return -1;
        }

    }
}
