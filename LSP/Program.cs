//using LSP.Violacao; //Remover comentario para rodar a violacao
using LSP.Solucao;
using System;
using System.Collections.Generic;

namespace LSP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numeros = new List<int>() { 11, 4, 7, 8, 3, 1, 9, 10 };

            var sum = new CalculadoraSoma(numeros);
            Console.WriteLine($"A soma de todos os números é: {sum.Calcular()}");

            Console.WriteLine();

            CalculadoraImpares evenSum = new CalculadoraImpares(numeros);
            Console.WriteLine($"A soma de todos os números ímpares é: {evenSum.Calcular()}");

            Console.ReadKey();
        }
    }
}