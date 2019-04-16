using OCP.Solucao;
using System;
using System.Collections.Generic;

namespace OCP
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var desenvolvedoresCalculador = new List<CalculadorSalarioBase>
            {
                new DesenvolvedorSeniorCalculadorSalario(
                    new Desenvolvedor {Id = 1, Nome = "Dev1", Nivel = "Desenvolvedor Senior", ValorHora  = 130.5M, HorasTrabalhadas = 160 }
                ),
                new DesenvolvedorJuniorCalculadorSalario(
                    new Desenvolvedor {Id = 2, Nome = "Dev2", Nivel = "Desenvolvedor Junior", ValorHora  = 60M, HorasTrabalhadas = 150 }
                ),
                new DesenvolvedorPlenoCalculadorSalario(
                    new Desenvolvedor {Id = 3, Nome = "Dev3", Nivel = "Desenvolvedor Pleno", ValorHora  = 95.5M, HorasTrabalhadas = 180 }
                )
            };

            var calculadora = new CalculadoraSalario(desenvolvedoresCalculador);

            Console.WriteLine($"O custo total com desenvolvedores é de {calculadora.CalcularTotalSalarios()} reais");
        }
    }
}