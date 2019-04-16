using System.Collections.Generic;
using System.Linq;

namespace LSP.Violacao
{
    public class CalculadoraImpares : CalculadoraSoma
    {
        public CalculadoraImpares(List<int> numeros)
            : base(numeros)
        {
        }

        //public new int Calcular() 
        //    => _numeros.Where(x => x % 2 == 0).Sum();
    }
}