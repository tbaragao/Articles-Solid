using System.Collections.Generic;

namespace OCP.Violacao
{
    public class CalculadoraSalario
    {
        private readonly IEnumerable<Desenvolvedor> _desenvolvedores;

        public CalculadoraSalario(List<Desenvolvedor> desenvolvedores)
        {
            _desenvolvedores = desenvolvedores;
        }

        //public decimal CalcularTotalSalarios()
        //{
        //    var total = 0M;

        //    foreach (var desenvolvedor in _desenvolvedores)
        //    {
        //        total += desenvolvedor.HorasTrabalhadas * desenvolvedor.ValorHora;
        //    }

        //    return total;
        //}

        public decimal CalcularTotalSalarios()
        {
            var total = 0M;

            foreach (var desenvolvedor in _desenvolvedores)
            {
                if (desenvolvedor.Nivel == "Desenvolvedor Senior")
                {
                    total += (desenvolvedor.HorasTrabalhadas * desenvolvedor.ValorHora) * 1.3M;
                }
                else if (desenvolvedor.Nivel == "Desenvolvedor Pleno")
                {
                    total += desenvolvedor.HorasTrabalhadas * desenvolvedor.ValorHora * 1.1M;
                }
                else
                {
                    total += desenvolvedor.HorasTrabalhadas * desenvolvedor.ValorHora;
                }
            }

            return total;
        }
    }
}