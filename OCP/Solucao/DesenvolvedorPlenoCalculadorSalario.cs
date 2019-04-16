namespace OCP.Solucao
{
    public class DesenvolvedorPlenoCalculadorSalario : CalculadorSalarioBase
    {
        public DesenvolvedorPlenoCalculadorSalario(Desenvolvedor desenvolvedor)
            : base(desenvolvedor) { }

        public override decimal CalcularSalario()
            => (Desenvolvedor.ValorHora * Desenvolvedor.HorasTrabalhadas) * 1.1M;
    }
}