using System.Collections.Generic;
using System.Linq;

namespace LSP.Solucao
{
    public class CalculadoraSoma : Calculadora
    {
        public CalculadoraSoma(List<int> numeros)
            : base(numeros) { }

        public override int Calcular()
            => _numeros.Sum();
    }
}