using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutenticacaoJwt.Model.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutenticacaoJwt.Model;
using AutenticacaoJwt.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace AutenticacaoJwt.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public ActionResult<String> ObterToken([FromBody] DtoUsuario credenciais)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Usuario usuarios = new Usuario();
                    DtoUsuario usuario = usuarios.ObterUsuarioPorEmail(credenciais);

                    if (usuario == null)
                    {
                        return "Usuário ou senha incorretos";
                    }
                    else
                    {
                        JwtToken jwtToken = new JwtToken();
                        string token = jwtToken.GerarTokenJwt(usuario.idUsuario);

                        return token;
                    }

                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "Dados incompletos";
            }
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public ActionResult<String> TestandoToken()
        {
            return "Seu token está valido!";
        }
    }
}