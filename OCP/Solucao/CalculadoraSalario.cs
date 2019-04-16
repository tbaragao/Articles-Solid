using System.Collections.Generic;

namespace OCP.Solucao
{
    public class CalculadoraSalario
    {
        private readonly IEnumerable<CalculadorSalarioBase> _desenvolvedoresCalculadorSalario;

        public CalculadoraSalario(IEnumerable<CalculadorSalarioBase> desenvolvedorCalculadorSalario)
        {
            _desenvolvedoresCalculadorSalario = desenvolvedorCalculadorSalario;
        }

        public decimal CalcularTotalSalarios()
        {
            var total = 0M;

            foreach (var calculador in _desenvolvedoresCalculadorSalario)
            {
                total += calculador.CalcularSalario();
            }

            return total;
        }
    }
}