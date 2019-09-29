using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chenpess.QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagemValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        protected void limparMensagemValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void adicionarMensagem(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }
        public abstract void Validade();

        protected bool ehValido
        {
            get { return !mensagemValidacao.Any(); }

        }
    }
}
