using Chenpess.QuickBuy.Dominio.Contratos;
using Chenpess.QuickBuy.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Chenpess.QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        //private readonly IUsuarioRepositorio _UsuarioRepositorio;
        //public UsuarioController(IUsuarioRepositorio UsuarioRepositorio)
        //{
        //    _UsuarioRepositorio = UsuarioRepositorio;
        //}

        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromForm] Usuario usuario)
        {
            try
            {
                if(usuario.email == "chenpess@gmail.com" && usuario.senha == "12345")
                    return Ok(usuario);
                return BadRequest("Usuário ou senha não cadastrado!"); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }

}
