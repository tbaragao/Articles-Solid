namespace DIP.Violacao
{
    public class Interruptor
    {
        private Lampada _ventilador;

        public void Acionar()
        {
            if (!_ventilador.Ligado)
                _ventilador.Ligar();
            else
                _ventilador.Desligar();
        }
    }
}