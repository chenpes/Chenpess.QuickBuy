using Chenpess.QuickBuy.Dominio.Enumerados;

namespace Chenpess.QuickBuy.Dominio.BLL
{
    public class FormaPagamento
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public bool ehBoleto
        {
            get { return id == (int)TipoFormaPagamentoEnum.Boleto; }
        }
        public bool ehCartao
        {
            get { return id == (int)TipoFormaPagamentoEnum.Cartao; }
        }
        public bool ehDeposito
        {
            get { return id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool NaoDefinido
        {
            get { return id == (int)TipoFormaPagamentoEnum.naoDef; }

        }
    }
}
