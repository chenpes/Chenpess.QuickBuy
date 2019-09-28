namespace Chenpess.QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }

        public override void Validade()
        {
            limparMensagemValidacao();
            if (string.IsNullOrEmpty(nome))
                adicionarMensagem("Critica: Nome do Produto não pode ser vazio");

            if (string.IsNullOrEmpty(descricao))
                adicionarMensagem("Critica: Descriçao não pode ser vazio!");

        }
    }
}
