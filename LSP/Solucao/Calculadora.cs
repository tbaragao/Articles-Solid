using System.Collections.Generic;

namespace LSP.Solucao
{
    public abstract class Calculadora
    {
        protected readonly IList<int> _numeros;

        public Calculadora(List<int> numeros)
        {
            _numeros = numeros;
        }

        public abstract int Calcular();
    }
}