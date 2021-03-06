﻿using Chenpess.QuickBuy.Dominio.Contratos;
using Chenpess.QuickBuy.Dominio.Entidades;
using Chenpess.QuickBuy.Repositorio.Contexto;

namespace Chenpess.QuickBuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}
