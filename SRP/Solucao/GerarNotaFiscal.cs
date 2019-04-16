namespace SRP.Solucao
{
    public class GerarNotaFiscal
    {
        private ComunicacaoCupomFiscal _comunicacaoCupomFiscal;
        private DadosDoCliente _dadosDoCliente;
        private EmissaoCupomFiscal _emissaoCupomFiscal;
        private ImpostosCupomFiscal _impostosCupomFiscal;
        private PersistenciaCupomFiscal _persistenciaCupomFiscal;

        public GerarNotaFiscal()
        {
            _comunicacaoCupomFiscal = new ComunicacaoCupomFiscal();
            _dadosDoCliente = new DadosDoCliente();
            _emissaoCupomFiscal = new EmissaoCupomFiscal();
            _impostosCupomFiscal = new ImpostosCupomFiscal();
            _persistenciaCupomFiscal = new PersistenciaCupomFiscal();
        }

        public void Gerar(decimal valorVenda)
        {
            if (_dadosDoCliente.Validar())
            {
                var valorFinal = _impostosCupomFiscal.GerarImpostos(valorVenda);

                _persistenciaCupomFiscal.Salvar(valorFinal);

                _emissaoCupomFiscal.Imprimir();

                _comunicacaoCupomFiscal.EnviarPorEmail();
            }

            // Emitir erro de emissão
        }
    }
}