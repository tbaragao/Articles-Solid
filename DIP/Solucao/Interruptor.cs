namespace DIP.Solucao
{
    public class Interruptor
    {
        private readonly IDispositivo _dispositivo;

        public void AcionarDispositivo()
        {
            _dispositivo.Acionar();
        }
    }
}