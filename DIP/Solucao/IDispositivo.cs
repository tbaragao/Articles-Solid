namespace DIP.Solucao
{
    public interface IDispositivo
    {
        bool Ligado { get; set; }

        void Acionar();

        void Ligar();

        void Desligar();
    }
}