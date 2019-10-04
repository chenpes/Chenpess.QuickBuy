using System.Collections.Generic;

namespace Chenpess.QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string sobreNome { get; set; }
        /// <summary>
        /// Usuario pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido> pedidos { get; set; }

        public override void Validade()
        {
            if (string.IsNullOrEmpty(nome))
                adicionarMensagem("Critica: Nome do usuário não pode ser vazio");
        }
    }
}
