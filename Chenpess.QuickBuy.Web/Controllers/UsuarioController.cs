using Chenpess.QuickBuy.Dominio.Contratos;
using Chenpess.QuickBuy.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chenpess.QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _UsuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio UsuarioRepositorio)
        {
            _UsuarioRepositorio = UsuarioRepositorio;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Usuario Usuario)
        {
            try
            {
                _UsuarioRepositorio.adicionar(Usuario);
                return Created("api/Usuario", Usuario);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_UsuarioRepositorio.obterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }

}
