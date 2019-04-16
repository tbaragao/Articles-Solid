namespace OCP.Solucao
{
    public class DesenvolvedorSeniorCalculadorSalario : CalculadorSalarioBase
    {
        public DesenvolvedorSeniorCalculadorSalario(Desenvolvedor desenvolvedor)
            : base(desenvolvedor) { }

        public override decimal CalcularSalario()
            => (Desenvolvedor.ValorHora * Desenvolvedor.HorasTrabalhadas) * 1.3M;
    }
}