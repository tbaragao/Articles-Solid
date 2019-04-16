namespace DIP.Solucao
{
    public class Ventilador : IDispositivo
    {
        public bool Ligado { get; set; }

        public void Acionar()
        {
            if (!this.Ligado)
                this.Ligar();
            else
                this.Desligar();
        }

        public void Ligar()
        {
            // Implementaçao do Metodo
        }

        public void Desligar()
        {
            // Implementaçao do Metodo
        }
    }
}