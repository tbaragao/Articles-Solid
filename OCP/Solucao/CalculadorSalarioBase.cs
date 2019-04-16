namespace OCP.Solucao
{
    public abstract class CalculadorSalarioBase
    {
        public CalculadorSalarioBase(Desenvolvedor desenvolvedor)
        {
            Desenvolvedor = desenvolvedor;
        }

        protected Desenvolvedor Desenvolvedor { get; private set; }

        public abstract decimal CalcularSalario();
    }
}