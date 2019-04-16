using System.Collections.Generic;
using System.Linq;

namespace LSP.Violacao
{
    public class CalculadoraSoma
    {
        protected readonly IList<int> _numeros;

        public CalculadoraSoma(List<int> numeros)
        {
            _numeros = numeros;
        }

        public int Calcular()
            => _numeros.Sum();
    }
}