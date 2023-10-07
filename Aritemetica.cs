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
    internal class Aritemetica
    {
            /// <summary>
            /// Operação soma.
            /// </summary>
            /// <returns>Retorna a soma de dois numeros</returns>
            public int Somar(int x,int y)
            { 
            return x + y; 
            }
            /// <summary>
            /// Operação Subtração.
            /// </summary>
            /// <returns>Retorna o resulatado da subtração de dois numeros</returns>
        public int Subtrair(int x, int y)
            {
            return x - y;
            }
    }
}
