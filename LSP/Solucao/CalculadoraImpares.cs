using System.Collections.Generic;
using System.Linq;

namespace LSP.Solucao
{
    public class CalculadoraImpares : Calculadora
    {
        public CalculadoraImpares(List<int> numeros)
            : base(numeros) { }

        public override int Calcular()
            => _numeros.Where(x => x % 2 == 0).Sum();
    }
}