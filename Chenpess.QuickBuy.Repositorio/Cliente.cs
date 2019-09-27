using Chenpess.QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chenpess.QuickBuy.Repositorio.Repositorios
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var usuario = new Usuario();
            usuarioRepositorio.adicionar(usuario);
        }

        
    }
}
