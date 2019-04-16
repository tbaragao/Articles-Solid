namespace OCP.Solucao
{
    public class DesenvolvedorJuniorCalculadorSalario : CalculadorSalarioBase
    {
        public DesenvolvedorJuniorCalculadorSalario(Desenvolvedor desenvolvedor)
            : base(desenvolvedor) { }

        public override decimal CalcularSalario()
            => Desenvolvedor.ValorHora * Desenvolvedor.HorasTrabalhadas;
    }
}